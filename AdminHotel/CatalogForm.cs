using System;
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
        public CatalogForm()
        {
            InitializeComponent();
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < AppartmentsList.app.Length; i++)
            {
                dataGridView1.Rows.Add("0000000" + i, " Апартаменти - " + (AppartmentsList.app[i].getNumber() + 1), AppartmentsList.app[i].getCountRooms());
            }            
           
            comboBox1.Items.AddRange(AppartmentsList.app);

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(AppartmentsList.app[comboBox1.SelectedIndex].getNumber() + 1, AppartmentsList.app[comboBox1.SelectedIndex].getFree(), AppartmentsList.app[comboBox1.SelectedIndex].getPrice(), AppartmentsList.app[comboBox1.SelectedIndex].getCountRooms());
        }
    }
}
