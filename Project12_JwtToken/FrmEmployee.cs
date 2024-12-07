﻿using Microsoft.IdentityModel.JsonWebTokens;
using Project12_JwtToken.JWT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace Project12_JwtToken
{
	public partial class FrmEmployee : Form
	{
		public FrmEmployee()
		{
			InitializeComponent();
		}
		public string tokenGet;
		SqlConnection connection = new SqlConnection("Server=DESKTOP-363RU31\\SQLEXPRESS;initial catalog=Db12Project20;integrated security=true");
		private void FrmEmployee_Load(object sender, EventArgs e)
		{
			TokenValidator tokenValidator = new TokenValidator();
			richTextBox1.Text=tokenGet;

			var principal= tokenValidator.ValidateJwtToken(tokenGet);
			if (principal != null)
			{
				string username=principal.FindFirst(JwtRegisteredClaimNames.Sub)?.Value;
				MessageBox.Show("Hoş geldiniz: " + username);
				connection.Open();
				SqlCommand command = new SqlCommand("Select * From TblEmployee", connection);
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);
				dataGridView1.DataSource = dataTable;
				connection.Close();
			}
			else
			{
				MessageBox.Show("Geçersiz Token");
			}
			
		}
	}
}
