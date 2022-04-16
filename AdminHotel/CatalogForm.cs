﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminHotel
{
    public partial class CatalogForm : Form
    {
        private static string[] appartments = { "appartment - 1", "appartment - 2", "appartment - 3" };
        
        private static Appartment[] app = new Appartment[appartments.Length];
        public CatalogForm()
        {
            InitializeComponent();
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < appartments.Length; i++)
            {
                app[i] = new Appartment(i, "free", i + 198, 2, false);
                dataGridView1.Rows.Add("0000000" + i, " Апартаменти - " + (app[i].getNumber() + 1), app[i].getCountRooms());
            }            
           
            comboBox1.Items.AddRange(appartments);

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(app[comboBox1.SelectedIndex].getNumber() + 1, app[comboBox1.SelectedIndex].getFree(), app[comboBox1.SelectedIndex].getPrice(), app[comboBox1.SelectedIndex].getCountRooms());
        }
    }
}
