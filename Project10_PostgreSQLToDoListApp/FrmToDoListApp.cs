using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project10_PostgreSQLToDoListApp
{
	public partial class FrmToDoListApp : Form
	{
		public FrmToDoListApp()
		{
			InitializeComponent();
		}
		string connectionString = "Server=localhost;port=5432;Database=postgres;user ID=postgres;Password=1";
		private void FrmToDoListApp_Load(object sender, EventArgs e)
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Select * From todolists";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable db = new DataTable();
			adapter.Fill(db);
			dataGridView1.DataSource= db;
			connection.Close();
		}
	}
}
