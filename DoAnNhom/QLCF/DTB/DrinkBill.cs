using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLCF.Class;
using System.Data;

namespace QLCF.DTB
{
    public class DrinkBill
    {
        private static DrinkBill instance;

        public static DrinkBill Instance
        {
            get { if (instance == null) instance = new DrinkBill(); return DrinkBill.instance; }
            private set { DrinkBill.instance = value; }
        }
        private DrinkBill() { }

        //Lấy danh sách hóa đơn từ id của hóa đơn
        public List<ClsDrinkBill> GetListBill(int id)
        {
            List<ClsDrinkBill> listBill = new List<ClsDrinkBill>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.DrinkBill WHERE idBill = " + id);
            foreach (DataRow item in data.Rows)
            {
                ClsDrinkBill drinkbill = new ClsDrinkBill(item);
                listBill.Add(drinkbill);
            }
            return listBill;
        }
    }
}
