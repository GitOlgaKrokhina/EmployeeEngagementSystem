using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeEngagement
{
    public partial class AddEvent : Form
    {
        public AddEvent()
        {
            InitializeComponent();
            this.codifierStatusEventTableAdapter.Fill(this.companyActivityDataSet.CodifierStatusEvent);
            this.codifierSubtypeEventTableAdapter.Fill(this.companyActivityDataSet.CodifierSubtypeEvent);
            this.codifierFormatTableAdapter.Fill(this.companyActivityDataSet.CodifierFormat);
            this.eventTableAdapter.Fill(this.companyActivityDataSet.Event);

            eventBindingSource.AddNew();
        }

        public AddEvent(int index)
        {
            InitializeComponent();
            this.codifierStatusEventTableAdapter.Fill(this.companyActivityDataSet.CodifierStatusEvent);
            this.codifierSubtypeEventTableAdapter.Fill(this.companyActivityDataSet.CodifierSubtypeEvent);
            this.codifierFormatTableAdapter.Fill(this.companyActivityDataSet.CodifierFormat);
            this.eventTableAdapter.Fill(this.companyActivityDataSet.Event);

            eventBindingSource.Position = index;
        }

        private void eventBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.companyActivityDataSet);

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (eventIdTextBox.Text == "" || eventNameTextBox.Text == "" )
            {
                MessageBox.Show("Заполнены не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (eventDateDateTimePicker.Value == null)
            {
                MessageBox.Show("Выберите дату!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    formatIdTextBox.Text = comboBoxFormat.SelectedValue.ToString();
                    subtypeEventIdTextBox.Text = comboBoxType.SelectedValue.ToString();
                    eventStatusTextBox.Text = comboBoxStatus.SelectedValue.ToString();

                    eventBindingSource.EndEdit();
                    eventTableAdapter.Update(companyActivityDataSet.Event);
                }

                catch (System.Data.ConstraintException)
                {
                    MessageBox.Show("Запись о мероприятии с таким номером уже имеется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void eventIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
