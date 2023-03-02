using r6.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r6
{
    public partial class ReportUC : UserControl
    {
        public ReportUC()
        {
            InitializeComponent();
            chart1.Series.Clear();
            string[] nums = new string[12];
            string[] names = new string[12];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = new DateTime(DateTime.Now.Year, i + 1, 1).ToString("MM");
                names[i] = new DateTime(DateTime.Now.Year, i + 1, 1).ToString("MMMM");
            }
            cmbFrom.Fill(names, nums);
            cmbFrom.Setup();
            cmbTo.Fill(names, nums);
            cmbTo.Setup();
        }

        private void ReportUC_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dateFrom = new DateTime(DateTime.Now.Year, Convert.ToInt32(cmbFrom.SelectedValue), 1).ToString("yyyy-MM-dd");
            string dateTo = new DateTime(DateTime.Now.Year, Convert.ToInt32(cmbTo.SelectedValue), 1).ToString("yyyy-MM-dd");
            DataTable dt = Helper.GetDataTable("select month(headorder.date) as 'Month', sum(qty * price) as 'Income' from headorder join detailorder on detailorder.orderid = headorder.orderid where date >= '2023-02-03' and date < '2023-03-04' group by month(date)");
            dataGridView1.DataSource = dt.AsEnumerable().Select(d => new
            {
                Month = new DateTime(DateTime.Now.Year, d.Field<int>("month"), 1).ToString("MMMM"),
                Income = d.Field<int>("Income").ToString("C", CultureInfo.GetCultureInfo("id-ID")),
            }).ToList();
            dataGridView1.Setup();
            chart1.Series.Add("Income");
            chart1.Titles.Add("Income in millions");
            foreach(DataRow row in dt.Rows)
            {
                chart1.Series["Income"].Points.AddXY(new DateTime(DateTime.Now.Year, Convert.ToInt32(row["month"]), 1).ToString("MMMM"), Convert.ToInt32(row["income"]) / 1_000_000);
            }

        }
    }
}
