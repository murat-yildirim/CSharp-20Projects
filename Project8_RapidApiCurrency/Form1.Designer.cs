namespace Project8_RapidApiCurrency
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
			this.lblDollar = new System.Windows.Forms.Label();
			this.lblEuro = new System.Windows.Forms.Label();
			this.txtUnitPrice = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.rdbDollar = new System.Windows.Forms.RadioButton();
			this.rdbEuro = new System.Windows.Forms.RadioButton();
			this.rdbSterlin = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTotalPrice = new System.Windows.Forms.TextBox();
			this.lblSterlin = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblDollar
			// 
			this.lblDollar.AutoSize = true;
			this.lblDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDollar.Location = new System.Drawing.Point(12, 20);
			this.lblDollar.Name = "lblDollar";
			this.lblDollar.Size = new System.Drawing.Size(51, 20);
			this.lblDollar.TabIndex = 0;
			this.lblDollar.Text = "label1";
			// 
			// lblEuro
			// 
			this.lblEuro.AutoSize = true;
			this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblEuro.Location = new System.Drawing.Point(161, 20);
			this.lblEuro.Name = "lblEuro";
			this.lblEuro.Size = new System.Drawing.Size(51, 20);
			this.lblEuro.TabIndex = 2;
			this.lblEuro.Text = "label3";
			// 
			// txtUnitPrice
			// 
			this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtUnitPrice.Location = new System.Drawing.Point(143, 156);
			this.txtUnitPrice.Name = "txtUnitPrice";
			this.txtUnitPrice.Size = new System.Drawing.Size(162, 24);
			this.txtUnitPrice.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(48, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Birim Tutar:";
			// 
			// rdbDollar
			// 
			this.rdbDollar.AutoSize = true;
			this.rdbDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rdbDollar.Location = new System.Drawing.Point(22, 93);
			this.rdbDollar.Name = "rdbDollar";
			this.rdbDollar.Size = new System.Drawing.Size(62, 22);
			this.rdbDollar.TabIndex = 6;
			this.rdbDollar.TabStop = true;
			this.rdbDollar.Text = "Dolar";
			this.rdbDollar.UseVisualStyleBackColor = true;
			// 
			// rdbEuro
			// 
			this.rdbEuro.AutoSize = true;
			this.rdbEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rdbEuro.Location = new System.Drawing.Point(106, 93);
			this.rdbEuro.Name = "rdbEuro";
			this.rdbEuro.Size = new System.Drawing.Size(58, 22);
			this.rdbEuro.TabIndex = 7;
			this.rdbEuro.TabStop = true;
			this.rdbEuro.Text = "Euro";
			this.rdbEuro.UseVisualStyleBackColor = true;
			// 
			// rdbSterlin
			// 
			this.rdbSterlin.AutoSize = true;
			this.rdbSterlin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rdbSterlin.Location = new System.Drawing.Point(188, 93);
			this.rdbSterlin.Name = "rdbSterlin";
			this.rdbSterlin.Size = new System.Drawing.Size(67, 22);
			this.rdbSterlin.TabIndex = 8;
			this.rdbSterlin.TabStop = true;
			this.rdbSterlin.Text = "Sterlin";
			this.rdbSterlin.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(156, 216);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(135, 32);
			this.button1.TabIndex = 9;
			this.button1.Text = "İşlemi Yap";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(10, 188);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 20);
			this.label1.TabIndex = 11;
			this.label1.Text = "Ödenecek Tutar:";
			// 
			// txtTotalPrice
			// 
			this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtTotalPrice.Location = new System.Drawing.Point(142, 186);
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.Size = new System.Drawing.Size(162, 24);
			this.txtTotalPrice.TabIndex = 10;
			// 
			// lblSterlin
			// 
			this.lblSterlin.AutoSize = true;
			this.lblSterlin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSterlin.Location = new System.Drawing.Point(307, 20);
			this.lblSterlin.Name = "lblSterlin";
			this.lblSterlin.Size = new System.Drawing.Size(51, 20);
			this.lblSterlin.TabIndex = 12;
			this.lblSterlin.Text = "label3";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(479, 317);
			this.Controls.Add(this.lblSterlin);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTotalPrice);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.rdbSterlin);
			this.Controls.Add(this.rdbEuro);
			this.Controls.Add(this.rdbDollar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUnitPrice);
			this.Controls.Add(this.lblEuro);
			this.Controls.Add(this.lblDollar);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDollar;
		private System.Windows.Forms.Label lblEuro;
		private System.Windows.Forms.TextBox txtUnitPrice;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rdbDollar;
		private System.Windows.Forms.RadioButton rdbEuro;
		private System.Windows.Forms.RadioButton rdbSterlin;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTotalPrice;
		private System.Windows.Forms.Label lblSterlin;
	}
}

