using BookStore.ModelsDB;
using BookStore.Repository.Implementations;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static BookStore.SharedData;
namespace BookStore.Forms
{
    public partial class BooksForms : UserControl
    {
        public BooksForms()
        {
            InitializeComponent();
        }
        public void ReloadData()
        {
            using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            {
                var list = uow.Books.Find(null, "Author,Category", null).Select(p => new
                {
                    IdBook = p.IdBook,
                    Title = p.Title,
                    Description = p.DescBook,
                    Price = p.Price,
                    nbPages = p.NbPages,
                    Published = p.PublishedDate,
                    Categorie = p.Category.Categ,
                    Author = p.Author.Name
                }).ToList();
                dgvBooks.DataSource = list;
            }
            txtNbBooks.Text = dgvBooks.RowCount.ToString();
        }
        private void BooksForms_Load(object sender, EventArgs e)
        {
            ReloadData();
            dgvBooks.Columns["IdBook"].Visible = false;
            AddColumnIcon(dgvBooks, "edit", "edit");
            AddColumnIcon(dgvBooks, "print", "print");
            AddColumnIcon(dgvBooks, "delete", "delete");
            SetWitdthDataGridView(dgvBooks, columnsDgvBooks);
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
            if(e.ColumnIndex!=-1 && e.RowIndex != -1)
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

            }
        }
        private void btnNewBook_Click(object sender, EventArgs e)
        {
            BookNewEditForm frmNewEdit = new BookNewEditForm(this);
            frmNewEdit.ShowDialog();
        }
    }
}
