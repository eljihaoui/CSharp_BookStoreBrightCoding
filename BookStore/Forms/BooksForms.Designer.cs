
namespace BookStore.Forms
{
    partial class BooksForms
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForms));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.txtNbBooks = new System.Windows.Forms.Label();
            this.btnNewBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitleCriteria = new System.Windows.Forms.TextBox();
            this.txtCategoryCriteria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthorCriteria = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.txtCurrentPage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(73, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "List Books : ";
            // 
            // dgvBooks
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooks.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBooks.ColumnHeadersHeight = 33;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBooks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBooks.EnableHeadersVisualStyles = false;
            this.dgvBooks.Location = new System.Drawing.Point(22, 95);
            this.dgvBooks.Name = "dgvBooks";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBooks.RowHeadersWidth = 62;
            this.dgvBooks.RowTemplate.Height = 40;
            this.dgvBooks.Size = new System.Drawing.Size(1451, 429);
            this.dgvBooks.TabIndex = 5;
            this.dgvBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentClick);
            this.dgvBooks.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellMouseEnter);
            // 
            // txtNbBooks
            // 
            this.txtNbBooks.AutoSize = true;
            this.txtNbBooks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNbBooks.ForeColor = System.Drawing.Color.Maroon;
            this.txtNbBooks.Location = new System.Drawing.Point(241, 12);
            this.txtNbBooks.Name = "txtNbBooks";
            this.txtNbBooks.Size = new System.Drawing.Size(24, 28);
            this.txtNbBooks.TabIndex = 6;
            this.txtNbBooks.Text = "_";
            // 
            // btnNewBook
            // 
            this.btnNewBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewBook.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNewBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewBook.FlatAppearance.BorderSize = 0;
            this.btnNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBook.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewBook.Image = ((System.Drawing.Image)(resources.GetObject("btnNewBook.Image")));
            this.btnNewBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewBook.Location = new System.Drawing.Point(1334, 27);
            this.btnNewBook.Name = "btnNewBook";
            this.btnNewBook.Size = new System.Drawing.Size(139, 36);
            this.btnNewBook.TabIndex = 8;
            this.btnNewBook.Text = "New Book";
            this.btnNewBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewBook.UseVisualStyleBackColor = false;
            this.btnNewBook.Click += new System.EventHandler(this.btnNewBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(310, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Title :";
            // 
            // txtTitleCriteria
            // 
            this.txtTitleCriteria.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtTitleCriteria.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitleCriteria.Location = new System.Drawing.Point(315, 37);
            this.txtTitleCriteria.Name = "txtTitleCriteria";
            this.txtTitleCriteria.Size = new System.Drawing.Size(159, 32);
            this.txtTitleCriteria.TabIndex = 10;
            // 
            // txtCategoryCriteria
            // 
            this.txtCategoryCriteria.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtCategoryCriteria.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCategoryCriteria.Location = new System.Drawing.Point(487, 37);
            this.txtCategoryCriteria.Name = "txtCategoryCriteria";
            this.txtCategoryCriteria.Size = new System.Drawing.Size(159, 32);
            this.txtCategoryCriteria.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(482, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Category : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(664, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Author : ";
            // 
            // txtAuthorCriteria
            // 
            this.txtAuthorCriteria.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtAuthorCriteria.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAuthorCriteria.FormattingEnabled = true;
            this.txtAuthorCriteria.Location = new System.Drawing.Point(664, 36);
            this.txtAuthorCriteria.Name = "txtAuthorCriteria";
            this.txtAuthorCriteria.Size = new System.Drawing.Size(243, 31);
            this.txtAuthorCriteria.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(295, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 74);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(617, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(47, 35);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.Location = new System.Drawing.Point(20, 54);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(47, 35);
            this.btnFirst.TabIndex = 17;
            this.btnFirst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(72, 58);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(33, 27);
            this.btnPrevious.TabIndex = 18;
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(103, 54);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(53, 35);
            this.btnNext.TabIndex = 19;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.Location = new System.Drawing.Point(152, 54);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(47, 35);
            this.btnLast.TabIndex = 20;
            this.btnLast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // txtCurrentPage
            // 
            this.txtCurrentPage.AutoSize = true;
            this.txtCurrentPage.ForeColor = System.Drawing.Color.Maroon;
            this.txtCurrentPage.Location = new System.Drawing.Point(206, 58);
            this.txtCurrentPage.Name = "txtCurrentPage";
            this.txtCurrentPage.Size = new System.Drawing.Size(19, 25);
            this.txtCurrentPage.TabIndex = 21;
            this.txtCurrentPage.Text = "_";
            // 
            // BooksForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCurrentPage);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.txtAuthorCriteria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCategoryCriteria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitleCriteria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewBook);
            this.Controls.Add(this.txtNbBooks);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "BooksForms";
            this.Size = new System.Drawing.Size(1487, 639);
            this.Load += new System.EventHandler(this.BooksForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label txtNbBooks;
        private System.Windows.Forms.Button btnNewBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitleCriteria;
        private System.Windows.Forms.TextBox txtCategoryCriteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtAuthorCriteria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label txtCurrentPage;
    }
}
