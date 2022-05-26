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
    public partial class BookingForm : Form 
    {
        public BookingForm()
        {
            InitializeComponent();
        }
        private void BookingForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < AppartmentsList.App.Length; i++)
            {
                comboBox1.Items.Add("Апартаменти - " + (AppartmentsList.App[i].Number));                                                            
            }

            for (int i = 0; i < AppartmentsList.GetNames().Count; i++)
            {
                comboBox2.Items.Add(AppartmentsList.GetNames().ElementAt(i));
            }
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ContrAgentForm contrAgentForm = new ContrAgentForm();
            contrAgentForm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {            
            AppartmentsList.App[comboBox1.SelectedIndex].Name = comboBox2.Text;
            AppartmentsList.App[comboBox1.SelectedIndex].CheckIn = dateTimePicker2.Value;
            AppartmentsList.App[comboBox1.SelectedIndex].CheckOut = dateTimePicker3.Value;
            AppartmentsList.App[comboBox1.SelectedIndex].Bron = checkBox1.Checked;
            AppartmentsList.App[comboBox1.SelectedIndex].Free = "nonFree";

            Close();            
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //калькулятор
            {
                e.Handled = true;
            }
        }
    }
}
