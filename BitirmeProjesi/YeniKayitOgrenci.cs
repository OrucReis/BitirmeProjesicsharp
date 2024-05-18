using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BitirmeProjesi
{
    public partial class YeniKayitOgrenci : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bitirme_projesi;user=root");
        public YeniKayitOgrenci()
        {
            InitializeComponent();
        }
        private string kullaniciadi;

        public void ReceiveData(string data)
        {
            kullaniciadi = data;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Int32 satir;
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand();
            // Insert Into SQL komutu ile tablomuza formdaki 
            //verileri yine parametreli şekilde gönderiyoruz.
            
            komut.CommandText = "UPDATE `tblgenelbilgiler` SET `ad` = @pad, `soyad` = @psoyad, `mezuntarih` = @pmezuntarih, `eposta` = @peposta," +
                " `ceptelefonu` = @pceptel, `evtelefonu` = @pevtel, `evulke` = @pevulke, `evsehir` = @pevsehir, `evadres` = @pevadres, `notlar` = @pnot " +
                "WHERE `tblgenelbilgiler`.`ogrno` = @pogrno";


            
            komut.Parameters.AddWithValue("@pad", txtAd.Text);
            komut.Parameters.AddWithValue("@psoyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@pmezuntarih", txtMezunTarih.Text);
            komut.Parameters.AddWithValue("@peposta", txtEposta.Text);
            komut.Parameters.AddWithValue("@pceptel", txtCepTel.Text);
            komut.Parameters.AddWithValue("@pevtel", txtEvTel.Text);
            komut.Parameters.AddWithValue("@pevulke", txtEvUlke.Text);
            komut.Parameters.AddWithValue("@pevsehir", txtEvSehir.Text);
            komut.Parameters.AddWithValue("@pevadres", txtEvAdres.Text);
            komut.Parameters.AddWithValue("@pnot", txtNot.Text);
            komut.Parameters.AddWithValue("@pogrno", txtOgrNo.Text);

            komut.Connection = baglanti;
            satir = komut.ExecuteNonQuery();
            MessageBox.Show(satir + " satır değişti");
            komut.Dispose(); // Komut nesnesini yoket
            baglanti.Close(); // Bağlantıyı kapat
        }

        private void btnEgitimGuncelle_Click(object sender, EventArgs e)
        {
            Int32 satir;
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand();
            // Insert Into SQL komutu ile tablomuza formdaki 
            //verileri yine parametreli şekilde gönderiyoruz.
            komut.CommandText = "UPDATE `tblegitimbilgiler` SET `akademik_egitim` = @pakademikegitim, `baslangic` = @baslangic, `bitis` = @pbitis," +
                " `ulke` = @pulke, `sehir` = @psehir, `universite` = @puniversite, `ogrno` = @pogrno WHERE `tblegitimbilgiler`.`ogrno` = @pogrno";

            komut.Parameters.AddWithValue("@pakademikegitim", txtAkademilEgitim.Text);
            komut.Parameters.AddWithValue("@baslangic", txtBaslangic.Text);
            komut.Parameters.AddWithValue("@pbitis", txtBitis.Text);
            komut.Parameters.AddWithValue("@pulke", txtUlke.Text);
            komut.Parameters.AddWithValue("@psehir", txtSehir.Text);
            komut.Parameters.AddWithValue("@puniversite", txtUniversite.Text);
            komut.Parameters.AddWithValue("@pogrno", txtOgrNo.Text);

            komut.Connection = baglanti;
            satir = komut.ExecuteNonQuery();
            MessageBox.Show(satir + " satır değişti");
            komut.Dispose(); // Komut nesnesini yoket
            baglanti.Close(); // Bağlantıyı kapat

        }

        private void btnİsBilgileriGuncelle_Click(object sender, EventArgs e)
        {
            Int32 satir;
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand();
            // Insert Into SQL komutu ile tablomuza formdaki 
            //verileri yine parametreli şekilde gönderiyoruz.
            komut.CommandText = "UPDATE `tblisbilgiler` SET `isegiristarih` = @pisegiris, `istencikistarih` = @pistencikis, `kamuozel` = @pkamuozel," +
                " `sektor` = @psektor, `unvan` = @punvan, `pozisyon` = @ppozisyon, `ogrno` = @pogrno, `mezuntarih` = @pmezun WHERE `tblisbilgiler`.`ogrno` = @pogrno";


            komut.Parameters.AddWithValue("@pisegiris", txtIseGirisTarihi.Text);
            komut.Parameters.AddWithValue("@pistencikis", txtIstenCikisTarihi.Text);
            komut.Parameters.AddWithValue("@pkamuozel", txtKamuOzel.Text);
            komut.Parameters.AddWithValue("@psektor", txtSektor.Text);
            komut.Parameters.AddWithValue("@punvan", txtUnvan.Text);
            komut.Parameters.AddWithValue("@ppozisyon", txtPozisyon.Text);
            komut.Parameters.AddWithValue("@pogrno", txtOgrNo.Text);
            komut.Parameters.AddWithValue("@pmezun", txtMezunTarih.Text);

            komut.Connection = baglanti;
            satir = komut.ExecuteNonQuery();
            MessageBox.Show(satir + " satır değişti");
            komut.Dispose(); // Komut nesnesini yoket
            baglanti.Close(); // Bağlantıyı kapat
        }

        private void YeniKayitOgrenci_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string query1 = "SELECT * FROM tblgenelbilgiler WHERE ogrno = @ad";
                MySqlCommand cmd1 = new MySqlCommand(query1, baglanti);
                cmd1.Parameters.AddWithValue("@ad", kullaniciadi);
                using (MySqlDataReader dataReader1 = cmd1.ExecuteReader())
                {
                    if (dataReader1.Read())
                    {
                        txtOgrNo.Text = dataReader1["ogrno"].ToString();
                        txtAd.Text = dataReader1["ad"].ToString();
                        txtSoyad.Text = dataReader1["soyad"].ToString();
                        txtMezunTarih.Text = dataReader1["mezuntarih"].ToString();
                        txtEposta.Text = dataReader1["eposta"].ToString();
                        txtCepTel.Text = dataReader1["ceptelefonu"].ToString();
                        txtEvTel.Text = dataReader1["evtelefonu"].ToString();
                        txtEvUlke.Text = dataReader1["evulke"].ToString();
                        txtEvSehir.Text = dataReader1["evsehir"].ToString();
                        txtEvAdres.Text = dataReader1["evadres"].ToString();
                        txtNot.Text = dataReader1["notlar"].ToString();
                        dataReader1.Close();

                    }
                }

                string query2 = "SELECT * FROM tblegitimbilgiler WHERE ogrno = @ad";
                MySqlCommand cmd2 = new MySqlCommand(query2, baglanti);
                cmd2.Parameters.AddWithValue("@ad", kullaniciadi);
                using (MySqlDataReader dataReader2 = cmd2.ExecuteReader())
                {
                    if (dataReader2.Read())
                    {
                        txtAkademilEgitim.Text = dataReader2["akademik_egitim"].ToString();
                        txtBaslangic.Text = dataReader2["baslangic"].ToString();
                        txtBitis.Text = dataReader2["bitis"].ToString();
                        txtUlke.Text = dataReader2["ulke"].ToString();
                        txtSehir.Text = dataReader2["sehir"].ToString();
                        txtUniversite.Text = dataReader2["universite"].ToString();
                        dataReader2.Close();

                    }
                }

                string query3 = "SELECT * FROM tblisbilgiler WHERE ogrno = @ad";
                MySqlCommand cmd3 = new MySqlCommand(query3, baglanti);
                cmd3.Parameters.AddWithValue("@ad", kullaniciadi);
                using (MySqlDataReader dataReader3 = cmd3.ExecuteReader())
                {
                    if (dataReader3.Read())
                    {
                        txtIseGirisTarihi.Text = dataReader3["isegiristarih"].ToString();
                        txtIstenCikisTarihi.Text = dataReader3["istencikistarih"].ToString();
                        txtKamuOzel.Text = dataReader3["kamuozel"].ToString();
                        txtSektor.Text = dataReader3["sektor"].ToString();
                        txtUnvan.Text = dataReader3["unvan"].ToString();
                        txtPozisyon.Text = dataReader3["pozisyon"].ToString();
                        dataReader3.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

    }
}
