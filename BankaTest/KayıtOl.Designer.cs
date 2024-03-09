namespace BankaTest
{
	partial class KayıtOl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayıtOl));
			this.LblAd = new System.Windows.Forms.Label();
			this.LblSifre = new System.Windows.Forms.Label();
			this.LblHesapNo = new System.Windows.Forms.Label();
			this.LblTel = new System.Windows.Forms.Label();
			this.LblTC = new System.Windows.Forms.Label();
			this.LblSoyad = new System.Windows.Forms.Label();
			this.TxtAd = new System.Windows.Forms.TextBox();
			this.MskTC = new System.Windows.Forms.MaskedTextBox();
			this.TxtSoyad = new System.Windows.Forms.TextBox();
			this.MskTel = new System.Windows.Forms.MaskedTextBox();
			this.MskHesapNo = new System.Windows.Forms.MaskedTextBox();
			this.MskSifre = new System.Windows.Forms.TextBox();
			this.BtnKaydet = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblAd
			// 
			this.LblAd.AutoSize = true;
			this.LblAd.BackColor = System.Drawing.Color.Transparent;
			this.LblAd.ForeColor = System.Drawing.Color.White;
			this.LblAd.Location = new System.Drawing.Point(67, 29);
			this.LblAd.Name = "LblAd";
			this.LblAd.Size = new System.Drawing.Size(43, 18);
			this.LblAd.TabIndex = 0;
			this.LblAd.Text = "AD : ";
			// 
			// LblSifre
			// 
			this.LblSifre.AutoSize = true;
			this.LblSifre.BackColor = System.Drawing.Color.Transparent;
			this.LblSifre.ForeColor = System.Drawing.Color.White;
			this.LblSifre.Location = new System.Drawing.Point(44, 179);
			this.LblSifre.Name = "LblSifre";
			this.LblSifre.Size = new System.Drawing.Size(64, 18);
			this.LblSifre.TabIndex = 2;
			this.LblSifre.Text = "ŞİFRE :";
			// 
			// LblHesapNo
			// 
			this.LblHesapNo.AutoSize = true;
			this.LblHesapNo.BackColor = System.Drawing.Color.Transparent;
			this.LblHesapNo.ForeColor = System.Drawing.Color.White;
			this.LblHesapNo.Location = new System.Drawing.Point(11, 148);
			this.LblHesapNo.Name = "LblHesapNo";
			this.LblHesapNo.Size = new System.Drawing.Size(97, 18);
			this.LblHesapNo.TabIndex = 3;
			this.LblHesapNo.Text = "HESAP NO :";
			// 
			// LblTel
			// 
			this.LblTel.AutoSize = true;
			this.LblTel.BackColor = System.Drawing.Color.Transparent;
			this.LblTel.ForeColor = System.Drawing.Color.White;
			this.LblTel.Location = new System.Drawing.Point(16, 116);
			this.LblTel.Name = "LblTel";
			this.LblTel.Size = new System.Drawing.Size(92, 18);
			this.LblTel.TabIndex = 4;
			this.LblTel.Text = "TELEFON :";
			// 
			// LblTC
			// 
			this.LblTC.AutoSize = true;
			this.LblTC.BackColor = System.Drawing.Color.Transparent;
			this.LblTC.ForeColor = System.Drawing.Color.White;
			this.LblTC.Location = new System.Drawing.Point(5, 88);
			this.LblTC.Name = "LblTC";
			this.LblTC.Size = new System.Drawing.Size(107, 18);
			this.LblTC.TabIndex = 5;
			this.LblTC.Text = "TC KİMLİK : ";
			// 
			// LblSoyad
			// 
			this.LblSoyad.AutoSize = true;
			this.LblSoyad.BackColor = System.Drawing.Color.Transparent;
			this.LblSoyad.ForeColor = System.Drawing.Color.White;
			this.LblSoyad.Location = new System.Drawing.Point(36, 58);
			this.LblSoyad.Name = "LblSoyad";
			this.LblSoyad.Size = new System.Drawing.Size(71, 18);
			this.LblSoyad.TabIndex = 6;
			this.LblSoyad.Text = "SOYAD :";
			// 
			// TxtAd
			// 
			this.TxtAd.Location = new System.Drawing.Point(116, 24);
			this.TxtAd.Name = "TxtAd";
			this.TxtAd.Size = new System.Drawing.Size(164, 26);
			this.TxtAd.TabIndex = 1;
			// 
			// MskTC
			// 
			this.MskTC.Location = new System.Drawing.Point(116, 84);
			this.MskTC.Mask = "00000000000";
			this.MskTC.Name = "MskTC";
			this.MskTC.Size = new System.Drawing.Size(164, 26);
			this.MskTC.TabIndex = 3;
			this.MskTC.ValidatingType = typeof(int);
			// 
			// TxtSoyad
			// 
			this.TxtSoyad.Location = new System.Drawing.Point(116, 54);
			this.TxtSoyad.Name = "TxtSoyad";
			this.TxtSoyad.Size = new System.Drawing.Size(164, 26);
			this.TxtSoyad.TabIndex = 2;
			// 
			// MskTel
			// 
			this.MskTel.Location = new System.Drawing.Point(116, 113);
			this.MskTel.Mask = "(999) 000-0000";
			this.MskTel.Name = "MskTel";
			this.MskTel.Size = new System.Drawing.Size(164, 26);
			this.MskTel.TabIndex = 4;
			// 
			// MskHesapNo
			// 
			this.MskHesapNo.Enabled = false;
			this.MskHesapNo.Location = new System.Drawing.Point(116, 145);
			this.MskHesapNo.Mask = "000000";
			this.MskHesapNo.Name = "MskHesapNo";
			this.MskHesapNo.Size = new System.Drawing.Size(164, 26);
			this.MskHesapNo.TabIndex = 5;
			this.MskHesapNo.ValidatingType = typeof(int);
			// 
			// MskSifre
			// 
			this.MskSifre.Location = new System.Drawing.Point(116, 176);
			this.MskSifre.Name = "MskSifre";
			this.MskSifre.Size = new System.Drawing.Size(164, 26);
			this.MskSifre.TabIndex = 6;
			this.MskSifre.UseSystemPasswordChar = true;
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnKaydet.Location = new System.Drawing.Point(116, 208);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(164, 35);
			this.BtnKaydet.TabIndex = 13;
			this.BtnKaydet.Text = "KAYDET";
			this.BtnKaydet.UseVisualStyleBackColor = true;
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button2.Location = new System.Drawing.Point(286, 144);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(39, 27);
			this.button2.TabIndex = 14;
			this.button2.Text = "...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// KayıtOl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(351, 335);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.BtnKaydet);
			this.Controls.Add(this.MskSifre);
			this.Controls.Add(this.MskHesapNo);
			this.Controls.Add(this.MskTel);
			this.Controls.Add(this.TxtSoyad);
			this.Controls.Add(this.TxtAd);
			this.Controls.Add(this.MskTC);
			this.Controls.Add(this.LblSoyad);
			this.Controls.Add(this.LblTC);
			this.Controls.Add(this.LblTel);
			this.Controls.Add(this.LblHesapNo);
			this.Controls.Add(this.LblSifre);
			this.Controls.Add(this.LblAd);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "KayıtOl";
			this.Text = "KayıtOl";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblAd;
		private System.Windows.Forms.Label LblSifre;
		private System.Windows.Forms.Label LblHesapNo;
		private System.Windows.Forms.Label LblTel;
		private System.Windows.Forms.Label LblTC;
		private System.Windows.Forms.Label LblSoyad;
		private System.Windows.Forms.TextBox TxtAd;
		private System.Windows.Forms.MaskedTextBox MskTC;
		private System.Windows.Forms.TextBox TxtSoyad;
		private System.Windows.Forms.MaskedTextBox MskTel;
		private System.Windows.Forms.MaskedTextBox MskHesapNo;
		private System.Windows.Forms.TextBox MskSifre;
		private System.Windows.Forms.Button BtnKaydet;
		private System.Windows.Forms.Button button2;
	}
}