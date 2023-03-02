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

namespace r6
{
    public partial class OrderUC : UserControl
    {
        public OrderUC()
        {
            InitializeComponent();
            FillMenuDGV();
            orderDataGridView.Columns.Clear();
            orderDataGridView.Columns.Add("menuid", "menuid");
            orderDataGridView.Columns.Add("menu", "Menu");
            orderDataGridView.Columns.Add("qty", "Qty");
            orderDataGridView.Columns.Add("price", "Price");
            orderDataGridView.Columns.Add("total", "Total");
            orderDataGridView.Columns["menuid"].Visible = false;
            orderDataGridView.Setup();
        }

        private void FillMenuDGV()
        {
            menuDataGridView.DataSource = Vars.db.Menus.Select(m => new
            {
                menuid = m.menuid,
                Name = m.name,
                Price = m.price,
                Photo = m.photo
            }).ToList();
            menuDataGridView.Columns["menuid"].Visible = false;
            menuDataGridView.Columns["photo"].Visible = false;
            menuDataGridView.Setup();
        }

        private void OrderUC_Load(object sender, EventArgs e)
        {

        }

        private void menuDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = menuDataGridView.CurrentRow;
            nameTextBox.Text = row.Cells["name"].Value.ToString();
            priceTextBox.Text = row.Cells["price"].Value.ToString();
            pictureBox1.Image = Image.FromFile(Path.Combine(Vars.StorageDir, row.Cells["photo"].Value.ToString()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Guard.FailsAgainstNull(new Control[]
            {
                nameTextBox, priceTextBox, qtyTextBox
            }))
            {
                Helper.ShowError("Inputs cannot be empty");
                return;
            }
            string name = nameTextBox.Text;
            int price = Convert.ToInt32(priceTextBox.Text);
            int qty = Convert.ToInt32(qtyTextBox.Text);
            string menuid = Helper.GetDataTable("select * from menu where name = '" + name + "'").Rows[0]["menuid"].ToString();
            orderDataGridView.Rows.Add(menuid, name, qty.ToString(), price.ToString(), (price * qty).ToString());
            int total = 0; 
            foreach (DataGridViewRow row in orderDataGridView.Rows)
            {
                total += Convert.ToInt32(row.Cells["total"].Value);
            }
            lblTotal.Text = $"Total: {total.ToString("C", CultureInfo.GetCultureInfo("id-ID"))}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string orderid = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToString("yyyyMM001");
            if (Helper.QueryHasRows("select * from headorder where orderid >= '" + orderid + "'"))
            {
                orderid = (Convert.ToInt32(Helper.GetDataTable("select max(orderid) as max from headorder").Rows[0]["max"]) + 1).ToString();
            }
            string employeeid = Vars.dtEmployee.Rows[0]["employeeid"].ToString();
            string memberid = Vars.dtMember.Rows[0]["memberid"].ToString();
            Vars.db.Headorders.Add(new Headorder
            {
                orderid = Convert.ToInt32(orderid),
                employeeid = Convert.ToInt32(employeeid),
                memberid = Convert.ToInt32(memberid),
                date = DateTime.Now,
                payment = "-",
                bank = "-"
            });
            Vars.db.SaveChanges();
            foreach(DataGridViewRow row in orderDataGridView.Rows)
            {
                int menuid = Convert.ToInt32(row.Cells["menuid"].Value);
                int qty = Convert.ToInt32(row.Cells["qty"].Value);
                int price = Convert.ToInt32(row.Cells["price"].Value);
                string status = "PENDING";
                Vars.db.Detailorders.Add(new Detailorder
                {
                    orderid = Convert.ToInt32(orderid),
                    menuid = menuid,
                    qty = qty,
                    price = price,
                    status = status
                });
                Vars.db.SaveChanges();
            }
            Helper.Clear(new Control[]
            {
                qtyTextBox, nameTextBox, priceTextBox, orderDataGridView, menuDataGridView, pictureBox1
            });
            lblTotal.Text = "Total: Rp 0";
        }
    }
}
