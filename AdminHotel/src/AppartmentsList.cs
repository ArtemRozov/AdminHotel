using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

using System.IO;
using AdminHotel.src;

namespace AdminHotel
{

    internal static class AppartmentsList
    {
        // Масив усіх апартаментів 
        public static Appartment[] Appartments { get; set; }
        // Список усіх контрагентів
        public static List<ContrAgent> ContrAgents { get; set; } = new List<ContrAgent>();
        // Змінювалася програма після запуску чи ні (для збереження)
        public static bool IsChanged { get; set; } = false;
        // Зчитуємо інформацію про апартаменти та клієнтів з файлу
        public static void InitArr()
        {
            Appartments = new Appartment[3];
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"Data\resourcesForApp.xml");
            XmlNodeList userNodes = xmlDoc.SelectNodes("//appartments/appartment");
            XmlNodeList contrAgentNodes = xmlDoc.SelectNodes("//appartments/contrAgent");

            for(int i = 0; i < contrAgentNodes.Count; i++)
            {
                string contrAgentName = contrAgentNodes[i].Attributes["name"].Value;
                string contrAgentInn = contrAgentNodes[i].Attributes["inn"].Value;

                if (contrAgentName != "")
                {
                    if (contrAgentNodes[i].Attributes["number"].Value != "")
                    {
                        int contrAgentNumber = int.Parse(contrAgentNodes[i].Attributes["number"].Value);
                        ContrAgents.Add(new ContrAgent(contrAgentName, contrAgentInn, contrAgentNumber));
                    }
                    else
                    {
                        ContrAgents.Add(new ContrAgent(contrAgentName, contrAgentInn));
                    }
                }                           
            }

            
            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(userNodes[i].Attributes["number"].Value);
                string free = userNodes[i].Attributes["free"].Value;
                int price = int.Parse(userNodes[i].Attributes["price"].Value);
                int countRooms = int.Parse(userNodes[i].Attributes["countRooms"].Value);
                bool bron = bool.Parse(userNodes[i].Attributes["bron"].Value);
                string name = userNodes[i].Attributes["name"].Value;
                string inn = userNodes[i].Attributes["inn"].Value;

                DateTimeOffset checkIn;
                DateTimeOffset checkOut;

                if (userNodes[i].Attributes["checkIn"].Value != "")
                {
                    checkIn = DateTimeOffset.Parse(userNodes[i].Attributes["checkIn"].Value);
                }
                else
                {
                    checkIn = DateTimeOffset.Now;
                }

                if(userNodes[i].Attributes["checkOut"].Value != "")
                {
                    checkOut = DateTimeOffset.Parse(userNodes[i].Attributes["checkOut"].Value);
                }
                else
                {
                    checkOut = DateTimeOffset.Now;
                }

                Appartments[i] = new Appartment(
                    number,
                    free,
                    price,
                    countRooms,
                    bron,
                    name,
                    inn,
                    checkIn,
                    checkOut );
            }
        }
    }
}
