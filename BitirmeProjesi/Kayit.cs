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
    public partial class Kayit : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bitirme_projesi;user=root");
        public Kayit()
        {
            InitializeComponent();
        }
        
        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            YeniKayit kayit = new YeniKayit();
            kayit.Show();
        }

        private void btnDigerRapor_Click(object sender, EventArgs e)
        {
            Raporlar raporlar = new Raporlar();
            raporlar.Show();
        }



        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnKaydiSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                try
                {
                    if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells[0].Value != null)
                    {
                        string ogrno = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                        using (MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bitirme_projesi;user=root"))
                        {
                            baglanti.Open();

                            // Yabancı anahtar kısıtlamalarını geçici olarak kaldırmak için bağlantı üzerinden işlem yapacağız
                            using (MySqlCommand kisitKaldirKomut = new MySqlCommand("SET FOREIGN_KEY_CHECKS=0", baglanti))
                            {
                                kisitKaldirKomut.ExecuteNonQuery();
                            }

                            using (MySqlCommand komut = new MySqlCommand())
                            {
                                komut.CommandText = "DELETE FROM tblgenelbilgiler WHERE ogrno = @pogrno";
                                komut.Parameters.AddWithValue("@pogrno", ogrno);
                                komut.Connection = baglanti;

                                int satir = komut.ExecuteNonQuery();

                            }
                            using (MySqlCommand komut = new MySqlCommand())
                            {
                                komut.CommandText = "DELETE FROM tblisbilgiler WHERE ogrno = @pogrno";
                                komut.Parameters.AddWithValue("@pogrno", ogrno);
                                komut.Connection = baglanti;

                                int satir = komut.ExecuteNonQuery();

                            }
                            using (MySqlCommand komut = new MySqlCommand())
                            {
                                komut.CommandText = "DELETE FROM tblegitimbilgiler WHERE ogrno = @pogrno";
                                komut.Parameters.AddWithValue("@pogrno", ogrno);
                                komut.Connection = baglanti;

                                int satir = komut.ExecuteNonQuery();
                                MessageBox.Show("satır silindi","SİLME",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }

                            // Yabancı anahtar kısıtlamalarını geri yükle
                            using (MySqlCommand kisitYerineKoyKomut = new MySqlCommand("SET FOREIGN_KEY_CHECKS=1", baglanti))
                            {
                                kisitYerineKoyKomut.ExecuteNonQuery();
                            }
                        }
                        listele(); // Veriyi güncelle
                    }
                    else
                    {
                        MessageBox.Show("Bir öğrenci seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void listele()
        {
            using (MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bitirme_projesi;user=root"))
            {
                baglanti.Open();
                MySqlDataAdapter adaptor = new MySqlDataAdapter("SELECT * FROM tblgenelbilgiler ORDER BY ogrno", baglanti);
                DataTable dt = new DataTable();
                adaptor.Fill(dt); // Tabloyu doldur
                dataGridView1.DataSource = dt; //Datagrid doldur
                adaptor.Dispose(); //Adaptor ü kapat
            } //Bağlantı burada otomatik olarak kapatılır
        }


    }
}
