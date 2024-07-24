using System.Xml;


namespace XMLCountries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string pathString = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..") + "\\Countries.xml");
            XmlDocument xmlDoc;


            if (File.Exists(pathString))
            {
                xmlDoc = new XmlDocument();
                xmlDoc.Load(pathString);
            }
            else
            {
                xmlDoc = new XmlDocument();
                XmlNode countryNode = xmlDoc.CreateElement("Countries");
                xmlDoc.AppendChild(countryNode);
            }
            

            XmlNode oneCountryNode = xmlDoc.CreateElement("Country");
            XmlNode countryName = xmlDoc.CreateElement("Name");
            XmlNode city1 = xmlDoc.CreateElement("City");
            XmlNode city2 = xmlDoc.CreateElement("City");


            countryName.InnerText = "Israel";
            city1.InnerText = "Tel Aviv";
            city2.InnerText = "Jerusalem";

            oneCountryNode.AppendChild(countryName);
            oneCountryNode.AppendChild(city1);
            oneCountryNode.AppendChild(city2);
            XmlNode? rootNode = xmlDoc.FirstChild;

            if (rootNode != null)
            {
                rootNode.AppendChild(oneCountryNode);
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