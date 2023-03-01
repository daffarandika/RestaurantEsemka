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
    public partial class CashierNav : Form
    {
        public CashierNav()
        {
            InitializeComponent();
            lblUsername.Text = $"Hello, {Vars.dtEmployee.Rows[0]["name"]}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (new PreorderForm().ShowDialog() != DialogResult.OK)
            {
                return;
            }
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new OrderUC());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new ChangePasswordUC());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new PaymentUC());
        }

        private void CashierNav_Load(object sender, EventArgs e)
        {

        }
    }
}
