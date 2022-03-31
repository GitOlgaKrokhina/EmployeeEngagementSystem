
namespace EmployeeEngagement
{
    partial class AddEvent
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
            System.Windows.Forms.Label eventNameLabel;
            System.Windows.Forms.Label formatIdLabel;
            System.Windows.Forms.Label subtypeEventIdLabel;
            System.Windows.Forms.Label eventDateLabel;
            System.Windows.Forms.Label eventStatusLabel;
            System.Windows.Forms.Label eventIdLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.eventIdTextBox = new System.Windows.Forms.TextBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyActivityDataSet = new EmployeeEngagement.CompanyActivityDataSet();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.formatIdTextBox = new System.Windows.Forms.TextBox();
            this.subtypeEventIdTextBox = new System.Windows.Forms.TextBox();
            this.eventDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eventStatusTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.codifierStatusEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.codifierFormatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.codifierSubtypeEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.EventTableAdapter();
            this.tableAdapterManager = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.TableAdapterManager();
            this.codifierFormatTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.CodifierFormatTableAdapter();
            this.codifierStatusEventTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.CodifierStatusEventTableAdapter();
            this.codifierSubtypeEventTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.CodifierSubtypeEventTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            eventNameLabel = new System.Windows.Forms.Label();
            formatIdLabel = new System.Windows.Forms.Label();
            subtypeEventIdLabel = new System.Windows.Forms.Label();
            eventDateLabel = new System.Windows.Forms.Label();
            eventStatusLabel = new System.Windows.Forms.Label();
            eventIdLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyActivityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierStatusEventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierFormatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierSubtypeEventBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eventNameLabel
            // 
            eventNameLabel.AutoSize = true;
            eventNameLabel.Location = new System.Drawing.Point(19, 53);
            eventNameLabel.Name = "eventNameLabel";
            eventNameLabel.Size = new System.Drawing.Size(76, 17);
            eventNameLabel.TabIndex = 0;
            eventNameLabel.Text = "Название:";
            // 
            // formatIdLabel
            // 
            formatIdLabel.AutoSize = true;
            formatIdLabel.Location = new System.Drawing.Point(19, 81);
            formatIdLabel.Name = "formatIdLabel";
            formatIdLabel.Size = new System.Drawing.Size(65, 17);
            formatIdLabel.TabIndex = 2;
            formatIdLabel.Text = "Формат:";
            // 
            // subtypeEventIdLabel
            // 
            subtypeEventIdLabel.AutoSize = true;
            subtypeEventIdLabel.Location = new System.Drawing.Point(19, 109);
            subtypeEventIdLabel.Name = "subtypeEventIdLabel";
            subtypeEventIdLabel.Size = new System.Drawing.Size(37, 17);
            subtypeEventIdLabel.TabIndex = 4;
            subtypeEventIdLabel.Text = "Тип:";
            // 
            // eventDateLabel
            // 
            eventDateLabel.AutoSize = true;
            eventDateLabel.Location = new System.Drawing.Point(19, 138);
            eventDateLabel.Name = "eventDateLabel";
            eventDateLabel.Size = new System.Drawing.Size(46, 17);
            eventDateLabel.TabIndex = 6;
            eventDateLabel.Text = "Дата:";
            // 
            // eventStatusLabel
            // 
            eventStatusLabel.AutoSize = true;
            eventStatusLabel.Location = new System.Drawing.Point(19, 165);
            eventStatusLabel.Name = "eventStatusLabel";
            eventStatusLabel.Size = new System.Drawing.Size(57, 17);
            eventStatusLabel.TabIndex = 8;
            eventStatusLabel.Text = "Статус:";
            // 
            // eventIdLabel
            // 
            eventIdLabel.AutoSize = true;
            eventIdLabel.Location = new System.Drawing.Point(19, 27);
            eventIdLabel.Name = "eventIdLabel";
            eventIdLabel.Size = new System.Drawing.Size(25, 17);
            eventIdLabel.TabIndex = 35;
            eventIdLabel.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(eventIdLabel);
            this.panel1.Controls.Add(this.eventIdTextBox);
            this.panel1.Controls.Add(this.eventNameTextBox);
            this.panel1.Controls.Add(this.formatIdTextBox);
            this.panel1.Controls.Add(this.subtypeEventIdTextBox);
            this.panel1.Controls.Add(this.eventDateDateTimePicker);
            this.panel1.Controls.Add(this.eventStatusTextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBoxStatus);
            this.panel1.Controls.Add(this.comboBoxFormat);
            this.panel1.Controls.Add(this.comboBoxType);
            this.panel1.Controls.Add(eventNameLabel);
            this.panel1.Controls.Add(formatIdLabel);
            this.panel1.Controls.Add(subtypeEventIdLabel);
            this.panel1.Controls.Add(eventDateLabel);
            this.panel1.Controls.Add(eventStatusLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 270);
            this.panel1.TabIndex = 0;
            // 
            // eventIdTextBox
            // 
            this.eventIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "EventId", true));
            this.eventIdTextBox.Location = new System.Drawing.Point(144, 24);
            this.eventIdTextBox.Name = "eventIdTextBox";
            this.eventIdTextBox.Size = new System.Drawing.Size(200, 22);
            this.eventIdTextBox.TabIndex = 36;
            this.eventIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eventIdTextBox_KeyPress);
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            this.eventBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // companyActivityDataSet
            // 
            this.companyActivityDataSet.DataSetName = "CompanyActivityDataSet";
            this.companyActivityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "EventName", true));
            this.eventNameTextBox.Location = new System.Drawing.Point(144, 50);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.eventNameTextBox.TabIndex = 38;
            // 
            // formatIdTextBox
            // 
            this.formatIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "FormatId", true));
            this.formatIdTextBox.Location = new System.Drawing.Point(375, 27);
            this.formatIdTextBox.Name = "formatIdTextBox";
            this.formatIdTextBox.Size = new System.Drawing.Size(200, 22);
            this.formatIdTextBox.TabIndex = 40;
            // 
            // subtypeEventIdTextBox
            // 
            this.subtypeEventIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "SubtypeEventId", true));
            this.subtypeEventIdTextBox.Location = new System.Drawing.Point(375, 55);
            this.subtypeEventIdTextBox.Name = "subtypeEventIdTextBox";
            this.subtypeEventIdTextBox.Size = new System.Drawing.Size(200, 22);
            this.subtypeEventIdTextBox.TabIndex = 42;
            // 
            // eventDateDateTimePicker
            // 
            this.eventDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EventDate", true));
            this.eventDateDateTimePicker.Location = new System.Drawing.Point(144, 134);
            this.eventDateDateTimePicker.Name = "eventDateDateTimePicker";
            this.eventDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.eventDateDateTimePicker.TabIndex = 44;
            // 
            // eventStatusTextBox
            // 
            this.eventStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "EventStatus", true));
            this.eventStatusTextBox.Location = new System.Drawing.Point(375, 111);
            this.eventStatusTextBox.Name = "eventStatusTextBox";
            this.eventStatusTextBox.Size = new System.Drawing.Size(200, 22);
            this.eventStatusTextBox.TabIndex = 46;
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
            this.button1.Location = new System.Drawing.Point(194, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 34);
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
            this.button2.Location = new System.Drawing.Point(22, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 34);
            this.button2.TabIndex = 34;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DataSource = this.codifierStatusEventBindingSource;
            this.comboBoxStatus.DisplayMember = "StatusName";
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(144, 162);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(200, 24);
            this.comboBoxStatus.TabIndex = 12;
            this.comboBoxStatus.ValueMember = "StatusId";
            // 
            // codifierStatusEventBindingSource
            // 
            this.codifierStatusEventBindingSource.DataMember = "CodifierStatusEvent";
            this.codifierStatusEventBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.DataSource = this.codifierFormatBindingSource;
            this.comboBoxFormat.DisplayMember = "FormatName";
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Location = new System.Drawing.Point(144, 78);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(200, 24);
            this.comboBoxFormat.TabIndex = 11;
            this.comboBoxFormat.ValueMember = "FormatId";
            // 
            // codifierFormatBindingSource
            // 
            this.codifierFormatBindingSource.DataMember = "CodifierFormat";
            this.codifierFormatBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DataSource = this.codifierSubtypeEventBindingSource;
            this.comboBoxType.DisplayMember = "SubtypeName";
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(144, 106);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(200, 24);
            this.comboBoxType.TabIndex = 10;
            this.comboBoxType.ValueMember = "SubtypeId";
            // 
            // codifierSubtypeEventBindingSource
            // 
            this.codifierSubtypeEventBindingSource.DataMember = "CodifierSubtypeEvent";
            this.codifierSubtypeEventBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivityTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CodifierActivityTableAdapter = null;
            this.tableAdapterManager.CodifierDepartmentTableAdapter = null;
            this.tableAdapterManager.CodifierFormatTableAdapter = this.codifierFormatTableAdapter;
            this.tableAdapterManager.CodifierGenderTableAdapter = null;
            this.tableAdapterManager.CodifierPostTableAdapter = null;
            this.tableAdapterManager.CodifierStatusEventTableAdapter = this.codifierStatusEventTableAdapter;
            this.tableAdapterManager.CodifierSubtypeEventTableAdapter = this.codifierSubtypeEventTableAdapter;
            this.tableAdapterManager.CodifierTypeEventTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EmployeeToActivityTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = this.eventTableAdapter;
            this.tableAdapterManager.HistoryForHRTableAdapter = null;
            this.tableAdapterManager.PostTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EmployeeEngagement.CompanyActivityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // codifierFormatTableAdapter
            // 
            this.codifierFormatTableAdapter.ClearBeforeFill = true;
            // 
            // codifierStatusEventTableAdapter
            // 
            this.codifierStatusEventTableAdapter.ClearBeforeFill = true;
            // 
            // codifierSubtypeEventTableAdapter
            // 
            this.codifierSubtypeEventTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(375, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 131);
            this.panel2.TabIndex = 55;
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 270);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddEvent";
            this.Text = "Добавление мероприятия";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyActivityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierStatusEventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierFormatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierSubtypeEventBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CompanyActivityDataSet companyActivityDataSet;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private CompanyActivityDataSetTableAdapters.EventTableAdapter eventTableAdapter;
        private CompanyActivityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.ComboBox comboBoxType;
        private CompanyActivityDataSetTableAdapters.CodifierFormatTableAdapter codifierFormatTableAdapter;
        private System.Windows.Forms.BindingSource codifierFormatBindingSource;
        private CompanyActivityDataSetTableAdapters.CodifierSubtypeEventTableAdapter codifierSubtypeEventTableAdapter;
        private System.Windows.Forms.BindingSource codifierSubtypeEventBindingSource;
        private CompanyActivityDataSetTableAdapters.CodifierStatusEventTableAdapter codifierStatusEventTableAdapter;
        private System.Windows.Forms.BindingSource codifierStatusEventBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox eventIdTextBox;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.TextBox formatIdTextBox;
        private System.Windows.Forms.TextBox subtypeEventIdTextBox;
        private System.Windows.Forms.DateTimePicker eventDateDateTimePicker;
        private System.Windows.Forms.TextBox eventStatusTextBox;
        private System.Windows.Forms.Panel panel2;
    }
}