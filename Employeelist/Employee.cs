using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeelist
{
    public class Employee
    {
        public int Code { get; set; }

        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }

        public DateTime BirthDay { get; set; }

        public int Age { get { return DateTime.Now.Year - BirthDay.Year; } }

        public bool IsMale { get; set; }

        public string Status { get; set; }

        public string PhoneNumber;

        public string CellPhone;

        public string Street;

        public int HouseNumber;

        public string City;

        public string HomeAdress { get { return City + " " + Street + " " + HouseNumber; } }

        //בנאי
        public Employee(int code, string iD, string firstName, string lastName, DateTime birthDay, bool isMale, string status, string phone, string cellPhone, string city, string street, int home)
        {
            this.Code = code;
            this.Id = iD;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDay = birthDay;
            this.IsMale = isMale;
            this.Status = status;
            this.PhoneNumber = phone;
            this.CellPhone = cellPhone;
            this.Street = street;
            this.HouseNumber = home;
            this.City = city;
        
        }

       
    }
}
