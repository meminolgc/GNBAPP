using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankaTest
{
	public partial class KayıtOl : Form
	{
		public KayıtOl()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection(@"Data Source=emin\SQLEXPRESS;Initial Catalog=BankaDb;Integrated Security=True;Encrypt=False");
		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into TBLKISILER (Ad, Soyad, TC, Telefon, HesapNo, Sıfre) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
			komut.Parameters.AddWithValue("@p1", TxtAd.Text);
			komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
			komut.Parameters.AddWithValue("@p3", MskTC.Text);
			komut.Parameters.AddWithValue("@p4", MskTel.Text);
			komut.Parameters.AddWithValue("@p5", MskHesapNo.Text);
			komut.Parameters.AddWithValue("@p6", MskSifre.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Müşteri Bilgileri Sisteme Kaydedildi");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();	
			int sayi = rnd.Next(100000, 1000000);
			MskHesapNo.Text = sayi.ToString();
		}
	}
}
