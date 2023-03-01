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
    public partial class LoginForm : Form
    {
        bool hidePW = true;
        public LoginForm()
        {
            InitializeComponent();
            passwordTextBox.UseSystemPasswordChar= hidePW;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Guard.FailsAgainstNull(new Control[] { emailTextBox, passwordTextBox }))
            {
                Helper.ShowError("Inputs cannot be empty");
                return;
            }
            string email = emailTextBox.Text;
            string password = Helper.Hash(passwordTextBox.Text);
            if (!Helper.QueryHasRows("select * from employee where email = '"+email+"' and password = '" + password + "'"))
            {
                Helper.ShowError("No user found");
                return;
            }
            Vars.dtEmployee = Helper.GetDataTable("select * from employee where email = '" + email + "' and password = '" + password + "'");
            Hide();
            string position = Vars.dtEmployee.Rows[0]["position"].ToString();
            switch (position)
            {
                case "ADMIN":
                    new AdminNav().ShowDialog();
                    break;
                case "CHEF":
                    new ChefNav().ShowDialog();
                    break;
                case "CASHIER":
                    new CashierNav().ShowDialog();
                    break;
            }
            Close();
        }

        private void cbShowPW_CheckedChanged(object sender, EventArgs e)
        {
            hidePW = !hidePW;
            passwordTextBox.UseSystemPasswordChar = hidePW;
            passwordTextBox.Focus();
        }
    }
}
