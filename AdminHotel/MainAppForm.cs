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
using System.Xml.Serialization;

namespace AdminHotel
{
    public partial class MainForm : Form
    {   
        public MainForm()
        {
            InitializeComponent();           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("All");

            for (int i = 0; i < AppartmentsList.app.Length; i++)
            {
                comboBox1.Items.Add("Апартаменти - " + (AppartmentsList.app[i].getNumber()));

                if (AppartmentsList.app[i].getName() == "")
                {
                    dataGridView1.Rows.Add(AppartmentsList.app[i].getNumber(), "Апартаменти - " + (AppartmentsList.app[i].getNumber()), AppartmentsList.app[i].getName(), "", "", AppartmentsList.app[i].getBron());
                }
                else
                {
                    dataGridView1.Rows.Add(AppartmentsList.app[i].getNumber(), "Апартаменти - " + (AppartmentsList.app[i].getNumber()), AppartmentsList.app[i].getName(), AppartmentsList.app[i].getCheckIn(), AppartmentsList.app[i].getCheckOut(), AppartmentsList.app[i].getBron());
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex > 0)
            {
                dataGridView1.Rows.Clear();

                if (AppartmentsList.app[comboBox1.SelectedIndex - 1].getName() == "")
                {
                    dataGridView1.Rows.Add(AppartmentsList.app[comboBox1.SelectedIndex - 1].getNumber(), "Апартаменти - " + (AppartmentsList.app[comboBox1.SelectedIndex - 1].getNumber()), AppartmentsList.app[comboBox1.SelectedIndex - 1].getName(), "", "", AppartmentsList.app[comboBox1.SelectedIndex - 1].getBron());
                }
                else
                {
                    dataGridView1.Rows.Add(AppartmentsList.app[comboBox1.SelectedIndex - 1].getNumber(), "Апартаменти - " + (AppartmentsList.app[comboBox1.SelectedIndex - 1].getNumber()), AppartmentsList.app[comboBox1.SelectedIndex - 1].getName(), AppartmentsList.app[comboBox1.SelectedIndex - 1].getCheckIn(), AppartmentsList.app[comboBox1.SelectedIndex - 1].getCheckOut(), AppartmentsList.app[comboBox1.SelectedIndex - 1].getBron());
                }
            }
            else
            {
                dataGridView1.Rows.Clear();

                for (int i = 0; i < AppartmentsList.app.Length; i++)
                {
                    if (AppartmentsList.app[i].getName() == "")
                    {
                        dataGridView1.Rows.Add(AppartmentsList.app[i].getNumber(), "Апартаменти - " + (AppartmentsList.app[i].getNumber()), AppartmentsList.app[i].getName(), "", "", AppartmentsList.app[i].getBron());
                    }
                    else
                    {
                        dataGridView1.Rows.Add(AppartmentsList.app[i].getNumber(), "Апартаменти - " + (AppartmentsList.app[i].getNumber()), AppartmentsList.app[i].getName(), AppartmentsList.app[i].getCheckIn(), AppartmentsList.app[i].getCheckOut(), AppartmentsList.app[i].getBron());
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Enabled)
            {
                comboBox1.SelectedItem = comboBox1.Items[1];
                comboBox1.SelectedItem = comboBox1.Items[0];
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0;i < AppartmentsList.app.Length; i++)
            {
                if(AppartmentsList.app[i].getFree() == "free")
                {
                    if (AppartmentsList.app[i].getName() == "")
                    {
                        dataGridView1.Rows.Add(AppartmentsList.app[i].getNumber(), "Апартаменти - " + (AppartmentsList.app[i].getNumber()), AppartmentsList.app[i].getName(), "", "", AppartmentsList.app[i].getBron());
                    }
                    else
                    {
                        dataGridView1.Rows.Add(AppartmentsList.app[i].getNumber(), "Апартаменти - " + (AppartmentsList.app[i].getNumber()), AppartmentsList.app[i].getName(), AppartmentsList.app[i].getCheckIn(), AppartmentsList.app[i].getCheckOut(), AppartmentsList.app[i].getBron());
                    }
                }                
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < AppartmentsList.app.Length; i++)
            {
                if (AppartmentsList.app[i].getFree() == "nonFree")
                {
                    if (AppartmentsList.app[i].getName() == "")
                    {
                        dataGridView1.Rows.Add(AppartmentsList.app[i].getNumber(), "Апартаменти - " + (AppartmentsList.app[i].getNumber()), AppartmentsList.app[i].getName(), "", "", AppartmentsList.app[i].getBron());
                    }
                    else
                    {
                        dataGridView1.Rows.Add(AppartmentsList.app[i].getNumber(), "Апартаменти - " + (AppartmentsList.app[i].getNumber()), AppartmentsList.app[i].getName(), AppartmentsList.app[i].getCheckIn(), AppartmentsList.app[i].getCheckOut(), AppartmentsList.app[i].getBron());
                    }
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < AppartmentsList.app.Length; i++)
            {
                if (AppartmentsList.app[i].getBron())
                {
                    if (AppartmentsList.app[i].getName() == "")
                    {
                        dataGridView1.Rows.Add(AppartmentsList.app[i].getNumber(), "Апартаменти - " + (AppartmentsList.app[i].getNumber()), AppartmentsList.app[i].getName(), "", "", AppartmentsList.app[i].getBron());
                    }
                    else
                    {
                        dataGridView1.Rows.Add(AppartmentsList.app[i].getNumber(), "Апартаменти - " + (AppartmentsList.app[i].getNumber()), AppartmentsList.app[i].getName(), AppartmentsList.app[i].getCheckIn(), AppartmentsList.app[i].getCheckOut(), AppartmentsList.app[i].getBron());
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CatalogForm form = new CatalogForm();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookingForm bookingForm = new BookingForm();
            bookingForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContrAgentForm contrAgentForm = new ContrAgentForm();
            contrAgentForm.Show();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex == 1 && AppartmentsList.app[e.RowIndex].getName() == "")
            {
                BookingForm bookingForm = new BookingForm();
                bookingForm.Show();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"C:\Users\Lenovo\source\repos\AdminHotel\AdminHotel\resourcesForApp.xml");
            XmlNodeList userNodes = xmlDoc.SelectNodes("//appartments/appartment");

            for(int i = 0; i < userNodes.Count; i++)
            {
                userNodes[i].Attributes.GetNamedItem("name").Value = AppartmentsList.app[i].getName();
                userNodes[i].Attributes.GetNamedItem("bron").Value = AppartmentsList.app[i].getBron().ToString();
                userNodes[i].Attributes.GetNamedItem("free").Value = AppartmentsList.app[i].getFree();
                userNodes[i].Attributes.GetNamedItem("inn").Value = AppartmentsList.app[i].getInn();

                userNodes[i].Attributes.GetNamedItem("checkIn").Value = AppartmentsList.app[i].getCheckIn().ToString();
                userNodes[i].Attributes.GetNamedItem("checkOut").Value = AppartmentsList.app[i].getCheckOut().ToString();
            }

            xmlDoc.Save(@"C:\Users\Lenovo\source\repos\AdminHotel\AdminHotel\resourcesForApp.xml");
        }
    }
}
