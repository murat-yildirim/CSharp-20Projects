﻿namespace Project12_JwtToken
{
	partial class FrmTokenGenerator
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
			this.btnCreateToken = new System.Windows.Forms.Button();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// btnCreateToken
			// 
			this.btnCreateToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCreateToken.Location = new System.Drawing.Point(224, 168);
			this.btnCreateToken.Name = "btnCreateToken";
			this.btnCreateToken.Size = new System.Drawing.Size(169, 31);
			this.btnCreateToken.TabIndex = 5;
			this.btnCreateToken.Text = "Token Oluştur";
			this.btnCreateToken.UseVisualStyleBackColor = true;
			this.btnCreateToken.Click += new System.EventHandler(this.btnCreateToken_Click);
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtUserName.Location = new System.Drawing.Point(115, 32);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(357, 24);
			this.txtUserName.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(18, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "Kullanıcı Adı:";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtName.Location = new System.Drawing.Point(115, 62);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(357, 24);
			this.txtName.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(76, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 18);
			this.label2.TabIndex = 6;
			this.label2.Text = "Adı:";
			// 
			// txtSurname
			// 
			this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSurname.Location = new System.Drawing.Point(115, 92);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Size = new System.Drawing.Size(357, 24);
			this.txtSurname.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(51, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 18);
			this.label3.TabIndex = 8;
			this.label3.Text = "Soyadı:";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtEmail.Location = new System.Drawing.Point(115, 122);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(357, 24);
			this.txtEmail.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(59, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 18);
			this.label4.TabIndex = 10;
			this.label4.Text = "Email:";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.richTextBox1.Location = new System.Drawing.Point(115, 218);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(357, 184);
			this.richTextBox1.TabIndex = 12;
			this.richTextBox1.Text = "";
			// 
			// FrmTokenGenerator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(537, 431);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtSurname);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCreateToken);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label1);
			this.Name = "FrmTokenGenerator";
			this.Text = "FrmTokenGenerator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCreateToken;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSurname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}