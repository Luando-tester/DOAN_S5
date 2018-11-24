using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QLCF.Class
{
    public class ClsDrink
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int typeDrink;

        public int TypeDrink
        {
            get { return typeDrink; }
            set { typeDrink = value; }
        }
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        public ClsDrink(int id, string name, int typeDrink, float price)
        {
            this.Id = id;
            this.Name = name;
            this.TypeDrink = typeDrink;
            this.Price = price;
        }
        public ClsDrink(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.TypeDrink = (int)row["idTypeDrink"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
    }
}
