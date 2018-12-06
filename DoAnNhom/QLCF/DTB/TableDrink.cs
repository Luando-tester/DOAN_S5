using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLCF.Class;
using System.Data;
using System.Windows.Forms;

namespace QLCF.DTB
{
    public class TableDrink
    {
        private static TableDrink instance;

        public static TableDrink Instance
        {
            get { if (instance == null) instance = new TableDrink(); return TableDrink.instance; }
            private set { TableDrink.instance = value; }
        }
        public static int TableWidth = 90;
        public static int TableHeight = 90;

        private TableDrink() { }

        //Load danh sách bàn hiển thị ra giao diện
        public List<ClsTableDrink> loadTableDrink()
        {
            List<ClsTableDrink> tablelist = new List<ClsTableDrink>();
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC SP_Ban");
            foreach (DataRow item in data.Rows)
            {
                ClsTableDrink table = new ClsTableDrink(item);
                tablelist.Add(table);
            }
            return tablelist;
        }

        public void chuyenban(int id1, int id2)
        {
            DataProvider.Instance.ExcuteQuery("EXEC SP_chuyenBan @idTable1 , @idTable2", new object[]{id1,id2});
        }
        public bool themBan(string name,string status)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("EXEC SP_themBan @name , @status", new object[] {name,status});
            return result > 0;
        }
        public bool suaBan(int id, string name, string status)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("EXEC SP_capnhatBan @id , @name , @status", new object[] { id, name, status });
            return result > 0;
        }
        public bool xoaBan(int id)
        {
            Bill.Instance.deleteBillByidTable(id);
            int result = DataProvider.Instance.ExcuteNonQuery("EXEC SP_xoaBan @id",new object[]{id});
            return result > 0;
        }
    }
}
