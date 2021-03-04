using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteCreditSuisse.Interface;
using TesteCreditSuisse.Model;
using System.Data;
using System.Data.SqlClient;

namespace TesteCreditSuisse.Business
{
    public class CategoryBusiness : ICategory
    {
        SqlConnection conn = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=CreditSuisse;Trusted_Connection=True;MultipleActiveResultSets=true");

        public bool AddCategory(Category category)
        {
            SqlCommand com = new SqlCommand("SP_AddCategory", conn);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@Value", category.Value) ;
            com.Parameters.AddWithValue("@Risk", category.Risk);
            com.Parameters.AddWithValue("@ClientSector", category.ClientSector);
            com.Parameters.AddWithValue("@Active", 1);
            com.Parameters.AddWithValue("@ValueGreaterThan", category.ValueGreaterThan);

            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            return true;
        }

        public List<Category> ListCategory()
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("SP_AllCategories", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(dt);

            }
            catch (Exception x)
            {

            }
            
            List<Category> Listcategories = new List<Category>();
            Category category = new Category();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                category.ClientSector = dt.Rows[i]["ClientSector"].ToString();
                category.Value = Convert.ToDouble (dt.Rows[i]["Value"]);
                int ValueGreaterThan = Convert.ToInt32( dt.Rows[i]["ValueGreaterThan"]);
                if (ValueGreaterThan == 0)
                {
                    category.ValueGreaterThan = false;
                }
                else
                {
                    category.ValueGreaterThan = true;
                }
                category.Risk = dt.Rows[i]["Risk"].ToString();
                int active = Convert.ToInt32(dt.Rows[i]["Active"]);
                if (active == 1)
                {
                    category.Active = true;
                }
                else
                {
                    category.Active = false;
                }
                category.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                Listcategories.Add(category);
                category = new Category();
            }

            return Listcategories;
            
        }

        public void RemoveCategory(int ID)
        {
            SqlCommand com = new SqlCommand("SP_DeleteCategory", conn);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@Id", ID);

            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }

        public bool UpdateCategory(Category category)
        {
            SqlCommand com = new SqlCommand("SP_UpdateCategory", conn);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@Value", category.Value);
            com.Parameters.AddWithValue("@Risk", category.Risk);
            com.Parameters.AddWithValue("@ClientSector", category.ClientSector);
            com.Parameters.AddWithValue("@Active", category.Active);
            com.Parameters.AddWithValue("@ValueGreaterThan", category.ValueGreaterThan);
            com.Parameters.AddWithValue("@Id", category.Id);

            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            return true;
        }
    }
}
