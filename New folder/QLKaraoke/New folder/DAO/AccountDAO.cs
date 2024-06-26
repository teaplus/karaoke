using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKaraoke.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        //Hàm get set account
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        //Gọi proc trong database để đăng nhập
        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }

        //Hiển thị danh sách tài khoản
        public DataTable showListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_showListAccount");
        }

        //Thêm tài khoản
        public void addAccount(string uName, string dName, string pass, string type)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_insertAccount @dpName , @userName , @pass , @type", new object[] { dName, uName, pass, type });
        }

        //Sửa thông tin tài khoản 
        public void editAccount(string id, string uName, string dName, string pass, string type)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_editAccount @id , @dpName , @userName , @pass , @type", new object[] { id, dName, uName, pass, type });
        }

        //Xóa tài khoản
        public void deleteAccount(string id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_deleteAccount @id", new object[] { id });
        }

        //Kiem tra xem da co ten trong db hay chua
        public string getNameStaff(String name)
        {
            try
            {
                return DataProvider.Instance.ExecuteScalar("exec USP_getNameStaff @name", new object[] { name }).ToString();
            }
            catch
            {
                return null;
            }
        }
    }
}
