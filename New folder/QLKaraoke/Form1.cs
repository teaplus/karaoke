using QLKaraoke.DAO;
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
    public partial class Form1 : Form
    {

        //public static string name = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        //Thoát ứng dụng khi nhấn nút exit
        private void Button_Login_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        //Hỏi người dùng có muốn thật sự thoát hay không
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn thoát ứng dụng?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        //Sự kiện đăng nhập khi nhấn nút đăng nhập
        private void Button_Login_DN_Click(object sender, EventArgs e)
        {
            string name = textBox_Login_Name.Text;    
            string passWord = textBox_Login_PassW.Text;
            if (Login(name, passWord))
            {
                formMain.N8 = name;

                formMain f = new formMain();
                this.Hide();//an form1
                f.ShowDialog();//hien thi formMain
                this.Show();//hien thi form1 khi nao thao tac xong formMain
            }
            else
            {
                MessageBox.Show("Sai name hoặc password");
            }
        }

        //Đăng nhập
        bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        //Sự kiện khi nhấn nút changeconnstring kích hoạt
        private void Button_Login_ChangeConnString_Click(object sender, EventArgs e)
        {
            ChangeConnString f = new ChangeConnString();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
