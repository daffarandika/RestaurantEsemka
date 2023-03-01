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
    public partial class MemberUC : UserControl
    {
        Control[] clearableInputField;
        Control[] insertInputField;
        Control[] updatableInputField;
        public MemberUC()
        {
            InitializeComponent();
            FillDGV();
            clearableInputField = new Control[]
            {
                nameTextBox, emailTextBox, handphoneTextBox, memberidTextBox
            };
            insertInputField = new Control[]
            {
                nameTextBox, emailTextBox, handphoneTextBox
            };
            updatableInputField = clearableInputField;
        }

        private void FillDGV()
        {
            memberDataGridView.DataSource = Vars.db.Members.Select(m => new
            {
                Member_ID = m.memberid,
                Name = m.name,
                Email = m.email,
                Handphone = m.handphone,
                Join_Date = m.joindate
            }).ToList();
            memberDataGridView.Setup();
        }

        private void MemberUC_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Guard.FailsAgainstNull(insertInputField))
            {
                Helper.ShowError("Inputs cannot be empty");
            }
            Vars.db.Members.Add(new Member
            {
                name = nameTextBox.Text,
                email = emailTextBox.Text,
                handphone = handphoneTextBox.Text,
                joindate = DateTime.Now
            });
            Vars.db.SaveChanges();
            FillDGV();
            Helper.Clear(clearableInputField);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Guard.FailsAgainstNull(updatableInputField))
            {
                Helper.ShowError("Inputs cannot be empty");
            }
            var member = Vars.db.Members.Find(Convert.ToInt32(memberidTextBox.Text));
            member.name = nameTextBox.Text;
            member.email = emailTextBox.Text;
            member.handphone = handphoneTextBox.Text;
            Vars.db.SaveChanges();
            FillDGV();
            Helper.Clear(clearableInputField);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Helper.AskForConfirmation() != DialogResult.Yes)
            {
                return;
            }
            if (memberDataGridView.CurrentRow.Index == -1)
            {
                Helper.ShowError("Please select an employee first");
            }
            string memberid = memberidTextBox.Text;
            Helper.RunQuery("delete from member where memberid = '" + memberid + "'");
            FillDGV();
            Helper.Clear(clearableInputField);
        }

        private void memberDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = memberDataGridView.CurrentRow;
            memberidTextBox.Text = row.Cells["member_id"].Value.ToString();
            nameTextBox.Text = row.Cells["name"].Value.ToString();
            emailTextBox.Text = row.Cells["email"].Value.ToString();
            handphoneTextBox.Text = row.Cells["handphone"].Value.ToString();
        }
    }
}
