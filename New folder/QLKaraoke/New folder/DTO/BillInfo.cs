using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKaraoke.DTO
{
    public class BillInfo
    {

        //Chi tiết hóa đơn
        public BillInfo(string id, string idBill, string idFood, int count)
        {
            this.ID = id;
            this.IdBill = idBill;
            this.IdFood = idFood;
            this.Number = count;
        }

        //Hiển thi chi tiết hóa đơn thanh toán
        public BillInfo(DataRow row)
        {
            this.ID = row["Id"].ToString();
            this.IdBill = row["IdBill"].ToString();
            this.IdFood = row["IdFood"].ToString();
            this.Number = (int)row["Number"];
        }

        private int number;

        //Hàm get set số lượng
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        private string idFood;

        //Hàm get set id dịch vụ
        public string IdFood
        {
            get { return idFood; }
            set { idFood = value; }
        }

        private string idBill;

        //Hàm get set id hóa đơn
        public string IdBill
        {
            get { return idBill; }
            set { idBill = value; }
        }

        private string id;

        //Hàm get set id
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
