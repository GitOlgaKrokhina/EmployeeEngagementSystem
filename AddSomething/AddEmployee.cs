using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeEngagement
{
    public partial class AddEmployee : Form
    {


        public AddEmployee()
        {
            InitializeComponent();
            this.codifierGenderTableAdapter.Fill(this.companyActivityDataSet.CodifierGender);
            this.codifierDepartmentTableAdapter.Fill(this.companyActivityDataSet.CodifierDepartment);
            this.codifierPostTableAdapter.Fill(this.companyActivityDataSet.CodifierPost);
            this.postTableAdapter.Fill(this.companyActivityDataSet.Post);
            this.employeeTableAdapter.Fill(this.companyActivityDataSet.Employee);

            employeeBindingSource.AddNew();
        }
        public AddEmployee(int index)
        {
            InitializeComponent();
            this.codifierGenderTableAdapter.Fill(this.companyActivityDataSet.CodifierGender);
            this.codifierDepartmentTableAdapter.Fill(this.companyActivityDataSet.CodifierDepartment);
            this.codifierPostTableAdapter.Fill(this.companyActivityDataSet.CodifierPost);
            this.postTableAdapter.Fill(this.companyActivityDataSet.Post);
            this.employeeTableAdapter.Fill(this.companyActivityDataSet.Employee);

            employeeBindingSource.Position = index;
        }

        //private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.employeeBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.companyActivityDataSet);

        //}

        //private void AddEmployee_Load(object sender, EventArgs e)
        //{
        //    // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.CodifierGender". При необходимости она может быть перемещена или удалена.
        //    this.codifierGenderTableAdapter.Fill(this.companyActivityDataSet.CodifierGender);
        //    // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.CodifierDepartment". При необходимости она может быть перемещена или удалена.
        //    this.codifierDepartmentTableAdapter.Fill(this.companyActivityDataSet.CodifierDepartment);
        //    // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.CodifierPost". При необходимости она может быть перемещена или удалена.
        //    this.codifierPostTableAdapter.Fill(this.companyActivityDataSet.CodifierPost);
        //    // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.Post". При необходимости она может быть перемещена или удалена.
        //    this.postTableAdapter.Fill(this.companyActivityDataSet.Post);
        //    // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.Employee". При необходимости она может быть перемещена или удалена.
        //    this.employeeTableAdapter.Fill(this.companyActivityDataSet.Employee);

        //}

        private void button2_Click(object sender, EventArgs e)
        {
            if(passportIDTextBox.Text==""|| nameTextBox.Text==""|| surnameTextBox.Text==""|| phoneTextBox.Text==""|| emailTextBox.Text=="")
            {
                MessageBox.Show("Заполнены не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (birthdateDateTimePicker.Value >= DateTime.Today)
            {
                MessageBox.Show("Выберите корректную дату рождения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Regex phReg = new Regex(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$");
                Regex emailReg = new Regex(@"^((\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)\s*[;]{0,1}\s*)+$");

                if (!phReg.IsMatch(phoneTextBox.Text) || !emailReg.IsMatch(emailTextBox.Text))
                {
                    if (!phReg.IsMatch(phoneTextBox.Text))
                    {
                        MessageBox.Show("Телефон введен в неверном формате, повторите ввод!");
                    }
                    if (!emailReg.IsMatch(emailTextBox.Text))
                    {
                        MessageBox.Show("Почта введена в неверном формате, повторите ввод! Образец: ivanivanov@mail.ru");
                    }
                }
                else
                {
                    try 
                    {
                        genderIDComboBox.Text = comboBox1.SelectedValue.ToString();
                        superUserTextBox.Text = "0";
                        employeeBindingSource.EndEdit();
                        employeeTableAdapter.Update(companyActivityDataSet.Employee);
                        postTableAdapter.Update(companyActivityDataSet.Post);
                    }
                    
                    catch (System.Data.ConstraintException)
                    {
                        MessageBox.Show("Учетная запись с таким номером паспорта уже имеется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        private void middleNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        private void passportIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
