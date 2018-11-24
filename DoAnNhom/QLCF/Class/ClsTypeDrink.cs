using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace QLCF.Class
{
    public class ClsTypeDrink
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
        public ClsTypeDrink(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public ClsTypeDrink(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
        }
    }
}
