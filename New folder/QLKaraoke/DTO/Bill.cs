using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKaraoke.DTO
{
    public class Bill
    {
        //Hóa đơn thanh toán
        public Bill(string id, DateTime? daySet, DateTime? dayGet, string idAccount, string idRoom,int statusBill, int discount, float totalPrice)
        {
            this.ID = id;
            this.DaySet = daySet;
            this.DayGet = dayGet;
            this.IDAccount = idAccount;
            this.IDRoom = iDRoom;
            this.StatusBill = statusBill;
            this.Discount = discount;
            this.TotalPrice = totalPrice;
        }

        //Hiển thị hóa đơn thanh toán
        public Bill(DataRow row)
        {
            this.ID = row["Id"].ToString();
            this.DaySet = (DateTime?)row["DaySet"];
            this.DayGet = (DateTime?)row["DayGet"];
            this.IDAccount = row["IdAccount"].ToString();
            this.IDRoom = row["IdRoom"].ToString();
            this.StatusBill = (int)row["statusBill"];
            this.Discount = (int)row["discount"];
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }

        private float totalPrice;

        //Hàm get set tổng tiền
        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        private string iDAccount;

        //Hàm get set id tài khoản
        public string IDAccount
        {
            get { return iDAccount; }
            set { iDAccount = value; }
        }

        private string iDRoom;

        //Hàm get set id phòng
        public string IDRoom
        {
            get { return iDRoom; }
            set { iDRoom = value; }
        }

        private string iD;

        //Hàm get set id
        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private int discount;

        //Hàm get set giảm giá
        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        private DateTime? daySet;

        //Hàm get set ngày đặt
        public DateTime? DaySet
        {
            get { return daySet; }
            set { daySet = value; }
        }

        private DateTime? dayGet;

        //Hàm get set ngày nhận
        public DateTime? DayGet
        {
            get { return dayGet; }
            set { dayGet = value; }
        }

        private int statusBill;

        //Hàm get set trạng thái hóa đơn
        public int StatusBill
        {
            get { return statusBill; }
            set { statusBill = value; }
        }
    }
}
