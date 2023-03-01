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
    public partial class ChangePasswordUC : UserControl
    {
        public ChangePasswordUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldPw = Helper.Hash(oldPasswordTextBox.Text);
            string currentPw = Vars.dtEmployee.Rows[0]["password"].ToString();
            string employeeid = Vars.dtEmployee.Rows[0]["employeeid"].ToString();
            if (currentPw != oldPw)
            {
                Helper.ShowError("Password is incorrect");
                return;
            }
            string newPw = Helper.Hash(newPasswordTextBox.Text);
            string confirmPw = Helper.Hash(confirmPasswordTextBox.Text);
            if (newPw != confirmPw)
            {
                Helper.ShowError("Password does not match");
                return;
            }
            Helper.RunQuery("update employee set password = '"+newPw+"' where employeeid = '"+employeeid+"'");
        }
    }
}
