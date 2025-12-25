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

namespace dStok
{
    public partial class Giris : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAB;Initial Catalog=dStok;User ID=sa;Password=123456;");

        public Giris()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //Butona basıldı.
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from personeller WHERE kullanici_adi= '"+txtKullaniciAdi.Text+ "' AND sifre = '"+txtSifre.Text+"'  ", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);


            // sql sonuç döndürmediğinde    (hatalı kullanıcı adı ve parola girildiğinde)
            // yetkiID değişkeni boş oluyor ve hata veriyor. Boş olmasını engellemek için alttaki 3 satır kod eklendi.
                string yetkiID = "0";
                if (dt.Rows.Count > 0)  
                    yetkiID = dt.Rows[0]["yetki_id"].ToString();
            
            baglanti.Close();

            if (yetkiID=="1")
            {
                Personel frmPersonel=new Personel();
                frmPersonel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş yetkiniz bulunmuyor");
            }

        }
    }
}
