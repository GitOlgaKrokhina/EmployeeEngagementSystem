using Microsoft.Office.Interop.Excel;
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
    public partial class HrPageForm : Form
    {
        public static string cs =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CompanyActivity;Integrated Security=True;";
        public string email;
        public string password;
        public HrPageForm(string email, string password, string surname, string name, string middlename)
        {
            InitializeComponent();
            this.email = email;
            this.password = password;
            label2.Text = surname + " " + name + " " + middlename;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CodDepartmentsForm frmDep = new CodDepartmentsForm();
            frmDep.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CodPostForm frmPost = new CodPostForm();
            frmPost.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CodActiveForm frmAct = new CodActiveForm();
            frmAct.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CodTypeEventForm frmEvent = new CodTypeEventForm();
            frmEvent.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HrEmployeesForm empForm = new HrEmployeesForm();
            empForm.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HrEventForm frm = new HrEventForm();
            frm.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HrActivityForm frm = new HrActivityForm();
            frm.Show();
        }

        private void linkLabelRang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app =
        new Microsoft.Office.Interop.Excel.Application();

            app.Visible = true;

            Workbook wb = app.Workbooks.Add();
            Worksheet ws = wb.Worksheets[1];

            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CompanyActivity;Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT CONCAT(Employee.Surname,' ' ,Employee.Name,' ' ,Employee.MiddleName) as ФИО, Employee.Email as Email, Sum(CodifierActivity.Score) AS [Сумма баллов]
            FROM (CodifierActivity INNER JOIN (Activity  INNER JOIN (Employee INNER JOIN EmployeeToActivity 
            ON Employee.PassportID = EmployeeToActivity.PassportID) 
            ON Activity.ActivityId = EmployeeToActivity.ActivityId) 
            ON CodifierActivity.TypeActivityId = Activity.TypeActivityId) 
            GROUP BY Employee.Surname, Employee.Name, Employee.MiddleName, Employee.Email
            ORDER BY Sum(CodifierActivity.Score) DESC;", conn);

            SqlDataReader reader = cmd.ExecuteReader();

            ws.Cells[1, 1].Value = reader.GetName(0);
            ws.Cells[1, 2].Value = reader.GetName(1);
            ws.Cells[1, 3].Value = reader.GetName(2);

            int i = 2;
            while (reader.Read())
            {
                ws.Cells[i, 1].Value = reader[0];
                ws.Cells[i, 2].Value = reader[1];
                ws.Cells[i, 3].Value = reader[2];
                i++;
            }

            reader.Close();
            conn.Close();

        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string sql = @"SELECT MAX(zaprosMax.[Сумма баллов])
FROM (SELECT CONCAT(Employee.Surname,' ' ,Employee.Name,' ' ,Employee.MiddleName) as ФИО, Employee.Email as Email, Sum(CodifierActivity.Score) AS [Сумма баллов]
            FROM (CodifierActivity INNER JOIN (Activity  INNER JOIN (Employee INNER JOIN EmployeeToActivity 
            ON Employee.PassportID = EmployeeToActivity.PassportID) 
            ON Activity.ActivityId = EmployeeToActivity.ActivityId) 
            ON CodifierActivity.TypeActivityId = Activity.TypeActivityId) 
            GROUP BY Employee.Surname, Employee.Name, Employee.MiddleName, Employee.Email) as zaprosMax";

            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            var cmd = new SqlCommand(sql, cn);
            object result = cmd.ExecuteScalar();
            int a = Convert.ToInt32(result);
            cn.Close();
            bestEmployees(a);

        }

        private void bestEmployees(int maximum)
        {
            Microsoft.Office.Interop.Excel.Application app =
        new Microsoft.Office.Interop.Excel.Application();

            app.Visible = true;

            Workbook wb = app.Workbooks.Add();
            Worksheet ws = wb.Worksheets[1];

            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CompanyActivity;Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand($"SELECT topActivity.[ФИО], topActivity.[Сумма баллов], " +
                $"IIF(SumZnach>=0.90,N'Надбавка 15%',  " +
                $"IIF(SumZnach>=0.75,N'Надбавка 10%', " +
                $"IIF(SumZnach>=0.51,N'Надбавка 5%', '0%' ))) AS Поощрение " +
                $"FROM (SELECT ZAPROS.[ФИО], ZAPROS.Email, ZAPROS.[Сумма баллов], ROUND(CAST(ZAPROS.[Сумма баллов] as decimal)/{maximum}, 2) as SumZnach " +
                $"FROM (SELECT CONCAT(Employee.Surname,' ' ,Employee.Name,' ' ,Employee.MiddleName, ' ', Employee.Email) as ФИО, Employee.Email as Email, Sum(CodifierActivity.Score) AS [Сумма баллов] " +
                $"FROM (CodifierActivity INNER JOIN (Activity  " +
                $"INNER JOIN (Employee INNER JOIN EmployeeToActivity " +
                $"ON Employee.PassportID = EmployeeToActivity.PassportID) " +
                $"ON Activity.ActivityId = EmployeeToActivity.ActivityId) " +
                $"ON CodifierActivity.TypeActivityId = Activity.TypeActivityId) " +
                $"GROUP BY Employee.Surname, Employee.Name, Employee.MiddleName, Employee.Email) AS ZAPROS " +
                $"WHERE ROUND(CAST(ZAPROS.[Сумма баллов] as decimal)/{maximum}, 2) >= 0.45 ) as topActivity", conn);

            SqlDataReader reader = cmd.ExecuteReader();

            ws.Cells[1, 1].Value = reader.GetName(0);
            ws.Cells[1, 2].Value = reader.GetName(1);
            ws.Cells[1, 3].Value = reader.GetName(2);

            int i = 2;
            while (reader.Read())
            {
                ws.Cells[i, 1].Value = reader[0];
                ws.Cells[i, 2].Value = reader[1];
                ws.Cells[i, 3].Value = reader[2];
                i++;
            }

            reader.Close();
            conn.Close();
        }
        private void notBestEmployees(int maximum)
        {
            Microsoft.Office.Interop.Excel.Application app =
        new Microsoft.Office.Interop.Excel.Application();

            app.Visible = true;

            Workbook wb = app.Workbooks.Add();
            Worksheet ws = wb.Worksheets[1];

            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CompanyActivity;Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand($"SELECT topActivity.[ФИО], topActivity.[Сумма баллов], " +
                $"IIF(SumZnach<=0.15,N'Посетите HR-отдел ',   " +
                $"IIF(SumZnach<=0.30,N'Поучаствуйте в ближайших мероприятиях', " +
                $"IIF(SumZnach<=0.50,N'Проявляйте большую активность ', '0%'  ))) AS Поощрение " +
                $"FROM (SELECT ZAPROS.[ФИО], ZAPROS.Email, ZAPROS.[Сумма баллов], ROUND(CAST(ZAPROS.[Сумма баллов] as decimal)/{maximum}, 2) as SumZnach " +
                $"FROM (SELECT CONCAT(Employee.Surname,' ' ,Employee.Name,' ' ,Employee.MiddleName, ' ', Employee.Email) as ФИО, Employee.Email as Email, Sum(CodifierActivity.Score) AS [Сумма баллов] " +
                $"FROM (CodifierActivity INNER JOIN (Activity  " +
                $"INNER JOIN (Employee INNER JOIN EmployeeToActivity " +
                $"ON Employee.PassportID = EmployeeToActivity.PassportID) " +
                $"ON Activity.ActivityId = EmployeeToActivity.ActivityId) " +
                $"ON CodifierActivity.TypeActivityId = Activity.TypeActivityId) " +
                $"GROUP BY Employee.Surname, Employee.Name, Employee.MiddleName, Employee.Email) AS ZAPROS " +
                $"WHERE ROUND(CAST(ZAPROS.[Сумма баллов] as decimal)/{maximum}, 2) <=0.50) as topActivity", conn);

            SqlDataReader reader = cmd.ExecuteReader();

            ws.Cells[1, 1].Value = reader.GetName(0);
            ws.Cells[1, 2].Value = reader.GetName(1);
            ws.Cells[1, 3].Value = reader.GetName(2);

            int i = 2;
            while (reader.Read())
            {
                ws.Cells[i, 1].Value = reader[0];
                ws.Cells[i, 2].Value = reader[1];
                ws.Cells[i, 3].Value = reader[2];
                i++;
            }

            reader.Close();
            conn.Close();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string sql = @"SELECT MAX(zaprosMax.[Сумма баллов])
FROM (SELECT CONCAT(Employee.Surname,' ' ,Employee.Name,' ' ,Employee.MiddleName) as ФИО, Employee.Email as Email, Sum(CodifierActivity.Score) AS [Сумма баллов]
            FROM (CodifierActivity INNER JOIN (Activity  INNER JOIN (Employee INNER JOIN EmployeeToActivity 
            ON Employee.PassportID = EmployeeToActivity.PassportID) 
            ON Activity.ActivityId = EmployeeToActivity.ActivityId) 
            ON CodifierActivity.TypeActivityId = Activity.TypeActivityId) 
            GROUP BY Employee.Surname, Employee.Name, Employee.MiddleName, Employee.Email) as zaprosMax";

            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            var cmd = new SqlCommand(sql, cn);
            object result = cmd.ExecuteScalar();
            int a = Convert.ToInt32(result);
            cn.Close();
            notBestEmployees(a);
        }
    }
}
