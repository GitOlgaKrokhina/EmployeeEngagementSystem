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
    public partial class CodTypeEventForm : Form
    {
        public CodTypeEventForm()
        {
            InitializeComponent();
        }

        private void CodTypeEventForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.CodifierTypeEvent". При необходимости она может быть перемещена или удалена.
            this.codifierTypeEventTableAdapter.Fill(this.companyActivityDataSet.CodifierTypeEvent);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.CodifierSubtypeEvent". При необходимости она может быть перемещена или удалена.
            this.codifierSubtypeEventTableAdapter.Fill(this.companyActivityDataSet.CodifierSubtypeEvent);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            codifierSubtypeEventTableAdapter.Update(companyActivityDataSet.CodifierSubtypeEvent);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Вы заполнили не все столбцы. Повторите ввод!");
            e.ThrowException = false;
        }
    }
}
