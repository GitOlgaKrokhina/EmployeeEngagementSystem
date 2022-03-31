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
    public partial class InfoEmployeeForm : Form
    {
        public static string cs =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CompanyActivity;Integrated Security=True;";
        public string name;
        public string surname;
        public string middlename;
        public string email;

        public InfoEmployeeForm(string fioPlusEmail)
        {
            InitializeComponent();
            labelInfo.Text = fioPlusEmail;
            String[] words = fioPlusEmail.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            this.surname = words[0];
            this.name = words[1];
            this.middlename = words[2];
            this.email = words[3];
            dataAdd();
            dataScore();
            dataActivity();
        }

        private void InfoEmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.Post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.companyActivityDataSet.Post);

        }
        private void dataAdd()
        {
            string sql = $"SELECT CodP.PostName as Должность, CodD.DepartmentName as Отдел, P.DateEmployment as 'Дата начала работы', P.DateDismissal as 'Дата увольнения'  " +
                $"FROM Post as P " +
                $"INNER JOIN Employee as E " +
                $"ON P.PassportId = E.PassportId " +
                $"INNER JOIN CodifierPost as CodP " +
                $"ON CodP.PostId = P.PostId " +
                $"INNER JOIN CodifierDepartment as CodD " +
                $"ON CodD.DepartmentId = P.DepartmentId " +
                $"WHERE Name = N'{name}' AND Email = N'{email}' AND Surname = N'{surname}' ";

            DataSet dataset = new DataSet();

            SqlDataAdapter dataAd = new SqlDataAdapter(sql, cs);
            dataAd.Fill(dataset);

            dataGridView1.DataSource = dataset.Tables[0];
        }

        private void dataScore()
        {
            string sql = $"SELECT Sum(CodA.Score) as Балл " +
                $"FROM Employee as E INNER JOIN EmployeeToActivity as EtoA  " +
                $"ON E.PassportId = EtoA.PassportId INNER JOIN Activity as A  " +
                $"ON A.ActivityId = EtoA.ActivityId INNER JOIN CodifierActivity as CodA  " +
                $"ON CodA.TypeActivityId = A.TypeActivityId INNER JOIN Event as Ev  " +
                $"ON Ev.EventId = A.EventId " +
                $"WHERE (Name = N'{name}' AND Email = N'{email}' AND Surname = N'{surname}')";

            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            var cmd = new SqlCommand(sql, cn);
            object result = cmd.ExecuteScalar();
            int a = Convert.ToInt32(result);
            cn.Close();
            label2.Text = a.ToString();

        }

        private void dataActivity()
        {
            string sql = $"SELECT Ev.EventName as Мероприятие, CodA.ActivityName as Активность, CodA.Score as Балл, A.Date as Дата " +
                $"FROM Employee as E " +
                $"INNER JOIN EmployeeToActivity as EtoA " +
                $"ON E.PassportId = EtoA.PassportId " +
                $"INNER JOIN Activity as A " +
                $"ON A.ActivityId = EtoA.ActivityId " +
                $"INNER JOIN CodifierActivity as CodA " +
                $"ON CodA.TypeActivityId = A.TypeActivityId " +
                $"INNER JOIN Event as Ev ON Ev.EventId = A.EventId " +
                $"WHERE Name = N'{name}' AND Email = N'{email}' AND Surname = N'{surname}' ";

            DataSet dataset = new DataSet();

            SqlDataAdapter dataAd = new SqlDataAdapter(sql, cs);
            dataAd.Fill(dataset);

            dataGridView2.DataSource = dataset.Tables[0];
        }

    }
}
