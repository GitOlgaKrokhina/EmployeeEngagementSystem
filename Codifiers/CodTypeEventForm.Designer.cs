
namespace EmployeeEngagement
{
    partial class CodTypeEventForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.companyActivityDataSet = new EmployeeEngagement.CompanyActivityDataSet();
            this.codifierSubtypeEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codifierSubtypeEventTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.CodifierSubtypeEventTableAdapter();
            this.codifierTypeEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codifierTypeEventTableAdapter = new EmployeeEngagement.CompanyActivityDataSetTableAdapters.CodifierTypeEventTableAdapter();
            this.subtypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.subtypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyActivityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierSubtypeEventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierTypeEventBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 256);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subtypeIdDataGridViewTextBoxColumn,
            this.typeIdDataGridViewTextBoxColumn,
            this.subtypeNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.codifierSubtypeEventBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(503, 171);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // companyActivityDataSet
            // 
            this.companyActivityDataSet.DataSetName = "CompanyActivityDataSet";
            this.companyActivityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // codifierTypeEventBindingSource
            // 
            this.codifierTypeEventBindingSource.DataMember = "CodifierTypeEvent";
            this.codifierTypeEventBindingSource.DataSource = this.companyActivityDataSet;
            // 
            // codifierTypeEventTableAdapter
            // 
            this.codifierTypeEventTableAdapter.ClearBeforeFill = true;
            // 
            // subtypeIdDataGridViewTextBoxColumn
            // 
            this.subtypeIdDataGridViewTextBoxColumn.DataPropertyName = "SubtypeId";
            this.subtypeIdDataGridViewTextBoxColumn.HeaderText = "Id подтипа";
            this.subtypeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subtypeIdDataGridViewTextBoxColumn.Name = "subtypeIdDataGridViewTextBoxColumn";
            this.subtypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.subtypeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeIdDataGridViewTextBoxColumn
            // 
            this.typeIdDataGridViewTextBoxColumn.DataPropertyName = "TypeId";
            this.typeIdDataGridViewTextBoxColumn.DataSource = this.codifierTypeEventBindingSource;
            this.typeIdDataGridViewTextBoxColumn.DisplayMember = "TypeName";
            this.typeIdDataGridViewTextBoxColumn.HeaderText = "Id типа";
            this.typeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeIdDataGridViewTextBoxColumn.Name = "typeIdDataGridViewTextBoxColumn";
            this.typeIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeIdDataGridViewTextBoxColumn.ValueMember = "TypeId";
            this.typeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // subtypeNameDataGridViewTextBoxColumn
            // 
            this.subtypeNameDataGridViewTextBoxColumn.DataPropertyName = "SubtypeName";
            this.subtypeNameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.subtypeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subtypeNameDataGridViewTextBoxColumn.Name = "subtypeNameDataGridViewTextBoxColumn";
            this.subtypeNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btnSave.Location = new System.Drawing.Point(13, 199);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(204, 34);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btnCancel.Location = new System.Drawing.Point(312, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(204, 34);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CodTypeEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 256);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(546, 303);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(546, 303);
            this.Name = "CodTypeEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Типы мероприятий";
            this.Load += new System.EventHandler(this.CodTypeEventForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyActivityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierSubtypeEventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codifierTypeEventBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CompanyActivityDataSet companyActivityDataSet;
        private System.Windows.Forms.BindingSource codifierSubtypeEventBindingSource;
        private CompanyActivityDataSetTableAdapters.CodifierSubtypeEventTableAdapter codifierSubtypeEventTableAdapter;
        private System.Windows.Forms.BindingSource codifierTypeEventBindingSource;
        private CompanyActivityDataSetTableAdapters.CodifierTypeEventTableAdapter codifierTypeEventTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}