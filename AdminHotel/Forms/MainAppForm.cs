using AdminHotel.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;
using System.Xml.Serialization;

namespace AdminHotel
{
    public partial class MainForm : Form
    {   
        public MainForm()
        {
            InitializeComponent();           
        }
        // При загрузці головної сторінки програми - заповнюємо таблицю та комбо бокс.
        private void MainForm_Load(object sender, EventArgs e)
        {
            AppartmentsComboBox.Items.Add("All");

            for (int i = 0; i < AppartmentsList.Appartments.Length; i++)
            {
                AppartmentsComboBox.Items.Add("Апартаменти - " + (AppartmentsList.Appartments[i].Number));

                if (AppartmentsList.Appartments[i].Name == "")
                {
                    dataGridView1.Rows.Add(AppartmentsList.Appartments[i].Number,
                        "Апартаменти - " + (AppartmentsList.Appartments[i].Number),
                        AppartmentsList.Appartments[i].Name, "", "",
                        AppartmentsList.Appartments[i].Bron );
                }
                else
                {
                    dataGridView1.Rows.Add(AppartmentsList.Appartments[i].Number,
                        "Апартаменти - " + (AppartmentsList.Appartments[i].Number),
                        AppartmentsList.Appartments[i].Name,
                        AppartmentsList.Appartments[i].CheckIn,
                        AppartmentsList.Appartments[i].CheckOut,
                        AppartmentsList.Appartments[i].Bron );
                }
            }

            AppartmentsComboBox.SelectedItem = AppartmentsComboBox.Items[0];
        }

