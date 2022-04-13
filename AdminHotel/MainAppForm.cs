using System;
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
        private static string[] appartments = { "appartment - 1", "appartment - 2", "appartment - 3" };

        private static Appartment[] app = new Appartment[appartments.Length];
        
        public MainForm()
        {
            InitializeComponent();           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("All");

            for (int i = 0; i < appartments.Length; i++)
            {
                app[i] = new Appartment(i, "free", i + 198, 2, false);
                comboBox1.Items.Add("Апартаменти - " + (app[i].getNumber() + 1));
                dataGridView1.Rows.Add(app[i].getNumber() + 1, "Апартаменти - " + (app[i].getNumber() + 1), "", "", "", false);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex > 0)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(app[comboBox1.SelectedIndex - 1].getNumber() + 1, "Апартаменти - " + (app[comboBox1.SelectedIndex - 1].getNumber() + 1), "", "", "", false);
            }
            else
            {
                dataGridView1.Rows.Clear();

                for (int i = 0; i < appartments.Length; i++)
                {
                    dataGridView1.Rows.Add(app[i].getNumber() + 1, "Апартаменти - " + (app[i].getNumber() + 1), "", "", "", false);
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
            for (int i = 0;i < appartments.Length; i++)
            {
                if(app[i].getFree() == "free")
                {
                    dataGridView1.Rows.Add(app[i].getNumber() + 1, "Апартаменти - " + (app[i].getNumber() + 1), "", "", "", false);
                }                
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < appartments.Length; i++)
            {
                if (app[i].getFree() == "nonFree")
                {
                    dataGridView1.Rows.Add(app[i].getNumber() + 1, "Апартаменти - " + (app[i].getNumber() + 1), "", "", "", false);
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < appartments.Length; i++)
            {
                if (app[i].getBron())
                {
                    dataGridView1.Rows.Add(app[i].getNumber() + 1, "Апартаменти - " + (app[i].getNumber() + 1), "", "", "", false);
                }
            }
        }
    }
}
