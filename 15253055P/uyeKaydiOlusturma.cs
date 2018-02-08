using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace _15253055P
{
    public partial class uyeKaydiOlusturma : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P1Q5AHK\\SQLEXPRESS;Initial Catalog=BankaOtomasyon; Integrated Security=true");
        public uyeKaydiOlusturma()
        {
            InitializeComponent();
        }

        private void geriDonBtn_Click(object sender, EventArgs e) // Kullanıcı işlemleri formunu kapatma butonu
        {
            anaSayfaForm main = new anaSayfaForm();
            this.Close();
            main.Show();
        }

        private void kayitOlusturBtn_Click(object sender, EventArgs e) // Kullanıcı kaydı oluşturma butonu
        {
            
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "insert into KullanicilarTBL Values('" + textBox1.Text + "','" + textBox2.Text + "')";
                komut.ExecuteNonQuery();
                baglanti.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Kayit Başarılı.");                            
        }

        private void kullaniciGridDoldur() // DataGridViewi doldurma fonksiyonu
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from KullanicilarTBL";
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void gosterBtn_Click(object sender, EventArgs e) // Kullanıcılar listesini dataGridViewde gösterme butonu
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanı Bağlantı Problemi!");
            }
            kullaniciGridDoldur();
            baglanti.Close();
        }

        private void kayitSilBtn_Click(object sender, EventArgs e) // Kullanıcı kaydı silme buton
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "delete from KullanicilarTBL where KullaniciAdi='" + textBox1.Text + "' AND Sifre='" + textBox2.Text + "'";
                komut.ExecuteNonQuery();
                baglanti.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Kayit Silindi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayit Silinemedi.");
            }
        }

        private void kayitGuncelleBtn_Click(object sender, EventArgs e) // Kullanıcı güncelleme buton
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText= "update KullanicilarTBL set KullaniciAdi='"+textBox1.Text+"' , Sifre='"+textBox2.Text+"' where KullaniciID= "+textBox3.Text+"";
                komut.ExecuteNonQuery();
                baglanti.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                MessageBox.Show("Kayıt Güncellendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Güncellenemedi.");
            }
        }

        public void ozan(int x) // Diğer (ana) classla alakalı
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "delete from HesaplarTBL where Bakiye="+0+" AND MusteriNo="+x+"";
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void sahin(TextBox temp, TextBox temp1, int islemTuru,DateTimePicker dtp)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem Gerçekleştirilemedi.");
            }
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "INSERT INTO IslemlerTBL VALUES(" + temp.Text + "," + islemTuru + "," + Convert.ToDecimal(temp1.Text) + ",'" + dtp.Value.ToString("yyyy-MM-dd") + "')";
            komut.ExecuteNonQuery();
        }
    }
    
}
