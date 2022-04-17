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
            for(int i = 0; i < AppartmentsList.app.Length; i++)
            {
                if (AppartmentsList.app[i].getName() != "")
                {
                    dataGridView1.Rows.Add("0000000" + AppartmentsList.app[i].getNumber(), AppartmentsList.app[i].getName(), AppartmentsList.app[i].getInn());
                    AppartmentsList.setNames(AppartmentsList.app[i].getName());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("000000", textBox1.Text, textBox2.Text);
            AppartmentsList.setNames(textBox1.Text);

            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
