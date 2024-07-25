using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace DatesRabanut
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public static class ProgramXml
    {
        private static string pathString = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..") + "\\Queries.xml");

        public static XmlDocument Main()
        {
            if (File.Exists(pathString))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(pathString);
                return xmlDoc;
            }
            else
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlNode dateNode = xmlDoc.CreateElement("Queries");
                xmlDoc.AppendChild(dateNode);
                Save(xmlDoc);
                return xmlDoc;
            }
        }

        public static void Save(XmlDocument xmlDocument)
        {
            xmlDocument.Save(pathString);
        }
    }
}
