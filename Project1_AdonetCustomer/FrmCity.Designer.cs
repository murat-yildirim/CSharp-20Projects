﻿namespace Project1_AdonetCustomer
{
	partial class FrmCity
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtCityId = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnList = new System.Windows.Forms.Button();
			this.txtCityName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCityCountry = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(25, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Şehir Id:";
			// 
			// txtCityId
			// 
			this.txtCityId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCityId.Location = new System.Drawing.Point(87, 44);
			this.txtCityId.Name = "txtCityId";
			this.txtCityId.Size = new System.Drawing.Size(135, 20);
			this.txtCityId.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(276, 43);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(553, 234);
			this.dataGridView1.TabIndex = 2;
			// 
			// btnList
			// 
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnList.Location = new System.Drawing.Point(70, 138);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(152, 23);
			this.btnList.TabIndex = 3;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtCityName
			// 
			this.txtCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCityName.Location = new System.Drawing.Point(87, 70);
			this.txtCityName.Name = "txtCityName";
			this.txtCityName.Size = new System.Drawing.Size(135, 20);
			this.txtCityName.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(19, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Şehir Adı:";
			// 
			// txtCityCountry
			// 
			this.txtCityCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCityCountry.Location = new System.Drawing.Point(87, 96);
			this.txtCityCountry.Name = "txtCityCountry";
			this.txtCityCountry.Size = new System.Drawing.Size(135, 20);
			this.txtCityCountry.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(39, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Ülke:";
			// 
			// btnCreate
			// 
			this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCreate.Location = new System.Drawing.Point(70, 167);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(152, 23);
			this.btnCreate.TabIndex = 9;
			this.btnCreate.Text = "Ekle";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDelete.Location = new System.Drawing.Point(70, 196);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(152, 23);
			this.btnDelete.TabIndex = 10;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdate.Location = new System.Drawing.Point(70, 225);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(152, 23);
			this.btnUpdate.TabIndex = 11;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSearch.Location = new System.Drawing.Point(70, 254);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(152, 23);
			this.btnSearch.TabIndex = 12;
			this.btnSearch.Text = "Ara";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// FrmCity
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSalmon;
			this.ClientSize = new System.Drawing.Size(847, 301);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtCityCountry);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCityName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtCityId);
			this.Controls.Add(this.label1);
			this.Name = "FrmCity";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Şehir Bilgi Formu";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCityId;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtCityName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCityCountry;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnSearch;
	}
}

