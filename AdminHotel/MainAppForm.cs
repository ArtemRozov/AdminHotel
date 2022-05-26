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

            for (int i = 0; i < AppartmentsList.App.Length; i++)
            {
                comboBox1.Items.Add("Апартаменти - " + (AppartmentsList.App[i].Number));

                if (AppartmentsList.App[i].Name == "")
                {
                    dataGridView1.Rows.Add(AppartmentsList.App[i].Number, "Апартаменти - " + (AppartmentsList.App[i].Number), AppartmentsList.App[i].Name, "", "", AppartmentsList.App[i].Bron);
                }
                else
                {
                    dataGridView1.Rows.Add(AppartmentsList.App[i].Number, "Апартаменти - " + (AppartmentsList.App[i].Number), AppartmentsList.App[i].Name, AppartmentsList.App[i].CheckIn, AppartmentsList.App[i].CheckOut, AppartmentsList.App[i].Bron);
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex > 0)
            {
                dataGridView1.Rows.Clear();

                if (AppartmentsList.App[comboBox1.SelectedIndex - 1].Name == "")
                {
                    dataGridView1.Rows.Add(AppartmentsList.App[comboBox1.SelectedIndex - 1].Number, "Апартаменти - " + (AppartmentsList.App[comboBox1.SelectedIndex - 1].Number), AppartmentsList.App[comboBox1.SelectedIndex - 1].Name, "", "", AppartmentsList.App[comboBox1.SelectedIndex - 1].Bron);
                }
                else
                {
                    dataGridView1.Rows.Add(AppartmentsList.App[comboBox1.SelectedIndex - 1].Number, "Апартаменти - " + (AppartmentsList.App[comboBox1.SelectedIndex - 1].Number), AppartmentsList.App[comboBox1.SelectedIndex - 1].Name, AppartmentsList.App[comboBox1.SelectedIndex - 1].CheckIn, AppartmentsList.App[comboBox1.SelectedIndex - 1].CheckOut, AppartmentsList.App[comboBox1.SelectedIndex - 1].Bron);
                }
            }
            else
            {
                dataGridView1.Rows.Clear();

                for (int i = 0; i < AppartmentsList.App.Length; i++)
                {
                    if (AppartmentsList.App[i].Name == "")
                    {
                        dataGridView1.Rows.Add(AppartmentsList.App[i].Number, "Апартаменти - " + (AppartmentsList.App[i].Number), AppartmentsList.App[i].Name, "", "", AppartmentsList.App[i].Bron);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(AppartmentsList.App[i].Number, "Апартаменти - " + (AppartmentsList.App[i].Number), AppartmentsList.App[i].Name, AppartmentsList.App[i].CheckIn, AppartmentsList.App[i].CheckOut, AppartmentsList.App[i].Bron);
                    }
                }
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Enabled)
            {
                comboBox1.SelectedItem = comboBox1.Items[1];
                comboBox1.SelectedItem = comboBox1.Items[0];
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0;i < AppartmentsList.App.Length; i++)
            {
                if(AppartmentsList.App[i].Free == "free")
                {
                    if (AppartmentsList.App[i].Name == "")
                    {
                        dataGridView1.Rows.Add(AppartmentsList.App[i].Number, "Апартаменти - " + (AppartmentsList.App[i].Number), AppartmentsList.App[i].Name, "", "", AppartmentsList.App[i].Bron);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(AppartmentsList.App[i].Number, "Апартаменти - " + (AppartmentsList.App[i].Number), AppartmentsList.App[i].Name, AppartmentsList.App[i].CheckIn, AppartmentsList.App[i].CheckOut, AppartmentsList.App[i].Bron);
                    }
                }                
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < AppartmentsList.App.Length; i++)
            {
                if (AppartmentsList.App[i].Free == "nonFree")
                {
                    if (AppartmentsList.App[i].Name == "")
                    {
                        dataGridView1.Rows.Add(AppartmentsList.App[i].Number, "Апартаменти - " + (AppartmentsList.App[i].Number), AppartmentsList.App[i].Name, "", "", AppartmentsList.App[i].Bron);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(AppartmentsList.App[i].Number, "Апартаменти - " + (AppartmentsList.App[i].Number), AppartmentsList.App[i].Name, AppartmentsList.App[i].CheckIn, AppartmentsList.App[i].CheckOut, AppartmentsList.App[i].Bron);
                    }
                }
            }
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < AppartmentsList.App.Length; i++)
            {
                if (AppartmentsList.App[i].Bron)
                {
                    if (AppartmentsList.App[i].Name == "")
                    {
                        dataGridView1.Rows.Add(AppartmentsList.App[i].Number, "Апартаменти - " + (AppartmentsList.App[i].Number), AppartmentsList.App[i].Name, "", "", AppartmentsList.App[i].Bron);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(AppartmentsList.App[i].Number, "Апартаменти - " + (AppartmentsList.App[i].Number), AppartmentsList.App[i].Name, AppartmentsList.App[i].CheckIn, AppartmentsList.App[i].CheckOut, AppartmentsList.App[i].Bron);
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CatalogForm form = new CatalogForm();
            form.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            BookingForm bookingForm = new BookingForm();
            bookingForm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ContrAgentForm contrAgentForm = new ContrAgentForm();
            contrAgentForm.Show();
        }

        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex == 1 && AppartmentsList.App[e.RowIndex].Name == "")
            {
                BookingForm bookingForm = new BookingForm();
                bookingForm.Show();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"resourcesForApp.xml");
            XmlNodeList userNodes = xmlDoc.SelectNodes("//appartments/appartment");

            for(int i = 0; i < userNodes.Count; i++)
            {
                userNodes[i].Attributes.GetNamedItem("name").Value = AppartmentsList.App[i].Name;
                userNodes[i].Attributes.GetNamedItem("bron").Value = AppartmentsList.App[i].Bron.ToString();
                userNodes[i].Attributes.GetNamedItem("free").Value = AppartmentsList.App[i].Free;
                userNodes[i].Attributes.GetNamedItem("inn").Value = AppartmentsList.App[i].Inn;

                userNodes[i].Attributes.GetNamedItem("checkIn").Value = AppartmentsList.App[i].CheckIn.ToString();
                userNodes[i].Attributes.GetNamedItem("checkOut").Value = AppartmentsList.App[i].CheckOut.ToString();
            }

            xmlDoc.Save(@"resourcesForApp.xml");
        }
    }
}
