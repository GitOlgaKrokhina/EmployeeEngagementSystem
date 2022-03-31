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
    public partial class HrEmployeesForm : Form
    {
        public HrEmployeesForm()
        {
            InitializeComponent();
        }

        private void HrEmployeesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.CodifierGender". При необходимости она может быть перемещена или удалена.
            this.codifierGenderTableAdapter.Fill(this.companyActivityDataSet.CodifierGender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.companyActivityDataSet.Employee);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEmployee frm = new AddEmployee();
            frm.Show();
            this.employeeTableAdapter.Fill(this.companyActivityDataSet.Employee);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployee frm = new AddEmployee(employeeBindingSource.Position);
            frm.Show();
            this.employeeTableAdapter.Fill(this.companyActivityDataSet.Employee);
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                employeeBindingSource.RemoveCurrent();
                employeeTableAdapter.Update(companyActivityDataSet.Employee);
            }
        }
    }
}
