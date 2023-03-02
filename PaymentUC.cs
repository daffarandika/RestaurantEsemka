using r6.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r6
{
    public partial class PaymentUC : UserControl
    {
        public PaymentUC()
        {
            InitializeComponent();
            orderidComboBox.Fill("select orderid from headorder where payment = '-'", "orderid", "orderid");
            orderidComboBox.Setup();
            paymentComboBox.Fill(new string[] { "CASH", "DEBIT", "CREDIT" });
            paymentComboBox.Setup();
        }

        private void PaymentUC_Load(object sender, EventArgs e)
        {

        }

        private void orderidComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderidComboBox.SelectedIndex == -1) return;

            int total = 0;
            int orderid = Convert.ToInt32(orderidComboBox.Text);

            orderDataGridView.DataSource = Vars.db.Detailorders.Where(h => h.orderid == orderid).Select(h => new
            {
                Menu = h.Menu.name,
                Qty = h.qty,
                Price = h.price,
                Total = h.qty * h.price,
            }).ToList();
            foreach (DataGridViewRow row in orderDataGridView.Rows)
            {
                total += Convert.ToInt32(row.Cells["total"].Value);
            }
            lblTotal.Text = $"Total: {total.ToString("C", CultureInfo.GetCultureInfo("id-ID"))}";
        }

        private void paymentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderidComboBox.SelectedIndex == -1)
            {
                Helper.ShowError("Please select an order first");
                return;
            }
            string orderid = Convert.ToString(orderidComboBox.Text);
            switch (paymentComboBox.SelectedIndex)
            {
                case 0:
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(new CashUC(orderid));
                    break;
                case 1:
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(new NonCash(orderid));
                    break;
                case 2:
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(new NonCash(orderid));
                    break;
                default:
                    flowLayoutPanel1.Controls.Clear();
                    break;
            }
        }
    }
}
