using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLFiles
{
    public class XML_First_Project
    {
        public static XmlDocument Main()
        {
            string pathString = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..") + "\\Employees.xml");
            Console.WriteLine("Project Directory: " + pathString);
            if (File.Exists(pathString))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(pathString);
                return xmlDoc;
            }
            return null;
        }
    }
}
//                // 2. Search for Employee
//                XmlNode? xmlNode = xmlDoc.SelectSingleNode("/Employees/Employee[@id='2']");
//                if (xmlNode != null && xmlNode.Attributes != null)
//                {
//                    // Check all attributes
//                    foreach (XmlAttribute attribute in xmlNode.Attributes)
//                    {
//                        Console.WriteLine(attribute.Name + ": " + attribute.Value);
//                    }
//                }
//                // 3. Search for all employees
//                XmlNodeList? xmlNodes = xmlDoc.SelectNodes("/Employees/Employee");
//                if (xmlNodes != null)
//                {
//                    foreach (XmlNode node in xmlNodes)
//                    {
//                        if (node.ChildNodes != null)
//                        {
//                            foreach (XmlNode childNode in node.ChildNodes)
//                            {
//                                if (childNode.ChildNodes != null)
//                                {
//                                    foreach (XmlNo)
//                            }
//                            }
//                        }

//                    }
//                }

//                Console.WriteLine();
//                //xmlDoc.SelectNodes();
//                // 4. Insert new employee - ....
//            }
//            else
//            {
//                Console.WriteLine("File not found");
//            }
//        }
//    }
//}

