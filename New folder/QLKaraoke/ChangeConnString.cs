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
    public partial class ChangeConnString : Form
    {
        public ChangeConnString()
        {
            InitializeComponent();
        }

        //Chức năng khi đăng nhập cần cài đặt tên database và tên server
        private void Button_ChangeConnString_Click(object sender, EventArgs e)
        {
            string svName = textBox_ChangeConnS_SVName.Text;
            string dbName = textBox_ChangeConnS_DBName.Text;
            DataProvider.Instance.SetConnectString(svName, dbName);
            this.Hide();      
        }

        private void ChangeConnString_Load(object sender, EventArgs e)
        {

        }
    }
}
