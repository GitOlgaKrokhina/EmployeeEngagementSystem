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
    public partial class CodDepartmentsForm : Form
    {
        public CodDepartmentsForm()
        {
            InitializeComponent();
        }

        private void CodDepartmentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.CodifierDepartment". При необходимости она может быть перемещена или удалена.
            this.codifierDepartmentTableAdapter.Fill(this.companyActivityDataSet.CodifierDepartment);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            codifierDepartmentTableAdapter.Update(companyActivityDataSet.CodifierDepartment);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Вы заполнили не все столбцы. Повторите ввод!");
            e.ThrowException = false;
        }
    }
}
