using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLCF.Class;
using System.Data;

namespace QLCF.DTB
{
    public class Drink
    {
        private static Drink instance;

        public static Drink Instance
        {
            get { if (instance == null) instance = new Drink(); return Drink.instance; }
            private set { Drink.instance = value; }
        }
        private Drink() { }

        public List<ClsDrink> listDrink(int id)
        {
            List<ClsDrink> list = new List<ClsDrink>();
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC SP_getDrinkbyIdTypeDrink " + id);
            foreach (DataRow item in data.Rows)
            {
                ClsDrink drink = new ClsDrink(item);
                list.Add(drink);
            }
            return list;
        }
        public List<ClsDrink> getListDrink()
        {
            List<ClsDrink> listDrink = new List<ClsDrink>();
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC SP_listDrink");
            foreach (DataRow item in data.Rows)
            {
                ClsDrink drink = new ClsDrink(item);
                listDrink.Add(drink);
            }
            return listDrink;
        }

        //Thuc hien query them drink
        public bool themDrink(string name, int id, float price)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("EXEC SP_themDrink @name , @idloai , @price",new object[]{name,id,price});
            return result > 0;
        }

        //thuc hien query cap nhat drink
        public bool suaDrink(int id, string name, int idLoai, float price)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("EXEC SP_updateDrink @id , @name , @idloai , @price", new object[]{id,name,idLoai,price});
            return result > 0;
        }

        //thuc hien xoa drink
        public bool xoaDrink(int id)
        {
            DrinkBill.Instance.deleteDrinkId(id);
            int result = DataProvider.Instance.ExcuteNonQuery("EXEC SP_deleteDrink @id", new object[]{id});
            return result > 0;
        }

        //tim kiem drink
        public List<ClsDrink> timkiem(string name)
        {
            List<ClsDrink> listDrink = new List<ClsDrink>();
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM drink WHERE dbo.GetUnsignString(name) LIKE N'%' + dbo.GetUnsignString(N'" + name + "') + '%'");
            foreach (DataRow item in data.Rows)
            {
                ClsDrink drink = new ClsDrink(item);
                listDrink.Add(drink);
            }
            return listDrink;
        }
        public void deleteDrinkByTypeId(int id)
        {
            DataProvider.Instance.ExcuteQuery("EXEC SP_deleteDrinkByType @idTypeDrink", new object[] { id });
        }
    }
}
