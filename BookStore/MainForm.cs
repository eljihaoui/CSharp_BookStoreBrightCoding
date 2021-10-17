using BookStore.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookStore
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
           btnAuthors_Click(sender, e);
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            AuthorsForm frmAuth = new AuthorsForm();
            frmAuth.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frmAuth);
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            BooksForms frmBooks= new BooksForms();
            frmBooks.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frmBooks);
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            StatisticsForm frmStatistics = new StatisticsForm();
            frmStatistics.Dock = DockStyle.Fill;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frmStatistics);
        }
    }
}
