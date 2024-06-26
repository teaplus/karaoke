using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKaraoke.DTO
{
   public class Food
    {
        //Hàm lấy dịch vụ
        public Food(string id, string name, string categoryId, float price)
        {
            this.ID = id;
            this.Name = name;
            this.CategoryID = categoryID;
            this.Price = price;
        }

        //Hiển thị dịch vụ
        public Food(DataRow row)
        {
            this.ID = row["Id"].ToString();
            this.Name = row["Name"].ToString();
            this.CategoryID = row["IdCategory"].ToString();
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
        }

        private string id;

        //Hàm get set id 
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        //Hàm get set tên dịch vụ
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        private string categoryID;

        //Hàm get set loại dịch vụ
        public string CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        private float price;

        //Hàm get set giá
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}

