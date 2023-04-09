using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meetings_app
{
	public partial class AddPerson : Form
	{
		public AddPerson()
		{
			InitializeComponent();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MeetingsDB"].ConnectionString))
			{
				conn.Open();
				SqlCommand addPerson = new SqlCommand("stp_AddPerson", conn);
				addPerson.CommandType = CommandType.StoredProcedure;
				addPerson.Parameters.AddWithValue("FirstName", NameBox.Text);
				addPerson.Parameters.AddWithValue("LastName", LastNameBox.Text);
				addPerson.Parameters.AddWithValue("Phone", NumberBox.Text);
				addPerson.Parameters.AddWithValue("Email", EmailBox.Text);
				addPerson.Parameters.AddWithValue("Id", 1);

				addPerson.ExecuteNonQuery();
				conn.Close();
				Close();
				


			}
		}
	}
}
