namespace Project5_DapperNorthwind
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
			this.btnCategoryList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.txtCategoryDescription = new System.Windows.Forms.TextBox();
			this.btnCreateCategory = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCategoryId = new System.Windows.Forms.TextBox();
			this.btnDeleteCategory = new System.Windows.Forms.Button();
			this.btnUpdateCategory = new System.Windows.Forms.Button();
			this.lblCategoryCount = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblProductCount = new System.Windows.Forms.Label();
			this.lblAvgProductStock = new System.Windows.Forms.Label();
			this.lblSeafoodProductTotalPrice = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCategoryList
			// 
			this.btnCategoryList.Location = new System.Drawing.Point(367, 17);
			this.btnCategoryList.Name = "btnCategoryList";
			this.btnCategoryList.Size = new System.Drawing.Size(119, 29);
			this.btnCategoryList.TabIndex = 0;
			this.btnCategoryList.Text = "Kategori Listesi";
			this.btnCategoryList.UseVisualStyleBackColor = true;
			this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 161);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(474, 293);
			this.dataGridView1.TabIndex = 1;
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(130, 43);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(214, 20);
			this.txtCategoryName.TabIndex = 2;
			// 
			// txtCategoryDescription
			// 
			this.txtCategoryDescription.Location = new System.Drawing.Point(130, 69);
			this.txtCategoryDescription.Multiline = true;
			this.txtCategoryDescription.Name = "txtCategoryDescription";
			this.txtCategoryDescription.Size = new System.Drawing.Size(214, 73);
			this.txtCategoryDescription.TabIndex = 3;
			// 
			// btnCreateCategory
			// 
			this.btnCreateCategory.Location = new System.Drawing.Point(367, 52);
			this.btnCreateCategory.Name = "btnCreateCategory";
			this.btnCreateCategory.Size = new System.Drawing.Size(119, 26);
			this.btnCreateCategory.TabIndex = 4;
			this.btnCreateCategory.Text = "Kategori Ekle";
			this.btnCreateCategory.UseVisualStyleBackColor = true;
			this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Kategori ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Kategori Adı:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Kategori Açıklaması:";
			// 
			// txtCategoryId
			// 
			this.txtCategoryId.Location = new System.Drawing.Point(130, 17);
			this.txtCategoryId.Name = "txtCategoryId";
			this.txtCategoryId.Size = new System.Drawing.Size(214, 20);
			this.txtCategoryId.TabIndex = 8;
			// 
			// btnDeleteCategory
			// 
			this.btnDeleteCategory.Location = new System.Drawing.Point(367, 84);
			this.btnDeleteCategory.Name = "btnDeleteCategory";
			this.btnDeleteCategory.Size = new System.Drawing.Size(119, 26);
			this.btnDeleteCategory.TabIndex = 9;
			this.btnDeleteCategory.Text = "Kategori Sil";
			this.btnDeleteCategory.UseVisualStyleBackColor = true;
			this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
			// 
			// btnUpdateCategory
			// 
			this.btnUpdateCategory.Location = new System.Drawing.Point(367, 116);
			this.btnUpdateCategory.Name = "btnUpdateCategory";
			this.btnUpdateCategory.Size = new System.Drawing.Size(119, 26);
			this.btnUpdateCategory.TabIndex = 10;
			this.btnUpdateCategory.Text = "Kategori Güncelle";
			this.btnUpdateCategory.UseVisualStyleBackColor = true;
			this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
			// 
			// lblCategoryCount
			// 
			this.lblCategoryCount.AutoSize = true;
			this.lblCategoryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCategoryCount.Location = new System.Drawing.Point(17, 39);
			this.lblCategoryCount.Name = "lblCategoryCount";
			this.lblCategoryCount.Size = new System.Drawing.Size(46, 18);
			this.lblCategoryCount.TabIndex = 11;
			this.lblCategoryCount.Text = "label4";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.groupBox1.Controls.Add(this.lblSeafoodProductTotalPrice);
			this.groupBox1.Controls.Add(this.lblAvgProductStock);
			this.groupBox1.Controls.Add(this.lblProductCount);
			this.groupBox1.Controls.Add(this.lblCategoryCount);
			this.groupBox1.Location = new System.Drawing.Point(514, 20);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(615, 441);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dapper İstatistikler";
			// 
			// lblProductCount
			// 
			this.lblProductCount.AutoSize = true;
			this.lblProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProductCount.Location = new System.Drawing.Point(17, 96);
			this.lblProductCount.Name = "lblProductCount";
			this.lblProductCount.Size = new System.Drawing.Size(46, 18);
			this.lblProductCount.TabIndex = 12;
			this.lblProductCount.Text = "label4";
			// 
			// lblAvgProductStock
			// 
			this.lblAvgProductStock.AutoSize = true;
			this.lblAvgProductStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAvgProductStock.Location = new System.Drawing.Point(17, 150);
			this.lblAvgProductStock.Name = "lblAvgProductStock";
			this.lblAvgProductStock.Size = new System.Drawing.Size(46, 18);
			this.lblAvgProductStock.TabIndex = 13;
			this.lblAvgProductStock.Text = "label4";
			// 
			// lblSeafoodProductTotalPrice
			// 
			this.lblSeafoodProductTotalPrice.AutoSize = true;
			this.lblSeafoodProductTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSeafoodProductTotalPrice.Location = new System.Drawing.Point(17, 204);
			this.lblSeafoodProductTotalPrice.Name = "lblSeafoodProductTotalPrice";
			this.lblSeafoodProductTotalPrice.Size = new System.Drawing.Size(46, 18);
			this.lblSeafoodProductTotalPrice.TabIndex = 14;
			this.lblSeafoodProductTotalPrice.Text = "label4";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1141, 473);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnUpdateCategory);
			this.Controls.Add(this.btnDeleteCategory);
			this.Controls.Add(this.txtCategoryId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCreateCategory);
			this.Controls.Add(this.txtCategoryDescription);
			this.Controls.Add(this.txtCategoryName);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnCategoryList);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCategoryList;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.TextBox txtCategoryDescription;
		private System.Windows.Forms.Button btnCreateCategory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCategoryId;
		private System.Windows.Forms.Button btnDeleteCategory;
		private System.Windows.Forms.Button btnUpdateCategory;
		private System.Windows.Forms.Label lblCategoryCount;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblSeafoodProductTotalPrice;
		private System.Windows.Forms.Label lblAvgProductStock;
		private System.Windows.Forms.Label lblProductCount;
	}
}

