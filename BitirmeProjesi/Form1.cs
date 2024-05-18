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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnGirisYap_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string s1 = "SELECT * FROM tblgenelbilgiler WHERE ogrno = @id AND sifre = @sifre";
            string s2 = "SELECT * FROM kullanicilar WHERE id = @id AND sifre = @sifre AND pozisyon = 'sekreter'";

            using (MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bitirme_projesi;user=root"))
            {
                baglanti.Open();

                using (MySqlCommand cmd1 = new MySqlCommand(s1, baglanti))
                {
                    cmd1.Parameters.AddWithValue("@id", txtKullaniciAdi.Text);
                    cmd1.Parameters.AddWithValue("@sifre", txtSifre.Text);

                    using (MySqlDataReader reader1 = cmd1.ExecuteReader())
                    {
                        if (reader1.HasRows)
                        {
                            // Student logged in
                            this.Hide();
                            string text = txtKullaniciAdi.Text;
                            KayitOgrenci kayitOgrenci = new KayitOgrenci();
                            kayitOgrenci.ReceiveData(text);
                            kayitOgrenci.ShowDialog();
                            return; // Exit the method after successful login
                        }
                    }
                }

                using (MySqlCommand cmd2 = new MySqlCommand(s2, baglanti))
                {
                    cmd2.Parameters.AddWithValue("@id", txtKullaniciAdi.Text);
                    cmd2.Parameters.AddWithValue("@sifre", txtSifre.Text);

                    using (MySqlDataReader reader2 = cmd2.ExecuteReader())
                    {
                        if (reader2.HasRows)
                        {
                            // Secretary logged in
                            this.Hide();
                            Kayit kayit = new Kayit();
                            kayit.ShowDialog();
                            return; // Exit the method after successful login
                        }
                    }
                }

                // If no login was successful
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
