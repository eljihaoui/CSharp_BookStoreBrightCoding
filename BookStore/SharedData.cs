using BookStore.ModelsDB;
using BookStore.ModelsHelpers;
using BookStore.Properties;
using BookStore.Repository.Implementations;
using Microsoft.Reporting.NETCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using static System.String;
namespace BookStore
{
    public static class SharedData
    {
        public static Dictionary<string, int> columnsDgvBooks = new Dictionary<string, int>()
        {
                {"Title",300 },
                {"Description",400 },
                {"Price",100 },
                {"nbPages",100 },
                {"Published",150 },
                {"Categorie",200 },
                {"Author",200 },
                {"edit",50 },
                {"print",50 },
                {"delete",50 },
        };

        public static void SetWitdthDataGridView(DataGridView dgv, Dictionary<string, int> DicColumns)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            foreach (string key in DicColumns.Keys)
            {
                dgv.Columns[key].Width = DicColumns[key];
            }
        }
        public static void AddColumnIcon(DataGridView dvg, string colName, string iconName)
        {
            ResourceManager rm = Resources.ResourceManager;
            Bitmap icon = (Bitmap)rm.GetObject(iconName);
            DataGridViewImageColumn col = new DataGridViewImageColumn
            {
                Name = colName,
                HeaderText = "",
                Image = icon,
                Width = 60
            };
            col.HeaderCell.Style.Padding = new Padding(20, 0, 20, 0);
            dvg.Columns.Add(col);
        }

        public static bool ConfirmDelete(string msg)
        {
            DialogResult dr = MessageBox.Show(msg,
                "Confirmation de Suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            return (dr == DialogResult.Yes);
        }

        public static byte[] ConvertToBinaryFromFile(string file)
        {
            byte[] bytes;
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[fs.Length];
                fs.Read(bytes, 0, (int)fs.Length);
            }
            return bytes;
        }


        public static bool IsNumeric(string input)
        {
            try
            {
                float a = float.Parse(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool ValidateData(ErrorProvider errProvider, TextBox textbox, string msgError, Button btn, bool isNumeric = false)
        {
            bool condition = (isNumeric) ? (IsNullOrEmpty(textbox.Text) || !IsNumeric(textbox.Text)) : IsNullOrEmpty(textbox.Text);
            if (condition)
            {
                errProvider.SetError(textbox, msgError);
                btn.Enabled = false;
                return false;
            }
            else
            {
                errProvider.Dispose();
                btn.Enabled = true;
                return true;
            }
        }

        public static DataTable getDataTableFromIEnumerable(IEnumerable<BookViewModel> list)
        {
            var props = typeof(BookViewModel).GetProperties();
            DataTable dt = new DataTable();
            dt.Columns.AddRange(
                props.Select(p => new DataColumn(p.Name, p.PropertyType)).ToArray()
                );
            list.ToList().ForEach(
                b => dt.Rows.Add(props.Select(p => p.GetValue(b, null)).ToArray())
                );
            return dt;
        }

        public static void PrintToPDF(string RptPath, string nameSrcRpt, DataTable valueSrcRpt, string fileName, bool subReport = false)
        {
            StreamReader reportDefintion = new StreamReader(RptPath);
            LocalReport report = new LocalReport();
            report.LoadReportDefinition(reportDefintion);
            report.DataSources.Add(new ReportDataSource(nameSrcRpt, valueSrcRpt));
           
            if (subReport)
            {
                StreamReader subReportDefinition = new StreamReader(@"Reports\AuthorSubReport.rdlc");
                report.LoadSubreportDefinition ("AuthorSubReport", subReportDefinition);
                report.SubreportProcessing+= new SubreportProcessingEventHandler(subreportProcessing);
            }

             byte[] pdf = report.Render("PDF");
            Stream stm;
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "All Files(*.*)| *.* ";
            DateTime d = DateTime.Now;
            string outputFileName = $"{fileName} {d.Day}-{d.Month}-{d.Year} {d.Hour}_{d.Minute}.pdf";
            saveFile.FileName = outputFileName;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if ((stm = saveFile.OpenFile()) != null)
                {
                    stm.Write(pdf, 0, pdf.Length);
                    stm.Close();
                }
            }

        }

        static void subreportProcessing(object sender, SubreportProcessingEventArgs args)
        {
            Guid idAuthor = Guid.Parse(args.Parameters["IdAuthor"].Values[0].ToString());
            DataTable dt;
            using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            {
                var list = uow.Books.Find(b => b.IdAuthor == idAuthor, "Author,Category")
                  .Select(p => new BookViewModel
                  {
                      IdBook = p.IdBook,
                      Title = p.Title,
                      Description = p.DescBook,
                      Price = (double)p.Price,
                      NbPages = (int)p.NbPages,
                      Published = (DateTime)p.PublishedDate,
                      Categorie = p.Category.Categ,
                      Author = p.Author.Name,
                      Cover = p.Cover
                  }).ToList();
               
                dt = getDataTableFromIEnumerable(list);
                ReportDataSource rds = new ReportDataSource("ds_listAuthorsBooks", dt);
                args.DataSources.Add(rds);
            }
        }

    }
}
