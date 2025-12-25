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
    public partial class Urunler : Form
    {
        SqlConnection baglanti= new SqlConnection("Data Source=LAB;Initial Catalog=dStok;User ID=sa;Password=123456;");
        void urunleriGetir()
        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from urunler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Close();
        }
        void kategorileriGetir()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from kategoriler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "kategori_adi";
            comboBox1.ValueMember = "kategori_id";
            comboBox1.DataSource = dt;



            baglanti.Close();
        }
        void tedarikcileriGoster()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tedarikciler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox2.DisplayMember = "firma_adi";
            comboBox2.ValueMember = "tedarikci_id";
            comboBox2.DataSource = dt;
            baglanti.Close();
        }
        public Urunler()
        {
            InitializeComponent();
        }

        private void urunler_Load(object sender, EventArgs e)
        {
            urunleriGetir();
            kategorileriGetir();
            tedarikcileriGoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand ekle = new SqlCommand("insert into urunler(urun_adi,kategori_id,tedarikci_id,stok_adet,fiyat,aciklama) values(@urunad,@katid,@tedid,@stokadet,@fiyat,@aciklama)",baglanti);
            ekle.Parameters.AddWithValue("@urunad",textBox1.Text);
            ekle.Parameters.AddWithValue("fiyat",textBox2.Text);
            ekle.Parameters.AddWithValue("@aciklama",richTextBox1.Text);
            ekle.Parameters.AddWithValue("@katid",comboBox1.SelectedValue);
            ekle.Parameters.AddWithValue("@tedid",comboBox2.SelectedValue);
            ekle.Parameters.AddWithValue("@stokadet",numericUpDown1.Value);



            ekle.ExecuteNonQuery();

            baglanti.Close();
            urunleriGetir();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            richTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from urunler where urun_id=@uID", baglanti);
            sil.Parameters.AddWithValue("@uID", dataGridView1.CurrentRow.Cells[0].Value);
            sil.ExecuteNonQuery();
            baglanti.Close();

            

            urunleriGetir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("update urunler set urun_adi=@urunad,kategori_id=@katid,tedarikci_id=@tedid,stok_adet=@stokad,fiyat=@fiyat,aciklama=@acik where urun_id=@uID", baglanti);
            guncelle.Parameters.AddWithValue("@urunad", textBox1.Text);
            guncelle.Parameters.AddWithValue("@fiyat", Convert.ToDouble(textBox2.Text));
            guncelle.Parameters.AddWithValue("@acik", richTextBox1.Text);
            guncelle.Parameters.AddWithValue("@katid", comboBox1.SelectedValue);
            guncelle.Parameters.AddWithValue("@tedid", comboBox2.SelectedValue);
            guncelle.Parameters.AddWithValue("@stokad", numericUpDown1.Value.ToString());

            guncelle.Parameters.AddWithValue("@uID", dataGridView1.CurrentRow.Cells[0].Value.ToString());

            guncelle.ExecuteNonQuery();
            baglanti.Close();
            urunleriGetir();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //comboBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }
    }
}
