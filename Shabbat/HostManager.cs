using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shabbat
{
    internal class ShabbatManager
    {
        private static string _ShabbatSQL = "-- Enter Category Query\r\ndeclare @new_category varchar (100);\r\n\r\nif not exists (select Name from Categories where Name  = @new_category)\r\n\tbegin \r\n\t\tinsert into Categories values (@new_category)\r\n\tend\r\n\r\n-- Get CategoryList Query by string\r\ndeclare @filter_category varchar (100);\r\n\r\nselect Name from categories where Name like '%'+@filter_category+'%';\r\n\r\n\r\n-- Add Guests\r\ndeclare @new_guests varchar (100);\r\n\r\nif not exists (select Name from Guests where Name  = @new_guests)\r\n\tbegin \r\n\t\tinsert into Guests values (@new_guests)\r\n\tend\r\n\r\n-- Get GuestsList Query by string\r\ndeclare @filter_guest varchar (100);\r\n\r\nselect Name from categories where Name like '%'+@filter_guest+'%';\r\n\r\n\r\n-- Add Food\r\ndeclare @new_food varchar (100), @category_name varchar (100), @guest_name varchar (100);\r\ndeclare @category_code int, @guest_code int;\r\n\r\nselect @category_code = (select CategoryId from Categories where name = @category_name);\r\nselect @guest_code = (select GuestId from Guests where name = @guest_name);\r\n\r\nif (@category_code is not null and @guest_code is not null)\r\n\tbegin\r\n\t\tinsert into MenuConnects values (@new_food, @category_code, @guest_code)\r\n\tend\r\n\r\n-- get Foods by category + count\r\ndeclare @category_specific varchar (100);\r\n\r\nselect MenuConnects.Name as name, count(MenuConnects.Name) as calculation\r\nfrom MenuConnects\r\njoin Categories on Categories.CategoryId = MenuConnects.CategoryId\r\nwhere @category_specific = Categories.name\r\ngroup by MenuConnects.Name\r\n\r\n-- get summary by guest choose\r\ndeclare @category_specific1 varchar (100);\r\ndeclare @user_name varchar (100);\r\n\r\nselect MenuConnects.Name as name, count(MenuConnects.Name) as calculation\r\nfrom MenuConnects\r\njoin Categories on Categories.CategoryId = MenuConnects.CategoryId\r\njoin Guests on Guests.GuestId = MenuConnects.GuestsId\r\nwhere @category_specific1 = Categories.name and @user_name = Guests.Name\r\ngroup by MenuConnects.Name\r\n\r\n-- get summary without guest choose\r\ndeclare @category_specific2 varchar (100);\r\ndeclare @user_name1 varchar (100);\r\n\r\nselect MenuConnects.Name as name, count(MenuConnects.Name) as calculation\r\nfrom MenuConnects\r\njoin Categories on Categories.CategoryId = MenuConnects.CategoryId\r\njoin Guests on Guests.GuestId = MenuConnects.GuestsId\r\nwhere @category_specific2 = Categories.name and @user_name1 != Guests.Name\r\ngroup by MenuConnects.Name";
      
        public void doX()
        {
        }
        public static string Login(string new_category, string filter_category)
        {
            // 1. Use the _ShabbatSQL
            // 2. Execute SQL against DB
            string[] parameters = { "@new_category", "@filter_category" };
            string[] values = { new_category, filter_category };
            string result = DBConnection.runSQL(_ShabbatSQL, parameters, values);
            // 3. Return response
            return result;
        }
    }
}

