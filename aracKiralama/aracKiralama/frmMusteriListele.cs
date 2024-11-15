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
    public partial class frmMusteriListele : Form
    {
        AracKiralama arackiralama = new AracKiralama();

        public frmMusteriListele()
        {
            InitializeComponent();
        }

        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            Yenile_Listele();
        }

        private void Yenile_Listele()
        {
            string cumle = "Select * from Musteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();

            dataGridView1.DataSource = arackiralama.listele(adtr2, cumle);
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "AD-SOYAD";
            dataGridView1.Columns[2].HeaderText = "TELEFON";
            dataGridView1.Columns[3].HeaderText = "ADRES";
            dataGridView1.Columns[4].HeaderText = "E-MAİL";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cumle = "Select * from Musteri Where Tc Like '%"+textBox1.Text+"%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            
            dataGridView1.DataSource = arackiralama.listele(adtr2, cumle);
        }

        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtTc.Text = satir.Cells[0].Value.ToString();
            txtAdSoyad.Text = satir.Cells[1].Value.ToString();
            txtTelefon.Text = satir.Cells[2].Value.ToString();
            txtAdres.Text = satir.Cells[3].Value.ToString();
            txtEMail.Text = satir.Cells[4].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string cumle = "Update Musteri Set AdSoyad = @AdSoyad, Telefon=@Telefon, Adres=@Adres, EMail=@EMail Where Tc=@Tc";
            
            SqlCommand komut2 = new SqlCommand();

            komut2.Parameters.AddWithValue("@Tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@EMail", txtEMail.Text);

            arackiralama.ekle_sil_guncelle(komut2, cumle);
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            Yenile_Listele();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;

            string cumle = "Delete from Musteri Where Tc='" + satir.Cells["Tc"].Value.ToString() +"'";
            SqlCommand komut2 = new SqlCommand();

            arackiralama.ekle_sil_guncelle(komut2, cumle);

            Yenile_Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
