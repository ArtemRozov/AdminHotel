﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
                comboBox1.Items.Add("Апартаменти - " + (AppartmentsList.app[i].getNumber() + 1));
                dataGridView1.Rows.Add(AppartmentsList.app[i].getNumber() + 1, "Апартаменти - " + (AppartmentsList.app[i].getNumber() + 1), "", "", "", false);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex > 0)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(AppartmentsList.app[comboBox1.SelectedIndex - 1].getNumber() + 1, "Апартаменти - " + (AppartmentsList.app[comboBox1.SelectedIndex - 1].getNumber() + 1), "", "", "", false);
            }
            else
            {
                dataGridView1.Rows.Clear();

                for (int i = 0; i < AppartmentsList.app.Length; i++)
                {
                    dataGridView1.Rows.Add(AppartmentsList.app[i].getNumber() + 1, "Апартаменти - " + (AppartmentsList.app[i].getNumber() + 1), "", "", "", false);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Enabled)
            {
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
                    dataGridView1.Rows.Add(AppartmentsList.app[i].getNumber() + 1, "Апартаменти - " + (AppartmentsList.app[i].getNumber() + 1), "", "", "", false);
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
                    dataGridView1.Rows.Add(AppartmentsList.app[i].getNumber() + 1, "Апартаменти - " + (AppartmentsList.app[i].getNumber() + 1), "", "", "", false);
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
                    dataGridView1.Rows.Add(AppartmentsList.app[i].getNumber() + 1, "Апартаменти - " + (AppartmentsList.app[i].getNumber() + 1), "", "", "", false);
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
    }
}
