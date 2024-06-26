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

namespace QLKaraoke
{
    public partial class FormAdmin : Form
    {
        //Gọi các tính năng
        public FormAdmin()
        {
            InitializeComponent();
            showListBill(dateTimePicker1.Value, dateTimePicker2.Value);
            showListAccount();
            showListCategory();
            showListRoom();
            loadListCFood();
            showListFood();
            loadListCFood();
        }

        //Hiển thị danh sách hóa đơn
        void showListBill(DateTime daySet, DateTime dayGet)
        {
            dataGridView_AD_DT.DataSource = BillDAO.Instance.ShowListBill(daySet, dayGet);
        }

        //Cho phép xem danh sách hóa đơn trong khoảng thời gian
        private void Button_Ad_DT_Xem_Click(object sender, EventArgs e)
        {
            showListBill(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        //Hiển thị danh sách tài khoản
        void showListAccount()
        {
            dataGridView_AD_Staff_.DataSource = AccountDAO.Instance.showListAccount();
        }

        //Xem các tài khoản hiện có trong danh sách
        private void Button_AD_Staff_Xem_Click(object sender, EventArgs e)
        {
            showListAccount();
        }

        //Quản lí tạo thêm  tài khoản cho nhân viên (goi hàm thêm tài khoản)
        private void Button_AD_Staff_Add_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Add staff ?", "Connection String", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            else
            {
                AddStaff();
                showListAccount();
            }
        }

        //Thêm tài khoản
        private void AddStaff()
        {
            string userName = textBox_AD_Staff_UserName.Text;
            string displayName = textBox_AD_Staff_DName.Text;
            string pass = textBox_AD_Staff_Pass.Text;
            string type = textBox_AD_Staff_TypeAcc.Text;

            //check name 
            if (AccountDAO.Instance.getNameStaff(userName) == null)
            {
                AccountDAO.Instance.addAccount(displayName, userName, pass, type);
            }
            else
            {
                MessageBox.Show("Ten tài khoản đã tồn tại vui lòng chọn tên khác!!!");
            }    
        }

        //Cho phép sửa thông tin tài khoản đã chọn (gọi hàm sửa tài khoản)
        private void Button_AD_Staff_Sua_Click(object sender, EventArgs e)
        {
            if (dataGridView_AD_Staff_.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a staff first");
                return;
            }
            int index = dataGridView_AD_Staff_.SelectedCells[0].RowIndex;
            if (index < 0 || index >= dataGridView_AD_Staff_.RowCount)
            {
                MessageBox.Show("Please select a staff first");
                return;
            }
            DataGridViewRow row = dataGridView_AD_Staff_.Rows[index];
            string id = row.Cells[0].Value.ToString();
            String name = row.Cells[1].Value.ToString();
            DialogResult result = MessageBox.Show("Edit staff " + name + "?", "Connection String", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            else
            {
                EditStaff(id);
                showListAccount();
            }
        }

        //Sửa tài khoản
        private void EditStaff(string id)
        {
            string userName = textBox_AD_Staff_UserName.Text;
            string displayName = textBox_AD_Staff_DName.Text;
            string pass = textBox_AD_Staff_Pass.Text;
            string type = textBox_AD_Staff_TypeAcc.Text;
            AccountDAO.Instance.editAccount(id, displayName, userName, pass, type);
        }

        //Cho phép quản lí chọn vào thông tin trên grid sau đó hiển thị thông tin đó trên textbox
        private void DataGridView_AD_Staff__CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridView_AD_Staff_.RowCount)
            {
                return;
            }
            DataGridViewRow row = dataGridView_AD_Staff_.Rows[index];
            // update UI
            textBox_AD_Staff_DName.Text = Convert.ToString(row.Cells[1].Value);
            textBox_AD_Staff_UserName.Text = Convert.ToString(row.Cells[2].Value);
            textBox_AD_Staff_Pass.Text = Convert.ToString(row.Cells[4].Value);
            textBox_AD_Staff_TypeAcc.Text = Convert.ToString(row.Cells[3].Value);
        }

