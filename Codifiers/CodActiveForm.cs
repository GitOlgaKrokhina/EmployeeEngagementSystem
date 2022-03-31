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
    public partial class CodActiveForm : Form
    {
        public CodActiveForm()
        {
            InitializeComponent();
        }

        private void CodActiveForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.CodifierActivity". При необходимости она может быть перемещена или удалена.
            this.codifierActivityTableAdapter.Fill(this.companyActivityDataSet.CodifierActivity);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            codifierActivityTableAdapter.Update(companyActivityDataSet.CodifierActivity);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Вы заполнили не все столбцы или ввели не числовое значение в Балл. Повторите ввод!");
            e.ThrowException = false;
        }
    }
}