        // Зміни відображення таблиці при виборах у комбо боксі.
        private void AppartmentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AppartmentsComboBox.SelectedIndex > 0)
            {
                dataGridView1.Rows.Clear();

                if (AppartmentsList.Appartments[AppartmentsComboBox.SelectedIndex - 1].Name == "")
                {
                    dataGridView1.Rows.Add(AppartmentsList.Appartments[AppartmentsComboBox.SelectedIndex - 1].Number,
                        "Апартаменти - " + (AppartmentsList.Appartments[AppartmentsComboBox.SelectedIndex - 1].Number),
                        AppartmentsList.Appartments[AppartmentsComboBox.SelectedIndex - 1].Name, "", "",
                        AppartmentsList.Appartments[AppartmentsComboBox.SelectedIndex - 1].Bron);
                }
                else
                {
                    dataGridView1.Rows.Add(AppartmentsList.Appartments[AppartmentsComboBox.SelectedIndex - 1].Number,
                        "Апартаменти - " + (AppartmentsList.Appartments[AppartmentsComboBox.SelectedIndex - 1].Number),
                        AppartmentsList.Appartments[AppartmentsComboBox.SelectedIndex - 1].Name,
                        AppartmentsList.Appartments[AppartmentsComboBox.SelectedIndex - 1].CheckIn,
                        AppartmentsList.Appartments[AppartmentsComboBox.SelectedIndex - 1].CheckOut,
                        AppartmentsList.Appartments[AppartmentsComboBox.SelectedIndex - 1].Bron);
                }
            }
            else
            {
                dataGridView1.Rows.Clear();

                for (int i = 0; i < AppartmentsList.Appartments.Length; i++)
                {
                    if (AppartmentsList.Appartments[i].Name == "")
                    {
                        dataGridView1.Rows.Add(AppartmentsList.Appartments[i].Number,
                            "Апартаменти - " + (AppartmentsList.Appartments[i].Number),
                            AppartmentsList.Appartments[i].Name, "", "",
                            AppartmentsList.Appartments[i].Bron);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(AppartmentsList.Appartments[i].Number,
                            "Апартаменти - " + (AppartmentsList.Appartments[i].Number),
                            AppartmentsList.Appartments[i].Name,
                            AppartmentsList.Appartments[i].CheckIn,
                            AppartmentsList.Appartments[i].CheckOut,
                            AppartmentsList.Appartments[i].Bron);
                    }
                }
            }
        }
        // Перевірка натискань на радіо кнопки та зміни таблиці після натискань (фільтри до таблиці)
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Enabled)
            {
                AppartmentsComboBox.SelectedItem = AppartmentsComboBox.Items[1];
                AppartmentsComboBox.SelectedItem = AppartmentsComboBox.Items[0];
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0;i < AppartmentsList.Appartments.Length; i++)
            {
                if(AppartmentsList.Appartments[i].Free == "free")
                {
                    if (AppartmentsList.Appartments[i].Name == "")
                    {
                        dataGridView1.Rows.Add(AppartmentsList.Appartments[i].Number,
                            "Апартаменти - " + (AppartmentsList.Appartments[i].Number),
                            AppartmentsList.Appartments[i].Name, "", "",
                            AppartmentsList.Appartments[i].Bron );
                    }
                    else
                    {
                        dataGridView1.Rows.Add(AppartmentsList.Appartments[i].Number,
                            "Апартаменти - " + (AppartmentsList.Appartments[i].Number),
                            AppartmentsList.Appartments[i].Name,
                            AppartmentsList.Appartments[i].CheckIn,
                            AppartmentsList.Appartments[i].CheckOut,
                            AppartmentsList.Appartments[i].Bron );
                    }
                }                
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < AppartmentsList.Appartments.Length; i++)
            {
                if (AppartmentsList.Appartments[i].Free == "nonFree")
                {
                    if (AppartmentsList.Appartments[i].Name == "")
                    {
                        dataGridView1.Rows.Add(AppartmentsList.Appartments[i].Number,
                            "Апартаменти - " + (AppartmentsList.Appartments[i].Number),
                            AppartmentsList.Appartments[i].Name, "", "",
                            AppartmentsList.Appartments[i].Bron );
                    }
                    else
                    {
                        dataGridView1.Rows.Add(AppartmentsList.Appartments[i].Number,
                            "Апартаменти - " + (AppartmentsList.Appartments[i].Number),
                            AppartmentsList.Appartments[i].Name,
                            AppartmentsList.Appartments[i].CheckIn,
                            AppartmentsList.Appartments[i].CheckOut,
                            AppartmentsList.Appartments[i].Bron );
                    }
                }
            }
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < AppartmentsList.Appartments.Length; i++)
            {
                if (AppartmentsList.Appartments[i].Bron)
                {
                    if (AppartmentsList.Appartments[i].Name == "")
                    {
                        dataGridView1.Rows.Add(AppartmentsList.Appartments[i].Number,
                            "Апартаменти - " + (AppartmentsList.Appartments[i].Number),
                            AppartmentsList.Appartments[i].Name, "", "",
                            AppartmentsList.Appartments[i].Bron );
                    }
                    else
                    {
                        dataGridView1.Rows.Add(AppartmentsList.Appartments[i].Number,
                            "Апартаменти - " + (AppartmentsList.Appartments[i].Number),
                            AppartmentsList.Appartments[i].Name,
                            AppartmentsList.Appartments[i].CheckIn,
                            AppartmentsList.Appartments[i].CheckOut,
                            AppartmentsList.Appartments[i].Bron );
                    }
                }
            }
        }

        // Перехід до каталогу апартаментів
        private void AppartmentButton_Click(object sender, EventArgs e)
        {
            CatalogForm form = new CatalogForm();
            form.Show();
            Hide();
        }

        // Перехід до форми контрагентів
        private void ContrAgentButton_Click(object sender, EventArgs e)
        {
            ContrAgentForm contrAgentForm = new ContrAgentForm();
            contrAgentForm.Show();
            Hide();
        }

        // Перехід до форми регістрації
        private void BookingButton_Click(object sender, EventArgs e)
        {
            BookingForm bookingForm = new BookingForm();
            bookingForm.Show();
            Hide();
        }

        // Перевірка двійного натискання на певну секцію таблиці
        // для відображення форми регістрації таким шляхом
        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 1 && AppartmentsList.Appartments[e.RowIndex].Name == "")
                {
                    BookingForm bookingForm = new BookingForm();
                    bookingForm.Show();
                    Hide();
                }                
            }            
        }

        // Перевіряємо натискання на секцію таблиці
        // Для видалення(виселення людини) із таблиці(отелю)
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6 && AppartmentsList.Appartments[e.RowIndex].Name != "")
                {
                    AppartmentsList.Appartments[e.RowIndex].Name = "";
                    AppartmentsList.Appartments[e.RowIndex].Inn = "";
                    AppartmentsList.Appartments[e.RowIndex].Free = "free";
                    AppartmentsList.Appartments[e.RowIndex].Bron = false;

                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < AppartmentsList.Appartments.Length; i++)
                    {
                        if (AppartmentsList.Appartments[i].Name == "")
                        {
                            dataGridView1.Rows.Add(AppartmentsList.Appartments[i].Number,
                                "Апартаменти - " + (AppartmentsList.Appartments[i].Number),
                                AppartmentsList.Appartments[i].Name, "", "",
                                AppartmentsList.Appartments[i].Bron);
                        }
                        else
                        {
                            dataGridView1.Rows.Add(AppartmentsList.Appartments[i].Number,
                                "Апартаменти - " + (AppartmentsList.Appartments[i].Number),
                                AppartmentsList.Appartments[i].Name,
                                AppartmentsList.Appartments[i].CheckIn,
                                AppartmentsList.Appartments[i].CheckOut,
                                AppartmentsList.Appartments[i].Bron);
                        }
                    }
                    AppartmentsList.IsChanged = true;
                }
            }
        }

        // Визиваємо діалогове вікно (для збереження) якщо були зміни у програмі
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AppartmentsList.IsChanged)
            {
                SaveDialogForm saveDialogForm = new SaveDialogForm();
                saveDialogForm.ShowDialog();
            }
            else
            {
                Application.Exit();
            }                    
        }
    }
}
