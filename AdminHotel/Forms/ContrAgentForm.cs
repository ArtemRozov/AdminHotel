using AdminHotel.src;
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
    public partial class ContrAgentForm : Form
    {
        public ContrAgentForm()
        {
            InitializeComponent();
        }

        private void ContrAgentForm_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < AppartmentsList.ContrAgents.Count; i++)
            {                
                dataGridView1.Rows.Add("0000000" + AppartmentsList.ContrAgents[i].Number,
                    AppartmentsList.ContrAgents[i].Name,
                    AppartmentsList.ContrAgents[i].Inn );
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" ^ textBox1.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Заповніть поле!\n" +
                    "1.Поле 'ПІБ' не повинно містити цифр або будь-яких інших знаків!\n" +
                    "2.Поле 'ПІБ' пoвинно бути заповненим!");
            } 
            else if(textBox2.Text == "" || textBox2.Text.Length != 10)
            {
                MessageBox.Show("Заповніть поле!\n" +
                       "1. Поле 'Інн' повинно бути заповненим!\n" + 
                       "2. Поле 'Інн' повинно містити 10 цифр!");
            }
            else 
            {
                AppartmentsList.IsChanged = true;

                dataGridView1.Rows.Add("000000", textBox1.Text, textBox2.Text);

                AppartmentsList.ContrAgents.Add(new ContrAgent(textBox1.Text, textBox2.Text));

                textBox1.Clear();
                textBox2.Clear();

                Close();
            }            
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void ContrAgentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 3)
                {
                    AppartmentsList.ContrAgents[e.RowIndex].Name = "";
                    AppartmentsList.ContrAgents[e.RowIndex].Inn = "";

                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < AppartmentsList.ContrAgents.Count; i++)
                    {
                        if(AppartmentsList.ContrAgents[i].Name != "")
                        {
                            dataGridView1.Rows.Add("0000000" + AppartmentsList.ContrAgents[i].Number,
                           AppartmentsList.ContrAgents[i].Name,
                           AppartmentsList.ContrAgents[i].Inn);
                        }                       
                    }
                    AppartmentsList.IsChanged = true;
                }
            }
        }
    }
}
