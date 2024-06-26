using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKaraoke.DTO
{
   public class Menu
    {
        //Hàm mục lục
        public Menu(string foodName, int count, float price, float totalPrice)
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        //Hiển thị thông tin được show ra trong hóa đơn
        public Menu(DataRow row)
        {
            this.FoodName = row["Name"].ToString();
            this.Count = (int)row["Number"];
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["TotalPrice"].ToString());
        }

        private string foodName;

        //Hàm get set tên dịch vụ
        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }

        private int count;

        //Hàm get set số lượng
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private float price;

        //Hàm get set giá
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private float totalPrice;

        //Hàm get set tổng giá tiền thanh toán
        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
    }
}
