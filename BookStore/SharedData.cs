using BookStore.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        public static bool ValidateData (ErrorProvider errProvider, TextBox textbox, string msgError,Button btn, bool isNumeric = false)
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
    }
}
