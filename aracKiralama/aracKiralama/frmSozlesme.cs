using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aracKiralama
{
    public partial class frmSozlesme : Form
    {
        AracKiralama arac = new AracKiralama();
        public frmSozlesme()
        {
            InitializeComponent();
        }

        private void frmSozlesme_Load(object sender, EventArgs e)
        {
            BosAraclar();

            Yenile();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query2 = "Select * from Arac Where Plaka Like '" + cbxAraclar.SelectedItem + "'";
            arac.ComboGetir(cbxAraclar, txtMarka, txtModel, txtYil, txtRenk, query2);
        }

        private void cbxKiraSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query2 = "Select * from Arac Where Plaka Like '" + cbxAraclar.SelectedItem + "'";

            arac.Hesapla(cbxKiraSekli, txtKiraUcreti, query2);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(dateDonus.Text) - DateTime.Parse(dateCikis.Text);
            int gun2 = gun.Days;
            txtGun.Text = gun2.ToString();

            txtTutar.Text = (gun2 * int.Parse(txtKiraUcreti.Text)).ToString();  //haftalıktasıkıntıvars
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            HesapTemizle();
        }

        private void btnSozlesmeEkle_Click(object sender, EventArgs e)
        {
            string query2 = "Insert into Sozlesme(Tc,AdSoyad,Telefon,EhliyetNo,EhliyetTarih,EhliyetYeri,Plaka,Marka,Model,Yil,Renk,KiraSekli,KiraUcreti,Gun,Tutar,CikisTarihi,DonusTarihi) " +
                "values(@Tc,@AdSoyad,@Telefon,@EhliyetNo,@EhliyetTarih,@EhliyetYeri,@Plaka,@Marka,@Model,@Yil,@Renk,@KiraSekli,@KiraUcreti,@Gun,@Tutar,@CikisTarihi,@DonusTarihi)";

            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.AddWithValue("@Tc", txtTc.Text);
            cmd.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@EhliyetNo", txtEhliyetNo.Text);
            cmd.Parameters.AddWithValue("@EhliyetTarih", txtEhliyetAlTarih.Text);
            cmd.Parameters.AddWithValue("@EhliyetYeri", txtEhliyetVerYer.Text);
            cmd.Parameters.AddWithValue("@Plaka", cbxAraclar.Text);
            cmd.Parameters.AddWithValue("@Marka", txtMarka.Text);
            cmd.Parameters.AddWithValue("@Model", txtModel.Text);
            cmd.Parameters.AddWithValue("@Yil", txtYil.Text);
            cmd.Parameters.AddWithValue("@Renk", txtRenk.Text);
            cmd.Parameters.AddWithValue("@KiraSekli", cbxKiraSekli.Text);
            cmd.Parameters.AddWithValue("@KiraUcreti", int.Parse(txtKiraUcreti.Text));
            cmd.Parameters.AddWithValue("@Gun", int.Parse(txtGun.Text));
            cmd.Parameters.AddWithValue("@Tutar", int.Parse(txtTutar.Text));
            cmd.Parameters.AddWithValue("@CikisTarihi", dateCikis.Text);
            cmd.Parameters.AddWithValue("@DonusTarihi", dateDonus.Text);

            arac.ekle_sil_guncelle(cmd, query2);

            string query3 = "Update Arac Set Durum='DOLU' Where Plaka = '" + cbxAraclar.Text + "'";
            SqlCommand cmd3 = new SqlCommand();
            arac.ekle_sil_guncelle(cmd3, query3);

            cbxAraclar.Items.Clear();
            BosAraclar();
            Yenile();

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            cbxAraclar.Text = "";
            HesapTemizle();

            MessageBox.Show("Sözleşme Eklendi");
        }

        private void HesapTemizle()
        {
            dateCikis.Text = DateTime.Now.ToShortDateString();
            dateDonus.Text = DateTime.Now.ToShortDateString();
            cbxKiraSekli.Text = "";
            txtKiraUcreti.Text = "";
            txtGun.Text = "";
            txtTutar.Text = "";
        }

        private void BosAraclar()
        {
            string query2 = "Select * from Arac Where Durum='BOS'";
            arac.BosAraclar(cbxAraclar, query2);
        }

        private void Yenile()
        {
            string query3 = "Select * from Sozlesme";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, query3);
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            if (txtTcAra.Text == "")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            string query2 = "Select * from Musteri Where Tc Like '" + txtTcAra.Text + "'";
            arac.TC_Ara(txtTcAra, txtTc, txtAdSoyad, txtTelefon, query2);
        }

        private void btnSozlesmeGuncelle_Click(object sender, EventArgs e)
        {
            string query2 = "Update Sozlesme Set Tc=@Tc, AdSoyad=@AdSoyad,Telefon=@Telefon, EhliyetNo=@EhliyetNo, " +
                "EhliyetTarih=@EhliyetTarih, EhliyetYeri=@EhliyetYeri, Marka=@Marka, Model=@Model, Yil=@Yil, " +
                "Renk=@Renk, KiraSekli=@KiraSekli, KiraUcreti=@KiraUcreti, Gun=@Gun, Tutar=@Tutar, CikisTarihi=@CikisTarihi, " +
                "DonusTarihi=@DonusTarihi Where Plaka=@Plaka";

            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.AddWithValue("@Tc", txtTc.Text);
            cmd.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@EhliyetNo", txtEhliyetNo.Text);
            cmd.Parameters.AddWithValue("@EhliyetTarih", txtEhliyetAlTarih.Text);
            cmd.Parameters.AddWithValue("@EhliyetYeri", txtEhliyetVerYer.Text);
            cmd.Parameters.AddWithValue("@Plaka", cbxAraclar.Text);
            cmd.Parameters.AddWithValue("@Marka", txtMarka.Text);
            cmd.Parameters.AddWithValue("@Model", txtModel.Text);
            cmd.Parameters.AddWithValue("@Yil", txtYil.Text);
            cmd.Parameters.AddWithValue("@Renk", txtRenk.Text);
            cmd.Parameters.AddWithValue("@KiraSekli", cbxKiraSekli.Text);
            cmd.Parameters.AddWithValue("@KiraUcreti", int.Parse(txtKiraUcreti.Text));
            cmd.Parameters.AddWithValue("@Gun", int.Parse(txtGun.Text));
            cmd.Parameters.AddWithValue("@Tutar", int.Parse(txtTutar.Text));
            cmd.Parameters.AddWithValue("@CikisTarihi", dateCikis.Text);
            cmd.Parameters.AddWithValue("@DonusTarihi", dateDonus.Text);

            arac.ekle_sil_guncelle(cmd, query2);

            cbxAraclar.Items.Clear();
            BosAraclar();
            Yenile();

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            cbxAraclar.Text = "";
            HesapTemizle();

            MessageBox.Show("Sözleşme Güncellendi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtTc.Text = satir.Cells[0].Value.ToString();
            txtAdSoyad.Text = satir.Cells[1].Value.ToString();
            txtTelefon.Text = satir.Cells[2].Value.ToString();
            txtEhliyetNo.Text = satir.Cells[3].Value.ToString();
            txtEhliyetAlTarih.Text = satir.Cells[4].Value.ToString();
            txtEhliyetVerYer.Text = satir.Cells[5].Value.ToString();
            cbxAraclar.Text = satir.Cells[6].Value.ToString();
            txtMarka.Text = satir.Cells[7].Value.ToString();
            txtModel.Text = satir.Cells[8].Value.ToString();
            txtYil.Text = satir.Cells[9].Value.ToString();
            txtRenk.Text = satir.Cells[10].Value.ToString();
            cbxKiraSekli.Text = satir.Cells[11].Value.ToString();
            txtKiraUcreti.Text = satir.Cells[12].Value.ToString();
            txtGun.Text = satir.Cells[13].Value.ToString();
            txtTutar.Text = satir.Cells[14].Value.ToString();
            dateCikis.Text = satir.Cells[15].Value.ToString();
            dateDonus.Text = satir.Cells[16].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;

            //Gün Farkı Hesapla
            DateTime bgn = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime dns = DateTime.Parse(satir.Cells["DonusTarihi"].Value.ToString());
            int ucret = int.Parse(satir.Cells["KiraUcreti"].Value.ToString());
            TimeSpan gunFarki = bgn - dns;
            int _gunFarki = gunFarki.Days;
            int ucretFarki;

            //Ücret Farkı Hesapla
            ucretFarki = _gunFarki * ucret;
            txtEkstra.Text = ucretFarki.ToString();

            //Toplam Tutar Hesapla
        }

        private void btnAracTeslim_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtEkstra.Text) >= 0 || int.Parse(txtEkstra.Text) < 0)
            {
                DataGridViewRow satir = dataGridView1.CurrentRow;
                DateTime bgn = DateTime.Parse(DateTime.Now.ToShortDateString());

                int ucret = int.Parse(satir.Cells["KiraUcreti"].Value.ToString());
                decimal tutar = decimal.Parse(satir.Cells["Tutar"].Value.ToString());

                DateTime cikis = DateTime.Parse(satir.Cells["CikisTarihi"].Value.ToString());

                TimeSpan gun = bgn - cikis;
                int _gun = gun.Days;
                int toplamTutar = _gun * ucret;

                //int _km = int.Parse()

                //toplamTutar, _gun ve ucret satis tablosuna aktarılacak
                string query1 = "Delete from Sozlesme Where Plaka='" + satir.Cells["Plaka"].Value.ToString() + "'";
                SqlCommand kmt = new SqlCommand();
                arac.ekle_sil_guncelle(kmt,query1);

                string query2 = "Update Arac Set Durum='BOS' Where Plaka='"+satir.Cells["Plaka"].Value.ToString()+"'";
                SqlCommand kmt2 = new SqlCommand();
                arac.ekle_sil_guncelle(kmt2, query2);

                string query3 = "Insert into Satis(Tc,AdSoyad,Plaka,Marka,Model,Yil,Renk,Gun,Fiyat,Tutar,KiralamaTarihi,TeslimTarihi,DonusTarihi) " +
                "values(@Tc,@AdSoyad,@Plaka,@Marka,@Model,@Yil,@Renk,@Gun,@Fiyat,@Tutar,@KiralamaTarihi,@TeslimTarihi,@DonusTarihi)";

                SqlCommand kmt3 = new SqlCommand();
                kmt3.Parameters.AddWithValue("@Tc", satir.Cells["Tc"].Value.ToString());
                kmt3.Parameters.AddWithValue("@AdSoyad", satir.Cells["AdSoyad"].Value.ToString());
                kmt3.Parameters.AddWithValue("@Plaka", satir.Cells["Plaka"].Value.ToString());
                kmt3.Parameters.AddWithValue("@Marka", satir.Cells["Marka"].Value.ToString());
                kmt3.Parameters.AddWithValue("@Model", satir.Cells["Model"].Value.ToString());
                kmt3.Parameters.AddWithValue("@Yil", satir.Cells["Yil"].Value.ToString());
                kmt3.Parameters.AddWithValue("@Renk", satir.Cells["Renk"].Value.ToString());
                kmt3.Parameters.AddWithValue("@Gun", _gun);
                kmt3.Parameters.AddWithValue("@Fiyat", ucret);
                kmt3.Parameters.AddWithValue("@Tutar", toplamTutar);
                kmt3.Parameters.AddWithValue("@KiralamaTarihi", satir.Cells["CikisTarihi"].Value.ToString());
                kmt3.Parameters.AddWithValue("@TeslimTarihi", DateTime.Now.ToShortDateString());
                kmt3.Parameters.AddWithValue("@DonusTarihi", satir.Cells["DonusTarihi"].Value.ToString());

                arac.ekle_sil_guncelle(kmt3,query3);

                MessageBox.Show("Araç Telsim Edildi");
                cbxAraclar.Text = "";

                cbxAraclar.Items.Clear();
                BosAraclar();
                Yenile();
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                cbxAraclar.Text = "";
                HesapTemizle();

                txtEkstra.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapınız", "Uyarı");
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
