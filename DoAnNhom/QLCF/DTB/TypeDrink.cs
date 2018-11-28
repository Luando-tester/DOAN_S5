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

        public ClsTypeDrink loadTypeDrinkbyId(int id)
        {
            ClsTypeDrink name = null;

            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC SP_LoaiDrinkId @id",new object[]{id});

            foreach (DataRow item in data.Rows)
            {
                name = new ClsTypeDrink(item);
                return name;
            }

            return name;
        }

        //them type drink
        public bool themTypeDrink(string name)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("EXEC SP_themLoaidrink @name", new object[] { name });
            return result > 0;
        }

        //sua type drink
        public bool suaTypeDrink(int id, string name)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("EXEC SP_capnhatLoaidrink @id , @name", new object[] { id, name });
            return result > 0;
        }
        public bool xoaTypeDrink(int id)
        {
            Drink.Instance.deleteDrinkByTypeId(id);
            int result = DataProvider.Instance.ExcuteNonQuery("EXEC SP_xoaLoaidrink @id", new object[] { id });
            return result > 0;
        }
    }
}
