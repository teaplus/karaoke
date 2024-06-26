using QLKaraoke.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKaraoke.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        //Hàm get set chi tiết hóa đơn
        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }


        private BillInfoDAO() { }

        //Hàm lấy chi tiết hóa đơn
        public List<BillInfo> GetLBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec GetLBillInfo @id", new object[] { id});
            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }

        //Hàm thêm chi tiết hóa đơn
        public void InsertBillInfo(string idBill, string idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }
    }
}
