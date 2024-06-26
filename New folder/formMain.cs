using QLKaraoke.DAO;
using QLKaraoke.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = QLKaraoke.DTO.Menu;

namespace QLKaraoke
{

    //public static string N8 = string.Empty;

    public partial class formMain : Form
    {
        public static string N8 = string.Empty;
        public formMain()
        {
            InitializeComponent();
            loadRoom();
            LoadComBRoom(comboBox_Main_ChangeR);
            Hello.Text = N8;
            PQ();
        }

        //Vô hiệu hóa chức năng quản lí nếu người sử dụng không phải admin
        void PQ()
        {
            if (Hello.Text != "Admin")
            {
                managementToolStripMenuItem.Enabled = false;
            }
        }

        //Hiển thị danh sách phòng cùng với trạng thái của nó
        void loadRoom()
        {
            flowLayoutPanel_M_ListRoom.Controls.Clear();
            List<Room> roomList = RoomDAO.Instance.LoadRoomList();
            foreach (Room item in roomList)
            {
                Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aquamarine;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                flowLayoutPanel_M_ListRoom.Controls.Add(btn);
            }
        }

        //Hiển thị thông tin hóa đơn
        void ShowBill(string id)
        {
            listView_Main.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByRoom(id);
            //tinh tong tien
            float totalPrice = 0;
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(Convert.ToDouble(item.TotalPrice).ToString());
                totalPrice += item.TotalPrice;
                listView_Main.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");//sutup dinh dang tien
            Thread.CurrentThread.CurrentCulture = culture;
            textBox_Main_Pay.Text = totalPrice.ToString("c");
            loadRoom();
        }

        //Gọi chức năng hiển thị hóa đơn
        void btn_Click(object sender, EventArgs e)
        {
            string roomID = ((sender as Button).Tag as Room).ID;
            listView_Main.Tag = (sender as Button).Tag;
            ShowBill(roomID);
        }

        //Đưa ra danh sách vào combobox chuyển phòng
        void LoadComBRoom(ComboBox cb)
        {
            cb.DataSource = RoomDAO.Instance.LoadRoomList();
            cb.DisplayMember = "Id";
        }

        //Bật tính năng gọi dịch vụ
        private void OrderFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrderFood f = new FormOrderFood();
            f.Show();
        }

        //Bật tính năng đặt phòng
        private void OrderRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderRoom f = new OrderRoom();
            f.Show();
        }

        //Chức năng thanh toán tiền
        private void Button_Main_Pay_Click(object sender, EventArgs e)
        {
            Room room = listView_Main.Tag as Room;
            string idBill = BillDAO.Instance.getUnChBillID(room.ID);
            int discount = (int)numericUpDown_Main_Discount.Value;
            //tính tổng tiền
            double a1 = Convert.ToDouble(textBox_Main_Pay.Text.Split(',')[0].Replace(".",""));
            double sum = a1 - ((a1 * discount) / 100);
            if (idBill != null)
            {
                if (MessageBox.Show("Tổng tiền của bạn là: " + sum,"thong bao", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)sum);
                    RoomDAO.Instance.DeleteRoom(room.ID);
                    ShowBill(room.ID);
                    loadRoom();
                    //hien hoa don thanh toan
                    FormReportPayment.N8_1 = idBill;
                    FormReportPayment f1 = new FormReportPayment();
                    f1.Show();
                }
            }
        }

        //Chức năng chuyển phòng
        private void Button_Main_ChangeR_Click(object sender, EventArgs e)
        {
            string id1 = (listView_Main.Tag as Room).ID;
            string id2 = comboBox_Main_ChangeR.Text;
            int discount = (int)numericUpDown_Main_Discount.Value;
            string idBill = BillDAO.Instance.getUnChBillID(id2);
            if (idBill != null)
            {
                RoomDAO.Instance.SwRoom(id1, id2);
            }
            else
            {
               RoomDAO.Instance.SwRoom(id1, id2);
               BillDAO.Instance.CheckOut(id1, discount,0);
               RoomDAO.Instance.DeleteRoom(id1);
               RoomDAO.Instance.OrderRoom(id2);
            }
            ShowBill(id1); 
        }

        //Bật tính năng quản lí
        private void ManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin f = new FormAdmin();
            f.Show();
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Hello_Click(object sender, EventArgs e)
        {

        }
    }
}
