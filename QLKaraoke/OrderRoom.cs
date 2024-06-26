using QLKaraoke.DAO;
using QLKaraoke.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = QLKaraoke.DTO.Menu;

namespace QLKaraoke
{
    public partial class OrderRoom : Form
    {
        public OrderRoom()
        {
            InitializeComponent();
            LoadOrderRoom_RoomID();
            LoadEmptyRoom_RoomID();
        }

        //Hiển thị danh sách phòng theo id
        void LoadOrderRoom_RoomID()
        {
            List<Room> listRoom = RoomDAO.Instance.LoadUnRoomListOrder();
            comboBox_OrderRoom_listRoom.DataSource = listRoom;
            comboBox_OrderRoom_listRoom.DisplayMember = "id";
        }

        //Hiển thị danh sách phòng trống có thể đặt
        void LoadEmptyRoom_RoomID()
        {
            List<Room> listRoom = RoomDAO.Instance.LoadRoomListOrder();
            comboBox_Order_listRoomFull.DataSource = listRoom;
            comboBox_Order_listRoomFull.DisplayMember = "id";
        }

        //Chấp nhận thông tin đặt phòng
        private void Button_OrderRoom_AddRoom_Click(object sender, EventArgs e)
        {
            string id = comboBox_OrderRoom_listRoom.Text;
            RoomDAO.Instance.OrderRoom(id);
            LoadOrderRoom_RoomID();
            MessageBox.Show("Đặt phòng thành công");
        }

        //Hủy phòng đã đặt
        private void Button_OrderRoom_RemoveRoom_Click(object sender, EventArgs e)
        {
            string id = comboBox_Order_listRoomFull.Text;
            int discount = 0;
            if (MessageBox.Show("Bạn thật sự muốn hủy phòng", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                BillDAO.Instance.CheckOut(id, discount, 0);
                RoomDAO.Instance.DeleteRoom(id);      
            }
        }

        private void OrderRoom_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
