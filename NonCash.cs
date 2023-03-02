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
    public partial class NonCash : UserControl
    {
        string orderid = "";
        Control[] inputFields;
        public NonCash(string orderid)
        {
            InitializeComponent();
            this.orderid = orderid;
            bankComboBox.Fill(new string[] { "BCA", "BRI", "BTN", "Danamon" });
            bankComboBox.Setup();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RecieptForm(orderid).ShowDialog();
            if (Guard.FailsAgainstNull(new Control[] {textBox1, bankComboBox}))
            {
                Helper.ShowError("Inputs cannot be empty");
                return;
            }

            ComboBox comboPayment = (ComboBox)Parent.Parent.Controls.Find("paymentComboBox", true)[0];
            var headorder = Vars.db.Headorders.Find(Convert.ToInt32(orderid));
            headorder.bank = bankComboBox.Text;
            headorder.payment = comboPayment.Text;
            Vars.db.SaveChanges();
            DataGridView orderDataGridView = (DataGridView)Parent.Parent.Controls.Find("orderDataGridView", false)[0];
            ComboBox orderidComboBox = (ComboBox)Parent.Parent.Controls.Find("orderidComboBox", true)[0];
            Label lblTotal = (Label)Parent.Parent.Controls.Find("lblTotal", true)[0];
            inputFields = new Control[]
            {
                orderDataGridView, orderidComboBox, textBox1, bankComboBox, lblTotal
            };
            Helper.Clear(inputFields);
        }
    }
}
