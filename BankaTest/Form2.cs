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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		public string hesap;

		SqlConnection baglanti = new SqlConnection(@"Data Source=emin\SQLEXPRESS;Initial Catalog=BankaDb;Integrated Security=True;Encrypt=False");

		private void Form2_Load(object sender, EventArgs e)
		{
			LblHesapNo.Text = hesap;

			baglanti.Open();
			SqlCommand komut = new SqlCommand("Select * From TblKısıler where hesapno=@p1", baglanti);
			komut.Parameters.AddWithValue("@p1", hesap);
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				LblAdSoyad.Text = dr[1] + " " + dr[2];
				LblTc.Text = dr[3].ToString();
				LblTel.Text = dr[4].ToString();	
			}
			baglanti.Close();
		}

		private void BtnGonder_Click(object sender, EventArgs e)
		{
			//Gönderilen hesabın para artışı
			baglanti.Open();
			SqlCommand komut = new SqlCommand("update tblhesap set bakıye=bakıye+@p1 where hesapno=@p2", baglanti);
			komut.Parameters.AddWithValue("@p1", decimal.Parse(TxtTutar.Text));	
			komut.Parameters.AddWithValue("@p2", MskHesapNo.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();

			//Gönderen hesabın para azalışı
			baglanti.Open();
			SqlCommand komut2 = new SqlCommand("update tblhesap set bakıye=bakıye-@k1 where hesapno=@k2", baglanti);
			komut2.Parameters.AddWithValue("@k1", decimal.Parse(TxtTutar.Text));
			komut2.Parameters.AddWithValue("@k2", hesap);
			komut2.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("İşlem gerçekleşti");

		}
	}
}
