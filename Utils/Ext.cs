using System;
using System.Collections.Generic;
using System.Data;
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
        public static void ShowTinyError(this Control c, string message = "Input cannot be empty")
        {
            ep.SetError(c, message);
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
                cmb.Items.Add(item);
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
            DataTable dt = new DataTable();
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

    }
}
