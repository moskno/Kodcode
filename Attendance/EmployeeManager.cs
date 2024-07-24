using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance
{
    internal class EmployeeManager
    {
        private static string _loginSQL = "declare @code int, @answer VARCHAR(250), @fullname VARCHAR(20)='';\r\nIF exists (SELECT * FROM Employees where IdNumber = @id)\r\n\tbegin\r\n\t\tSELECT @code = (SELECT code FROM Employees where IdNumber = @id)\r\n\tend\r\n\r\nelse\r\n\tbegin\r\n\t\tinsert into Employees  (FullName, IdNumber) values (@FullName, @id);\r\n\t\tselect @code = @@IDENTITY;\r\n\tend\r\n\r\n\r\nIF exists (select * from Passwords WHERE EmployeeCode = @code)\r\n\tbegin\r\n\t\tif exists (select pass From Passwords\r\n\t\tWHERE EmployeeCode = @code AND pass = @password AND HAS_ACCESS = 1)\r\n\t\t\tbegin\r\n\t\t\t\tif exists (select pass From Passwords\r\n\t\t\t\tWHERE EmployeeCode = @code AND pass = @password AND HAS_ACCESS = 1 AND ExpiryDate>=GETDATE())\r\n\t\t\t\t\tbegin\r\n\t\t\t\t\t\tIF exists (SELECT * FROM Attendances\r\n\t\t\t\t\t\tWHERE EmployeeCode = @code AND ExitTime is null)\r\n\t\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\t\tUPDATE Attendances set ExitTime = GETDATE()\r\n\t\t\t\t\t\t\t\tWHERE EmployeeCode = @code AND ExitTime is null;\r\n\t\t\t\t\t\t\t\tselect @answer = 'exit time' + convert (nvarchar, GETDATE(),121);\r\n\t\t\t\t\t\t\tend\r\n\t\t\t\t\t\telse\r\n\t\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\t\tinsert into Attendances VALUES (@code, GETDATE(), GETDATE(), null);\r\n\t\t\t\t\t\t\t\tselect @answer = 'entry time' + convert (nvarchar, GETDATE(),121);\r\n\t\t\t\t\t\t\tend\r\n\t\t\t\t\t\t-- כניסה \\ יציאה\r\n\t\t\t\t\tend\r\n\t\t\t\telse\r\n\t\t\t\t\tbegin\r\n\t\t\t\t\t\tselect @answer = 'you need to update your password';\r\n\t\t\t\t\t\t-- עדכון סיסמא\r\n\t\t\t\t\tend\r\n\t\t\tend\r\n\t\telse\r\n\t\t\tbegin\r\n\t\t\t\tselect @answer = 'wrong password';\r\n\t\t\t\t-- סיסמה שגויה\r\n\t\t\tend\r\n\tend\r\n\t\r\n\telse\r\n\t\tbegin\r\n\t\t\tinsert into Passwords values (@code, @password,DATEADD(day, 180,  GETDATE()), 1)\r\n\t\t\tselect @answer = 'you need to create a new password'\r\n\t\tend select @answer";
        private static string _changePasswordSQL = "declare @return_answer varchar (250) = '';\r\n\r\n\r\n\r\n-- חיבור ת\"ז לסיסמה\r\nif exists (\r\n\tselect Pass from Passwords\r\n\tjoin Employees on Employees.Code = Passwords.EmployeeCode\r\n\twhere Employees.IdNumber=@id_number\r\n\tand Passwords.Pass = @password\r\n\tand Passwords.HAS_ACCESS = 1)\r\n\t\tbegin\r\n\t\t\tif exists (\r\n\t\t\t\tselect Pass from Passwords\r\n\t\t\t\tjoin Employees on Employees.Code = Passwords.EmployeeCode\r\n\t\t\t\twhere Employees.IdNumber=@id_number \r\n\t\t\t\tand Passwords.Pass = @password \r\n\t\t\t\tand Passwords.HAS_ACCESS = 1 \r\n\t\t\t\tand @new_pass != @password)\r\n\t\t\t\t\tbegin\r\n\t\t\t\t\t\tif exists (\r\n\t\t\t\t\t\t\tselect Pass from Passwords\r\n\t\t\t\t\t\t\tjoin Employees on Employees.Code = Passwords.EmployeeCode\r\n\t\t\t\t\t\t\twhere Employees.IdNumber=@id_number \r\n\t\t\t\t\t\t\tand Passwords.Pass = @password \r\n\t\t\t\t\t\t\tand Passwords.HAS_ACCESS = 1 \r\n\t\t\t\t\t\t\tand @new_pass = @valid_new_pass)\r\n\t\t\t\t\t\t\t\tbegin \r\n\t\t\t\t\t\t\t\t\tupdate Passwords\r\n\t\t\t\t\t\t\t\t\tset HAS_ACCESS = 0\r\n\t\t\t\t\t\t\t\t\tfrom Passwords\r\n\t\t\t\t\t\t\t\t\tjoin Employees on Employees.Code = Passwords.EmployeeCode\r\n\t\t\t\t\t\t\t\t\twhere Employees.IdNumber=@id_number\r\n\t\t\t\t\t\t\t\t\tand Passwords.Pass = @password\r\n\r\n\t\t\t\t\t\t\t\t\tinsert into Passwords values\r\n\t\t\t\t\t\t\t\t\t((select Employees.Code from Employees\r\n\t\t\t\t\t\t\t\t\twhere Employees.IdNumber = @id_number), @new_pass ,DATEADD(day, 180, GETDATE()), 1)\r\n\t\t\t\t\t\t\t\t\tselect @return_answer = 'Your Password has been succsessfully updated';\r\n\t\t\t\t\t\t\t\tend\r\n\t\t\t\t\t\telse\r\n\t\t\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\t\t\tselect @return_answer = 'The Valid Password is incorrect, Try again';\r\n\t\t\t\t\t\t\t\tend\r\n\t\t\t\t\tend\r\n\t\t\telse\r\n\t\t\t\t\tbegin \r\n\t\t\t\t\t\tselect @return_answer = 'The password has already been used, Try a different password';\r\n\t\t\t\t\tend\r\n\t\tend\r\nelse\r\n\tbegin \r\n\t\tselect @return_answer = 'One of the data you entered is incorrect, Please try again';\r\n\tend\r\n\r\nselect @return_answer\r\n";
        public void doX()
        {
        }
        public static string Login(string password, string id)
        {
            // 1. Use the _loginSQL
            // 2. Execute SQL against DB
            string[] parameters = { "@id", "@password" };
            string[] values = { id, password };
            string runresult = DBConnection.runSQL(_loginSQL, parameters, values);
            // 3. Return response
            return runresult;
        }
        public static string ChangePassword(string id, string oldPass, string newPass, string confirmPass)
        {
            // 1. Use the _loginSQL
            // 2. Execute SQL against DB
            string[] parameters = { "@id_number", "@password", "@new_pass", "@valid_new_pass"};
            string[] values = { id, oldPass, newPass, confirmPass};
            string runresult = DBConnection.runSQL(_changePasswordSQL, parameters, values);
            // 3. Return response
            return runresult;
        }
    }
}
