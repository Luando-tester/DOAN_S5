using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QLCF.Class;

namespace QLCF.DTB
{
    public class Bill
    {
        private static Bill instance;

        public static Bill Instance
        {
            get { if (instance == null) instance = new Bill(); return Bill.instance; }
            private set { Bill.instance = value; }
        }

        private Bill() { }

        //Lấy hóa đơn của Bàn 
        public int getBill(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Bill WHERE idTable =" + id + "AND status = 0");
            if (data.Rows.Count > 0)
            {
                ClsBill bill = new ClsBill(data.Rows[0]);
                return bill.Id;
            }
            return -1;
        }
        public void AddBill(int id)
        {
            DataProvider.Instance.ExcuteNonQuery("EXEC SP_AddBill @idTable", new object[]{id});
        }

        public int getIdBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExcuteScalar("SELECT MAX(id) FROM Bill");
            }
            catch
            {
                return 1;
            }
        }
        public void CheckOut(int id)
        {
            DataProvider.Instance.ExcuteNonQuery("EXEC SP_BillidTable " + id);
        }
    }
}
