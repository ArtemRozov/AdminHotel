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
            for(int i = 0; i < AppartmentsList.App.Length; i++)
            {
                if (AppartmentsList.App[i].Name != "")
                {
                    dataGridView1.Rows.Add("0000000" + AppartmentsList.App[i].Number, AppartmentsList.App[i].Name, AppartmentsList.App[i].Inn);
                    AppartmentsList.SetNames(AppartmentsList.App[i].Name);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("000000", textBox1.Text, textBox2.Text);
            AppartmentsList.SetNames(textBox1.Text);

            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
