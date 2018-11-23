using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QLCF.Class
{
    public class ClsDrinkBill
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int idBill;

        public int IdBill
        {
            get { return idBill; }
            set { idBill = value; }
        }
        private int drinkId;

        public int DrinkId
        {
            get { return drinkId; }
            set { drinkId = value; }
        }
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public ClsDrinkBill(int id, int idBill, int idDrink, int count)
        {
            this.Id = id;
            this.IdBill = idBill;
            this.DrinkId = idDrink;
            this.Count = count;
        }
        public ClsDrinkBill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.IdBill = (int)row["idBill"];
            this.DrinkId = (int)row["idDrink"];
            this.Count = (int)row["count"];
        }
    }
}
