using BookStore.ModelsDB;
using BookStore.Repository.Implementations;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static BookStore.SharedData;
namespace BookStore.Forms
{
    public partial class AuthorsForm : UserControl
    {
        private Guid idAuthorUp;
        public AuthorsForm()
        {
            InitializeComponent();
        }

        private void LoadData(UnitOfWork uow)
        {
            dgvAuthors.DataSource = uow.Authors.Find(null, "Books").Select(p => new
            {
                p.IdAuthor,
                p.Name,
                p.Email,
                p.Gender,
                nbBooks = p.Books.Count()
            }).ToList();
        }
        private void btnSaveAuthor_Click(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            {
                Author author = new Author()
                {
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Gender = txtGenderM.Checked ? txtGenderM.Text : txtGenderF.Text
                };
                uow.Authors.Add(author);
                int res = uow.Complete();
                if (res > 0)
                {
                    //MessageBox.Show("Author created successfully ID : " + author.IdAuthor, "Info Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(uow);
                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtName.Focus();
                    txtGenderM.Select();
                    txtNbAuthors.Text = dgvAuthors.RowCount.ToString();
                }
            }

        }
        private void AuthorsForm_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            txtGenderM.Select();
            using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            {
                LoadData(uow);

                dgvAuthors.Columns["IdAuthor"].Visible = false;
                dgvAuthors.Columns["Name"].Width = 300;
                dgvAuthors.Columns["Email"].Width = 300;
                dgvAuthors.Columns["Gender"].Width = 100;
                dgvAuthors.Columns["nbBooks"].Width = 100;
                dgvAuthors.RowHeadersVisible = false;
                AddColumnIcon(dgvAuthors, "print", "print");
                AddColumnIcon(dgvAuthors, "delete", "delete");
                txtNbAuthors.Text = dgvAuthors.RowCount.ToString();
                btnUpdateAuthor.Visible = false;
            }
        }

        private void dgvAuthors_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                string colName = dgvAuthors.Columns[e.ColumnIndex].Name;
                if (colName != "delete" && colName != "print")
                {
                    dgvAuthors.Cursor = Cursors.Default;
                }
                else
                {
                    dgvAuthors.Cursor = Cursors.Hand;

                }
            }
        }

        private void dgvAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                string colName = dgvAuthors.Columns[e.ColumnIndex].Name;
                if (colName == "delete")
                {
                    Guid idAuthor = Guid.Parse(dgvAuthors.Rows[e.RowIndex].Cells["IdAuthor"].Value.ToString());
                    bool confirm = ConfirmDelete("Voulez vous vraiment supprimer cet auteur  ?");
                    if (confirm)
                    {
                        using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
                        {
                            Author author = uow.Authors.Get(idAuthor);
                            uow.Authors.Remove(author);
                            uow.Complete();
                            LoadData(uow);
                            txtNbAuthors.Text = dgvAuthors.RowCount.ToString();
                        }
                    }

                }
            }
        }

        private void dgvAuthors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idAuthorUp = Guid.Parse(dgvAuthors.Rows[e.RowIndex].Cells["IdAuthor"].Value.ToString());
                using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
                {
                    Author auth = uow.Authors.Get(idAuthorUp);
                    txtName.Text = auth.Name;
                    txtEmail.Text = auth.Email;
                    txtGenderM.Checked = (auth.Gender == "M") ? true : false;
                    txtGenderF.Checked = (auth.Gender == "F") ? true : false;
                    btnUpdateAuthor.Visible = true;
                }
            }
        }

        private void btnUpdateAuthor_Click(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            {
                Author auth = uow.Authors.Get(idAuthorUp);
                auth.Name=txtName.Text ;
                auth.Email = txtEmail.Text;
                auth.Gender = txtGenderM.Checked ? txtGenderM.Text : txtGenderF.Text;
                uow.Complete();
                LoadData(uow);
                btnUpdateAuthor.Visible = false;
            }
        }
    }
}
