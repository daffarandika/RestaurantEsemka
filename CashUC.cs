using r6.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r6
{
    public partial class CashUC : UserControl
    {
        string orderid = "";
        int total = 0;
        Control[] inputFields;
        public CashUC(string orderid)
        {
            InitializeComponent();
            this.orderid= orderid;
            DataTable dt = Helper.GetDataTable("select * from detailorder where orderid = '"+orderid+"'");
            foreach (DataRow row in dt.Rows)
            {
                total += Convert.ToInt32(row["qty"]) * Convert.ToInt32(row["price"]);
            }
        }

        private void CashUC_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RecieptForm(orderid).ShowDialog();
            if (Guard.FailsAgainstNull(new Control[] { tbCash }))
            {
                Helper.ShowError("Inputs cannot be empty");
                return;
            }
            int cash = Convert.ToInt32(tbCash.Text);
            if (cash < total)
            {
                Helper.ShowError("The amount recieved was less than expected");
                return;
            }
            int change = cash - total;
            tbChange.Text = change.ToString();
            var headorder = Vars.db.Headorders.Find(Convert.ToInt32(orderid));
            headorder.payment = "BANK";
            Vars.db.SaveChanges();
            DataGridView orderDataGridView = (DataGridView)Parent.Parent.Controls.Find("orderDataGridView", false)[0];
            ComboBox orderidComboBox = (ComboBox)Parent.Parent.Controls.Find("orderidComboBox", true)[0];
            inputFields = new Control[]
            {
                tbCash, tbChange, orderDataGridView, orderidComboBox
            };
            Helper.Clear(inputFields);
        }
    }
}
