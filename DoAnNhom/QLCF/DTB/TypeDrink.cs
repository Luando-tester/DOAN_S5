using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLCF.Class;
using System.Data;

namespace QLCF.DTB
{
    public class TypeDrink
    {
        private static TypeDrink instance;

        public static TypeDrink Instance
        {
            get { if (instance == null) instance = new TypeDrink(); return TypeDrink.instance; }
            private set { TypeDrink.instance = value; }
        }

        private TypeDrink() { }

        public List<ClsTypeDrink> ListTypeDrink()
        {
            List<ClsTypeDrink> listTypeDrink = new List<ClsTypeDrink>();
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC SP_LoaiDrink");
            foreach (DataRow item in data.Rows)
            {
                ClsTypeDrink typedrink = new ClsTypeDrink(item);
                listTypeDrink.Add(typedrink);
            }
            return listTypeDrink;
        }
    }
}
