using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_AdonetCustomer
{
	public partial class FrmCustomer : Form
	{
		public FrmCustomer()
		{
			InitializeComponent();
		}
		SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-363RU31\\SQLEXPRESS;initial catalog=DbCustomer;integrated security=true");

		private void btnList_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("select CustomerId,CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CityName from TblCustomer INNER JOIN TblCity ON TblCity.CityId = TblCustomer.CustomerCity", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			sqlConnection.Close();
		}

		private void btnProcedure_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("Execute CustomerListWithCity", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			sqlConnection.Close();
		}

		private void FrmCustomer_Load(object sender, EventArgs e)
		{
			
			SqlCommand command = new SqlCommand("Select * From TblCity", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			cmbCity.ValueMember = "CityId";
			cmbCity.DisplayMember = "CityName";
			cmbCity.DataSource= dataTable;

		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("insert into TblCustomer(CustomerName,CustomerSurname,CustomerCity,CustomerBalance,CustomerStatus) Values(@customerName,@customerSurname,@customerCity,@customerBalance,@customerStatus)",sqlConnection);
			command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
			command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
			command.Parameters.AddWithValue("@customerCity", cmbCity.SelectedValue);
			command.Parameters.AddWithValue("@customerBalance", txtBalance.Text);
		
			if(rdbActive.Checked)
			{
				command.Parameters.AddWithValue("@customerStatus",true);

			}
			if (rdbPassive.Checked)
			{
				command.Parameters.AddWithValue("@customerStatus", false);

			}
			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Müşteri başarıyla eklendi");


		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("Delete From TblCustomer Where CustomerId=@cutomerId", sqlConnection);
			command.Parameters.AddWithValue("@cutomerId", txtCustomerId.Text);
			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Müşteri Başarılı bir şekilde silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("update TblCustomer Set CustomerName=@customerName,CustomerSurname=@customerSurname,CustomerCity=@customerCity,CustomerBalance=@customerBalance,CustomerStatus=@customerStatus Where CustomerId=@customerId", sqlConnection);
			command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
			command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
			command.Parameters.AddWithValue("@customerCity", cmbCity.SelectedValue);
			command.Parameters.AddWithValue("@customerBalance", txtBalance.Text);
			command.Parameters.AddWithValue("@customerId", txtCustomerId.Text);

			if (rdbActive.Checked)
			{
				command.Parameters.AddWithValue("@customerStatus", true);

			}
			if (rdbPassive.Checked)
			{
				command.Parameters.AddWithValue("@customerStatus", false);

			}
			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Müşteri başarıyla güncellendi");
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("Select * From TblCustomer Where CustomerName=@customerName", sqlConnection);
			command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			sqlConnection.Close();
		}
	}
}
