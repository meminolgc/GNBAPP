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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection(@"Data Source=emin\SQLEXPRESS;Initial Catalog=BankaDb;Integrated Security=True;Encrypt=False");
		private void LnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			KayıtOl kyt = new KayıtOl();
			kyt.Show();
		}

		private void BtnGirisYap_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("Select * From TBLKISILER where hesapno=@p1 and sıfre=@p2", baglanti);
			komut.Parameters.AddWithValue("@p1", MskHesapNo.Text);
			komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
			SqlDataReader dr = komut.ExecuteReader();
			if (dr.Read())
			{
				Form2 fr = new Form2();
				fr.hesap = MskHesapNo.Text;
				fr.Show();
			}
			else
			{
				MessageBox.Show("Hatalı Bilgi");
			}
			baglanti.Close();
		}

		private void pictureBox1_DoubleClick(object sender, EventArgs e)
		{
			MessageBox.Show("Barney Stinson was here");
		}
	}
}
