using QLKaraoke.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKaraoke.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        //Hàm get set dịch vụ
        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }

        //Hàm tải lại danh sách dịch vụ
        public List<Food> LoadListFood(string id)
        {
            List<Food> foodList = new List<Food>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_getListFoodByCategory @idCF ", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Food category = new Food(item);
                foodList.Add(category);
            }
            return foodList;
        }

        //Hàm hiển thị danh sách dịch vụ
        public DataTable showListFood()
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_showListFood");
        }

        //Hàm lấy id theo tên dịch vụ
        public string getIdbyName(string name)
        {
            try
            {
                return DataProvider.Instance.ExecuteScalar("exec getIdbyName @name ", new object[] { name}).ToString();
            }
            catch
            {
                return null;
            }
        }

        //Hàm thêm dịch vụ
        public void addFood(string name, string cf, float price)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_insertFood @name , @idCF , @price", new object[] { name, cf, price });
        }

        //Hàm sửa dịch vụ
        public void editFood(string id, string name, string idCF, float price)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_editFood @id , @name , @idCF , @price ", new object[] { id, name, idCF, price });
        }

        //Hàm xóa dịch vụ
        public void deleteFood(string id)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_deleteFood @id ", new object[] { id });
        }

        //Hàm tìm kiếm dịch vụ
        public List<Food> SearchFood(string name)
        {
            List<Food> foodList = new List<Food>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_searchFood @name ", new object[] { name });
            foreach (DataRow item in data.Rows)
            {
                Food category = new Food(item);
                foodList.Add(category);
            }
            return foodList;
        }

        //lay id trong db ra bang id Bill
        public String getFoddByIdBill(string idB, string idF)
        {
            
            try
            {
                return DataProvider.Instance.ExecuteScalar("exec USP_getFoddByIdBill @idB , @idF", new object[] { idB, idF }).ToString();
            }
            catch
            {
                return null;
            }
            //data = DataProvider.Instance.ExecuteScalar("exec USP_USP_getFoddByIdBill @idB , @idF", new object[] { idB, idF}).ToString();
            
        }
    } 
}
