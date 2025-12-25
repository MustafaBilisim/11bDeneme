using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;


namespace dStok
{
    public partial class Kategoriler : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=LAB;Initial Catalog=dStok;User ID=sa;Password=123456;");
        void kategorileriGoster()
        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from kategoriler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwKategoriler.DataSource = dt;

            baglanti.Close();
        }


        public Kategoriler()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            kategorileriGoster();





        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand ekle=new SqlCommand("insert into kategoriler(kategori_adi) values(@katAd);", baglanti);
            ekle.Parameters.AddWithValue("@katAd", txtKategoriAdi.Text);

            ekle.ExecuteNonQuery();
            baglanti.Close();
            txtKategoriAdi.Clear();

            kategorileriGoster();

        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from kategoriler where kategori_id=@katID",baglanti);
            sil.Parameters.AddWithValue("@katID", dgwKategoriler.CurrentRow.Cells[0].Value);
            sil.ExecuteNonQuery();  
            baglanti.Close();
            kategorileriGoster();

        }

        private void dgwKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKategoriAdi.Text = dgwKategoriler.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("update kategoriler set kategori_adi=@katAdi where kategori_id=@katID", baglanti);
            guncelle.Parameters.AddWithValue("@katAdi", txtKategoriAdi.Text);
            guncelle.Parameters.AddWithValue("@katID", dgwKategoriler.CurrentRow.Cells[0].Value);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            kategorileriGoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
