using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shabbat
{
    internal class Guest_Manager
    {
        public static List<string> GetGuests()
        {
            string sqlQuery = "select Name from guests";
            List<string> Guests = new List<string>();
            SqlDataReader reader = DBConnection.runSQLAllResult(sqlQuery);

            for (int i = 0; reader.Read(); i++)
            {
                Guests.Add(reader.GetString(0));
            }
            reader.Close();
            return Guests;
        }

        public static void AddGst(string guest)
        {
            string sqlQuery = "if not exists (select Name from Guests where Name  = @new_guests)\r\n\tbegin \r\n\t\tinsert into Guests values (@new_guests)\r\n\tend";
            string[] parameters = { "@new_guests" };
            string[] values = { guest };
            DBConnection.runSQLNoAnswer(sqlQuery, parameters, values);

        }
    }
}
