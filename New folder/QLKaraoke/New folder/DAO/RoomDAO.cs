using QLKaraoke.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKaraoke.DAO
{
    public class RoomDAO
    {
        private static RoomDAO instance;

        //Hàm get set phòng
        public static RoomDAO Instance
        {
            get { if (instance == null) instance = new RoomDAO(); return RoomDAO.instance; }
            private set { RoomDAO.instance = value; }
        }

        public static int RoomWidth = 80;
        
        public static int RoomHeight = 50;

        private RoomDAO() { }

        //Hàm tải lại danh sách phòng
        public List<Room> LoadRoomList()
        {
            List<Room> roomList = new List<Room>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetRoomList");
            foreach (DataRow item in data.Rows)
            {
                Room room = new Room(item);
                roomList.Add(room);
            }
            return roomList;
        }

        //Hàm tải lại danh sách order phòng
        public List<Room> LoadRoomListOrder()
        {
            List<Room> roomList = new List<Room>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_GetRoomList_OrderFood");
            foreach (DataRow item in data.Rows)
            {
                Room room = new Room(item);
                roomList.Add(room);
            }
            return roomList;
        }

        //Hàm load danh sách phòng trống
        public List<Room> LoadUnRoomListOrder()
        {
            List<Room> roomList = new List<Room>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetRoomList_OrderRoom");
            foreach (DataRow item in data.Rows)
            {
                Room room = new Room(item);
                roomList.Add(room);
            }
            return roomList;
        }

        //Hàm đặt phòng
        public void OrderRoom(string id)
        {
            DataProvider.Instance.ExecuteQuery("exec OrderRoom @id", new object[]{ id });
        }

        //Hàm đổi trạng thái phòng
        public void DeleteRoom(string id)//change status
        {
            DataProvider.Instance.ExecuteQuery("exec DeleteRoom @id", new object[] { id });
        }

        //Hàm sửa thông tin phòng
        public void SwRoom(string id1, string id2)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_SWRoom @idRoom1 , @idRoom2 ", new object[] { id1, id2 });
        }

        //Hàm hiển thị danh sách phòng
        public DataTable showListRoom()
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_showListRoom");
        }

        //Hàm thêm phòng
        public void addRoom(string name, DateTime d1, DateTime d2, string status)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_insertRoom @name , @dayOut , @dayIn , @status", new object[] { name, d1, d2, status });
        }

        //Hàm xóa phòng
        public void deleteRoom(string id)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_deleteRoom @id ", new object[] { id });
        }
    } 
}
