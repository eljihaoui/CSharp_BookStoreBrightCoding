﻿using BookStore.ModelsDB;
using BookStore.ModelsHelpers;
using BookStore.Repository.Implementations;
using LinqKit;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static BookStore.SharedData;
namespace BookStore.Forms
{
    public partial class BooksForms : UserControl
    {
        private int TotalPages = 0;
        private Page page;
        private IEnumerable<BookViewModel> listbooks;
        public BooksForms()
        {
            InitializeComponent();
            int nbElemByPage = Convert.ToInt32(ConfigurationManager.AppSettings["nbElemByPage"]);
            page = new Page() { pageIndex = 1, pageSize = nbElemByPage };
        }
        public void ReloadData()
        {
            var predicate = PredicateBuilder.New<Book>(true);

            string title = txtTitleCriteria.Text.ToLower();
            string category = txtCategoryCriteria.Text.ToLower();
            Author author = (Author)txtAuthorCriteria.SelectedItem;
            Guid idAuthor = (author == null) ? Guid.Empty : author.IdAuthor;

            if (!String.IsNullOrEmpty(title))
                predicate = predicate.And(b => b.Title.ToLower().Contains(title));

            if (!String.IsNullOrEmpty(category))
                predicate = predicate.And(b => b.Category.Categ.ToLower().Contains(category));

            if (idAuthor != Guid.Empty)
                predicate = predicate.And(b => b.IdAuthor == idAuthor);

            using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            {
                var list = uow.Books.Find(predicate, "Author,Category", page).Select(p => new BookViewModel
                {
                    IdBook = p.IdBook,
                    Title = p.Title,
                    Description = p.DescBook,
                    Price = (double)p.Price,
                    NbPages = (int)p.NbPages,
                    Published = (DateTime)p.PublishedDate,
                    Categorie = p.Category.Categ,
                    Author = p.Author.Name
                }).ToList();
                dgvBooks.DataSource = list;
                listbooks = list;
            }
            txtNbBooks.Text = dgvBooks.RowCount.ToString();
        }
        private void CalculateTotalPages(Page page)
        {
            using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            {
                TotalPages = (int)Math.Ceiling((double)uow.Books.GetAll().Count() / page.pageSize);
            }
        }
        private void BooksForms_Load(object sender, EventArgs e)
        {
            ReloadData();
            CalculateTotalPages(page);
            dgvBooks.Columns["IdBook"].Visible = false;
            dgvBooks.Columns["Cover"].Visible = false;
            AddColumnIcon(dgvBooks, "edit", "edit");
            AddColumnIcon(dgvBooks, "print", "print");
            AddColumnIcon(dgvBooks, "delete", "delete");
            SetWitdthDataGridView(dgvBooks, columnsDgvBooks);

            txtAuthorCriteria.Items.Add(new Author() { IdAuthor = Guid.Empty, Name = "-- All  Authors --" });
            using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            {
                foreach (var item in uow.Authors.GetAll())
                {
                    txtAuthorCriteria.Items.Add(item);
                }
                txtAuthorCriteria.ValueMember = "IdAuthor";
                txtAuthorCriteria.DisplayMember = "Name";
                txtAuthorCriteria.SelectedIndex = 0;
            }
        }

        private void dgvBooks_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                string ColName = dgvBooks.Columns[e.ColumnIndex].Name;
                if (ColName != "edit" && ColName != "print" && ColName != "delete")
                {
                    dgvBooks.Cursor = Cursors.Default;
                }
                else
                {
                    dgvBooks.Cursor = Cursors.Hand;
                }
            }
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                DataGridViewRow CurrentRow = dgvBooks.Rows[e.RowIndex];
                CurrentRow.Selected = true;
                string colName = dgvBooks.Columns[e.ColumnIndex].Name;
                Guid idBook = Guid.Parse(dgvBooks.Rows[e.RowIndex].Cells["IdBook"].Value.ToString());
                if (colName == "delete")
                {
                    bool confirm = ConfirmDelete("Voulez vous vraiment supprimer ce Livre ?");
                    if (confirm)
                    {
                        using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
                        {
                            Book book = uow.Books.Get(idBook);
                            uow.Books.Remove(book);
                            uow.Complete();
                            ReloadData();
                        }
                    }
                }
                if (colName == "edit")
                {
                    BookNewEditForm bookEditform = new BookNewEditForm(this, idBook);
                    bookEditform.ShowDialog();
                }

                if (colName == "print")
                {
                    using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
                    {
                        Book book = uow.Books.Find(p => p.IdBook == idBook, "Category,Author").FirstOrDefault();
                        BookViewModel bv = new BookViewModel()
                        {
                            IdBook = book.IdBook,
                            Title = book.Title,
                            Description = book.DescBook,
                            Price = (float)book.Price,
                            NbPages= (int)book.NbPages,
                            Published = (DateTime)book.PublishedDate,
                            Categorie = book.Category.Categ,
                            Author = book.Author.Name,
                            Cover = book.Cover
                        };
                        var props = typeof(BookViewModel).GetProperties();
                        var dt = new DataTable();
                        dt.Columns.AddRange(
                            props.Select(p => new DataColumn(p.Name, p.PropertyType)).ToArray()
                            );
                        dt.Rows.Add(props.Select(p => p.GetValue(bv, null)).ToArray());

                        string RptPath = @"Reports\BookDetail.rdlc";
                        string NameSrcRpt = "ds_BookDetail";
                        string fileName = "BookDetail";
                        PrintToPDF(RptPath, NameSrcRpt, dt, fileName);
                    }
                }

            }
        }
        private void btnNewBook_Click(object sender, EventArgs e)
        {
            BookNewEditForm frmNewEdit = new BookNewEditForm(this);
            frmNewEdit.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            page.pageIndex = 1;
            txtCurrentPage.Text = $"Page {page.pageIndex} / {TotalPages}";
            ReloadData();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (page.pageIndex > 1)
            {
                page.pageIndex--;
                txtCurrentPage.Text = $"Page {page.pageIndex} / {TotalPages}";
                ReloadData();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (page.pageIndex < TotalPages)
            {
                page.pageIndex++;
                txtCurrentPage.Text = $"Page {page.pageIndex} / {TotalPages}";
                ReloadData();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            page.pageIndex = TotalPages;
            txtCurrentPage.Text = $"Page {page.pageIndex} / {TotalPages}";
            ReloadData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dataSource;
            dataSource = getDataTableFromIEnumerable(listbooks);
            string path = @"Reports\ListOfBooks.rdlc";
            string dataSourceName = "ds_listBooks";
            string fileName = "ListBooks";
            PrintToPDF(path, dataSourceName, dataSource, fileName);


        }
    }
}
