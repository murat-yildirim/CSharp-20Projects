﻿using Dapper;
using Project5_DapperNorthwind.Dtos;
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

namespace Project5_DapperNorthwind
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		SqlConnection connection = new SqlConnection("Server=DESKTOP-363RU31\\SQLEXPRESS;initial catalog=Db5Project20;integrated security=true");
		private async void btnCategoryList_Click(object sender, EventArgs e)
		{
			string query = "Select * From Categories";
			var values = await connection.QueryAsync<ResultCategoryDto>(query);
			dataGridView1.DataSource = values;
			
			
		}

		private async void btnCreateCategory_Click(object sender, EventArgs e)
		{
			string query = "insert into Categories (CategoryName,Description) Values (@p1,@p2)";
			var parameteres = new DynamicParameters();
			parameteres.Add("@p1", txtCategoryName.Text);
			parameteres.Add("@p2", txtCategoryDescription.Text);
			await connection.ExecuteAsync(query, parameteres);
		}

		private async void btnDeleteCategory_Click(object sender, EventArgs e)
		{
			string query = "delete from Categories Where CategoryId=@categoryId";
			var parameteres = new DynamicParameters();
			parameteres.Add("@categoryId",txtCategoryId.Text);
			await connection.ExecuteAsync(query, parameteres);
		}

		private async void btnUpdateCategory_Click(object sender, EventArgs e)
		{
			string query = "Update Categories Set CategoryName =@categoryName,Description=@description Where CategoryId=@categoryId";
			var parameteres = new DynamicParameters();
			parameteres.Add("@categoryName", txtCategoryName.Text);
			parameteres.Add("@description", txtCategoryDescription.Text);
			parameteres.Add("@categoryId", txtCategoryId.Text);
			await connection.ExecuteAsync(query, parameteres);
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
		
			// KATEGORİ TOPLAM SAYISI
			string query = "Select Count(*) From Categories";
			var categoryCount = await connection.ExecuteScalarAsync<int>(query);
			lblCategoryCount.Text = "Toplam Kategori Sayısı: " + categoryCount;

			//ÜRÜN SAYISI
			string query2 = "Select Count(*) From Products";
			var productCount = await connection.ExecuteScalarAsync<int>(query2);
			lblProductCount.Text="Toplam Ürün Sayısı: "+ productCount;

			// ORTALAMA ÜRÜN STOK SAYISI
			string query3 = "Select Avg(UnitsInStock) From products";
			var avgProductStock=await connection.ExecuteScalarAsync<int>(query3);
			lblAvgProductStock.Text = "Ortalama Ürün Sayısı: " + avgProductStock;

			//DENİZ ÜRÜLERİ TOPLAM FİYATI
			string query4 = "Select Sum(UnitPrice) From Products Where CategoryId=(Select CategoryId From Categories Where CategoryName='SeaFood')";
			var totalSeaFoodPrice=await connection.ExecuteScalarAsync<decimal>(query4);
			lblSeafoodProductTotalPrice.Text="Deniz Ürünleri Toplam Fiyatı: " +totalSeaFoodPrice;

		}
	}
}