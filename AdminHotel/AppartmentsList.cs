using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

using System.IO;


namespace AdminHotel
{

    internal static class AppartmentsList
    {
        private static List<string> names = new List<string>();
        public static Appartment[] app { get; set; }

        public static void InitArr()
        {
            app = new Appartment[3];

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"C:\Users\Lenovo\source\repos\AdminHotel\AdminHotel\resourcesForApp.xml");
            XmlNodeList userNodes = xmlDoc.SelectNodes("//appartments/appartment");

            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(userNodes[i].Attributes["number"].Value);
                string free = userNodes[i].Attributes["free"].Value;
                int price = int.Parse(userNodes[i].Attributes["price"].Value);
                int countRooms = int.Parse(userNodes[i].Attributes["countRooms"].Value);
                bool bron = bool.Parse(userNodes[i].Attributes["bron"].Value);
                string name = userNodes[i].Attributes["name"].Value;
                string inn = userNodes[i].Attributes["inn"].Value;

                DateTimeOffset checkIn =DateTimeOffset.Parse(userNodes[i].Attributes["checkIn"].Value);
                DateTimeOffset checkOut = DateTimeOffset.Parse(userNodes[i].Attributes["checkOut"].Value);

                app[i] = new Appartment(number, free, price, countRooms, bron, name, inn, checkIn, checkOut);
            }
        }

        public static List<string> getNames()
        {
            return names;
        }
        public static void setNames(string name)
        {
            names.Add(name);
        }
    }
}
