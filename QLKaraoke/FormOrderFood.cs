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
    public partial class FormOrderFood : Form
    {
        public FormOrderFood()
        {
            InitializeComponent();
            LoadOrderFood_RoomID();
            LoadOrderFood_Category();
        }

        //Hiển thị danh sách phòng theo id
        void LoadOrderFood_RoomID()
        {   
            List<Room> listRoom = RoomDAO.Instance.LoadRoomListOrder();
            comboBox_OrdFood_Room.DataSource = listRoom;
            comboBox_OrdFood_Room.DisplayMember = "Id";
        }

        //Hiển thị danh sách loại dịch vụ
        void LoadOrderFood_Category()
        {
            List<Category> listCategory = CategoryDAO.Instance.LoadListCategory();
            comboBox_OrdFood_Category.DataSource = listCategory;
            comboBox_OrdFood_Category.DisplayMember = "Name";
        }

        //Hiển thị danh sách dịch vụ có trong loại dịch vụ đã chọn
        void LoadOrderFood_FoodByCategory(string id)
        {
            List<Food> listFood = FoodDAO.Instance.LoadListFood(id);  
            comboBox_OrdFood_FoodName.DataSource = listFood;
            comboBox_OrdFood_FoodName.DisplayMember = "Name";
       
        }

        //Hiển thị hóa đơn thanh toán dịch vụ       
        void ShowBillOrderFood(string id)
        {
            listView_OrdFood.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByRoom(id);
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(Convert.ToDouble(item.TotalPrice).ToString());
                listView_OrdFood.Items.Add(lsvItem);
            }
        }

        //Lấy loại dịch vụ đã chọn để hiển thi dịch vụ
        private void ComboBox_OrdFood_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox r = sender as ComboBox;
            Category selected = r.SelectedItem as Category;
            string id = selected.ID;
            comboBox_OrdFood_FoodName.Text = "";//clear comboBox
            LoadOrderFood_FoodByCategory(id);

            //truong hop category khong co mon an hoac ko co phong nao duoc chon
            if (comboBox_OrdFood_FoodName.Text == "" || comboBox_OrdFood_Room.Text == "")
            {
                button_OrdFood_AddFood.Enabled = false;
            }
            else 
            {
                button_OrdFood_AddFood.Enabled = true;
            }
        }

        //Thêm dịch vụ với phòng đã đặt
        private void Button_OrdFood_AddFood_Click(object sender, EventArgs e)
        {
            string id = comboBox_OrdFood_Room.Text; 
            string foodId = (comboBox_OrdFood_FoodName.SelectedItem as Food).ID;
            int count = (int)numericUpDown1.Value;
            string idBill = BillDAO.Instance.getUnChBillID(id);
            if (idBill == null)
            {
                //truong hop bill chua ton tai
                BillDAO.Instance.InsertBill(id);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodId, count);
            }
            else
            {
                //truong hop bill da ton tai

                if (FoodDAO.Instance.getFoddByIdBill(idBill, foodId) == null && count<1)
                {
                    MessageBox.Show("Món ăn hiện tại chưa tồn tại trong Bill nên không thể xóa!! Vui lòng chọn số lượng lớn hơn 0");
                }
                else 
                {
                    BillInfoDAO.Instance.InsertBillInfo(idBill, foodId, count);
                }
                //BillInfoDAO.Instance.InsertBillInfo(idBill, foodId, count);
            }
            ShowBillOrderFood(id);
        }

        //Chọn danh sách phòng để gọi dịch vụ
        private void ComboBox_OrdFood_Room_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox r = sender as ComboBox;
            Room selected = r.SelectedItem as Room;
            string id = selected.ID;
            ShowBillOrderFood(id);
        }

        private void FormOrderFood_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
