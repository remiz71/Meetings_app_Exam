namespace Meetings_app
{
	partial class Form1
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.place_tb = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.personListSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.meetingsDBPersonSet = new Meetings_app.MeetingsDBPersonSet();
			this.label3 = new System.Windows.Forms.Label();
			this.topic_tb = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TimePick = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.DatePick = new System.Windows.Forms.DateTimePicker();
			this.meetingsDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.meetingsDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.meetingsDBDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.personListSetTableAdapter = new Meetings_app.MeetingsDBPersonSetTableAdapters.PersonListSetTableAdapter();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button3 = new System.Windows.Forms.Button();
			this.meetingsDBDataSet = new Meetings_app.MeetingsDBDataSet();
			this.meetingSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.meetingSetTableAdapter = new Meetings_app.MeetingsDBDataSetTableAdapters.MeetingSetTableAdapter();
			this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.topicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.personListIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.personListSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.meetingsDBPersonSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.meetingsDBDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.meetingsDBDataSetBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.meetingsDBDataSetBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.meetingsDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.meetingSetBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightCyan;
			this.panel1.Controls.Add(this.dataGridView2);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(952, 531);
			this.panel1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn,
            this.topicDataGridViewTextBoxColumn,
            this.personListIdDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.meetingSetBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(3, 157);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(459, 362);
			this.dataGridView1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.place_tb);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.topic_tb);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.TimePick);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.DatePick);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(952, 151);
			this.panel2.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(237, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Место встречи";
			// 
			// place_tb
			// 
			this.place_tb.Location = new System.Drawing.Point(240, 33);
			this.place_tb.Name = "place_tb";
			this.place_tb.Size = new System.Drawing.Size(221, 20);
			this.place_tb.TabIndex = 9;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(240, 73);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(221, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "Добавить встречу";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(240, 114);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(221, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Добавить участника";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(469, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(166, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "С кем будет проходить встреча";
			// 
			// personListSetBindingSource
			// 
			this.personListSetBindingSource.DataMember = "PersonListSet";
			this.personListSetBindingSource.DataSource = this.meetingsDBPersonSet;
			// 
			// meetingsDBPersonSet
			// 
			this.meetingsDBPersonSet.DataSetName = "MeetingsDBPersonSet";
			this.meetingsDBPersonSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Тема встречи";
			// 
			// topic_tb
			// 
			this.topic_tb.Location = new System.Drawing.Point(11, 33);
			this.topic_tb.Name = "topic_tb";
			this.topic_tb.Size = new System.Drawing.Size(200, 20);
			this.topic_tb.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Время встречи";
			// 
			// TimePick
			// 
			this.TimePick.Location = new System.Drawing.Point(11, 72);
			this.TimePick.Name = "TimePick";
			this.TimePick.Size = new System.Drawing.Size(200, 20);
			this.TimePick.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Дата встречи";
			// 
			// DatePick
			// 
			this.DatePick.Location = new System.Drawing.Point(11, 114);
			this.DatePick.MinDate = new System.DateTime(2023, 3, 18, 0, 0, 0, 0);
			this.DatePick.Name = "DatePick";
			this.DatePick.Size = new System.Drawing.Size(200, 20);
			this.DatePick.TabIndex = 0;
			// 
			// personListSetTableAdapter
			// 
			this.personListSetTableAdapter.ClearBeforeFill = true;
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataSource = this.meetingsDBDataSetBindingSource;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.personListSetBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(473, 157);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(479, 362);
			this.dataGridView2.TabIndex = 11;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// firstNameDataGridViewTextBoxColumn
			// 
			this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
			this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// lastNameDataGridViewTextBoxColumn
			// 
			this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
			this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
			this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
			this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// phoneDataGridViewTextBoxColumn
			// 
			this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
			this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
			this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
			this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(789, 113);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(123, 23);
			this.button3.TabIndex = 11;
			this.button3.Text = "Сохранить в файл";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// meetingsDBDataSet
			// 
			this.meetingsDBDataSet.DataSetName = "MeetingsDBDataSet";
			this.meetingsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// meetingSetBindingSource
			// 
			this.meetingSetBindingSource.DataMember = "MeetingSet";
			this.meetingSetBindingSource.DataSource = this.meetingsDBDataSet;
			// 
			// meetingSetTableAdapter
			// 
			this.meetingSetTableAdapter.ClearBeforeFill = true;
			// 
			// idDataGridViewTextBoxColumn1
			// 
			this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
			this.idDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// timeDataGridViewTextBoxColumn
			// 
			this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
			this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
			this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
			this.timeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// placeDataGridViewTextBoxColumn
			// 
			this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
			this.placeDataGridViewTextBoxColumn.HeaderText = "Place";
			this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
			this.placeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// topicDataGridViewTextBoxColumn
			// 
			this.topicDataGridViewTextBoxColumn.DataPropertyName = "Topic";
			this.topicDataGridViewTextBoxColumn.HeaderText = "Topic";
			this.topicDataGridViewTextBoxColumn.Name = "topicDataGridViewTextBoxColumn";
			this.topicDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// personListIdDataGridViewTextBoxColumn
			// 
			this.personListIdDataGridViewTextBoxColumn.DataPropertyName = "PersonListId";
			this.personListIdDataGridViewTextBoxColumn.HeaderText = "PersonListId";
			this.personListIdDataGridViewTextBoxColumn.Name = "personListIdDataGridViewTextBoxColumn";
			this.personListIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(952, 531);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.personListSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.meetingsDBPersonSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.meetingsDBDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.meetingsDBDataSetBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.meetingsDBDataSetBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.meetingsDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.meetingSetBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DateTimePicker TimePick;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker DatePick;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.BindingSource meetingsDBDataSetBindingSource;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox topic_tb;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.BindingSource meetingsDBDataSetBindingSource1;
		private System.Windows.Forms.BindingSource meetingsDBDataSetBindingSource2;
		private MeetingsDBPersonSet meetingsDBPersonSet;
		private System.Windows.Forms.BindingSource personListSetBindingSource;
		private MeetingsDBPersonSetTableAdapters.PersonListSetTableAdapter personListSetTableAdapter;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox place_tb;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button button3;
		private MeetingsDBDataSet meetingsDBDataSet;
		private System.Windows.Forms.BindingSource meetingSetBindingSource;
		private MeetingsDBDataSetTableAdapters.MeetingSetTableAdapter meetingSetTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn topicDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn personListIdDataGridViewTextBoxColumn;
	}
}

