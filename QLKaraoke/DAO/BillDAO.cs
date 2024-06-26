using QLKaraoke.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKaraoke.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        //Hàm get set chi tiết hóa đơn
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }


        private BillDAO() { }

        //Hàm lấy id của hóa đơn
        public string getUnChBillID(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("exec getUnChBillID @id", new object[] { id});
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;

            }
            return null;
        }

        //Hàm thêm hóa đơn
        public void InsertBill(string id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idRoom", new object[] { id});
        }

        //Hàm lấy id lớn nhất của hóa đơn
        public string GetMaxIDBill()
        {
            try
            {
                return DataProvider.Instance.ExecuteScalar("Select Max(Id) from Bill").ToString();
            }
            catch
            {
                return null;
            }
        }

        //Hàm thanh toán hóa đơn
        public void CheckOut(string id, int dis, float totalPrice)
        {
            DataProvider.Instance.ExecuteNonQuery("exec checkOut @id , @dis , @totalPrice ", new object[] { id, dis, totalPrice});
        }

        //Hàm hiển thị danh sách hóa đơn
        public DataTable ShowListBill(DateTime daySet, DateTime dayGet)
        {
           return DataProvider.Instance.ExecuteQuery("exec USP_showListBill @daySet , @dayGet ", new object[] { daySet, dayGet});
        }
    }
}
