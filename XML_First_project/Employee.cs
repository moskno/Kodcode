using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XmlFiles
{
    internal class Employee
    {
        public XmlDocument XmlDocument { get; set; }
        public Employee(XmlDocument xmlDocument)
        {
            XmlDocument = xmlDocument;
        }

        public void GetAllEmployees(XmlNodeList xmlNodeList = null)
        {
            if (xmlNodeList == null)
            {
                xmlNodeList = XmlDocument.SelectNodes("/Employees/Employee");
            }
            foreach (XmlNode children in xmlNodeList)
            {
                if (children.Attributes != null)
                {
                    // Check all attributes
                    foreach (XmlAttribute attribute in children.Attributes)
                    {
                        Console.WriteLine(attribute.Name + ": " + attribute.Value);
                    }
                }
                if (children.ChildNodes != null)
                {
                    GetAllEmployees(children.ChildNodes);
                }
            }
        }

        public void GetEmployeeById(string id)
        {
            XmlNode? employee = XmlDocument.SelectSingleNode($"/Employees/Employee[@id='{id}']");
            if (employee != null) return;
            if (employee.Attributes != null)
            {
                foreach (XmlAttribute attribute in employee.Attributes)
                {
                    Console.WriteLine(attribute.Name + ": " + attribute.Value);
                }
                if (employee.ChildNodes  != null)
                {
                    GetAllEmployees(employee.ChildNodes);
                }

            }
           
        }
    }
}