using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Meetings_app.MeetingsDBPersonSetTableAdapters;

namespace Meetings_app
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			TimePick.Format = DateTimePickerFormat.Time;
			TimePick.ShowUpDown = true;
			TimePick.Value = DateTime.Now;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'meetingsDBDataSet.MeetingSet' table. You can move, or remove it, as needed.
			this.meetingSetTableAdapter.Fill(this.meetingsDBDataSet.MeetingSet);
			// TODO: This line of code loads data into the 'meetingsDBPersonSet.PersonListSet' table. You can move, or remove it, as needed.
			this.personListSetTableAdapter.Fill(this.meetingsDBPersonSet.PersonListSet);
			UpdateGrid();
			


		}

		private void button1_Click(object sender, EventArgs e)
		{
			AddPerson add = new AddPerson();
			if (add.ShowDialog() == DialogResult.OK)
			{
				this.personListSetTableAdapter.Fill(this.meetingsDBPersonSet.PersonListSet);
			}
		}
		

		private void button2_Click(object sender, EventArgs e)
		{
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MeetingsDB"].ConnectionString))
			{
				
				
				conn.Open();
				SqlCommand addMeeting = new SqlCommand("stp_AddMeeting", conn);
				addMeeting.CommandType = CommandType.StoredProcedure;
				addMeeting.Parameters.AddWithValue("@Date", DatePick.Value);
				addMeeting.Parameters.AddWithValue("@Time", TimePick.Value);
				addMeeting.Parameters.AddWithValue("@Place", place_tb.Text);
				addMeeting.Parameters.AddWithValue("@Topic", topic_tb.Text);
				addMeeting.Parameters.AddWithValue("@PersonListId", dataGridView2.CurrentRow.Cells[0].Value);
				addMeeting.Parameters.AddWithValue("@Id", 1);

				addMeeting.ExecuteNonQuery();
				conn.Close();



			}
			UpdateGrid();
		}
		private void UpdateGrid()
		{
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MeetingsDB"].ConnectionString))
			{
				conn.Open();
				SqlCommand ALL = new SqlCommand("SELECT * FROM MeetingSet INNER JOIN PersonListSet ON MeetingSet.PersonListId = PersonListSet.Id", conn);
				SqlDataAdapter da = new SqlDataAdapter(ALL);
				DataSet ds = new DataSet();

				da.Fill(ds);
				dataGridView1.DataSource = ds.Tables[0];
				conn.Close();


			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
				StreamWriter streamWriter = new StreamWriter("test.txt");
				try
				{
				for (int i = 0; i < dataGridView1.Columns.Count; i++)
				{
					streamWriter.Write(dataGridView1.Columns[i].HeaderText + "\t");
				}
				streamWriter.WriteLine();
					for (int j = 0; j < dataGridView1.Rows.Count; j++)
					{
						for (int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
						{
							streamWriter.Write(dataGridView1.Rows[j].Cells[i].Value + "\t");
						}

						streamWriter.WriteLine();
					}

					streamWriter.Close();

					MessageBox.Show("Файл успешно сохранен");
				}
				catch
				{
					MessageBox.Show("Ошибка при сохранении файла!");
				}

			
		}
	}
}
