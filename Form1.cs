using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeEngagement
{
    public partial class StartForm : Form
    {
        public static string cs =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CompanyActivity;Integrated Security=True;";
        public StartForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration frmReg = new Registration();
            frmReg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string em = textBoxEmail.Text;
            string pas = textBoxPassword.Text;
            string FIO = " ";
            string sql = $"SELECT CONCAT(E.Surname,' ',E.Name, ' ', E.MiddleName) as FIO " +
                             $"FROM Employee as E " +
                             $"WHERE E.Email = '{em}' AND E.Password = '{pas}' AND E.SuperUser = 1";

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FIO = reader["FIO"].ToString();
                        }
                    }
                }
                conn.Close();

            }


            if (FIO == " ")
            {
                MessageBox.Show("Учетной записи нет в базе. Проверьте введенные данные или зарегистрируйтесь!", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                String[] words = FIO.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                HrPageForm frmHR = new HrPageForm(em, pas, words[0], words[1], words[2]);
                frmHR.Show();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutSystemForm frmAbout = new AboutSystemForm();
            frmAbout.Show();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.CodifierStatusEvent". При необходимости она может быть перемещена или удалена.
            this.codifierStatusEventTableAdapter.Fill(this.companyActivityDataSet.CodifierStatusEvent);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.CodifierSubtypeEvent". При необходимости она может быть перемещена или удалена.
            this.codifierSubtypeEventTableAdapter.Fill(this.companyActivityDataSet.CodifierSubtypeEvent);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.CodifierFormat". При необходимости она может быть перемещена или удалена.
            this.codifierFormatTableAdapter.Fill(this.companyActivityDataSet.CodifierFormat);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.Event". При необходимости она может быть перемещена или удалена.
            this.eventTableAdapter.Fill(this.companyActivityDataSet.Event);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.eventTableAdapter.FillBy(this.companyActivityDataSet.Event);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void LoadData()
        {
            List<string> data = new List<string>();
            //SqlConnection myConnection = new SqlConnection(cs);

            //myConnection.Open();

            string sql = "SELECT CONCAT(E.Surname,' ',E.Name,' ', E.MiddleName, ' ',E.Email) as Stroka FROM Employee as E ";

            //SqlCommand command = new SqlCommand(query, myConnection);

            //SqlDataReader reader = command.ExecuteReader();

            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(reader["Stroka"].ToString());
                        }
                    }
                }
                conn.Close();
            }
            
            comboBoxFIO.DataSource = data;
            comboBoxFIO.SelectedIndex = -1;


        }

        private void buttonCheckFIO_Click(object sender, EventArgs e)
        {
            try
            {
                InfoEmployeeForm frm = new InfoEmployeeForm(comboBoxFIO.Text);
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите сотрудника из списка", "Ошибка поиска", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (filterDate.Text == "Прошедшие")
            {
                string sqlPred = $"SELECT E.EventName as Название, Form.FormatName as Формат, Sub.SubtypeName as Тип, " +
                            $"E.EventDate as Дата, Stat.StatusName as Статус " +
                         $"FROM Event as E  " +
                         $"INNER JOIN CodifierSubtypeEvent as Sub ON E.SubtypeEventId = Sub.SubtypeId " +
                         $"INNER JOIN CodifierStatusEvent as Stat ON E.EventStatus = Stat.StatusId " +
                         $"INNER JOIN CodifierFormat as Form ON E.FormatId = Form.FormatId " +
                         $"WHERE E.EventDate < GETDATE() AND E.FormatId = '{filterFormat.SelectedValue.ToString()}' " +
                         $"AND E.SubtypeEventId = '{filterType.SelectedValue.ToString()}' AND E.EventStatus = '{filterStatus.SelectedValue.ToString()}'";
                DataSet datasetPred = new DataSet();
                SqlDataAdapter dataAd = new SqlDataAdapter(sqlPred, cs);
                dataAd.Fill(datasetPred);

                dataGridViewEvent.DataSource = datasetPred.Tables[0];

            }
            else
            {
                string sqlPred = $"SELECT E.EventName as Название, Form.FormatName as Формат, Sub.SubtypeName as Тип, " +
                            $"E.EventDate as Дата, Stat.StatusName as Статус " +
                         $"FROM Event as E  " +
                         $"INNER JOIN CodifierSubtypeEvent as Sub ON E.SubtypeEventId = Sub.SubtypeId " +
                         $"INNER JOIN CodifierStatusEvent as Stat ON E.EventStatus = Stat.StatusId " +
                         $"INNER JOIN CodifierFormat as Form ON E.FormatId = Form.FormatId " +
                         $"WHERE E.EventDate > GETDATE() AND E.FormatId = '{filterFormat.SelectedValue.ToString()}' " +
                         $"AND E.SubtypeEventId = '{filterType.SelectedValue.ToString()}' AND E.EventStatus = '{filterStatus.SelectedValue.ToString()}'";
                DataSet datasetNext = new DataSet();
                SqlDataAdapter dataAd = new SqlDataAdapter(sqlPred, cs);
                dataAd.Fill(datasetNext);

                dataGridViewEvent.DataSource = datasetNext.Tables[0];
            }
            if (dataGridViewEvent.Rows.Count == 0)
            {
                MessageBox.Show("Мероприятия не найдены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonAllEvent_Click(object sender, EventArgs e)
        {
            string sqlPred = $"SELECT E.EventName as Название, Form.FormatName as Формат, Sub.SubtypeName as Тип, " +
                            $"E.EventDate as Дата, Stat.StatusName as Статус " +
                         $"FROM Event as E  " +
                         $"INNER JOIN CodifierSubtypeEvent as Sub ON E.SubtypeEventId = Sub.SubtypeId " +
                         $"INNER JOIN CodifierStatusEvent as Stat ON E.EventStatus = Stat.StatusId " +
                         $"INNER JOIN CodifierFormat as Form ON E.FormatId = Form.FormatId";
            DataSet datasetPred = new DataSet();
            SqlDataAdapter dataAd = new SqlDataAdapter(sqlPred, cs);
            dataAd.Fill(datasetPred);

            dataGridViewEvent.DataSource = datasetPred.Tables[0];
        }
    }
}
