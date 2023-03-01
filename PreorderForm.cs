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
    public partial class PreorderForm : Form
    {
        public PreorderForm()
        {
            InitializeComponent();
            memberidComboBox.Fill("select * from member", "memberid");
            memberidComboBox.Setup();
        }

        private void PreorderForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (memberidComboBox.SelectedIndex == -1)
            {
                Helper.ShowError("Please select a member first");
                return;
            }
            string name = memberidComboBox.Text;
            Vars.dtMember = Helper.GetDataTable("select * from member where name = '"+name+"'");
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
