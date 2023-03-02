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
    public partial class EmployeeUC : UserControl
    {
        Control[] updateInputField;
        Control[] insertInputField;
        Control[] clearableInputField;
        public EmployeeUC()
        {
            InitializeComponent();
            FillDGV();
            positionComboBox.Fill(new string[] { "ADMIN", "CHEF", "CASHIER" });
            updateInputField = new Control[]
            {
                nameTextBox, emailTextBox, passwordTextBox, handphoneTextBox, positionComboBox, employeeidTextBox
            };
            insertInputField = new Control[]
            {
                nameTextBox, emailTextBox, passwordTextBox, handphoneTextBox, positionComboBox, passwordTextBox
            };
            clearableInputField = new Control[]
            {
                nameTextBox, emailTextBox, passwordTextBox, handphoneTextBox, positionComboBox, employeeidTextBox, passwordTextBox
            };
        }

        private void FillDGV()
        {
            employeeDataGridView.DataSource = Vars.db.Employees.Select(emp => new
            {
                Employee_ID = emp.employeeid,
                Name = emp.name,
                Email = emp.email,
                Handphone = emp.handphone,
                Position = emp.position
            }).ToList();
            employeeDataGridView.Setup();
        }

        private void EmployeeUC_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Guard.FailsAgainstNull(insertInputField))
            {
                Helper.ShowError("Inputs cannot be emtpy");
                return;
            }
            Vars.db.Employees.Add(new Employee
            {
                name = nameTextBox.Text,
                email = emailTextBox.Text,
                handphone = handphoneTextBox.Text,
                password = Helper.Hash(passwordTextBox.Text),
                position = positionComboBox.Text
            });
            Vars.db.SaveChanges();
            FillDGV();
            Helper.Clear(clearableInputField);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (Guard.FailsAgainstNull(updateInputField))
            {
                Helper.ShowError("Inputs cannot be emtpy");
                return;
            }
            var emp = Vars.db.Employees.Find(Convert.ToInt32(employeeidTextBox.Text));
            emp.name = nameTextBox.Text;    
            emp.email= emailTextBox.Text;
            emp.position = positionComboBox.Text;
            emp.handphone = handphoneTextBox.Text;
            Vars.db.SaveChanges ();
            FillDGV();
            Helper.Clear(clearableInputField);
        }

        private void employeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = employeeDataGridView.Rows[e.RowIndex];
            employeeidTextBox.Text = row.Cells["employee_id"].Value.ToString();
            nameTextBox.Text = row.Cells["name"].Value.ToString();
            emailTextBox.Text = row.Cells["email"].Value.ToString();
            handphoneTextBox.Text = row.Cells["handphone"].Value.ToString();
            positionComboBox.Text = row.Cells["position"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Helper.AskForConfirmation() != DialogResult.Yes)
            {
                return;
            }
            if (employeeDataGridView.CurrentRow.Index == -1)
            {
                Helper.ShowError("Please select an employee first");
            }
            string employeeid = employeeidTextBox.Text;
            Helper.RunQuery("delete from employee where employeeid = '" + employeeid + "'");
            Vars.db.SaveChanges();
            FillDGV();
            Helper.Clear(clearableInputField);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            employeeDataGridView.GenerateExcelFile($"List of employees {DateTime.Now.ToString("yyyy-MM-dd")}");
        }
    }
}
