using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace VendingMachine
{
    internal class DrinksManager
    {
        //משתנה
        private XmlDocument _document;
        //בנאי
        public DrinksManager(XmlDocument doc)
        {
            _document = doc;
        }

        public List<List<string>> GetDrinksData()
        {
            List<List<string>> AllDrinks = new List<List<string>>();
            XmlNodeList drinksNodes = _document.SelectNodes("/drinks/drink");
            if (drinksNodes != null)
            {
                foreach (XmlNode drink in drinksNodes)
                {
                    List<string> drinkList = new List<string>();
                    if (drink.ChildNodes != null)
                    {
                        foreach (XmlNode drinkNode in drink.ChildNodes)
                        {
                            drinkList.Add(drinkNode.InnerText);
                        }
                    }
                    AllDrinks.Add(drinkList);
                }
            }
            return AllDrinks;
        }

        private XmlNode GetRoot()
        {
            return _document.GetElementsByTagName("drinks")[0];
        }
        public void AddDrink(List<string> drinks)
        {
            XmlElement drinkElement = _document.CreateElement("drink");
            List<string> tagsName = new List<string>()
            {"name", "sugar", "coffee", "milk", "cacao", "price"};
            for (int i = 0; i < tagsName.Count; i++)
            {
                XmlElement child = _document.CreateElement(tagsName[i]);
                child.InnerText = drinks[i];
                drinkElement.AppendChild(child);
            }
            GetRoot().AppendChild(drinkElement);
        }

        public void Save()
        {
            MainProject.Save(_document);
        }

        public void UpdateDrink(List<string> drinks) 
        {
            XmlNodeList drinkslist = _document.GetElementsByTagName("name");
            if (drinkslist == null) return;
            foreach (XmlNode drink in drinkslist)
            {
                if (drink.InnerText == drinks[0])
                {
                    int i = 0;
                    foreach(XmlNode child in drink.ParentNode)
                    {
                        child.InnerText = drinks[i];
                        i++;
                    }
 
                }
            }
        }

        public List<string> GetDrinkByName (string name)
        {
            List<string> list = null;
            XmlNodeList drinkslist = _document.GetElementsByTagName ("name");
            if (drinkslist == null) return null;
            foreach (XmlNode drink in drinkslist)
            {
                if(drink.InnerText == name)
                {
                    list = GetAllData(drink.ParentNode);
                    break;
                }
            }
            return list;
        }

        private List<string> GetAllData(XmlNode drink)
        {
            List<string> list = new List<string>();
            foreach (XmlNode child in drink.ChildNodes)
            {
                list.Add(child.InnerText);
            }
            return list;
        }


        public void DeleteDrink(string name)
        {
            //removeChild();
            //method;
        }


        

    }
}
