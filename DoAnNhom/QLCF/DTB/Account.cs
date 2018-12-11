using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLCF.Class;

namespace QLCF.DTB
{
    public class Account
    {
        private static Account instance;

        public static Account Instance
        {
            get { if(instance == null) instance = new Account();return Account.instance; }
            private set { Account.instance = value; }
        }

        //lay danh sach tai khoan
        public List<ClsAccount> listAccount()
        {
            List<ClsAccount> list = new List<ClsAccount>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SP_Account");

            foreach (DataRow item in data.Rows)
            {
                ClsAccount account = new ClsAccount(item);
                list.Add(account);
            }

            return list;
        }
        //them tai khoan
        public bool themAccount(string username, string displayname, string password, int type)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("SP_themTaikhoan @Username , @Displayname , @Password , @type", new object[]{username,displayname,password,type});
            return result > 0;
        }

        //cap nhat tai khoan
        public bool capnhatAccount(string username, string displayname, string password, int type)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("SP_capnhatTaikhoan @Username , @Displayname , @Password , @type", new object[] { username, displayname, password, type });
            return result > 0;
        }

        //xoa tai khoan
        public bool xoaAccount(string username)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("SP_xoaTaikhoan @Username", new object[] { username });
            return result > 0;
        }

        //Tim kiem tai khoan
        public List<ClsAccount> timkiem(string name)
        {
            List<ClsAccount> list = new List<ClsAccount>();
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM Account WHERE dbo.GetUnsignString(UserName) LIKE N'%' + dbo.GetUnsignString(N'" + name + "') + '%'");
            foreach (DataRow item in data.Rows)
            {
                ClsAccount account = new ClsAccount(item);
                list.Add(account);
            }
            return list;
        }
    }
}
