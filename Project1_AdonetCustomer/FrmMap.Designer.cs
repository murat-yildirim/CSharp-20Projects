﻿namespace Project1_AdonetCustomer
{
	partial class FrmMap
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
			this.btnOpenCityForm = new System.Windows.Forms.Button();
			this.btnOpenCustomer = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnOpenCityForm
			// 
			this.btnOpenCityForm.Location = new System.Drawing.Point(37, 12);
			this.btnOpenCityForm.Name = "btnOpenCityForm";
			this.btnOpenCityForm.Size = new System.Drawing.Size(151, 49);
			this.btnOpenCityForm.TabIndex = 0;
			this.btnOpenCityForm.Text = "Şehir İşlemleri";
			this.btnOpenCityForm.UseVisualStyleBackColor = true;
			this.btnOpenCityForm.Click += new System.EventHandler(this.btnOpenCityForm_Click);
			// 
			// btnOpenCustomer
			// 
			this.btnOpenCustomer.Location = new System.Drawing.Point(37, 67);
			this.btnOpenCustomer.Name = "btnOpenCustomer";
			this.btnOpenCustomer.Size = new System.Drawing.Size(151, 49);
			this.btnOpenCustomer.TabIndex = 1;
			this.btnOpenCustomer.Text = "Müşteri İşlemleri";
			this.btnOpenCustomer.UseVisualStyleBackColor = true;
			this.btnOpenCustomer.Click += new System.EventHandler(this.btnOpenCustomer_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(37, 122);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(151, 49);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Çıkış Yap";
			this.btnExit.UseVisualStyleBackColor = true;
			// 
			// FrmMap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(226, 186);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnOpenCustomer);
			this.Controls.Add(this.btnOpenCityForm);
			this.Name = "FrmMap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Formlar";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOpenCityForm;
		private System.Windows.Forms.Button btnOpenCustomer;
		private System.Windows.Forms.Button btnExit;
	}
}