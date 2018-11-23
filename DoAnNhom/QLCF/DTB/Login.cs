using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QLCF.DTB
{
    public class Login
    {
        private static Login instance;

        public static Login Instance
        {
            get { if(instance == null) instance = new Login(); return instance; }
            private set { instance = value; }
        }
        private Login() { }

        public bool Logins(string username, string password)
        {
            string query = "SELECT * FROM dbo.Account WHERE Username = @username and Password = @password";
            DataTable result = DataProvider.Instance.ExcuteQuery(query,new object[]{username,password});
            return result.Rows.Count > 0;
        }
    }
}
