using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeEngagement
{
    public partial class Registration : Form
    {
        public static string cs =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CompanyActivity;Integrated Security=True;";
        public Registration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(maskedTextBoxPassport.Text == "" || textBoxName.Text == "" || textBoxSurname.Text==""|| maskedTextBoxPassword.Text==""|| maskedTextBoxPhone.Text ==""|| textBoxEmail.Text=="")
            {
                MessageBox.Show("Заполнены не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateTimePicker1.Value >= DateTime.Today)
            {
                MessageBox.Show("Выберите корректную дату рождения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Regex phReg = new Regex(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$");
                Regex emailReg = new Regex(@"^((\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)\s*[;]{0,1}\s*)+$");

                if (!phReg.IsMatch(maskedTextBoxPhone.Text) || !emailReg.IsMatch(textBoxEmail.Text))
                {
                    if (!phReg.IsMatch(maskedTextBoxPhone.Text))
                    {
                        MessageBox.Show("Телефон введен в неверном формате, повторите ввод!");
                    }
                    if (!emailReg.IsMatch(textBoxEmail.Text))
                    {
                        MessageBox.Show("Почта введена в неверном формате, повторите ввод! Образец: ivanivanov@mail.ru");
                    }
                }
                else
                {
                    SqlConnection cn = new SqlConnection(cs);
                    cn.Open();
                    var sqlRequest = $"INSERT INTO Employee " +
                        $"(PassportID, Name, Surname, MiddleName, GenderID, Birthdate, SuperUser, Password, Phone, Email) " +
                        $"VALUES " +
                        $"({maskedTextBoxPassport.Text}, N'{textBoxName.Text}',N'{textBoxSurname.Text}',N'{textBoxMiddleName.Text}'," +
                        $"N'{comboBox1.SelectedValue}',N'{dateTimePicker1.Value.ToShortDateString()}',1,N'{maskedTextBoxPassword.Text}'," +
                        $"N'{maskedTextBoxPhone.Text}', N'{textBoxEmail.Text}')";
                    var cmd = new SqlCommand(sqlRequest, cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();


                    HrPageForm frmHR = new HrPageForm(textBoxEmail.Text, maskedTextBoxPassword.Text, textBoxSurname.Text, textBoxName.Text, textBoxMiddleName.Text);
                    frmHR.Show();
                }
            }

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.CodifierGender". При необходимости она может быть перемещена или удалена.
            this.codifierGenderTableAdapter.Fill(this.companyActivityDataSet.CodifierGender);

        }
        #region keypress
        private void textBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                e.Handled = true;
            if (e.KeyChar.Equals((char)13))
                textBoxName.Focus();
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                e.Handled = true;
            if (e.KeyChar.Equals((char)13))
                textBoxMiddleName.Focus();
        }

        private void textBoxMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                e.Handled = true;
            if (e.KeyChar.Equals((char)13))
                comboBox1.Focus();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
                dateTimePicker1.Focus();
        }

        private void maskedTextBoxPassport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (e.KeyChar.Equals((char)13))
                maskedTextBoxPhone.Focus();
        }

        private void maskedTextBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar.Equals((char)13))
                textBoxEmail.Focus();
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
                maskedTextBoxPassword.Focus();
        }

        private void maskedTextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
                buttonReg.Focus();
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
                maskedTextBoxPassport.Focus();
        }
        #endregion

    }
}
