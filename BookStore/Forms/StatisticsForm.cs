using BookStore.ModelsDB;
using BookStore.Repository.Implementations;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static BookStore.SharedData;
namespace BookStore.Forms
{
    public partial class StatisticsForm : UserControl
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            {
                dgvBooksByAuthor.DataSource = uow.Books.BookByAuthor();
                dgvBooksByAuthor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgvBooksByAuthor.RowHeadersVisible = false;
                dgvBooksByAuthor.Columns[0].Width = 350;
                dgvBooksByAuthor.Columns[1].Width = 150;



                dgvBooksByCategory.DataSource = uow.Books.BookByCategory();
                dgvBooksByCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgvBooksByCategory.RowHeadersVisible = false;
                dgvBooksByCategory.Columns[0].Width = 350;
                dgvBooksByCategory.Columns[1].Width = 150;
            }
        }
    }
}
