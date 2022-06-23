using System;
using AdminHotel.Forms;
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

        // При загрузці форми заповнюємо комбобокси.
        private void BookingForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < AppartmentsList.Appartments.Length; i++)
            {
                AppartmentsComboBox.Items.Add("Апартаменти - " + (AppartmentsList.Appartments[i].Number));
            }

            for (int i = 0; i < AppartmentsList.ContrAgents.Count; i++)
            {
                ContrAgentComboBox.Items.Add(AppartmentsList.ContrAgents[i].Name);
            }

        }

        // Перехід до форми контрагентів.
        private void ToContrAgentFormButton_Click(object sender, EventArgs e)
        {
            ContrAgentForm contrAgentForm = new ContrAgentForm();
            contrAgentForm.Show();
            Hide();
        }

        // Перевіряємо, щоб всі поля були вірно заповнені
        // Записуємо данні до апартаментів, Закриваємо форму
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CodeTextBox.Text == "" || CodeTextBox.Text.Length != 5)
            {
                MessageBox.Show("Заповніть поле!\n" +
                       "1. Поле 'Код' повинно бути заповненим!\n" +
                       "2. Поле 'Код' повинно містити 5 цифр!");
            } else if (AppartmentsComboBox.Text == "")
            {
                MessageBox.Show("Заповніть поле!\n" +
                       "1. Поле 'Номер апартаментів' повинен бути заповненим!");
            } else if (ContrAgentComboBox.Text == "")
            {
                MessageBox.Show("Заповніть поле!\n" +
                       "1. Поле 'Контрагент' повинно бути заповненим!");
            } else if (dateTimePicker2.Value.Day < DateTime.Now.Day)
            {
                MessageBox.Show("Заповніть поле!\n" +
                       "1. Поле 'Дата в'їзду' повинно бути сьогоднішним днем або піздніше!");
            } else if (dateTimePicker3.Value.Date <= dateTimePicker2.Value.Date)
            {
                MessageBox.Show("Заповніть поле!\n" +
                       "1. Поле 'Дата виїзду' повинно бути більше ніж поле 'Дата в'їзду'!");
            } else if (GuestsCountTextBox.Text == "" ||
                int.Parse(GuestsCountTextBox.Text) <= 0 ||
                int.Parse(GuestsCountTextBox.Text) >= 10)
            {
                MessageBox.Show("Заповніть поле!\n" +
                       "1. Поле 'Кількість гостей' повинно бути заповненим!\n" +
                       "2. Поле 'Кількість гостей' повинно мати реальну кількість (1 - 9)");
            }
            else
            {
                AppartmentsList.IsChanged = true;

                AppartmentsList.Appartments[AppartmentsComboBox.SelectedIndex].Name = ContrAgentComboBox.Text;
                AppartmentsList.Appartments[AppartmentsComboBox.SelectedIndex].CheckIn = dateTimePicker2.Value;
                AppartmentsList.Appartments[AppartmentsComboBox.SelectedIndex].CheckOut = dateTimePicker3.Value;
                AppartmentsList.Appartments[AppartmentsComboBox.SelectedIndex].Bron = checkBox1.Checked;
                AppartmentsList.Appartments[AppartmentsComboBox.SelectedIndex].Free = "nonFree";

                Close();
            }   
        }

        // Дозволяємо вводити тільки цифри у поле Код
        private void CodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

        // Дозволяємо вводти тільки цифри до поля Кількість гостей
        private void GuestCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

        // Закриваємо форму при натисканні відповідної кнопки.
        private void CloseButton_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        // При закритті поточної форми відкриваємо головну.
        private void BookingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
