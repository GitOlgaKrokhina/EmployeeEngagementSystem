
namespace EmployeeEngagement
{
    partial class HrEventForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.companyActivityDataSet = new EmployeeEngagement.CompanyActivityDataSet();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.EventTableAdapter();
            this.codifierFormatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codifierFormatTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.CodifierFormatTableAdapter();
            this.codifierSubtypeEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codifierSubtypeEventTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.CodifierSubtypeEventTableAdapter();
            this.codifierStatusEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codifierStatusEventTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.CodifierStatusEventTableAdapter();
            this.eventIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.subtypeEventIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.eventDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buttoncreate = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyActivityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierFormatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierSubtypeEventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierStatusEventBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttondelete);
            this.panel1.Controls.Add(this.buttonupdate);
            this.panel1.Controls.Add(this.buttoncreate);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 450);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Меропрития";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(0, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1020, 2);
            this.label3.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventIdDataGridViewTextBoxColumn,
            this.eventNameDataGridViewTextBoxColumn,
            this.formatIdDataGridViewTextBoxColumn,
            this.subtypeEventIdDataGridViewTextBoxColumn,
            this.eventDateDataGridViewTextBoxColumn,
            this.eventStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eventBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 298);
            this.dataGridView1.TabIndex = 33;
            // 
            // companyActivityDataSet
            // 
            this.companyActivityDataSet.DataSetName = "CompanyActivityDataSet";
            this.companyActivityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            this.eventBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // codifierFormatBindingSource
            // 
            this.codifierFormatBindingSource.DataMember = "CodifierFormat";
            this.codifierFormatBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // codifierFormatTableAdapter
            // 
            this.codifierFormatTableAdapter.ClearBeforeFill = true;
            // 
            // codifierSubtypeEventBindingSource
            // 
            this.codifierSubtypeEventBindingSource.DataMember = "CodifierSubtypeEvent";
            this.codifierSubtypeEventBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // codifierSubtypeEventTableAdapter
            // 
            this.codifierSubtypeEventTableAdapter.ClearBeforeFill = true;
            // 
            // codifierStatusEventBindingSource
            // 
            this.codifierStatusEventBindingSource.DataMember = "CodifierStatusEvent";
            this.codifierStatusEventBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // codifierStatusEventTableAdapter
            // 
            this.codifierStatusEventTableAdapter.ClearBeforeFill = true;
            // 
            // eventIdDataGridViewTextBoxColumn
            // 
            this.eventIdDataGridViewTextBoxColumn.DataPropertyName = "EventId";
            this.eventIdDataGridViewTextBoxColumn.HeaderText = "EventId";
            this.eventIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eventIdDataGridViewTextBoxColumn.Name = "eventIdDataGridViewTextBoxColumn";
            this.eventIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventIdDataGridViewTextBoxColumn.Visible = false;
            this.eventIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // eventNameDataGridViewTextBoxColumn
            // 
            this.eventNameDataGridViewTextBoxColumn.DataPropertyName = "EventName";
            this.eventNameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.eventNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eventNameDataGridViewTextBoxColumn.Name = "eventNameDataGridViewTextBoxColumn";
            this.eventNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // formatIdDataGridViewTextBoxColumn
            // 
            this.formatIdDataGridViewTextBoxColumn.DataPropertyName = "FormatId";
            this.formatIdDataGridViewTextBoxColumn.DataSource = this.codifierFormatBindingSource;
            this.formatIdDataGridViewTextBoxColumn.DisplayMember = "FormatName";
            this.formatIdDataGridViewTextBoxColumn.HeaderText = "Формат";
            this.formatIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.formatIdDataGridViewTextBoxColumn.Name = "formatIdDataGridViewTextBoxColumn";
            this.formatIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.formatIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.formatIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.formatIdDataGridViewTextBoxColumn.ValueMember = "FormatId";
            this.formatIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // subtypeEventIdDataGridViewTextBoxColumn
            // 
            this.subtypeEventIdDataGridViewTextBoxColumn.DataPropertyName = "SubtypeEventId";
            this.subtypeEventIdDataGridViewTextBoxColumn.DataSource = this.codifierSubtypeEventBindingSource;
            this.subtypeEventIdDataGridViewTextBoxColumn.DisplayMember = "SubtypeName";
            this.subtypeEventIdDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.subtypeEventIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subtypeEventIdDataGridViewTextBoxColumn.Name = "subtypeEventIdDataGridViewTextBoxColumn";
            this.subtypeEventIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.subtypeEventIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.subtypeEventIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.subtypeEventIdDataGridViewTextBoxColumn.ValueMember = "SubtypeId";
            this.subtypeEventIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // eventDateDataGridViewTextBoxColumn
            // 
            this.eventDateDataGridViewTextBoxColumn.DataPropertyName = "EventDate";
            this.eventDateDataGridViewTextBoxColumn.HeaderText = "Дата проведения";
            this.eventDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eventDateDataGridViewTextBoxColumn.Name = "eventDateDataGridViewTextBoxColumn";
            this.eventDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // eventStatusDataGridViewTextBoxColumn
            // 
            this.eventStatusDataGridViewTextBoxColumn.DataPropertyName = "EventStatus";
            this.eventStatusDataGridViewTextBoxColumn.DataSource = this.codifierStatusEventBindingSource;
            this.eventStatusDataGridViewTextBoxColumn.DisplayMember = "StatusName";
            this.eventStatusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.eventStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eventStatusDataGridViewTextBoxColumn.Name = "eventStatusDataGridViewTextBoxColumn";
            this.eventStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventStatusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eventStatusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eventStatusDataGridViewTextBoxColumn.ValueMember = "StatusId";
            this.eventStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // buttoncreate
            // 
            this.buttoncreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.buttoncreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoncreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttoncreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttoncreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttoncreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncreate.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.buttoncreate.Location = new System.Drawing.Point(18, 389);
            this.buttoncreate.Name = "buttoncreate";
            this.buttoncreate.Size = new System.Drawing.Size(279, 34);
            this.buttoncreate.TabIndex = 34;
            this.buttoncreate.Text = "Добавить мероприятие";
            this.buttoncreate.UseVisualStyleBackColor = false;
            this.buttoncreate.Click += new System.EventHandler(this.buttoncreate_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.buttonupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonupdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttonupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttonupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttonupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonupdate.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.buttonupdate.Location = new System.Drawing.Point(303, 389);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(279, 34);
            this.buttonupdate.TabIndex = 35;
            this.buttonupdate.Text = "Изменить данные";
            this.buttonupdate.UseVisualStyleBackColor = false;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.buttondelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttondelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttondelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttondelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondelete.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.buttondelete.Location = new System.Drawing.Point(588, 389);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(279, 34);
            this.buttondelete.TabIndex = 36;
            this.buttondelete.Text = "Удалить мероприятие";
            this.buttondelete.UseVisualStyleBackColor = false;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // HrEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.panel1);
            this.Name = "HrEventForm";
            this.Text = "Мероприятия";
            this.Load += new System.EventHandler(this.HrEventForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyActivityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierFormatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierSubtypeEventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierStatusEventBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CompanyActivityDataSet companyActivityDataSet;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private CompanyActivityDataSetTableAdapters.EventTableAdapter eventTableAdapter;
        private System.Windows.Forms.BindingSource codifierFormatBindingSource;
        private CompanyActivityDataSetTableAdapters.CodifierFormatTableAdapter codifierFormatTableAdapter;
        private System.Windows.Forms.BindingSource codifierSubtypeEventBindingSource;
        private CompanyActivityDataSetTableAdapters.CodifierSubtypeEventTableAdapter codifierSubtypeEventTableAdapter;
        private System.Windows.Forms.BindingSource codifierStatusEventBindingSource;
        private CompanyActivityDataSetTableAdapters.CodifierStatusEventTableAdapter codifierStatusEventTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn formatIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn subtypeEventIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn eventStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttoncreate;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttondelete;
    }
}