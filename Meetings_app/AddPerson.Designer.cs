namespace Meetings_app
{
	partial class AddPerson
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.LastNameBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.NumberBox = new System.Windows.Forms.MaskedTextBox();
			this.EmailBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.EmailBox);
			this.panel1.Controls.Add(this.NumberBox);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.LastNameBox);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.NameBox);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(379, 514);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 136);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Фамилия";
			// 
			// LastNameBox
			// 
			this.LastNameBox.Location = new System.Drawing.Point(32, 152);
			this.LastNameBox.Name = "LastNameBox";
			this.LastNameBox.Size = new System.Drawing.Size(200, 20);
			this.LastNameBox.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Имя";
			// 
			// NameBox
			// 
			this.NameBox.Location = new System.Drawing.Point(32, 56);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(200, 20);
			this.NameBox.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 245);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Номер телефона";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 356);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "E-Mail";
			// 
			// NumberBox
			// 
			this.NumberBox.Location = new System.Drawing.Point(32, 280);
			this.NumberBox.Mask = "+7(000-000-00-00)";
			this.NumberBox.Name = "NumberBox";
			this.NumberBox.Size = new System.Drawing.Size(200, 20);
			this.NumberBox.TabIndex = 12;
			// 
			// EmailBox
			// 
			this.EmailBox.Location = new System.Drawing.Point(32, 392);
			this.EmailBox.Name = "EmailBox";
			this.EmailBox.Size = new System.Drawing.Size(200, 20);
			this.EmailBox.TabIndex = 13;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 470);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(143, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(219, 470);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(148, 23);
			this.button2.TabIndex = 15;
			this.button2.Text = "Отменить";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// AddPerson
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 514);
			this.Controls.Add(this.panel1);
			this.Name = "AddPerson";
			this.Text = "AddPerson";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox LastNameBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox NameBox;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox EmailBox;
		private System.Windows.Forms.MaskedTextBox NumberBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
	}
}