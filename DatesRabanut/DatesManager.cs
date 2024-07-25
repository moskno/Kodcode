using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace DatesRabanut
{
    public class DatesManager
    {
        private XmlDocument xmlDoc;

        public DatesManager(XmlDocument document)
        {
            xmlDoc = document;
        }

        public void AddDate(List<string> dates)
        {
            XmlNode dateNode = xmlDoc.CreateElement("Date");

            XmlNode weekDayNode = xmlDoc.CreateElement("WeekDay");
            weekDayNode.InnerText = dates[0];
            dateNode.AppendChild(weekDayNode);

            XmlNode monthDayNode = xmlDoc.CreateElement("MonthDay");
            monthDayNode.InnerText = dates[1];
            dateNode.AppendChild(monthDayNode);

            XmlNode monthNode = xmlDoc.CreateElement("Month");
            monthNode.InnerText = dates[2];
            dateNode.AppendChild(monthNode);

            XmlNode yearNode = xmlDoc.CreateElement("Year");
            yearNode.InnerText = dates[3];
            dateNode.AppendChild(yearNode);

            xmlDoc.DocumentElement.AppendChild(dateNode);
        }

        public XmlDocument GetDocument()
        {
            return xmlDoc;
        }

        public string GetFormattedDates()
        {
            StringBuilder formattedDates = new StringBuilder();

            foreach (XmlNode dateNode in xmlDoc.DocumentElement.ChildNodes)
            {
                string weekDay = dateNode["WeekDay"]?.InnerText ?? "";
                string monthDay = dateNode["MonthDay"]?.InnerText ?? "";
                string month = dateNode["Month"]?.InnerText ?? "";
                string year = dateNode["Year"]?.InnerText ?? "";

                formattedDates.AppendLine($"{weekDay}, {monthDay} {month}, {year}");
            }

            return formattedDates.ToString();
        }
    }
}
