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
    public partial class frmAracKayit : Form
    {
        AracKiralama arackiralama = new AracKiralama();

        public frmAracKayit()
        {
            InitializeComponent();
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbxModel.Items.Clear();
                if (cbxMarka.SelectedIndex == 0)
                {
                    cbxModel.Items.Add("Egea");
                    cbxModel.Items.Add("Egea Cross");
                    cbxModel.Items.Add("Egea HB");
                    cbxModel.Items.Add("Doblo");
                    cbxModel.Items.Add("Doblo-van");
                    cbxModel.Items.Add("Fiorino");
                    cbxModel.Items.Add("Ulysse");
                    cbxModel.Items.Add("500X");
                    cbxModel.Items.Add("Ducato Van");
                    cbxModel.Items.Add("Ducato Kamyonet");
                    cbxModel.Items.Add("Ducato Minibüs");
                    cbxModel.Items.Add("Ducato Karavan");
                }
                else if (cbxMarka.SelectedIndex == 1)
                {
                    cbxModel.Items.Add("Yaris");
                    cbxModel.Items.Add("Corolla");
                    cbxModel.Items.Add("C-HR");
                    cbxModel.Items.Add("RAV-4");
                    cbxModel.Items.Add("Hilux");
                    cbxModel.Items.Add("Auris");
                }

                else if (cbxMarka.SelectedIndex == 2)
                {
                    cbxModel.Items.Add("Clio");
                    cbxModel.Items.Add("Symbol");
                    cbxModel.Items.Add("Taliant");
                    cbxModel.Items.Add("Megane");
                    cbxModel.Items.Add("Kadjar");
                    cbxModel.Items.Add("Talisman");

                }

                else if (cbxMarka.SelectedIndex == 3)
                {
                    cbxModel.Items.Add("Corsa");
                    cbxModel.Items.Add("Astra");
                    cbxModel.Items.Add("Astra HB");
                    cbxModel.Items.Add("Insignia");
                    cbxModel.Items.Add("Crossland");
                    cbxModel.Items.Add("Mokka");
                    cbxModel.Items.Add("Grandland-X");
                }

                else if (cbxMarka.SelectedIndex == 4)
                {
                    cbxModel.Items.Add("Fiesta");
                    cbxModel.Items.Add("Focus");
                    cbxModel.Items.Add("Puma");
                    cbxModel.Items.Add("Kuga");
                    cbxModel.Items.Add("Tourneo Courier");
                    cbxModel.Items.Add("Transit Courier");
                    cbxModel.Items.Add("Tourneo Connect");

                }

                else if (cbxMarka.SelectedIndex == 5)
                {
                    cbxModel.Items.Add("Golf");
                    cbxModel.Items.Add("T-Roc");
                    cbxModel.Items.Add("Tiguan RLine");
                    cbxModel.Items.Add("Touareg");
                    cbxModel.Items.Add("Caddy");
                    cbxModel.Items.Add("Passat");

                }

                else if (cbxMarka.SelectedIndex == 6)
                {
                    cbxModel.Items.Add("301");
                    cbxModel.Items.Add("308");
                    cbxModel.Items.Add("508");
                    cbxModel.Items.Add("3008");
                    cbxModel.Items.Add("5008");

                }

                else if (cbxMarka.SelectedIndex == 7)
                {
                    cbxModel.Items.Add("Yeni i10");
                    cbxModel.Items.Add("i20");
                    cbxModel.Items.Add("i20 N");
                    cbxModel.Items.Add("Tucson");
                    cbxModel.Items.Add("Elantra");
                    cbxModel.Items.Add("Bayon");
                    cbxModel.Items.Add("Kona");

                }
            }
            catch
            {
                ;
            }
            
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            string cumle = "Insert into Arac(Plaka,Marka,Model,Yil,Renk,Kilometre,MotorGucu,YakitTipi,KiraUcreti,Resim,Tarih,Durum) values(@Plaka,@Marka,@Model,@Yil,@Renk,@Kilometre,@MotorGucu,@YakitTipi,@KiraUcreti,@Resim,@Tarih,@Durum)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@Plaka",txtPlaka.Text);
            komut2.Parameters.AddWithValue("@Marka",cbxMarka.Text);
            komut2.Parameters.AddWithValue("@Model",cbxModel.Text);
            komut2.Parameters.AddWithValue("@Yil",txtYil.Text);
            komut2.Parameters.AddWithValue("@Renk",txtRenk.Text);
            komut2.Parameters.AddWithValue("@Kilometre",txtKm.Text);
            komut2.Parameters.AddWithValue("@MotorGucu",txtMotorGucu.Text);
            komut2.Parameters.AddWithValue("@YakitTipi",cbxYakitTipi.Text);
            komut2.Parameters.AddWithValue("@KiraUcreti",int.Parse(txtUcret.Text));
            komut2.Parameters.AddWithValue("@Resim",pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@Tarih",DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@Durum","BOS");

            arackiralama.ekle_sil_guncelle(komut2,cumle);
            cbxModel.Items.Clear();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }

            pictureBox1.ImageLocation = "";
        }

        private void frmAracKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
