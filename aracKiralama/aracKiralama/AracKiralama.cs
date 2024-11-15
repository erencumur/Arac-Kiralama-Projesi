using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aracKiralama
{
    class AracKiralama
    {
        SqlConnection _connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = AracKiralama; Integrated Security = True;");
        DataTable tablo;

        public void ekle_sil_guncelle(SqlCommand komut, string sorgu)
        {
            _connection.Open();
            komut.Connection = _connection;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            _connection.Close();
        } 

        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, _connection);
            adtr.Fill(tablo);
            _connection.Close();

            return tablo;
        }

        public void BosAraclar(ComboBox cbx, string query)
        {
            _connection.Open();
            SqlCommand kmt = new SqlCommand(query,_connection);
            SqlDataReader reader = kmt.ExecuteReader();
            while (reader.Read())
            {
                cbx.Items.Add(reader["Plaka"].ToString());
            }
            _connection.Close();
        }

        public void TC_Ara(TextBox tTcAra, TextBox tc, TextBox tAdSoyad, TextBox tTelefon, string query)
        {
            _connection.Open();
            SqlCommand kmt = new SqlCommand(query, _connection);
            SqlDataReader reader = kmt.ExecuteReader();
            while (reader.Read())
            {
                tc.Text = reader["Tc"].ToString();
                tAdSoyad.Text = reader["AdSoyad"].ToString();
                tTelefon.Text = reader["Telefon"].ToString();
            }
            _connection.Close();
        }

        public void ComboGetir(ComboBox araclar, TextBox tMarka, TextBox tModel, TextBox tYil, TextBox tRenk, string query)
        {
            _connection.Open();
            SqlCommand kmt = new SqlCommand(query, _connection);
            SqlDataReader reader = kmt.ExecuteReader();
            while (reader.Read())
            {
                tMarka.Text = reader["Marka"].ToString();
                tModel.Text = reader["Model"].ToString();
                tYil.Text = reader["Yil"].ToString();
                tRenk.Text = reader["Renk"].ToString();
            }
            _connection.Close();
        }

        public void Hesapla(ComboBox cKiraSekli, TextBox tKiraUcreti, string query)
        {
            _connection.Open();
            SqlCommand kmt = new SqlCommand(query, _connection);
            SqlDataReader reader = kmt.ExecuteReader();
            while (reader.Read())
            {
                if (cKiraSekli.SelectedIndex == 0)
                {
                    tKiraUcreti.Text = reader["KiraUcreti"].ToString();
                }

                if (cKiraSekli.SelectedIndex == 1)
                {
                    tKiraUcreti.Text = (int.Parse(reader["KiraUcreti"].ToString()) * 0.95).ToString();
                }

                if (cKiraSekli.SelectedIndex == 2)
                {
                    tKiraUcreti.Text = (int.Parse(reader["KiraUcreti"].ToString()) * 0.90).ToString();
                }

                if (cKiraSekli.SelectedIndex == 3)
                {
                    tKiraUcreti.Text = (int.Parse(reader["KiraUcreti"].ToString()) * 0.80).ToString();
                }
            }
            _connection.Close();
        }

        public void satisHespala(Label lbl)
        {
            _connection.Open();
            SqlCommand cmd = new SqlCommand("Select Sum(Tutar) from Satis",_connection);

            lbl.Text = "Toplam Tutar = " + cmd.ExecuteScalar() + " TL";
            _connection.Close();
        }
    }
}
