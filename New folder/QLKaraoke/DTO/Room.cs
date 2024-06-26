using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKaraoke.DTO
{
    public class Room
    {
        //Hàm phòng
        public Room(string id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        //Hiển thị thông tin phòng
        public Room(DataRow row)
        {
            this.ID = row["Id"].ToString();
            this.Name = row["Name"].ToString();
            this.Status = row["StatusRoom"].ToString();
        }

        private string id;

        //Hàm get set id
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        //Hàm get set tên
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string status;
        
        //Hàm get ste trạng thái phòng
        public string Status
        {
            get { return status; }


            set { status = value; }
        }
    }
}
