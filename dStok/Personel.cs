using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dStok
{
    public partial class Personel : Form
    {



        SqlConnection baglanti = new SqlConnection("Data Source=LAB;Initial Catalog=dStok;User ID=sa;Password=123456;");
        void yetkileriGetir()

        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from yetkiler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbYetkiler.DisplayMember = "yetki_adi";
            cbbYetkiler.ValueMember = "yetki_id";
            cbbYetkiler.DataSource = dt;
            


            baglanti.Close();
        }

        void personelGetir()

        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from personeller", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwPersoneller.DataSource = dt;


            baglanti.Close();
        }

        void temizle()
        {
            txtPersonelAd.Clear();
            txtPersonelSoyad.Clear();
            txtPersonelKullaniciAd.Clear();
            txtPersonelMail.Clear();
            txtPersonelMail.Clear();
            richPersonelAdres.Clear();
            mskPersonelTelefon.Clear();
        }

        public Personel()
        {
            InitializeComponent();
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            yetkileriGetir();
            personelGetir();

        }

        private void cbbYetkiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand ekle = new SqlCommand("insert into personeller(ad,soyad,telefon,mail,adres,kullanici_adi,sifre,yetki_id) values(@a,@s,@t,@m,@adr,@kul,@sif,@yetki);", baglanti);
            ekle.Parameters.AddWithValue("@a", txtPersonelAd.Text);
            ekle.Parameters.AddWithValue("@s", txtPersonelSoyad.Text);
            ekle.Parameters.AddWithValue("@t", mskPersonelTelefon.Text);
            ekle.Parameters.AddWithValue("@m", txtPersonelMail.Text);
            ekle.Parameters.AddWithValue("@adr", richPersonelAdres.Text);
            ekle.Parameters.AddWithValue("@kul", txtPersonelKullaniciAd.Text);
            ekle.Parameters.AddWithValue("@sif", txtPersonelSifre.Text);
            ekle.Parameters.AddWithValue("@yetki", cbbYetkiler.SelectedValue);

            ekle.ExecuteNonQuery();
            baglanti.Close();

            temizle();
            personelGetir();


           
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from personeller where personel_id=@pID", baglanti);
            sil.Parameters.AddWithValue("@pID", dgwPersoneller.CurrentRow.Cells[0].Value);
            sil.ExecuteNonQuery();
            baglanti.Close();

            temizle();

            personelGetir();
        }

        private void dgwPersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelAd.Text = dgwPersoneller.CurrentRow.Cells[1].Value.ToString();
            txtPersonelSoyad.Text = dgwPersoneller.CurrentRow.Cells[2].Value.ToString();
            mskPersonelTelefon.Text = dgwPersoneller.CurrentRow.Cells[3].Value.ToString();
            txtPersonelMail.Text = dgwPersoneller.CurrentRow.Cells[4].Value.ToString();
            richPersonelAdres.Text = dgwPersoneller.CurrentRow.Cells[5].Value.ToString();
            txtPersonelKullaniciAd.Text = dgwPersoneller.CurrentRow.Cells[6].Value.ToString();
            txtPersonelSifre.Text = dgwPersoneller.CurrentRow.Cells[7].Value.ToString();

        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("update personeller set ad = @a ,soyad = @s ,telefon = @t,mail = @m,adres = @adr, kullanici_adi=@kul, sifre=@sif, yetki_id=@yetki where personel_id=@pID", baglanti);
            guncelle.Parameters.AddWithValue("@a", txtPersonelAd.Text);
            guncelle.Parameters.AddWithValue("@s", txtPersonelSoyad.Text);
            guncelle.Parameters.AddWithValue("@t", mskPersonelTelefon.Text);
            guncelle.Parameters.AddWithValue("@m", txtPersonelMail.Text);
            guncelle.Parameters.AddWithValue("@adr", richPersonelAdres.Text);
            guncelle.Parameters.AddWithValue("@kul", txtPersonelKullaniciAd.Text);
            guncelle.Parameters.AddWithValue("@sif", txtPersonelSifre.Text);
            guncelle.Parameters.AddWithValue("@yetki", cbbYetkiler.SelectedValue);
            guncelle.Parameters.AddWithValue("@pID", dgwPersoneller.CurrentRow.Cells[0].Value.ToString());
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            temizle();
            personelGetir();
            
        }
    }
}
