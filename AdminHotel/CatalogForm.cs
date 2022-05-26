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
            for(int i = 0; i < AppartmentsList.App.Length; i++)
            {
                dataGridView1.Rows.Add("0000000" + i, " Апартаменти - " + (AppartmentsList.App[i].Number), AppartmentsList.App[i].CountRooms);
                comboBox1.Items.Add("апартаменти - " + AppartmentsList.App[i].Number);
            }   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(AppartmentsList.App[comboBox1.SelectedIndex].Number, AppartmentsList.App[comboBox1.SelectedIndex].Free, AppartmentsList.App[comboBox1.SelectedIndex].Price, AppartmentsList.App[comboBox1.SelectedIndex].CountRooms);
        }
    }
}
