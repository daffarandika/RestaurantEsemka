using r6.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r6
{
    public partial class VOrderUC : UserControl
    {
        public VOrderUC()
        {
            InitializeComponent();
            orderDataGridView.Setup();
            orderDataGridView.ReadOnly = false;
            orderidComboBox.Fill("select orderid from headorder", "orderid", "orderid");
            orderidComboBox.Setup();
            actionC.Fill(new string[] {"COOKING", "PENDING", "DELIVERED"});
        }

        private void VOrderUC_Load(object sender, EventArgs e)
        {

        }

        private void orderidComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderidComboBox.SelectedIndex == -1) return;

            int total = 0;
            orderDataGridView.Rows.Clear();
            string orderid = orderidComboBox.Text;
            using (var conn = Helper.GetSqlConnection())
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select detailid, menu.name as 'Menu', qty, status from detailorder join menu on menu.menuid = detailorder.menuid where orderid = '" + orderid + "'";
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read()) 
                {
                    orderDataGridView.Rows.Add(reader["detailid"], reader["menu"], reader["qty"], reader["status"]);
                }
            }
        }

        private void orderDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox box = (ComboBox)e.Control;
            box.SelectedIndexChanged -= statusComboBoxChanged;
            box.SelectedIndexChanged += statusComboBoxChanged;
        }

        private void statusComboBoxChanged(object sender, EventArgs e)
        {
            string status = ((ComboBox)sender).Text;
            int detailid = Convert.ToInt32(orderDataGridView.CurrentRow.Cells["detailid"].Value);
            Detailorder detailorder = Vars.db.Detailorders.Find(detailid);
            detailorder.status = status;
            Vars.db.SaveChanges();
        }
    }
}
