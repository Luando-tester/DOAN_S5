using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QLCF.Class
{
    public class ClsMenu
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        private float total;

        public float Total
        {
            get { return total; }
            set { total = value; }
        }
        public ClsMenu(string name, int count, float price, float total = 0)
        {
            this.Name = name;
            this.Count = count;
            this.Price = price;
            this.Total = Total;
        }
        public ClsMenu(DataRow row)
        {
            this.Name = row["name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.Total = (float)Convert.ToDouble(row["TotalPrice"].ToString());
        }
    }
}
