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
    public partial class AddActivity : Form
    {
        public AddActivity()
        {
            InitializeComponent();
            this.employeeTableAdapter.Fill(this.companyActivityDataSet.Employee);
            this.employeeToActivityTableAdapter.Fill(this.companyActivityDataSet.EmployeeToActivity);
            this.activityTableAdapter.Fill(this.companyActivityDataSet.Activity);

            this.codifierActivityTableAdapter.Fill(this.companyActivityDataSet.CodifierActivity);
            this.eventTableAdapter.Fill(this.companyActivityDataSet.Event);

            activityBindingSource.AddNew();

        }
        public AddActivity(int index)
        {
            InitializeComponent();
            this.employeeTableAdapter.Fill(this.companyActivityDataSet.Employee);
            this.employeeToActivityTableAdapter.Fill(this.companyActivityDataSet.EmployeeToActivity);
            this.activityTableAdapter.Fill(this.companyActivityDataSet.Activity);

            this.codifierActivityTableAdapter.Fill(this.companyActivityDataSet.CodifierActivity);
            this.eventTableAdapter.Fill(this.companyActivityDataSet.Event);

            activityBindingSource.Position = index;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (activityIdTextBox.Text == "" )
            {
                MessageBox.Show("Заполнены не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateDateTimePicker.Value == null)
            {
                MessageBox.Show("Выберите дату!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    eventIdTextBox.Text = comboBoxEvent.SelectedValue.ToString();
                    typeActivityIdTextBox.Text = comboBoxTypeAct.SelectedValue.ToString();

                    activityBindingSource.EndEdit();
                    activityTableAdapter.Update(companyActivityDataSet.Activity);
                    employeeToActivityTableAdapter.Update(companyActivityDataSet.EmployeeToActivity);
                }

                catch (System.Data.ConstraintException)
                {
                    MessageBox.Show("Запись об активности с таким номером уже имеется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Данные введены неверно. Повторите ввод!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false;
        }

        private void activityIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
