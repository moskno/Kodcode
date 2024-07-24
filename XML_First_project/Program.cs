using System.Xml;
using XmlFiles;
using XMLFiles;

XmlDocument xmlDocument = XML_First_Project.Main();
Employee employee = new Employee(xmlDocument);
employee.GetAllEmployees();