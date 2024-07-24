// See https://aka.ms/new-console-template for more information
using System.Xml;


namespace XMLSimpleProject
{
    public class Program
    {
        //פרויקט כיתה

        public static void Main (string[] args)
        {
            // קובץ לעבודה
             string pathString = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..") + "\\Students.xml");
            XmlDocument xmlDoc;

            //קריאת הקובץ
            if (File.Exists(pathString))
            {
                xmlDoc = new XmlDocument();
                xmlDoc.Load(pathString);
            }
            //אם לא קיים, נייצר משלנו
            else
            {
                xmlDoc = new XmlDocument();
                XmlNode studentNode = xmlDoc.CreateElement("Students");
                xmlDoc.AppendChild(studentNode);
            }

            // הספת תלמידים
            XmlNode oneStudentNode = xmlDoc.CreateElement("Student");
            XmlNode studentFirstName = xmlDoc.CreateElement("FirstName");
            XmlNode studentLastName = xmlDoc.CreateElement("LastName");

            // הזנת נתונים
            studentFirstName.InnerText = "Shalom";
            studentLastName.InnerText = "Bergman";

            //לחבר הכל
            oneStudentNode.AppendChild(studentFirstName);
            oneStudentNode.AppendChild (studentLastName);
            XmlNode? rootNode = xmlDoc.FirstChild;

            if (rootNode != null) 
            {
                rootNode.AppendChild(oneStudentNode);
            }
            else
            {
                Console.WriteLine("Can't find any Nodes");
            }

            //לשמור את העדכונים
            xmlDoc.Save(pathString);

        }
    }
}
