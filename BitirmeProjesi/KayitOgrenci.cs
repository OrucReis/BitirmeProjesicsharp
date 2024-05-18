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
    public partial class KayitOgrenci : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=bitirme_projesi;user=root");
        public KayitOgrenci()
        {
            InitializeComponent();
        }
        
        public KayitOgrenci(string kullaniciAdi)
        {
            InitializeComponent();
            // Burada kullanıcı adını kullanabilirsiniz
            string _kullaniciadi =kullaniciAdi;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KayitOgrenci_Load(object sender, EventArgs e)
        {
            listele();
        }


        private void listele()
        {
            baglanti.Open();

            // Create a command and set its properties
            MySqlCommand komut = new MySqlCommand("SELECT * FROM tblgenelbilgiler WHERE ogrno = @pogrno ORDER BY ogrno", baglanti);

            // Assuming receivedData is a string containing the ogrno
            string ogrno = receivedData;

            // Add the parameter to the command
            komut.Parameters.AddWithValue("@pogrno", ogrno);

            // Create a data adapter and set its select command
            MySqlDataAdapter adaptor = new MySqlDataAdapter(komut);

            // Create a DataTable to hold the query results
            DataTable dt = new DataTable();

            // Fill the DataTable with the results from the query
            dt.Clear();
            adaptor.Fill(dt);

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dt;

            // Dispose of the adapter and close the connection
            adaptor.Dispose();
            baglanti.Close();

        }


        private void btnKaydiGetir_Click_1(object sender, EventArgs e)
        {

            YeniKayitOgrenci yeniKayitogr = new YeniKayitOgrenci();
            yeniKayitogr.ReceiveData(receivedData);
            yeniKayitogr.ShowDialog();
        }
        private string receivedData;
        public void ReceiveData(string data)
        {
            receivedData = data;
        }

    }
}
