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
    public partial class HrEventForm : Form
    {
        public HrEventForm()
        {
            InitializeComponent();
        }

        private void HrEventForm_Load(object sender, EventArgs e)
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

        private void buttoncreate_Click(object sender, EventArgs e)
        {
            AddEvent frm = new AddEvent();
            frm.Show();
            this.eventTableAdapter.Fill(this.companyActivityDataSet.Event);
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            AddEvent frm = new AddEvent(eventBindingSource.Position);
            frm.Show();
            this.eventTableAdapter.Fill(this.companyActivityDataSet.Event);
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                eventBindingSource.RemoveCurrent();
                eventTableAdapter.Update(companyActivityDataSet.Event);
            }
        }
    }
}
