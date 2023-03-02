using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r6.Utils
{
    public static class Ext
    {
        public static ErrorProvider ep = new ErrorProvider();
        public static TextInfo textInfo = new CultureInfo("en-US").TextInfo;
        public static void ShowTinyError(this Control c, string message = "input cannot be empty")
        {
            ep.SetError(c, textInfo.ToTitleCase(message));
        }
        public static void ClearTinyError(this Control c)
        {
            ep.SetError(c, "");
        }
        public static void Fill(this ComboBox cmb, string[] items)
        {
            cmb.Items.Clear();
            foreach (string item in items)
            {
                cmb.Items.Add(textInfo.ToUpper(item));
            }
        }
        public static void Setup(this ComboBox cmb)
        {
            cmb.DropDownStyle = ComboBoxStyle.DropDownList; 
            cmb.SelectedIndex = -1;
        }
        public static void Setup(this DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows= false;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.HeaderText = col.HeaderText.Replace('_', ' ');
                if (col.HeaderText.ToLower().Contains("date"))
                {
                    col.DefaultCellStyle.Format = "yyyy-MM-dd";
                }
            }
        }
        public static void Fill(this ComboBox cmb, string query,  string valueMember, string displayMember = "name")
        {
            cmb.DataSource = Helper.GetDataTable(query);
            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
        }

        public static void Fill(this ComboBox cmb, string[] displayMembers, string[] valueMembers)
        {
            if (displayMembers.Length != valueMembers.Length)
            {
                throw new ArgumentException("array length mismatch");
            }
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("display");
            dt.Columns.Add("value");
            for (int i = 0; i < displayMembers.Length; i++)
            {
                dt.Rows.Add(displayMembers[i], valueMembers[i]);
            }
            cmb.DataSource = dt;
            cmb.DisplayMember = "display";
            cmb.ValueMember= "value";
        }
        public static void Fill (this DataGridViewComboBoxColumn cmb, string[] items){
            foreach (string item in items)
            {
                cmb.Items.Add(item);
            }
        }

        public static void GenerateExcelFile(this DataGridView dgv, string filename)
        {
            dgv.SelectAll();
            DataObject obj = dgv.GetClipboardContent();
            string temp = Clipboard.GetText();
            Clipboard.SetDataObject(obj);
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            var misVal = System.Reflection.Missing.Value;
            Workbook workbook = app.Workbooks.Add(misVal);
            Worksheet worksheet = workbook.Worksheets[1];
            app.Visible= true;
            worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 5]].Merge();
            worksheet.Cells[1, 1].Value = filename;
            worksheet.Cells[1, 1].Font.Bold = true;
            worksheet.Cells[1, 1].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            Range range = worksheet.Cells[2,1];
            range.Select();
            worksheet.PasteSpecial(range, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            worksheet.SaveAs($"{filename}.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            if (temp.Length != 0) Clipboard.SetText(temp);
            dgv.ClearSelection();
        }


    }
}
