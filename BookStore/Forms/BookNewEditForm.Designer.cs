
namespace BookStore.Forms
{
    partial class BookNewEditForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookNewEditForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTitleForm = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCateg = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.ComboBox();
            this.txtNbPages = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.labeltxtnbPage = new System.Windows.Forms.Label();
            this.txtPricell = new System.Windows.Forms.Label();
            this.txtPublishedDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveBook = new System.Windows.Forms.Button();
            this.txtImageCover = new System.Windows.Forms.PictureBox();
            this.btnUploadCover = new System.Windows.Forms.Button();
            this.txtImageCoverPath = new System.Windows.Forms.Label();
            this.ErrProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtTitleForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 53);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1035, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 41);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtTitleForm
            // 
            this.txtTitleForm.AutoSize = true;
            this.txtTitleForm.BackColor = System.Drawing.Color.Maroon;
            this.txtTitleForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitleForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTitleForm.Location = new System.Drawing.Point(64, 9);
            this.txtTitleForm.Name = "txtTitleForm";
            this.txtTitleForm.Size = new System.Drawing.Size(150, 28);
            this.txtTitleForm.TabIndex = 2;
            this.txtTitleForm.Text = "New Book : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCateg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.txtNbPages);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.labeltxtnbPage);
            this.groupBox1.Controls.Add(this.txtPricell);
            this.groupBox1.Controls.Add(this.txtPublishedDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescrip);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 612);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(19, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 30);
            this.label6.TabIndex = 16;
            this.label6.Text = "Categorie :";
            // 
            // txtCateg
            // 
            this.txtCateg.BackColor = System.Drawing.Color.LightBlue;
            this.txtCateg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCateg.FormattingEnabled = true;
            this.txtCateg.Location = new System.Drawing.Point(22, 546);
            this.txtCateg.Name = "txtCateg";
            this.txtCateg.Size = new System.Drawing.Size(420, 38);
            this.txtCateg.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(22, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Author :";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.LightBlue;
            this.txtAuthor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAuthor.FormattingEnabled = true;
            this.txtAuthor.Location = new System.Drawing.Point(22, 457);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(420, 38);
            this.txtAuthor.TabIndex = 13;
            // 
            // txtNbPages
            // 
            this.txtNbPages.BackColor = System.Drawing.Color.LightBlue;
            this.txtNbPages.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNbPages.Location = new System.Drawing.Point(336, 367);
            this.txtNbPages.Name = "txtNbPages";
            this.txtNbPages.Size = new System.Drawing.Size(103, 37);
            this.txtNbPages.TabIndex = 12;
            this.txtNbPages.Validating += new System.ComponentModel.CancelEventHandler(this.txtNbPages_Validating);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.LightBlue;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(218, 366);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(86, 37);
            this.txtPrice.TabIndex = 11;
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            // 
            // labeltxtnbPage
            // 
            this.labeltxtnbPage.AutoSize = true;
            this.labeltxtnbPage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltxtnbPage.ForeColor = System.Drawing.Color.Brown;
            this.labeltxtnbPage.Location = new System.Drawing.Point(336, 333);
            this.labeltxtnbPage.Name = "labeltxtnbPage";
            this.labeltxtnbPage.Size = new System.Drawing.Size(103, 30);
            this.labeltxtnbPage.TabIndex = 10;
            this.labeltxtnbPage.Text = "Nb.Pages";
            this.labeltxtnbPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPricell
            // 
            this.txtPricell.AutoSize = true;
            this.txtPricell.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPricell.ForeColor = System.Drawing.Color.Brown;
            this.txtPricell.Location = new System.Drawing.Point(218, 333);
            this.txtPricell.Name = "txtPricell";
            this.txtPricell.Size = new System.Drawing.Size(71, 30);
            this.txtPricell.TabIndex = 4;
            this.txtPricell.Text = "Price :";
            this.txtPricell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPublishedDate
            // 
            this.txtPublishedDate.CalendarFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPublishedDate.CalendarMonthBackground = System.Drawing.Color.LightBlue;
            this.txtPublishedDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPublishedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtPublishedDate.Location = new System.Drawing.Point(22, 368);
            this.txtPublishedDate.Name = "txtPublishedDate";
            this.txtPublishedDate.Size = new System.Drawing.Size(152, 37);
            this.txtPublishedDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(22, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Published Date :";
            // 
            // txtDescrip
            // 
            this.txtDescrip.BackColor = System.Drawing.Color.LightBlue;
            this.txtDescrip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescrip.Location = new System.Drawing.Point(22, 170);
            this.txtDescrip.Multiline = true;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(420, 131);
            this.txtDescrip.TabIndex = 3;
            this.txtDescrip.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescrip_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(22, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description :";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.LightBlue;
            this.txtTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(22, 84);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(420, 37);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(22, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title :";
            // 
            // btnSaveBook
            // 
            this.btnSaveBook.BackColor = System.Drawing.Color.LightGray;
            this.btnSaveBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveBook.FlatAppearance.BorderSize = 0;
            this.btnSaveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBook.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveBook.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveBook.Image")));
            this.btnSaveBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveBook.Location = new System.Drawing.Point(870, 721);
            this.btnSaveBook.Name = "btnSaveBook";
            this.btnSaveBook.Size = new System.Drawing.Size(181, 40);
            this.btnSaveBook.TabIndex = 7;
            this.btnSaveBook.Text = "Create New Book";
            this.btnSaveBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveBook.UseVisualStyleBackColor = false;
            this.btnSaveBook.Click += new System.EventHandler(this.btnSaveBook_Click);
            // 
            // txtImageCover
            // 
            this.txtImageCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImageCover.Location = new System.Drawing.Point(531, 84);
            this.txtImageCover.Name = "txtImageCover";
            this.txtImageCover.Size = new System.Drawing.Size(520, 602);
            this.txtImageCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImageCover.TabIndex = 8;
            this.txtImageCover.TabStop = false;
            // 
            // btnUploadCover
            // 
            this.btnUploadCover.BackColor = System.Drawing.Color.SeaShell;
            this.btnUploadCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadCover.FlatAppearance.BorderSize = 0;
            this.btnUploadCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadCover.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUploadCover.Image = ((System.Drawing.Image)(resources.GetObject("btnUploadCover.Image")));
            this.btnUploadCover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadCover.Location = new System.Drawing.Point(923, 637);
            this.btnUploadCover.Name = "btnUploadCover";
            this.btnUploadCover.Size = new System.Drawing.Size(116, 40);
            this.btnUploadCover.TabIndex = 9;
            this.btnUploadCover.Text = "Upload";
            this.btnUploadCover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUploadCover.UseVisualStyleBackColor = false;
            this.btnUploadCover.Click += new System.EventHandler(this.btnUploadCover_Click);
            // 
            // txtImageCoverPath
            // 
            this.txtImageCoverPath.AutoSize = true;
            this.txtImageCoverPath.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtImageCoverPath.ForeColor = System.Drawing.Color.Brown;
            this.txtImageCoverPath.Location = new System.Drawing.Point(500, 689);
            this.txtImageCoverPath.Name = "txtImageCoverPath";
            this.txtImageCoverPath.Size = new System.Drawing.Size(22, 30);
            this.txtImageCoverPath.TabIndex = 17;
            this.txtImageCoverPath.Text = "_";
            this.txtImageCoverPath.Visible = false;
            // 
            // ErrProvider
            // 
            this.ErrProvider.ContainerControl = this;
            this.ErrProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrProvider.Icon")));
            // 
            // BookNewEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1098, 791);
            this.Controls.Add(this.txtImageCoverPath);
            this.Controls.Add(this.btnUploadCover);
            this.Controls.Add(this.txtImageCover);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSaveBook);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookNewEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookNewEditForm";
            this.Load += new System.EventHandler(this.BookNewEditForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtTitleForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtPublishedDate;
        private System.Windows.Forms.Button btnSaveBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNbPages;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label labeltxtnbPage;
        private System.Windows.Forms.Label txtPricell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtAuthor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtCateg;
        private System.Windows.Forms.PictureBox txtImageCover;
        private System.Windows.Forms.Button btnUploadCover;
        private System.Windows.Forms.Label txtImageCoverPath;
        private System.Windows.Forms.ErrorProvider ErrProvider;
    }
}