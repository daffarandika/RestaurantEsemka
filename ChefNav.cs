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
    public partial class ChefNav : Form
    {
        public ChefNav()
        {
            InitializeComponent();
            lblUsername.Text = $"Hello, {Vars.dtEmployee.Rows[0]["name"]}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new VOrderUC());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(new ChangePasswordUC());
        }

        private void ChefNav_Load(object sender, EventArgs e)
        {

        }
    }
}
