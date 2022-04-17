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
            ContrAgentForm contrAgentForm = new ContrAgentForm();

            for (int i = 0; i < AppartmentsList.app.Length; i++)
            {
                comboBox1.Items.Add("Апартаменти - " + (AppartmentsList.app[i].getNumber() + 1));                                                            
            }

            for (int i = 0; i < AppartmentsList.getNames().Count; i++)
            {
                comboBox2.Items.Add(AppartmentsList.getNames().ElementAt(i));
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ContrAgentForm contrAgentForm = new ContrAgentForm();
            contrAgentForm.Show();
        }
    }
}
