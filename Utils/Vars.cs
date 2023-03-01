using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r6.Utils
{
    internal class Vars
    {
        public static r6Entities db = new r6Entities();
        public static string StorageDir = @"C:\Users\" + Environment.UserName + @"\Desktop\r6\images";
        public static DataTable dtEmployee = Helper.GetDataTable("select * from employee where employeeid = 3");
        public static DataTable dtMember = new DataTable();
    }
}
