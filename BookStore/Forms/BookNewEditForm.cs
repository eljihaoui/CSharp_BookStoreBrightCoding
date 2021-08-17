using BookStore.ModelsDB;
using BookStore.Repository.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static BookStore.SharedData;
namespace BookStore.Forms
{
    public partial class BookNewEditForm : Form
    {
        private readonly BooksForms bookforms;
        private readonly Guid IdBookUp;
        public BookNewEditForm()
        {
            InitializeComponent();
        }

        public BookNewEditForm(BooksForms Pbookforms,[Optional] Guid IdBook)
        {
            InitializeComponent();
            this.bookforms = Pbookforms;
            if (IdBook != Guid.Empty) this.IdBookUp = IdBook;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookNewEditForm_Load(object sender, EventArgs e)
        {
            txtImageCoverPath.Text = "";
            using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            {
                txtAuthor.DataSource = uow.Authors.GetAll();
                txtAuthor.ValueMember = "IdAuthor";
                txtAuthor.DisplayMember = "Name";
                txtCateg.DataSource = uow.Categorys.GetAll();
                txtCateg.ValueMember = "IdCateg";
                txtCateg.DisplayMember = "Categ";
                if (IdBookUp != Guid.Empty)
                {
                    txtTitleForm.Text = "Edit Book";
                    btnSaveBook.Text = "Update Book";
                    Book book = uow.Books.Get(IdBookUp);
                    txtTitle.Text = book.Title;
                    txtDescrip.Text = book.DescBook;
                    txtPublishedDate.Value = book.PublishedDate.Value;
                    txtPrice.Text = book.Price.ToString();
                    txtNbPages.Text = book.NbPages.ToString();
                    txtAuthor.SelectedItem = book.Author;
                    txtCateg.SelectedItem = book.Category;
                    if (book.Cover != null)
                    {
                        MemoryStream ms = new MemoryStream(book.Cover);
                        txtImageCover.Image = Image.FromStream(ms);
                    }
                    
                }

            }
        }

        private void btnUploadCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images |*.jpg; *.jpeg; *.png; *.bmp";
            ofd.Title = "Sélectionner une image de couveture ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImageCover.Image = new Bitmap(ofd.FileName);
                txtImageCoverPath.Text = ofd.FileName;
            }
        }
        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            {
                string title = txtTitle.Text;
                string descBook = txtDescrip.Text;
                DateTime publishedDate = txtPublishedDate.Value.Date;
                double price = Convert.ToDouble(txtPrice.Text);
                int nbPages = Convert.ToInt32(txtNbPages.Text);
                Guid idAuthor = Guid.Parse(txtAuthor.SelectedValue.ToString());
                Guid idCateg = Guid.Parse(txtCateg.SelectedValue.ToString());
                /************************** Add Book ********************************/
                if (IdBookUp == Guid.Empty)
                {
                    Book book = new Book()
                    {
                        Title = title,
                        DescBook = descBook,
                        PublishedDate = publishedDate,
                        Price = price,
                        NbPages = nbPages,
                        IdAuthor = idAuthor,
                        IdCateg = idCateg,
                        Cover = (!String.IsNullOrEmpty(txtImageCoverPath.Text) ? ConvertToBinaryFromFile(txtImageCoverPath.Text) : null)
                    };
                    uow.Books.Add(book);
                }
                /************************** Edit  Book ********************************/
                else
                {
                    Book book = uow.Books.Get(IdBookUp);
                    book.Title = title;
                    book.DescBook = descBook;
                    book.PublishedDate = publishedDate;
                    book.Price = price;
                    book.NbPages = nbPages;
                    book.IdAuthor = idAuthor;
                    book.IdCateg = idCateg;
                    book.Cover = (!String.IsNullOrEmpty(txtImageCoverPath.Text) ? ConvertToBinaryFromFile(txtImageCoverPath.Text) : book.Cover);
                }
               
                if (uow.Complete() > 0)
                {
                    this.Close();
                    bookforms.ReloadData();
                }
            }
        }
    }
}
