using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aracKiralama
{
	public partial class frmMusteriEkle : Form
	{
		AracKiralama arac_kiralama = new AracKiralama();

		public frmMusteriEkle()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string cumle = "Insert into Musteri(Tc,AdSoyad,Telefon,Adres,EMail) values(@Tc,@AdSoyad,@Telefon,@Adres,@EMail)";
			SqlCommand komut2 = new SqlCommand();
			if (txtTc.Text.Length == 11)
			{
				komut2.Parameters.AddWithValue("@Tc", txtTc.Text);
				komut2.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
				komut2.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
				komut2.Parameters.AddWithValue("@Adres", txtAdres.Text);
				komut2.Parameters.AddWithValue("@EMail", txtEMail.Text);

				arac_kiralama.ekle_sil_guncelle(komut2, cumle);

				foreach (Control item in Controls)
				{
					if (item is TextBox)
					{
						item.Text = "";
					}
				}
			}
			else
			{
				MessageBox.Show("TC kimlik numarası 11 haneden oluşmalıdır.");
			}

		}

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
