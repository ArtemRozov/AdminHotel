using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AdminHotel.Forms
{
    public partial class SaveDialogForm : Form
    {
        public SaveDialogForm()
        {
            InitializeComponent();
        }

        // Вихід з програми без зберігання данних якщо був вибраним цей варіант
        private void ExitButton_Click(object sender, EventArgs e)
        {
            AppartmentsList.IsChanged = false;
            Application.Exit();
        }

        // Зберігання усіх змін у файл при закритті програми
        private void SaveButton_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"Data\resourcesForApp.xml");
            XmlNodeList userNodes = xmlDoc.SelectNodes("//appartments/appartment");
            XmlNodeList contrAgentNodes = xmlDoc.SelectNodes("//appartments/contrAgent");

            for (int i = 0; i < AppartmentsList.ContrAgents.Count; i++)
            {
                contrAgentNodes[i].Attributes.GetNamedItem("name").Value =
                    AppartmentsList.ContrAgents[i].Name;
                contrAgentNodes[i].Attributes.GetNamedItem("inn").Value =
                    AppartmentsList.ContrAgents[i].Inn;
                if (AppartmentsList.ContrAgents[i].Number > 0)
                {
                    contrAgentNodes[i].Attributes.GetNamedItem("number").Value =
                        AppartmentsList.ContrAgents[i].Number.ToString();
                }
                else
                {
                    contrAgentNodes[i].Attributes.GetNamedItem("number").Value = "";
                }
            }

            for (int i = 0; i < userNodes.Count; i++)
            {
                userNodes[i].Attributes.GetNamedItem("name").Value =
                    AppartmentsList.Appartments[i].Name;
                userNodes[i].Attributes.GetNamedItem("bron").Value =
                    AppartmentsList.Appartments[i].Bron.ToString();
                userNodes[i].Attributes.GetNamedItem("free").Value =
                    AppartmentsList.Appartments[i].Free;
                userNodes[i].Attributes.GetNamedItem("inn").Value =
                    AppartmentsList.Appartments[i].Inn;

                userNodes[i].Attributes.GetNamedItem("checkIn").Value =
                    AppartmentsList.Appartments[i].CheckIn.ToString();
                userNodes[i].Attributes.GetNamedItem("checkOut").Value =
                    AppartmentsList.Appartments[i].CheckOut.ToString();
            }

            xmlDoc.Save(@"Data\resourcesForApp.xml");

            AppartmentsList.IsChanged = false;
            Application.Exit();
        }

       
    }
}
