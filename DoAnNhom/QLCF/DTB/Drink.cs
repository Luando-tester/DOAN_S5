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
    }
}