        //Xóa tài khoản đã chọn (gọi hàm xóa tài khoản)
        private void Button_AD_Staff_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView_AD_Staff_.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a staff first");
                return;
            }
            int index = dataGridView_AD_Staff_.SelectedCells[0].RowIndex;
            if (index < 0 || index >= dataGridView_AD_Staff_.RowCount)
            {
                MessageBox.Show("Please select a staff first");
                return;
            }
            DataGridViewRow row = dataGridView_AD_Staff_.Rows[index];
            string id = row.Cells[0].Value.ToString();
            String name = row.Cells[1].Value.ToString();
            DialogResult result = MessageBox.Show("remove staff " + name + "?", "Connection String", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            else
            {
                try
                {
                    DeleteAccount(id);
                    showListAccount();
                }
                catch {
                    MessageBox.Show("Nhân viên này hiện tại đang liên quan đến một số chức năng trong hện thống nên ko thể xóa!");
                }
            }
        }

        //Xóa tài khoản
        void DeleteAccount(string id)
        {
            AccountDAO.Instance.deleteAccount(id);
        }

        //Chức năng thêm loại dịch vụ (gọi hàm thêm loại dịch vụ)
        private void Button_AD_Cate_Add_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Add FoodCategory ?", "Connection String", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            else
            {
                AddCategory();
                showListCategory();
            }
        }

        //Thêm loại dịch vụ
        void AddCategory()
        {
            string cName = textBox_AD_Cate_Name.Text;
            CategoryDAO.Instance.addFoodCategory(cName);
        }

        //Hiển thị danh sách loại dịch vụ đang có
        void showListCategory()
        {
            dataGridView_AD_Cate.DataSource = CategoryDAO.Instance.showListCategory();
        }

        //Xem danh sách loại dịch vụ
        private void Button_AD_Cate_Xem_Click(object sender, EventArgs e)
        {
            showListCategory();
        }

        //Sửa loại dịch vụ đã chọn (gọi hàm sửa loại dịch vụ)
        private void Button_AD_Cate_Sua_Click(object sender, EventArgs e)
        {
            if (dataGridView_AD_Cate.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a category first");
                return;
            }
            int index = dataGridView_AD_Cate.SelectedCells[0].RowIndex;
            if (index < 0 || index >= dataGridView_AD_Cate.RowCount)
            {
                MessageBox.Show("Please select a category first");
                return;
            }
            DataGridViewRow row = dataGridView_AD_Cate.Rows[index];
            string id = row.Cells[0].Value.ToString();            
            String name = row.Cells[1].Value.ToString();
            DialogResult result = MessageBox.Show("Edit category " + name + "?", "Connection String", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            else
            {
                EditCategory(id);
                showListCategory();
            }
        }

        //Sửa loại dịch vụ
        public void EditCategory(string id)
        {
            string name = textBox_AD_Cate_Name.Text;
            CategoryDAO.Instance.editFoodCategory(id, name);
        }

        //Cho phép chọn loại dịch vụ có trong grid
        private void DataGridView_AD_Cate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridView_AD_Cate.RowCount)
            {
                return;
            }
            DataGridViewRow row = dataGridView_AD_Cate.Rows[index];
            textBox_AD_Cate_Id.Text = Convert.ToString(row.Cells[0].Value);
            textBox_AD_Cate_Name.Text = Convert.ToString(row.Cells[1].Value);
        }

        //Xóa loại dịch vụ đã chọn (gọi hàm xóa loại dịch vụ)
        private void Button_AD_Cate_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView_AD_Cate.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a category first");
                return;
            }
            int index = dataGridView_AD_Cate.SelectedCells[0].RowIndex;
            if (index < 0 || index >= dataGridView_AD_Cate.RowCount)
            {
                MessageBox.Show("Please select a category first");
                return;
            }
            DataGridViewRow row = dataGridView_AD_Cate.Rows[index];
            string id = row.Cells[0].Value.ToString();
            String name = row.Cells[1].Value.ToString();
            DialogResult result = MessageBox.Show("Remove category " + name + "?", "Connection String", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            else
            {
                try
                {
                    DeleteCategory(id);
                    showListCategory();
                }
                catch
                {
                    MessageBox.Show("FoodCategory này hiện tại đang liên quan đến một số chức năng trong hện thống nên ko thể xóa!");
                }
            }
        }

        //Xóa loại dịch vụ
        void DeleteCategory(string id)
        {
            CategoryDAO.Instance.deleteCategory(id);
        }

        //Hiển thi danh sách phòng cùng trạng thái
        void showListRoom()
        {
            dataGridView_AD_R.DataSource = RoomDAO.Instance.showListRoom();
        }

        //Xem danh sách phòng
        private void Button_AD_R_Xem_Click(object sender, EventArgs e)
        {
            showListRoom();
        }

        //Chức năng thêm phòng(trường hợp phần mềm mới tạo) gọi hàm thêm phòng
        private void Button_AD_R_Add_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Add Room ?", "Connection String", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            else
            {
                AddRoom();
                showListRoom();
            }
        }

        //Thêm phòng
        void AddRoom()
        {
            string cName = textBox_AD_R_Name.Text;
            string status = textBox_AD_R_Status.Text;
            DateTime day1 = DateTime.Today;
            DateTime day2 = DateTime.Today;
            RoomDAO.Instance.addRoom(cName, day1, day2, status);
        }

        //Xem danh sách dịch vụ (cụ thể là thức ăn)
        private void Button_Ad_F_Xem_Click(object sender, EventArgs e)
        {
            showListFood();
            loadListCFood();
        }

        //Xem danh sách dịch vụ
        void showListFood()
        {
            dataGridView_AD_F.DataSource = FoodDAO.Instance.showListFood();
        }

        //Chức năng xóa phòng (trường hợp thêm sai) đã chọn (gọi hàm xóa phòng)
        private void Button_AD_R_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView_AD_R.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a room first");
                return;
            }
            int index = dataGridView_AD_R.SelectedCells[0].RowIndex;
            if (index < 0 || index >= dataGridView_AD_R.RowCount)
            {
                MessageBox.Show("Please select a room first");
                return;
            }
            DataGridViewRow row = dataGridView_AD_R.Rows[index];
            string id = row.Cells[0].Value.ToString();
            String name = row.Cells[1].Value.ToString();
            DialogResult result = MessageBox.Show("Remove room " + name + "?", "Connection String", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            else
            {
                try
                {
                    DeleteRoom(id);
                    showListRoom();
                }
                catch
                {
                    MessageBox.Show("Room này hiện tại đang liên quan đến một số chức năng trong hện thống nên ko thể xóa!");
                }
            }
        }

        //Xóa phòng
        void DeleteRoom(string id)
        {
            RoomDAO.Instance.deleteRoom(id);
        }

        //Cho phép chọn phòng trong grid
        private void DataGridView_AD_R_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridView_AD_R.RowCount)
            {
                return;
            }
            DataGridViewRow row = dataGridView_AD_R.Rows[index];
            textBox_AD_R_Id.Text = Convert.ToString(row.Cells[0].Value);
            textBox_AD_R_Name.Text = Convert.ToString(row.Cells[1].Value);
            textBox_AD_R_Status.Text = Convert.ToString(row.Cells[2].Value);
        }

        //Hiển thị danh sách dịch vụ theo loại dịch vụ đã chọn
        void loadListCFood()
        {
            comboBox_AD_F_CFood.DataSource = CategoryDAO.Instance.LoadListCategory();
            comboBox_AD_F_CFood.DisplayMember = "Name";
        }

        //Chức năng thêm dịch vụ (gọi hàm thêm dịch vụ)
        private void Button_Ad_F_Thêm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Add Food ?", "Connection String", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            else
            {
                AddFood();
                showListFood();
            }
        }

        //Thêm dịch vụ
        void AddFood()
        {
            string fName = textBox_AD_F_NameF.Text;
            string idCF = FoodDAO.Instance.getIdbyName(comboBox_AD_F_CFood.Text);
            float price = (float)Convert.ToDouble(textBox_AD_F_Price.Text.ToString());
            FoodDAO.Instance.addFood(fName, idCF, price);
        }

        //Cho phép chọn dịch vụ 
        private void DataGridView_AD_F_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridView_AD_F.RowCount)
            {
                return;
            }
            DataGridViewRow row = dataGridView_AD_F.Rows[index];
            textBox_AD_F_ID.Text = Convert.ToString(row.Cells[0].Value);
            textBox_AD_F_NameF.Text = Convert.ToString(row.Cells[1].Value);
            comboBox_AD_F_CFood.Text = Convert.ToString(row.Cells[2].Value);
            textBox_AD_F_Price.Text = Convert.ToString(row.Cells[3].Value);
        }

        //Cho phép sửa dịch vụ đã chọn (gọi hàm sửa)
        private void Button_AD_F_Sua_Click(object sender, EventArgs e)
        {
            if (dataGridView_AD_F.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a food first");
                return;
            }
            int index = dataGridView_AD_F.SelectedCells[0].RowIndex;
            if (index < 0 || index >= dataGridView_AD_F.RowCount)
            {
                MessageBox.Show("Please select a food first");
                return;
            }
            DataGridViewRow row = dataGridView_AD_F.Rows[index];
            string id = row.Cells[0].Value.ToString();
            String name = row.Cells[1].Value.ToString();
            DialogResult result = MessageBox.Show("Edit food " + name + "?", "Connection String", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            else
            {
                EditFood(id);
                showListFood();
            }
        }

        //Sửa dịch vụ
        public void EditFood(string id)
        {
            string fName = textBox_AD_F_NameF.Text;
            string idCF = FoodDAO.Instance.getIdbyName(comboBox_AD_F_CFood.Text);
            float price = (float)Convert.ToDouble(textBox_AD_F_Price.Text.ToString());
            FoodDAO.Instance.editFood(id, fName, idCF, price);
        }

        //Chức năng xóa dịch vụ đã chọn (gọi hàm xóa dịch vụ)
        private void Button_AD_F_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView_AD_F.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a food first");
                return;
            }
            int index = dataGridView_AD_F.SelectedCells[0].RowIndex;
            if (index < 0 || index >= dataGridView_AD_F.RowCount)
            {
                MessageBox.Show("Please select a food first");
                return;
            }
            DataGridViewRow row = dataGridView_AD_F.Rows[index];
            string id = row.Cells[0].Value.ToString();
            String name = row.Cells[1].Value.ToString();
            DialogResult result = MessageBox.Show("Remove food " + name + "?", "Connection String", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            else
            {
                try
                {
                    DeleteFood(id);
                    showListFood();
                }
                catch
                {
                    MessageBox.Show("Food này hiện tại đang liên quan đến một số chức năng trong hện thống nên ko thể xóa!");
                }
            }
        }

        //Xóa dịch vụ
        void DeleteFood(string id)
        {
            FoodDAO.Instance.deleteFood(id);
        }

        //Tìm kiếm dịch vụ trong hàm danh sách dịch vụ có sẵn (gọi hàm tìm kiếm dịch vụ)
        private void Button_AD_F_Search_Click(object sender, EventArgs e)
        {
            dataGridView_AD_F.DataSource = SearchFood(textBox_AD_F_SearchNFood.Text);
        }

        //Tìm kiếm dịch vụ
        List<Food> SearchFood(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFood(name);
            return listFood;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormReportBill f = new FormReportBill();
            f.Show();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
