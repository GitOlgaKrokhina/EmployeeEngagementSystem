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
    public partial class CodPostForm : Form
    {
        public CodPostForm()
        {
            InitializeComponent();
        }

        private void CodPostForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.CodifierPost". При необходимости она может быть перемещена или удалена.
            this.codifierPostTableAdapter.Fill(this.companyActivityDataSet.CodifierPost);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            codifierPostTableAdapter.Update(companyActivityDataSet.CodifierPost);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Вы заполнили не все столбцы. Повторите ввод!");
            e.ThrowException = false;
        }
    }
}
