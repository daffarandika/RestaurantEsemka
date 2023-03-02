using r6.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace r6
{
    public partial class MenuUC : UserControl
    {
        bool imageChanged = false;
        string filename = "";
        Control[] clearableInputField;
        Control[] insertInputField;
        Control[] updatableInputField;
        public MenuUC()
        {
            InitializeComponent();
            clearableInputField = new Control[]
            {
                nameTextBox, priceTextBox, menuidTextBox, photoTextBox, pictureBox1
            };
            insertInputField = new Control[]
            {
                nameTextBox, priceTextBox, photoTextBox
            };
            updatableInputField = clearableInputField;
            FillDGV();
        }

        private void FillDGV()
        {
            menuDataGridView.DataSource = Vars.db.Menus.Select(m => new
            {
                Menu_ID = m.menuid,
                Name = m.name,
                Price = m.price,
                Photo = m.photo
            }).ToList();
            menuDataGridView.Columns["photo"].Visible = false;
            menuDataGridView.Setup();
        }

        private void MenuUC_Load(object sender, EventArgs e)
        {
        }

        private void menuDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = menuDataGridView.CurrentRow;
            menuidTextBox.Text = row.Cells["menu_id"].Value.ToString();
            nameTextBox.Text = row.Cells["name"].Value.ToString();
            priceTextBox.Text = row.Cells["price"].Value.ToString();
            photoTextBox.Text = row.Cells["photo"].Value.ToString();
            pictureBox1.Image = Image.FromFile(Path.Combine(Vars.StorageDir, photoTextBox.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            imageChanged= true;
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Images Only (*.jpeg; *.jpg; *.png)| *.jpeg; *.jpg; *.png",
                Multiselect = false
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                photoTextBox.Text = ofd.SafeFileName;
                filename = ofd.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Vars.StorageDir);
            File.Copy(filename,
                Path.Combine(Vars.StorageDir, photoTextBox.Text),
                true);
            Vars.db.Menus.Add(new Menu
            {
                name = nameTextBox.Text,
                price = Convert.ToInt32(priceTextBox.Text),
                photo = photoTextBox.Text,
            });
            Vars.db.SaveChanges();
            FillDGV();
            Helper.Clear(clearableInputField);
            imageChanged= false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Guard.FailsAgainstNull(updatableInputField))
            {
                Helper.ShowError("Inputs cannot be empty");
            }
            var menu = Vars.db.Menus.Find(Convert.ToInt32(menuidTextBox.Text));
            menu.name = nameTextBox.Text;
            menu.price = Convert.ToInt32(priceTextBox.Text);
            menu.photo = photoTextBox.Text;
            Vars.db.SaveChanges();
            if (imageChanged)
            {
                Directory.CreateDirectory(Vars.StorageDir);
                File.Copy(filename,
                    Path.Combine(Vars.StorageDir, photoTextBox.Text),
                    true);
            }
            Helper.Clear(clearableInputField);
            FillDGV();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Helper.AskForConfirmation() != DialogResult.Yes)
            {
                return;
            }
            if (menuDataGridView.CurrentRow.Index == -1)
            {
                Helper.ShowError("Please select an employee first");
            }
            string menuid = menuidTextBox.Text;
            Helper.RunQuery("delete from menu where menuid = '" + menuid + "'");
            Helper.Clear(clearableInputField);
            FillDGV();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            menuDataGridView.GenerateExcelFile($"List of menus {DateTime.Now.ToString("yyyy-MM-dd")}");
        }
    }
}
