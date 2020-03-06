using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
namespace Lesson8Task1and2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextWriter xmlWriter = new XmlTextWriter("TelephoneBook.xml", null);
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("MyContacts");
            xmlWriter.WriteStartElement("Contact");
            xmlWriter.WriteStartAttribute("TelephoneNumber");
            xmlWriter.WriteString("911");
            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteString("Vasya");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Contact");
            xmlWriter.WriteStartAttribute("TelephoneNumber");
            xmlWriter.WriteString("112");
            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteString("Lena");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.Close();
            Console.WriteLine("Added information");
          //  Task2
            Console.WriteLine("Information from TelephoneBook.xml file:");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("TelephoneBook.xml");
            XmlElement xRoot = xmlDoc.DocumentElement;
            foreach (XmlNode t in xRoot)
            {
                Console.WriteLine("Name:");
                foreach (XmlNode td in t.ChildNodes)
                {
                    Console.WriteLine(td.InnerText);
                }
                Console.WriteLine("Telephone number:");
                if (t.Attributes.Count>0)
                {
                    XmlNode attr = t.Attributes.GetNamedItem("TelephoneNumber");
                    if (attr!=null)
                    { Console.WriteLine(attr.Value);  }
                }

                Console.WriteLine();
            }
            //  Task3
            XmlDocument xmlDoc2 = new XmlDocument();
            xmlDoc.Load("TelephoneBook.xml");
            XmlElement xRoot2 = xmlDoc.DocumentElement;
            Console.WriteLine("Telephones:");
            foreach (XmlNode t in xRoot2)
            {
                if (t.Attributes.Count > 0)
                {
                    XmlNode attr = t.Attributes.GetNamedItem("TelephoneNumber");
                    if (attr != null)
                    { Console.WriteLine(attr.Value); }
                }
            }
                Console.ReadLine();
        }
    }
}
