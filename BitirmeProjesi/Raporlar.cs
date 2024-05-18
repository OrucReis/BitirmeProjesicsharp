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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {

        }

        private void btnDoktoraYapan_Click(object sender, EventArgs e)
        {
            Bosalt();
            using (MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bitirme_projesi;user=root"))
            {
                baglanti.Open();
                MySqlDataAdapter adaptor = new MySqlDataAdapter("SELECT * FROM tblegitimbilgiler WHERE akademik_egitim='doktora' ORDER BY ogrno", baglanti);
                DataTable dt = new DataTable();
                adaptor.Fill(dt); // Tabloyu doldur
                dataGridView1.DataSource = dt; //Datagrid doldur
                adaptor.Dispose(); //Adaptor ü kapat
            } //Bağlantı burada otomatik olarak kapatılır
        }

        private void btnDoktoraTurkiye_Click(object sender, EventArgs e)
        {
            Bosalt();
            using (MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bitirme_projesi;user=root"))
            {
                baglanti.Open();
                MySqlDataAdapter adaptor = new MySqlDataAdapter("SELECT * FROM tblegitimbilgiler WHERE ulke='turkiye' AND akademik_egitim='doktora' ORDER BY ogrno", baglanti);

                DataTable dt = new DataTable();
                adaptor.Fill(dt); // Tabloyu doldur
                dataGridView1.DataSource = dt; //Datagrid doldur
                adaptor.Dispose(); //Adaptor ü kapat
            } //Bağlantı burada otomatik olarak kapatılır
        }



        private void Bosalt()
        {
            dataGridView1.DataSource = null;
        }

        private void btnDoktoraYurtdisi_Click(object sender, EventArgs e)
        {
            Bosalt();
            using (MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bitirme_projesi;user=root"))
            {
                baglanti.Open();
                MySqlDataAdapter adaptor = new MySqlDataAdapter("SELECT * FROM tblegitimbilgiler WHERE NOT ulke='turkiye' AND akademik_egitim='doktora' ORDER BY ogrno", baglanti);

                DataTable dt = new DataTable();
                adaptor.Fill(dt); // Tabloyu doldur
                dataGridView1.DataSource = dt; //Datagrid doldur
                adaptor.Dispose(); //Adaptor ü kapat
            } //Bağlantı burada otomatik olarak kapatılır
        }

        private void btnYuksekLisans_Click(object sender, EventArgs e)
        {
            Bosalt();
            using (MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bitirme_projesi;user=root"))
            {
                baglanti.Open();
                MySqlDataAdapter adaptor = new MySqlDataAdapter("SELECT * FROM tblegitimbilgiler WHERE akademik_egitim='yukseklisans' ORDER BY ogrno", baglanti);

                DataTable dt = new DataTable();
                adaptor.Fill(dt); // Tabloyu doldur
                dataGridView1.DataSource = dt; //Datagrid doldur
                adaptor.Dispose(); //Adaptor ü kapat
            } //Bağlantı burada otomatik olarak kapatılır
        }

        private void btnYuksekLisansTurkiye_Click(object sender, EventArgs e)
        {
            Bosalt();
            using (MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bitirme_projesi;user=root"))
            {
                baglanti.Open();
                MySqlDataAdapter adaptor = new MySqlDataAdapter("SELECT * FROM tblegitimbilgiler WHERE ulke='turkiye' AND akademik_egitim='yukseklisans' ORDER BY ogrno", baglanti);

                DataTable dt = new DataTable();
                adaptor.Fill(dt); // Tabloyu doldur
                dataGridView1.DataSource = dt; //Datagrid doldur
                adaptor.Dispose(); //Adaptor ü kapat
            } //Bağlantı burada otomatik olarak kapatılır
        }

        private void btnYuksekLisansYurtDisi_Click(object sender, EventArgs e)
        {
            Bosalt();
            using (MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bitirme_projesi;user=root"))
            {
                baglanti.Open();
                MySqlDataAdapter adaptor = new MySqlDataAdapter("SELECT * FROM tblegitimbilgiler WHERE NOT ulke='turkiye' AND akademik_egitim='yukseklisans' ORDER BY ogrno", baglanti);

                DataTable dt = new DataTable();
                adaptor.Fill(dt); // Tabloyu doldur
                dataGridView1.DataSource = dt; //Datagrid doldur
                adaptor.Dispose(); //Adaptor ü kapat
            } //Bağlantı burada otomatik olarak kapatılır
        }

        private void btnMezuniseGiren_Click(object sender, EventArgs e)
        {
            //mezuntarih-işegiriştarih
        }
    }
}
