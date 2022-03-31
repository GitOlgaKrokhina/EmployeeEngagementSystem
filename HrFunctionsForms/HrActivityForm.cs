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
    public partial class HrActivityForm : Form
    {
        public HrActivityForm()
        {
            InitializeComponent();
        }

        private void HrActivityForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.CodifierActivity". При необходимости она может быть перемещена или удалена.
            this.codifierActivityTableAdapter.Fill(this.companyActivityDataSet.CodifierActivity);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.Event". При необходимости она может быть перемещена или удалена.
            this.eventTableAdapter.Fill(this.companyActivityDataSet.Event);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "companyActivityDataSet.Activity". При необходимости она может быть перемещена или удалена.
            this.activityTableAdapter.Fill(this.companyActivityDataSet.Activity);

        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            AddActivity frm = new AddActivity(activityBindingSource.Position);
            frm.Show();
            this.activityTableAdapter.Fill(this.companyActivityDataSet.Activity);
        }

        private void buttoncreate_Click(object sender, EventArgs e)
        {
            AddActivity frm = new AddActivity();
            frm.Show();
            this.activityTableAdapter.Fill(this.companyActivityDataSet.Activity);
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                activityBindingSource.RemoveCurrent();
                activityTableAdapter.Update(companyActivityDataSet.Activity);
            }
        }
    }
}
