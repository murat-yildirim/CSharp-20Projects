﻿namespace Project1_AdonetCustomer
{
	partial class FrmCustomer
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
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.txtCustomerSurname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtCustomerId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtBalance = new System.Windows.Forms.TextBox();
			this.cmbCity = new System.Windows.Forms.ComboBox();
			this.rdbActive = new System.Windows.Forms.RadioButton();
			this.rdbPassive = new System.Windows.Forms.RadioButton();
			this.btnProcedure = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSearch.Location = new System.Drawing.Point(110, 325);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(152, 23);
			this.btnSearch.TabIndex = 24;
			this.btnSearch.Text = "Ara";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdate.Location = new System.Drawing.Point(110, 296);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(152, 23);
			this.btnUpdate.TabIndex = 23;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDelete.Location = new System.Drawing.Point(110, 267);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(152, 23);
			this.btnDelete.TabIndex = 22;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCreate.Location = new System.Drawing.Point(110, 238);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(152, 23);
			this.btnCreate.TabIndex = 21;
			this.btnCreate.Text = "Ekle";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// txtCustomerSurname
			// 
			this.txtCustomerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCustomerSurname.Location = new System.Drawing.Point(127, 89);
			this.txtCustomerSurname.Name = "txtCustomerSurname";
			this.txtCustomerSurname.Size = new System.Drawing.Size(135, 20);
			this.txtCustomerSurname.TabIndex = 20;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(27, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 13);
			this.label3.TabIndex = 19;
			this.label3.Text = "Müşteri Soyadı:";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCustomerName.Location = new System.Drawing.Point(127, 63);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(135, 20);
			this.txtCustomerName.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(47, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "Müşteri Adı:";
			// 
			// btnList
			// 
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnList.Location = new System.Drawing.Point(111, 209);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(74, 23);
			this.btnList.TabIndex = 16;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(285, 37);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(761, 311);
			this.dataGridView1.TabIndex = 15;
			// 
			// txtCustomerId
			// 
			this.txtCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtCustomerId.Location = new System.Drawing.Point(127, 37);
			this.txtCustomerId.Name = "txtCustomerId";
			this.txtCustomerId.Size = new System.Drawing.Size(135, 20);
			this.txtCustomerId.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(54, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "Müşteri Id:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(72, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 25;
			this.label4.Text = "Bakiye:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(74, 170);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 26;
			this.label5.Text = "Durum:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(81, 146);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 27;
			this.label6.Text = "Şehir:";
			// 
			// txtBalance
			// 
			this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBalance.Location = new System.Drawing.Point(127, 115);
			this.txtBalance.Name = "txtBalance";
			this.txtBalance.Size = new System.Drawing.Size(135, 20);
			this.txtBalance.TabIndex = 28;
			// 
			// cmbCity
			// 
			this.cmbCity.FormattingEnabled = true;
			this.cmbCity.Location = new System.Drawing.Point(127, 141);
			this.cmbCity.Name = "cmbCity";
			this.cmbCity.Size = new System.Drawing.Size(136, 21);
			this.cmbCity.TabIndex = 31;
			// 
			// rdbActive
			// 
			this.rdbActive.AutoSize = true;
			this.rdbActive.Location = new System.Drawing.Point(139, 170);
			this.rdbActive.Name = "rdbActive";
			this.rdbActive.Size = new System.Drawing.Size(46, 17);
			this.rdbActive.TabIndex = 32;
			this.rdbActive.TabStop = true;
			this.rdbActive.Text = "Aktif";
			this.rdbActive.UseVisualStyleBackColor = true;
			// 
			// rdbPassive
			// 
			this.rdbPassive.AutoSize = true;
			this.rdbPassive.Location = new System.Drawing.Point(201, 170);
			this.rdbPassive.Name = "rdbPassive";
			this.rdbPassive.Size = new System.Drawing.Size(48, 17);
			this.rdbPassive.TabIndex = 33;
			this.rdbPassive.TabStop = true;
			this.rdbPassive.Text = "Pasif";
			this.rdbPassive.UseVisualStyleBackColor = true;
			// 
			// btnProcedure
			// 
			this.btnProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnProcedure.Location = new System.Drawing.Point(188, 209);
			this.btnProcedure.Name = "btnProcedure";
			this.btnProcedure.Size = new System.Drawing.Size(74, 23);
			this.btnProcedure.TabIndex = 34;
			this.btnProcedure.Text = "Prosedür";
			this.btnProcedure.UseVisualStyleBackColor = true;
			this.btnProcedure.Click += new System.EventHandler(this.btnProcedure_Click);
			// 
			// FrmCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.ClientSize = new System.Drawing.Size(1079, 381);
			this.Controls.Add(this.btnProcedure);
			this.Controls.Add(this.rdbPassive);
			this.Controls.Add(this.rdbActive);
			this.Controls.Add(this.cmbCity);
			this.Controls.Add(this.txtBalance);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtCustomerSurname);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCustomerName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtCustomerId);
			this.Controls.Add(this.label1);
			this.Name = "FrmCustomer";
			this.Text = "Müşteri Formu";
			this.Load += new System.EventHandler(this.FrmCustomer_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox txtCustomerSurname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtCustomerId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtBalance;
		private System.Windows.Forms.ComboBox cmbCity;
		private System.Windows.Forms.RadioButton rdbActive;
		private System.Windows.Forms.RadioButton rdbPassive;
		private System.Windows.Forms.Button btnProcedure;
	}
}