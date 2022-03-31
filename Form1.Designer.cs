
namespace EmployeeEngagement
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.filterStatus = new System.Windows.Forms.ComboBox();
            this.codifierStatusEventBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.companyActivityDataSet = new EmployeeEngagement.CompanyActivityDataSet();
            this.label16 = new System.Windows.Forms.Label();
            this.filterDate = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.filterType = new System.Windows.Forms.ComboBox();
            this.codifierSubtypeEventBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.filterFormat = new System.Windows.Forms.ComboBox();
            this.codifierFormatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.linkLabelHelp = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridViewEvent = new System.Windows.Forms.DataGridView();
            this.codifierFormatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codifierSubtypeEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codifierStatusEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkLabelAbout = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonCheckFIO = new System.Windows.Forms.Button();
            this.comboBoxFIO = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.MaskedTextBox();
            this.linkLabelSignUp = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.eventTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.EventTableAdapter();
            this.codifierFormatTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.CodifierFormatTableAdapter();
            this.codifierSubtypeEventTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.CodifierSubtypeEventTableAdapter();
            this.codifierStatusEventTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.CodifierStatusEventTableAdapter();
            this.fKEventCodifierFormatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonAllEvent = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codifierStatusEventBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyActivityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierSubtypeEventBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierFormatBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierFormatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierSubtypeEventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierStatusEventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKEventCodifierFormatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonAllEvent);
            this.panel1.Controls.Add(this.buttonFilter);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.filterStatus);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.filterDate);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.filterType);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.filterFormat);
            this.panel1.Controls.Add(this.linkLabelHelp);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dataGridViewEvent);
            this.panel1.Controls.Add(this.linkLabelAbout);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.buttonCheckFIO);
            this.panel1.Controls.Add(this.comboBoxFIO);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 755);
            this.panel1.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(33, 340);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 50);
            this.label19.TabIndex = 28;
            this.label19.Text = "Фильтры поиска";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(669, 342);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 21);
            this.label17.TabIndex = 26;
            this.label17.Text = "Статус";
            // 
            // filterStatus
            // 
            this.filterStatus.DataSource = this.codifierStatusEventBindingSource1;
            this.filterStatus.DisplayMember = "StatusName";
            this.filterStatus.FormattingEnabled = true;
            this.filterStatus.Location = new System.Drawing.Point(673, 366);
            this.filterStatus.Name = "filterStatus";
            this.filterStatus.Size = new System.Drawing.Size(165, 24);
            this.filterStatus.TabIndex = 25;
            this.filterStatus.ValueMember = "StatusId";
            // 
            // codifierStatusEventBindingSource1
            // 
            this.codifierStatusEventBindingSource1.DataMember = "CodifierStatusEvent";
            this.codifierStatusEventBindingSource1.DataSource = this.companyActivityDataSet;
            // 
            // companyActivityDataSet
            // 
            this.companyActivityDataSet.DataSetName = "CompanyActivityDataSet";
            this.companyActivityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(479, 342);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 21);
            this.label16.TabIndex = 24;
            this.label16.Text = "Дата";
            // 
            // filterDate
            // 
            this.filterDate.FormattingEnabled = true;
            this.filterDate.Items.AddRange(new object[] {
            "Прошедшие",
            "Предстоящие"});
            this.filterDate.Location = new System.Drawing.Point(483, 366);
            this.filterDate.Name = "filterDate";
            this.filterDate.Size = new System.Drawing.Size(173, 24);
            this.filterDate.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(315, 342);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 21);
            this.label15.TabIndex = 22;
            this.label15.Text = "Тип";
            // 
            // filterType
            // 
            this.filterType.DataSource = this.codifierSubtypeEventBindingSource1;
            this.filterType.DisplayMember = "SubtypeName";
            this.filterType.FormattingEnabled = true;
            this.filterType.Location = new System.Drawing.Point(319, 366);
            this.filterType.Name = "filterType";
            this.filterType.Size = new System.Drawing.Size(137, 24);
            this.filterType.TabIndex = 21;
            this.filterType.ValueMember = "SubtypeId";
            // 
            // codifierSubtypeEventBindingSource1
            // 
            this.codifierSubtypeEventBindingSource1.DataMember = "CodifierSubtypeEvent";
            this.codifierSubtypeEventBindingSource1.DataSource = this.companyActivityDataSet;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(152, 342);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 21);
            this.label14.TabIndex = 20;
            this.label14.Text = "Формат";
            // 
            // filterFormat
            // 
            this.filterFormat.DataSource = this.codifierFormatBindingSource1;
            this.filterFormat.DisplayMember = "FormatName";
            this.filterFormat.FormattingEnabled = true;
            this.filterFormat.Location = new System.Drawing.Point(156, 366);
            this.filterFormat.Name = "filterFormat";
            this.filterFormat.Size = new System.Drawing.Size(137, 24);
            this.filterFormat.TabIndex = 19;
            this.filterFormat.ValueMember = "FormatId";
            // 
            // codifierFormatBindingSource1
            // 
            this.codifierFormatBindingSource1.DataMember = "CodifierFormat";
            this.codifierFormatBindingSource1.DataSource = this.companyActivityDataSet;
            // 
            // linkLabelHelp
            // 
            this.linkLabelHelp.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.linkLabelHelp.AutoSize = true;
            this.linkLabelHelp.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.linkLabelHelp.LinkColor = System.Drawing.Color.Black;
            this.linkLabelHelp.Location = new System.Drawing.Point(968, 724);
            this.linkLabelHelp.Name = "linkLabelHelp";
            this.linkLabelHelp.Size = new System.Drawing.Size(127, 22);
            this.linkLabelHelp.TabIndex = 18;
            this.linkLabelHelp.TabStop = true;
            this.linkLabelHelp.Text = "Помочь мне";
            this.linkLabelHelp.Visible = false;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(12, 713);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1267, 2);
            this.label13.TabIndex = 17;
            // 
            // dataGridViewEvent
            // 
            this.dataGridViewEvent.AllowUserToAddRows = false;
            this.dataGridViewEvent.AllowUserToDeleteRows = false;
            this.dataGridViewEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvent.Location = new System.Drawing.Point(19, 457);
            this.dataGridViewEvent.Name = "dataGridViewEvent";
            this.dataGridViewEvent.ReadOnly = true;
            this.dataGridViewEvent.RowHeadersWidth = 51;
            this.dataGridViewEvent.RowTemplate.Height = 24;
            this.dataGridViewEvent.Size = new System.Drawing.Size(838, 240);
            this.dataGridViewEvent.TabIndex = 14;
            // 
            // codifierFormatBindingSource
            // 
            this.codifierFormatBindingSource.DataMember = "CodifierFormat";
            this.codifierFormatBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // codifierSubtypeEventBindingSource
            // 
            this.codifierSubtypeEventBindingSource.DataMember = "CodifierSubtypeEvent";
            this.codifierSubtypeEventBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // codifierStatusEventBindingSource
            // 
            this.codifierStatusEventBindingSource.DataMember = "CodifierStatusEvent";
            this.codifierStatusEventBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            this.eventBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // linkLabelAbout
            // 
            this.linkLabelAbout.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.linkLabelAbout.AutoSize = true;
            this.linkLabelAbout.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.linkLabelAbout.LinkColor = System.Drawing.Color.Black;
            this.linkLabelAbout.Location = new System.Drawing.Point(1124, 724);
            this.linkLabelAbout.Name = "linkLabelAbout";
            this.linkLabelAbout.Size = new System.Drawing.Size(152, 22);
            this.linkLabelAbout.TabIndex = 13;
            this.linkLabelAbout.TabStop = true;
            this.linkLabelAbout.Text = "О приложении";
            this.linkLabelAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(15, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(570, 23);
            this.label12.TabIndex = 8;
            this.label12.Text = "Узнайте о мероприятиях, организуемых предприятием";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(13, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 34);
            this.label11.TabIndex = 7;
            this.label11.Text = "Мероприятия";
            // 
            // buttonCheckFIO
            // 
            this.buttonCheckFIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.buttonCheckFIO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckFIO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttonCheckFIO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttonCheckFIO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttonCheckFIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckFIO.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.buttonCheckFIO.Location = new System.Drawing.Point(629, 155);
            this.buttonCheckFIO.Name = "buttonCheckFIO";
            this.buttonCheckFIO.Size = new System.Drawing.Size(172, 34);
            this.buttonCheckFIO.TabIndex = 6;
            this.buttonCheckFIO.Text = "Просмотр";
            this.buttonCheckFIO.UseVisualStyleBackColor = false;
            this.buttonCheckFIO.Click += new System.EventHandler(this.buttonCheckFIO_Click);
            // 
            // comboBoxFIO
            // 
            this.comboBoxFIO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxFIO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFIO.FormattingEnabled = true;
            this.comboBoxFIO.Location = new System.Drawing.Point(19, 161);
            this.comboBoxFIO.Name = "comboBoxFIO";
            this.comboBoxFIO.Size = new System.Drawing.Size(592, 24);
            this.comboBoxFIO.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(211)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBoxPassword);
            this.panel2.Controls.Add(this.linkLabelSignUp);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.buttonLogin);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBoxEmail);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(877, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 400);
            this.panel2.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(113, 177);
            this.textBoxPassword.Mask = "AAAAAAAA";
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(253, 22);
            this.textBoxPassword.TabIndex = 13;
            // 
            // linkLabelSignUp
            // 
            this.linkLabelSignUp.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(83)))));
            this.linkLabelSignUp.AutoSize = true;
            this.linkLabelSignUp.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.linkLabelSignUp.LinkColor = System.Drawing.Color.Black;
            this.linkLabelSignUp.Location = new System.Drawing.Point(89, 355);
            this.linkLabelSignUp.Name = "linkLabelSignUp";
            this.linkLabelSignUp.Size = new System.Drawing.Size(205, 22);
            this.linkLabelSignUp.TabIndex = 12;
            this.linkLabelSignUp.TabStop = true;
            this.linkLabelSignUp.Text = "Зарегистрироваться";
            this.linkLabelSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(4, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(378, 78);
            this.label10.TabIndex = 11;
            this.label10.Text = "Нет личного кабинета? Зарегистрируйтесь в системе, чтобы получить доступ ко всем " +
    "функциям";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttonLogin.FlatAppearance.BorderSize = 2;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.Location = new System.Drawing.Point(105, 223);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(180, 40);
            this.buttonLogin.TabIndex = 10;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Пароль:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(113, 118);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(253, 22);
            this.textBoxEmail.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(0, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(387, 2);
            this.label7.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(379, 52);
            this.label6.TabIndex = 6;
            this.label6.Text = "Войдите в свою учетную запись для получения расширенного функционала";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(89, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Вы HR-сотрудник?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Начните вводить свои ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Просмотреть свою активность";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1247, 2);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1180, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в систему по управлению вовлеченностью сотрудников";
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(19, 325);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(838, 118);
            this.label18.TabIndex = 27;
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // codifierFormatTableAdapter
            // 
            this.codifierFormatTableAdapter.ClearBeforeFill = true;
            // 
            // codifierSubtypeEventTableAdapter
            // 
            this.codifierSubtypeEventTableAdapter.ClearBeforeFill = true;
            // 
            // codifierStatusEventTableAdapter
            // 
            this.codifierStatusEventTableAdapter.ClearBeforeFill = true;
            // 
            // fKEventCodifierFormatBindingSource
            // 
            this.fKEventCodifierFormatBindingSource.DataMember = "FK_Event_CodifierFormat";
            this.fKEventCodifierFormatBindingSource.DataSource = this.codifierFormatBindingSource;
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.buttonFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttonFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttonFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilter.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFilter.Location = new System.Drawing.Point(37, 396);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(210, 34);
            this.buttonFilter.TabIndex = 29;
            this.buttonFilter.Text = "Просмотр";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonAllEvent
            // 
            this.buttonAllEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.buttonAllEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAllEvent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttonAllEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttonAllEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.buttonAllEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllEvent.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAllEvent.Location = new System.Drawing.Point(253, 396);
            this.buttonAllEvent.Name = "buttonAllEvent";
            this.buttonAllEvent.Size = new System.Drawing.Size(210, 34);
            this.buttonAllEvent.TabIndex = 30;
            this.buttonAllEvent.Text = "Все мероприятия";
            this.buttonAllEvent.UseVisualStyleBackColor = false;
            this.buttonAllEvent.Click += new System.EventHandler(this.buttonAllEvent_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1294, 755);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система для управления вовлеченностью сотрудников";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codifierStatusEventBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyActivityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierSubtypeEventBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierFormatBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierFormatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierSubtypeEventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierStatusEventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKEventCodifierFormatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.LinkLabel linkLabelSignUp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxFIO;
        private System.Windows.Forms.Button buttonCheckFIO;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridViewEvent;
        private System.Windows.Forms.LinkLabel linkLabelAbout;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel linkLabelHelp;
        private CompanyActivityDataSet companyActivityDataSet;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private CompanyActivityDataSetTableAdapters.EventTableAdapter eventTableAdapter;
        private System.Windows.Forms.MaskedTextBox textBoxPassword;
        private System.Windows.Forms.BindingSource codifierFormatBindingSource;
        private CompanyActivityDataSetTableAdapters.CodifierFormatTableAdapter codifierFormatTableAdapter;
        private System.Windows.Forms.BindingSource codifierSubtypeEventBindingSource;
        private CompanyActivityDataSetTableAdapters.CodifierSubtypeEventTableAdapter codifierSubtypeEventTableAdapter;
        private System.Windows.Forms.BindingSource codifierStatusEventBindingSource;
        private CompanyActivityDataSetTableAdapters.CodifierStatusEventTableAdapter codifierStatusEventTableAdapter;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox filterStatus;
        private System.Windows.Forms.BindingSource codifierSubtypeEventBindingSource1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox filterDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox filterType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox filterFormat;
        private System.Windows.Forms.BindingSource codifierFormatBindingSource1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.BindingSource fKEventCodifierFormatBindingSource;
        private System.Windows.Forms.BindingSource codifierStatusEventBindingSource1;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonAllEvent;
    }
}

