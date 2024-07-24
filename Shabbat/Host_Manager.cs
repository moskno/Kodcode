using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shabbat
{
    internal class Host_Manager
    {
        public static List<string> GetCategorie()
        {
            string sqlQuery = "select Name from categories";
            List<string> Categories = new List<string>();
            SqlDataReader reader = DBConnection.runSQLAllResult(sqlQuery);

            for (int i = 0; reader.Read(); i++)
            {
                Categories.Add(reader.GetString(0));
            }
            reader.Close();
            return Categories;
        }

        public static List<string> GetCtgrByString(string filter)
        {
            string sqlQuery = "select Name from categories where Name like '%'+@filter_guest+'%';\r\n";
            string[] parameters = {"@filter_guest"};
            string[] values = {filter};
            List<string> Categories = new List<string>();
            SqlDataReader reader = DBConnection.runSQLAllResult(sqlQuery, parameters, values);

            for (int i = 0; reader.Read(); i++)
            {
                Categories.Add(reader.GetString(0));
            }
            reader.Close();
            return Categories;
        }

        public static DataTable GetFoodByCtgr(string categoryName)
        {
            string sqlQuery = "select MenuConnects.Name as name, count(MenuConnects.Name) as calculation\r\nfrom MenuConnects\r\njoin Categories on Categories.CategoryId = MenuConnects.CategoryId\r\nwhere Categories.name = @category_specific\r\ngroup by MenuConnects.Name";
            string[] parameters = { "@category_specific" };
            string[] values = { categoryName };
            return DBConnection.runSQLTableResult(sqlQuery, parameters, values);
        }

        public static void AddCtgr(string categorie) 
        {
            string sqlQuery = "if not exists (select Name from Categories where Name  = @new_category)\r\n\tbegin \r\n\t\tinsert into Categories values (@new_category)\r\n\tend";
            string[] parameters = { "@new_category" };
            string[] values = { categorie };
            DBConnection.runSQLNoAnswer(sqlQuery, parameters, values);
        }




    }
}
