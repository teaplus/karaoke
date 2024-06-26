using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKaraoke.DTO
{
    public class Category
    {
        //Loại dịch vụ
        public Category(string id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        //Hiển thị loại dịch vụ
        public Category(DataRow row)
        {
            this.ID = row["Id"].ToString();
            this.Name = row["Name"].ToString();
            
        }

        private string id;

        //Hàm get set id
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        //Hàm get set tên loại dịch vụ
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
