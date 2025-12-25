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


    public partial class Tedarikciler : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAB6-20;Initial Catalog=dStok;User ID=sa;Password=123456;");
        void tedarikcileriGoster()

        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from tedarikciler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Close();
        }


        public Tedarikciler()
        {
            InitializeComponent();
        }


        private void datagridview1_cellclick1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand ekle = new SqlCommand("insert into tedarikciler(firma_adi,yetkili_adsoyad,telefon,mail,adres) values(@a,@y,@t,@m,@adr);", baglanti);
            ekle.Parameters.AddWithValue("@a", textBox1.Text);
            ekle.Parameters.AddWithValue("@y", textBox2.Text);
            ekle.Parameters.AddWithValue("@t", textBox3.Text);
            ekle.Parameters.AddWithValue("@m", textBox4.Text);
            ekle.Parameters.AddWithValue("@adr", textBox5.Text);

            ekle.ExecuteNonQuery();
            baglanti.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            tedarikcileriGoster();

            baglanti.Close();

        }

        private void Tedarikciler_Load_1(object sender, EventArgs e)
        {
            tedarikcileriGoster();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from tedarikciler where tedarikci_id=@tedID", baglanti);
            sil.Parameters.AddWithValue("@tedID", dataGridView1.CurrentRow.Cells[0].Value);
            sil.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            tedarikcileriGoster();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("update tedarikciler set firma_adi = @a ,yetkili_adsoyad = @y ,telefon = @t,mail = @m,adres = @adr where tedarikci_id=@tedID", baglanti);
            guncelle.Parameters.AddWithValue("@a", textBox1.Text);
            guncelle.Parameters.AddWithValue("@y", textBox2.Text);
            guncelle.Parameters.AddWithValue("@t", textBox3.Text);
            guncelle.Parameters.AddWithValue("@m", textBox4.Text);
            guncelle.Parameters.AddWithValue("@adr", textBox5.Text);
            guncelle.Parameters.AddWithValue("@tedID", dataGridView1.CurrentRow.Cells[0].Value);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            tedarikcileriGoster();
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

    }
}
