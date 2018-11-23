using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLCF.Class;
using System.Data;

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
    }
}
