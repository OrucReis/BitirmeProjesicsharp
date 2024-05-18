using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;


namespace BitirmeProjesi
{
    public partial class YeniKayit : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bitirme_projesi;user=root");
        public YeniKayit()
        {
            InitializeComponent();
        }


        private void YeniKayit_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int satir;
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.CommandText = "INSERT INTO `tblgenelbilgiler` (`ogrno`, `ad`, `soyad`, `mezuntarih`, `eposta`, `ceptelefonu`, `evtelefonu`, `evulke`, `evsehir`, `evadres`, `notlar`) " +
                "VALUES (@pogrno,@pad,@psoyad,@pmezuntarih,@peposta,@pceptel,@pevtel,@pevulke,@pevsehir,@pevadres,@pnot) ";

            komut.Parameters.AddWithValue("@pogrno", txtOgrNo.Text);
            komut.Parameters.AddWithValue("@pad", txtAd.Text);
            komut.Parameters.AddWithValue("@psoyad",txtSoyad.Text );
            komut.Parameters.AddWithValue("@pmezuntarih", txtMezunTarih.Text);
            komut.Parameters.AddWithValue("@peposta", txtEposta.Text);
            komut.Parameters.AddWithValue("@pceptel", txtCepTel.Text);
            komut.Parameters.AddWithValue("@pevtel", txtEvTel.Text);
            komut.Parameters.AddWithValue("@pevulke", txtEvUlke.Text);
            komut.Parameters.AddWithValue("@pevsehir", txtEvSehir.Text);
            komut.Parameters.AddWithValue("@pevadres", txtEvAdres.Text);
            komut.Parameters.AddWithValue("@pnot", txtNot.Text);

            komut.Connection = baglanti;
            satir = komut.ExecuteNonQuery();
            MessageBox.Show(satir + " satır eklendi");
            komut.Dispose(); // Komut nesnesini yoket
            baglanti.Close(); // Bağlantıyı kapat

        }

        private void btnEgitimEkle_Click(object sender, EventArgs e)
        {
            int satir;
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand();
            
            komut.CommandText = "INSERT INTO `tblegitimbilgiler` (`akademik_egitim`, `baslangic`, `bitis`, `ulke`, `sehir`, `universite`, `ogrno`) " +
                "VALUES (@pakademikegitim,@baslangic,@pbitis,@pulke,@psehir,@puniversite,@pogrno)";

            komut.Parameters.AddWithValue("@pakademikegitim", txtAkademilEgitim.Text);
            komut.Parameters.AddWithValue("@baslangic", txtBaslangic.Text);
            komut.Parameters.AddWithValue("@pbitis", txtBitis.Text);
            komut.Parameters.AddWithValue("@pulke", txtUlke.Text);
            komut.Parameters.AddWithValue("@psehir", txtSehir.Text);
            komut.Parameters.AddWithValue("@puniversite", txtUniversite.Text);
            komut.Parameters.AddWithValue("@pogrno", txtOgrNo.Text);


            komut.Connection = baglanti;
            satir = komut.ExecuteNonQuery();
            MessageBox.Show(satir + " satır eklendi");
            komut.Dispose(); // Komut nesnesini yoket
            baglanti.Close(); // Bağlantıyı kapat
        }

        private void btnİsBilgileriEkle_Click(object sender, EventArgs e)
        {
            int satir;
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.CommandText = "INSERT INTO `tblisbilgiler` (`isegiristarih`, `istencikistarih`, `kamuozel`, `sektor`, `unvan`, `pozisyon`, `ogrno`, `mezuntarih`) " +
                "VALUES (@pisegiris,@pistencikis,@pkamuozel,@psektor,@punvan,@ppozisyon,@pogrno,@pmezun)";

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
            MessageBox.Show(satir + " satır eklendi");
            komut.Dispose(); // Komut nesnesini yoket
            baglanti.Close(); // Bağlantıyı kapat
        }
    }
}
