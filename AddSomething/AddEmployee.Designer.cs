
namespace EmployeeEngagement
{
    partial class AddEmployee
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
            System.Windows.Forms.Label passportIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label genderIDLabel;
            System.Windows.Forms.Label birthdateLabel;
            System.Windows.Forms.Label superUserLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label label1;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.codifierGenderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyActivityDataSet = new EmployeeEngagement.CompanyActivityDataSet();
            this.passportIDTextBox = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.genderIDComboBox = new System.Windows.Forms.ComboBox();
            this.birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.superUserTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeNumberIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.codifierPostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.codifierDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateEmploymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDismissalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKPostEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.TableAdapterManager();
            this.codifierDepartmentTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.CodifierDepartmentTableAdapter();
            this.codifierGenderTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.CodifierGenderTableAdapter();
            this.codifierPostTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.CodifierPostTableAdapter();
            this.postTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.PostTableAdapter();
            this.codifierGenderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.codifierGenderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            passportIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            genderIDLabel = new System.Windows.Forms.Label();
            birthdateLabel = new System.Windows.Forms.Label();
            superUserLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codifierGenderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyActivityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierPostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPostEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierGenderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierGenderBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // passportIDLabel
            // 
            passportIDLabel.AutoSize = true;
            passportIDLabel.Location = new System.Drawing.Point(29, 23);
            passportIDLabel.Name = "passportIDLabel";
            passportIDLabel.Size = new System.Drawing.Size(68, 17);
            passportIDLabel.TabIndex = 34;
            passportIDLabel.Text = "Паспорт:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(29, 51);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(39, 17);
            nameLabel.TabIndex = 36;
            nameLabel.Text = "Имя:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(29, 79);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(74, 17);
            surnameLabel.TabIndex = 38;
            surnameLabel.Text = "Фамилия:";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new System.Drawing.Point(29, 107);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(75, 17);
            middleNameLabel.TabIndex = 40;
            middleNameLabel.Text = "Отчество:";
            // 
            // genderIDLabel
            // 
            genderIDLabel.AutoSize = true;
            genderIDLabel.Location = new System.Drawing.Point(29, 139);
            genderIDLabel.Name = "genderIDLabel";
            genderIDLabel.Size = new System.Drawing.Size(38, 17);
            genderIDLabel.TabIndex = 42;
            genderIDLabel.Text = "Пол:";
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.Location = new System.Drawing.Point(29, 168);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new System.Drawing.Size(115, 17);
            birthdateLabel.TabIndex = 44;
            birthdateLabel.Text = "Дата рождения:";
            // 
            // superUserLabel
            // 
            superUserLabel.AutoSize = true;
            superUserLabel.Location = new System.Drawing.Point(550, 20);
            superUserLabel.Name = "superUserLabel";
            superUserLabel.Size = new System.Drawing.Size(100, 17);
            superUserLabel.TabIndex = 46;
            superUserLabel.Text = "Hr-сотрудник:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(29, 199);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(72, 17);
            phoneLabel.TabIndex = 48;
            phoneLabel.Text = "Телефон:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(29, 227);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 50;
            emailLabel.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(550, 58);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 17);
            label1.TabIndex = 53;
            label1.Text = "Код пола:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(passportIDLabel);
            this.panel1.Controls.Add(this.passportIDTextBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(surnameLabel);
            this.panel1.Controls.Add(this.surnameTextBox);
            this.panel1.Controls.Add(middleNameLabel);
            this.panel1.Controls.Add(this.middleNameTextBox);
            this.panel1.Controls.Add(genderIDLabel);
            this.panel1.Controls.Add(this.genderIDComboBox);
            this.panel1.Controls.Add(birthdateLabel);
            this.panel1.Controls.Add(this.birthdateDateTimePicker);
            this.panel1.Controls.Add(superUserLabel);
            this.panel1.Controls.Add(this.superUserTextBox);
            this.panel1.Controls.Add(phoneLabel);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 503);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(553, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 100);
            this.panel2.TabIndex = 54;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.codifierGenderBindingSource;
            this.comboBox1.DisplayMember = "GenderName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 52;
            this.comboBox1.ValueMember = "GenderId";
            // 
            // codifierGenderBindingSource
            // 
            this.codifierGenderBindingSource.DataMember = "CodifierGender";
            this.codifierGenderBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // companyActivityDataSet
            // 
            this.companyActivityDataSet.DataSetName = "CompanyActivityDataSet";
            this.companyActivityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passportIDTextBox
            // 
            this.passportIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "PassportID", true));
            this.passportIDTextBox.Location = new System.Drawing.Point(160, 20);
            this.passportIDTextBox.Name = "passportIDTextBox";
            this.passportIDTextBox.Size = new System.Drawing.Size(200, 22);
            this.passportIDTextBox.TabIndex = 35;
            this.passportIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passportIDTextBox_KeyPress);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(160, 48);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox.TabIndex = 37;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(160, 76);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(200, 22);
            this.surnameTextBox.TabIndex = 39;
            this.surnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBox_KeyPress);
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "MiddleName", true));
            this.middleNameTextBox.Location = new System.Drawing.Point(160, 104);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.middleNameTextBox.TabIndex = 41;
            this.middleNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.middleNameTextBox_KeyPress);
            // 
            // genderIDComboBox
            // 
            this.genderIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "GenderID", true));
            this.genderIDComboBox.FormattingEnabled = true;
            this.genderIDComboBox.Location = new System.Drawing.Point(656, 51);
            this.genderIDComboBox.Name = "genderIDComboBox";
            this.genderIDComboBox.Size = new System.Drawing.Size(200, 24);
            this.genderIDComboBox.TabIndex = 43;
            // 
            // birthdateDateTimePicker
            // 
            this.birthdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource, "Birthdate", true));
            this.birthdateDateTimePicker.Location = new System.Drawing.Point(160, 163);
            this.birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            this.birthdateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.birthdateDateTimePicker.TabIndex = 45;
            // 
            // superUserTextBox
            // 
            this.superUserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "SuperUser", true));
            this.superUserTextBox.Location = new System.Drawing.Point(656, 20);
            this.superUserTextBox.Name = "superUserTextBox";
            this.superUserTextBox.ReadOnly = true;
            this.superUserTextBox.Size = new System.Drawing.Size(200, 22);
            this.superUserTextBox.TabIndex = 47;
            this.superUserTextBox.Text = "0";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(160, 196);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 22);
            this.phoneTextBox.TabIndex = 49;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(160, 224);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 22);
            this.emailTextBox.TabIndex = 51;
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
            this.button1.Location = new System.Drawing.Point(385, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 34);
            this.button1.TabIndex = 34;
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
            this.button2.Location = new System.Drawing.Point(32, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 34);
            this.button2.TabIndex = 33;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeNumberIdDataGridViewTextBoxColumn,
            this.passportIdDataGridViewTextBoxColumn,
            this.postIdDataGridViewTextBoxColumn,
            this.departmentIdDataGridViewTextBoxColumn,
            this.dateEmploymentDataGridViewTextBoxColumn,
            this.dateDismissalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKPostEmployeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(824, 162);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // employeeNumberIdDataGridViewTextBoxColumn
            // 
            this.employeeNumberIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeNumberId";
            this.employeeNumberIdDataGridViewTextBoxColumn.HeaderText = "Табельный номер";
            this.employeeNumberIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeNumberIdDataGridViewTextBoxColumn.Name = "employeeNumberIdDataGridViewTextBoxColumn";
            this.employeeNumberIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeNumberIdDataGridViewTextBoxColumn.Visible = false;
            this.employeeNumberIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // passportIdDataGridViewTextBoxColumn
            // 
            this.passportIdDataGridViewTextBoxColumn.DataPropertyName = "PassportId";
            this.passportIdDataGridViewTextBoxColumn.HeaderText = "Паспорт";
            this.passportIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passportIdDataGridViewTextBoxColumn.Name = "passportIdDataGridViewTextBoxColumn";
            this.passportIdDataGridViewTextBoxColumn.Visible = false;
            this.passportIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // postIdDataGridViewTextBoxColumn
            // 
            this.postIdDataGridViewTextBoxColumn.DataPropertyName = "PostId";
            this.postIdDataGridViewTextBoxColumn.DataSource = this.codifierPostBindingSource;
            this.postIdDataGridViewTextBoxColumn.DisplayMember = "PostName";
            this.postIdDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.postIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postIdDataGridViewTextBoxColumn.Name = "postIdDataGridViewTextBoxColumn";
            this.postIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.postIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.postIdDataGridViewTextBoxColumn.ValueMember = "PostId";
            this.postIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // codifierPostBindingSource
            // 
            this.codifierPostBindingSource.DataMember = "CodifierPost";
            this.codifierPostBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // departmentIdDataGridViewTextBoxColumn
            // 
            this.departmentIdDataGridViewTextBoxColumn.DataPropertyName = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.DataSource = this.codifierDepartmentBindingSource;
            this.departmentIdDataGridViewTextBoxColumn.DisplayMember = "DepartmentName";
            this.departmentIdDataGridViewTextBoxColumn.HeaderText = "Отдел";
            this.departmentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentIdDataGridViewTextBoxColumn.Name = "departmentIdDataGridViewTextBoxColumn";
            this.departmentIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.departmentIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.departmentIdDataGridViewTextBoxColumn.ValueMember = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // codifierDepartmentBindingSource
            // 
            this.codifierDepartmentBindingSource.DataMember = "CodifierDepartment";
            this.codifierDepartmentBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // dateEmploymentDataGridViewTextBoxColumn
            // 
            this.dateEmploymentDataGridViewTextBoxColumn.DataPropertyName = "DateEmployment";
            this.dateEmploymentDataGridViewTextBoxColumn.HeaderText = "Начало работы";
            this.dateEmploymentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateEmploymentDataGridViewTextBoxColumn.Name = "dateEmploymentDataGridViewTextBoxColumn";
            this.dateEmploymentDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDismissalDataGridViewTextBoxColumn
            // 
            this.dateDismissalDataGridViewTextBoxColumn.DataPropertyName = "DateDismissal";
            this.dateDismissalDataGridViewTextBoxColumn.HeaderText = "Дата увольнения";
            this.dateDismissalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDismissalDataGridViewTextBoxColumn.Name = "dateDismissalDataGridViewTextBoxColumn";
            this.dateDismissalDataGridViewTextBoxColumn.Width = 125;
            // 
            // fKPostEmployeeBindingSource
            // 
            this.fKPostEmployeeBindingSource.DataMember = "FK_Post_Employee";
            this.fKPostEmployeeBindingSource.DataSource = this.employeeBindingSource;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivityTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CodifierActivityTableAdapter = null;
            this.tableAdapterManager.CodifierDepartmentTableAdapter = this.codifierDepartmentTableAdapter;
            this.tableAdapterManager.CodifierFormatTableAdapter = null;
            this.tableAdapterManager.CodifierGenderTableAdapter = this.codifierGenderTableAdapter;
            this.tableAdapterManager.CodifierPostTableAdapter = this.codifierPostTableAdapter;
            this.tableAdapterManager.CodifierStatusEventTableAdapter = null;
            this.tableAdapterManager.CodifierSubtypeEventTableAdapter = null;
            this.tableAdapterManager.CodifierTypeEventTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.EmployeeToActivityTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.HistoryForHRTableAdapter = null;
            this.tableAdapterManager.PostTableAdapter = this.postTableAdapter;
            this.tableAdapterManager.UpdateOrder = EmployeeEngagement.CompanyActivityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // codifierDepartmentTableAdapter
            // 
            this.codifierDepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // codifierGenderTableAdapter
            // 
            this.codifierGenderTableAdapter.ClearBeforeFill = true;
            // 
            // codifierPostTableAdapter
            // 
            this.codifierPostTableAdapter.ClearBeforeFill = true;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // codifierGenderBindingSource1
            // 
            this.codifierGenderBindingSource1.DataMember = "CodifierGender";
            this.codifierGenderBindingSource1.DataSource = this.companyActivityDataSet;
            // 
            // codifierGenderBindingSource2
            // 
            this.codifierGenderBindingSource2.DataMember = "CodifierGender";
            this.codifierGenderBindingSource2.DataSource = this.companyActivityDataSet;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 503);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Text = "Добавление сотрудника";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codifierGenderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyActivityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierPostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPostEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierGenderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierGenderBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CompanyActivityDataSet companyActivityDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private CompanyActivityDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private CompanyActivityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CompanyActivityDataSetTableAdapters.PostTableAdapter postTableAdapter;
        private System.Windows.Forms.BindingSource fKPostEmployeeBindingSource;
        private CompanyActivityDataSetTableAdapters.CodifierPostTableAdapter codifierPostTableAdapter;
        private System.Windows.Forms.BindingSource codifierPostBindingSource;
        private CompanyActivityDataSetTableAdapters.CodifierDepartmentTableAdapter codifierDepartmentTableAdapter;
        private System.Windows.Forms.BindingSource codifierDepartmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNumberIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn postIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn departmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEmploymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDismissalDataGridViewTextBoxColumn;
        private CompanyActivityDataSetTableAdapters.CodifierGenderTableAdapter codifierGenderTableAdapter;
        private System.Windows.Forms.BindingSource codifierGenderBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox passportIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.ComboBox genderIDComboBox;
        private System.Windows.Forms.BindingSource codifierGenderBindingSource1;
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker;
        private System.Windows.Forms.TextBox superUserTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource codifierGenderBindingSource2;
        private System.Windows.Forms.Panel panel2;
    }
}