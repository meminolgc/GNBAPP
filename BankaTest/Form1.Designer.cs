namespace BankaTest
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.MskHesapNo = new System.Windows.Forms.MaskedTextBox();
			this.TxtSifre = new System.Windows.Forms.TextBox();
			this.BtnGirisYap = new System.Windows.Forms.Button();
			this.LnkKayitOl = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(78, 183);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hesap No:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(119, 216);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Şifre:";
			// 
			// MskHesapNo
			// 
			this.MskHesapNo.Location = new System.Drawing.Point(176, 179);
			this.MskHesapNo.Mask = "000000";
			this.MskHesapNo.Name = "MskHesapNo";
			this.MskHesapNo.Size = new System.Drawing.Size(187, 26);
			this.MskHesapNo.TabIndex = 1;
			this.MskHesapNo.ValidatingType = typeof(int);
			// 
			// TxtSifre
			// 
			this.TxtSifre.Location = new System.Drawing.Point(176, 212);
			this.TxtSifre.Name = "TxtSifre";
			this.TxtSifre.Size = new System.Drawing.Size(187, 26);
			this.TxtSifre.TabIndex = 2;
			this.TxtSifre.UseSystemPasswordChar = true;
			// 
			// BtnGirisYap
			// 
			this.BtnGirisYap.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnGirisYap.Location = new System.Drawing.Point(176, 244);
			this.BtnGirisYap.Name = "BtnGirisYap";
			this.BtnGirisYap.Size = new System.Drawing.Size(187, 35);
			this.BtnGirisYap.TabIndex = 3;
			this.BtnGirisYap.Text = "Giriş Yap";
			this.BtnGirisYap.UseVisualStyleBackColor = true;
			this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
			// 
			// LnkKayitOl
			// 
			this.LnkKayitOl.AutoSize = true;
			this.LnkKayitOl.BackColor = System.Drawing.Color.Transparent;
			this.LnkKayitOl.LinkColor = System.Drawing.Color.White;
			this.LnkKayitOl.Location = new System.Drawing.Point(170, 282);
			this.LnkKayitOl.Name = "LnkKayitOl";
			this.LnkKayitOl.Size = new System.Drawing.Size(66, 18);
			this.LnkKayitOl.TabIndex = 4;
			this.LnkKayitOl.TabStop = true;
			this.LnkKayitOl.Text = "Kayıt Ol";
			this.LnkKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkKayitOl_LinkClicked);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.LinkColor = System.Drawing.Color.White;
			this.linkLabel1.Location = new System.Drawing.Point(240, 282);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(128, 18);
			this.linkLabel1.TabIndex = 5;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Şifremi Unuttum";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(65, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(317, 171);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			//this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(454, 335);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.LnkKayitOl);
			this.Controls.Add(this.BtnGirisYap);
			this.Controls.Add(this.TxtSifre);
			this.Controls.Add(this.MskHesapNo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "GNB";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox MskHesapNo;
		private System.Windows.Forms.TextBox TxtSifre;
		private System.Windows.Forms.Button BtnGirisYap;
		private System.Windows.Forms.LinkLabel LnkKayitOl;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

