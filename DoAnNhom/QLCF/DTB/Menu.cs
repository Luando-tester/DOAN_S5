using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLCF.Class;
using System.Data;

namespace QLCF.DTB
{
    public class Menu
    {
        private static Menu instance;

        public static Menu Instance
        {
            get { if (instance == null) instance = new Menu(); return Menu.instance; }
            private set { Menu.instance = value; }
        }

        private Menu() { }

        //Lấy danh sách Menu từ  id Bàn chưa thanh toán
        public List<ClsMenu> getListMenu(int id)
        {
            List<ClsMenu> listMenu = new List<ClsMenu>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT d.name,db.count,d.price,d.price*db.count AS TotalPrice FROM dbo.DrinkBill AS db,dbo.drink AS d,dbo.Bill AS bi WHERE db.idBill = bi.id AND db.idDrink = d.id AND bi.status = 0 AND bi.idTable = " + id);

            foreach (DataRow item in data.Rows)
            {
                ClsMenu menu = new ClsMenu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
