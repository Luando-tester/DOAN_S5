using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QLCF.Class
{
    public class ClsAccount
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string displayname;

        public string Displayname
        {
            get { return displayname; }
            set { displayname = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        public ClsAccount(string username, string displayname, int type, string password = null)
        {
            this.Username = username;
            this.Displayname = displayname;
            this.Password = password;
            this.Type = type;
        }
        public ClsAccount(DataRow row)
        {
            this.Username = row["Username"].ToString();
            this.Displayname = row["Displayname"].ToString();
            this.Password = row["Password"].ToString();
            this.Type = (int)row["Type"];
        }
    }
}
