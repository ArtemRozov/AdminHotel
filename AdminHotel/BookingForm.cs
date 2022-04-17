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
            for (int i = 0; i < AppartmentsList.app.Length; i++)
            {
                AppartmentsList.app[i] = new Appartment(i, "free", i + 198, 2, false);
                comboBox1.Items.Add("Апартаменти - " + (AppartmentsList.app[i].getNumber() + 1));
            }
        }
    }
}
