
namespace EmployeeEngagement
{
    partial class AddActivity
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
            System.Windows.Forms.Label activityIdLabel;
            System.Windows.Forms.Label eventIdLabel;
            System.Windows.Forms.Label typeActivityIdLabel;
            System.Windows.Forms.Label dateLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxTypeAct = new System.Windows.Forms.ComboBox();
            this.codifierActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyActivityDataSet = new EmployeeEngagement.CompanyActivityDataSet();
            this.comboBoxEvent = new System.Windows.Forms.ComboBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.connectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKEmployeeToActivityActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityIdTextBox = new System.Windows.Forms.TextBox();
            this.eventIdTextBox = new System.Windows.Forms.TextBox();
            this.typeActivityIdTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.activityTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.ActivityTableAdapter();
            this.tableAdapterManager = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.TableAdapterManager();
            this.employeeTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.EmployeeTableAdapter();
            this.employeeToActivityTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.EmployeeToActivityTableAdapter();
            this.employeeToActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.EventTableAdapter();
            this.codifierActivityTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.CodifierActivityTableAdapter();
            activityIdLabel = new System.Windows.Forms.Label();
            eventIdLabel = new System.Windows.Forms.Label();
            typeActivityIdLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codifierActivityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyActivityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmployeeToActivityActivityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeToActivityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activityIdLabel
            // 
            activityIdLabel.AutoSize = true;
            activityIdLabel.Location = new System.Drawing.Point(20, 20);
            activityIdLabel.Name = "activityIdLabel";
            activityIdLabel.Size = new System.Drawing.Size(102, 17);
            activityIdLabel.TabIndex = 0;
            activityIdLabel.Text = "Id активности:";
            // 
            // eventIdLabel
            // 
            eventIdLabel.AutoSize = true;
            eventIdLabel.Location = new System.Drawing.Point(20, 48);
            eventIdLabel.Name = "eventIdLabel";
            eventIdLabel.Size = new System.Drawing.Size(102, 17);
            eventIdLabel.TabIndex = 2;
            eventIdLabel.Text = "Мероприятие:";
            // 
            // typeActivityIdLabel
            // 
            typeActivityIdLabel.AutoSize = true;
            typeActivityIdLabel.Location = new System.Drawing.Point(20, 76);
            typeActivityIdLabel.Name = "typeActivityIdLabel";
            typeActivityIdLabel.Size = new System.Drawing.Size(116, 17);
            typeActivityIdLabel.TabIndex = 4;
            typeActivityIdLabel.Text = "Тип активности:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(20, 105);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(46, 17);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "Дата:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBoxTypeAct);
            this.panel1.Controls.Add(this.comboBoxEvent);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(activityIdLabel);
            this.panel1.Controls.Add(this.activityIdTextBox);
            this.panel1.Controls.Add(eventIdLabel);
            this.panel1.Controls.Add(this.eventIdTextBox);
            this.panel1.Controls.Add(typeActivityIdLabel);
            this.panel1.Controls.Add(this.typeActivityIdTextBox);
            this.panel1.Controls.Add(dateLabel);
            this.panel1.Controls.Add(this.dateDateTimePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 384);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(390, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 100);
            this.panel2.TabIndex = 55;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.button1.Location = new System.Drawing.Point(324, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 34);
            this.button1.TabIndex = 35;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.button2.Location = new System.Drawing.Point(23, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 34);
            this.button2.TabIndex = 34;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxTypeAct
            // 
            this.comboBoxTypeAct.DataSource = this.codifierActivityBindingSource;
            this.comboBoxTypeAct.DisplayMember = "ActivityName";
            this.comboBoxTypeAct.FormattingEnabled = true;
            this.comboBoxTypeAct.Location = new System.Drawing.Point(148, 74);
            this.comboBoxTypeAct.Name = "comboBoxTypeAct";
            this.comboBoxTypeAct.Size = new System.Drawing.Size(200, 24);
            this.comboBoxTypeAct.TabIndex = 10;
            this.comboBoxTypeAct.ValueMember = "TypeActivityId";
            // 
            // codifierActivityBindingSource
            // 
            this.codifierActivityBindingSource.DataMember = "CodifierActivity";
            this.codifierActivityBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // companyActivityDataSet
            // 
            this.companyActivityDataSet.DataSetName = "CompanyActivityDataSet";
            this.companyActivityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxEvent
            // 
            this.comboBoxEvent.DataSource = this.eventBindingSource;
            this.comboBoxEvent.DisplayMember = "EventName";
            this.comboBoxEvent.FormattingEnabled = true;
            this.comboBoxEvent.Location = new System.Drawing.Point(148, 45);
            this.comboBoxEvent.Name = "comboBoxEvent";
            this.comboBoxEvent.Size = new System.Drawing.Size(200, 24);
            this.comboBoxEvent.TabIndex = 9;
            this.comboBoxEvent.ValueMember = "EventId";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            this.eventBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.connectIdDataGridViewTextBoxColumn,
            this.passportIdDataGridViewTextBoxColumn,
            this.activityIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKEmployeeToActivityActivityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(489, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // connectIdDataGridViewTextBoxColumn
            // 
            this.connectIdDataGridViewTextBoxColumn.DataPropertyName = "ConnectId";
            this.connectIdDataGridViewTextBoxColumn.HeaderText = "Id записи";
            this.connectIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.connectIdDataGridViewTextBoxColumn.Name = "connectIdDataGridViewTextBoxColumn";
            this.connectIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.connectIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // passportIdDataGridViewTextBoxColumn
            // 
            this.passportIdDataGridViewTextBoxColumn.DataPropertyName = "PassportId";
            this.passportIdDataGridViewTextBoxColumn.DataSource = this.employeeBindingSource;
            this.passportIdDataGridViewTextBoxColumn.DisplayMember = "PassportID";
            this.passportIdDataGridViewTextBoxColumn.HeaderText = "Паспорт сотрудника";
            this.passportIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passportIdDataGridViewTextBoxColumn.Name = "passportIdDataGridViewTextBoxColumn";
            this.passportIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.passportIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.passportIdDataGridViewTextBoxColumn.ValueMember = "PassportID";
            this.passportIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // activityIdDataGridViewTextBoxColumn
            // 
            this.activityIdDataGridViewTextBoxColumn.DataPropertyName = "ActivityId";
            this.activityIdDataGridViewTextBoxColumn.HeaderText = "ActivityId";
            this.activityIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.activityIdDataGridViewTextBoxColumn.Name = "activityIdDataGridViewTextBoxColumn";
            this.activityIdDataGridViewTextBoxColumn.Visible = false;
            this.activityIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // fKEmployeeToActivityActivityBindingSource
            // 
            this.fKEmployeeToActivityActivityBindingSource.DataMember = "FK_EmployeeToActivity_Activity";
            this.fKEmployeeToActivityActivityBindingSource.DataSource = this.activityBindingSource;
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataMember = "Activity";
            this.activityBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // activityIdTextBox
            // 
            this.activityIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "ActivityId", true));
            this.activityIdTextBox.Location = new System.Drawing.Point(148, 17);
            this.activityIdTextBox.Name = "activityIdTextBox";
            this.activityIdTextBox.Size = new System.Drawing.Size(200, 22);
            this.activityIdTextBox.TabIndex = 1;
            this.activityIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.activityIdTextBox_KeyPress);
            // 
            // eventIdTextBox
            // 
            this.eventIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "EventId", true));
            this.eventIdTextBox.Location = new System.Drawing.Point(417, 48);
            this.eventIdTextBox.Name = "eventIdTextBox";
            this.eventIdTextBox.Size = new System.Drawing.Size(200, 22);
            this.eventIdTextBox.TabIndex = 3;
            // 
            // typeActivityIdTextBox
            // 
            this.typeActivityIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "TypeActivityId", true));
            this.typeActivityIdTextBox.Location = new System.Drawing.Point(417, 76);
            this.typeActivityIdTextBox.Name = "typeActivityIdTextBox";
            this.typeActivityIdTextBox.Size = new System.Drawing.Size(200, 22);
            this.typeActivityIdTextBox.TabIndex = 5;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.activityBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(148, 101);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateDateTimePicker.TabIndex = 7;
            // 
            // activityTableAdapter
            // 
            this.activityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivityTableAdapter = this.activityTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CodifierActivityTableAdapter = null;
            this.tableAdapterManager.CodifierDepartmentTableAdapter = null;
            this.tableAdapterManager.CodifierFormatTableAdapter = null;
            this.tableAdapterManager.CodifierGenderTableAdapter = null;
            this.tableAdapterManager.CodifierPostTableAdapter = null;
            this.tableAdapterManager.CodifierStatusEventTableAdapter = null;
            this.tableAdapterManager.CodifierSubtypeEventTableAdapter = null;
            this.tableAdapterManager.CodifierTypeEventTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.EmployeeToActivityTableAdapter = this.employeeToActivityTableAdapter;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.HistoryForHRTableAdapter = null;
            this.tableAdapterManager.PostTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EmployeeEngagement.CompanyActivityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employeeToActivityTableAdapter
            // 
            this.employeeToActivityTableAdapter.ClearBeforeFill = true;
            // 
            // employeeToActivityBindingSource
            // 
            this.employeeToActivityBindingSource.DataMember = "EmployeeToActivity";
            this.employeeToActivityBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // codifierActivityTableAdapter
            // 
            this.codifierActivityTableAdapter.ClearBeforeFill = true;
            // 
            // AddActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 384);
            this.Controls.Add(this.panel1);
            this.Name = "AddActivity";
            this.Text = "Добавить активность";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codifierActivityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyActivityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmployeeToActivityActivityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeToActivityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CompanyActivityDataSet companyActivityDataSet;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private CompanyActivityDataSetTableAdapters.ActivityTableAdapter activityTableAdapter;
        private CompanyActivityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox activityIdTextBox;
        private System.Windows.Forms.TextBox eventIdTextBox;
        private System.Windows.Forms.TextBox typeActivityIdTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CompanyActivityDataSetTableAdapters.EmployeeToActivityTableAdapter employeeToActivityTableAdapter;
        private System.Windows.Forms.BindingSource employeeToActivityBindingSource;
        private System.Windows.Forms.BindingSource fKEmployeeToActivityActivityBindingSource;
        private CompanyActivityDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.ComboBox comboBoxTypeAct;
        private System.Windows.Forms.ComboBox comboBoxEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn passportIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private CompanyActivityDataSetTableAdapters.EventTableAdapter eventTableAdapter;
        private System.Windows.Forms.BindingSource codifierActivityBindingSource;
        private CompanyActivityDataSetTableAdapters.CodifierActivityTableAdapter codifierActivityTableAdapter;
        private System.Windows.Forms.Panel panel2;
    }
}