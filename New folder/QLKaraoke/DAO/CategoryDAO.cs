using QLKaraoke.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKaraoke.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        //Hàm get set loại dịch vụ
        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        
        private CategoryDAO() { }

        //Hàm tải lại danh sách loại dịch vụ
        public List<Category> LoadListCategory()
        {
            List<Category> catagoryList = new List<Category>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from FoodCategory");
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                catagoryList.Add(category);
            }
            return catagoryList;
        }

        //Hàm hiển thị loại dịch vụ
        public DataTable showListCategory()
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_getListCategory");
        }

        //Hàm thêm loại dịch vụ
        public void addFoodCategory(string name)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_insertCFood @name ", new object[] { name });
        }

        //Hàm sửa loại dịch vụ
        public void editFoodCategory(string id, string name)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_editCFood @id , @name", new object[] { id, name });
        }

        //Hàm xóa loại dịch vụ
        public void deleteCategory(string id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_deleteCategory @id", new object[] { id });
        }
    }
}

