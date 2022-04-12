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
            for (int i = 0; i < appartments.Length; i++)
            {
                app[i] = new Appartment(i, "free", i + 198, 2);
                listBox1.Items.Add("Appartment #" + (app[i].getNumber() + 1) + "; " + app[i].getFree() + "; Price = " + app[i].getPrice() + "; CountRooms = " + app[i].getCountRooms());
            }
        }

        private void listBoxItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CatalogForm catalogForm = new CatalogForm();

            int index = listBox1.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                catalogForm.Show();
            }                
        }
    }
}
