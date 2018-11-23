using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLCF.DTB;

namespace QLCF.Class
{
    public class ClsDangnhap
    {
        private static ClsDangnhap instance;

        public static ClsDangnhap Instance
        {
            get { if(instance == null) instance = new ClsDangnhap(); return instance; }
            private set { instance = value; }
        }
        private ClsDangnhap() { }

        public bool Login(string username, string password)
        {
            string query = "SELECT * FROM dbo.Account WHERE Username = @username and Password = @password";
            DataTable result = DataProvider.Instance.ExcuteQuery(query,new object[]{username,password});
            return result.Rows.Count > 0;
        }
    }
}
