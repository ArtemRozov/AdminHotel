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

        // При загрузці форми заповнюємо таблицю та комбобокс.
        private void CatalogForm_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < AppartmentsList.Appartments.Length; i++)
            {
                dataGridView1.Rows.Add("0000000" + i,
                    " Апартаменти - " + (AppartmentsList.Appartments[i].Number),
                    AppartmentsList.Appartments[i].CountRooms );
                comboBox1.Items.Add("апартаменти - " + AppartmentsList.Appartments[i].Number);
            }   
        }

        // Змінюємо відображеня таблиці при виборі пункту у комбобоксі.
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(AppartmentsList.Appartments[comboBox1.SelectedIndex].Number,
                AppartmentsList.Appartments[comboBox1.SelectedIndex].Free,
                AppartmentsList.Appartments[comboBox1.SelectedIndex].Price,
                AppartmentsList.Appartments[comboBox1.SelectedIndex].CountRooms );
        }


        // Прибираємо фільтри по таблиці.
        private void RemoveFilterButton_MouseClick(object sender, MouseEventArgs e)
        {        
            dataGridView1.Rows.Clear();
            for (int i = 0; i < AppartmentsList.Appartments.Length; i++)
            {
                dataGridView1.Rows.Add("0000000" + i,
                    " Апартаменти - " + (AppartmentsList.Appartments[i].Number),
                    AppartmentsList.Appartments[i].CountRooms);
            }
        }

        // Кнопка закриття форми (повернення до головної форми).
        private void CloseButton_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        // Повертаємося до головної форми при закритті поточної
        private void CatalogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }        
    }
}
