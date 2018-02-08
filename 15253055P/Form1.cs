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
using System.Globalization;

namespace _15253055P
{
    public partial class anaSayfaForm : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P1Q5AHK\\SQLEXPRESS;Initial Catalog=BankaOtomasyon; Integrated Security=true");
        uyeKaydiOlusturma uye = new uyeKaydiOlusturma();
        public anaSayfaForm()
        {
            InitializeComponent();
        }

        private void ekleSilGuncelleBtn_Click(object sender, EventArgs e)  // Kullanıcı işlemleri formunu açma buton
        {
            uyeKaydiOlusturma uye = new uyeKaydiOlusturma();
            this.Hide();
            uye.Show();
        }

        private void anaSayfaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankaOtomasyonDataSet.IslemlerTBL' table. You can move, or remove it, as needed.
            this.islemlerTBLTableAdapter.Fill(this.bankaOtomasyonDataSet.IslemlerTBL);
            // TODO: This line of code loads data into the 'bankaOtomasyonDataSet.MusterilerTBL' table. You can move, or remove it, as needed.
            this.musterilerTBLTableAdapter.Fill(this.bankaOtomasyonDataSet.MusterilerTBL);
            try
            {
                baglanti.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("VERİTABANI BAGLANTI HATASI");
            }
        }

        private void girisYapBtn_Click(object sender, EventArgs e)  // Kullanıcı girişi yapma buton
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
            try
            {
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT KullaniciAdi,Sifre FROM KullanicilarTBL";
                komut.ExecuteNonQuery();
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    string a = reader["KullaniciAdi"].ToString().Trim();
                    string b = reader["Sifre"].ToString().Trim();
                    if (a == girisAdTxt.Text && b == girisSifreTxt.Text)
                    {
                            tabControl1.Visible = true;
                            ekleSilGuncelleBtn.Visible = true;
                            girisSifreTxt.Visible = false;
                            girisAdTxt.Visible = false;
                            girisYapBtn.Visible = false;
                    }
                }
                reader.Close();
                baglanti.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("VERİTABANI BAGLANTI HATASI");
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı Adı/Sifre Hatalı");
            }
            paraCekGroup.Visible = false;
            paraYatirGroup.Visible = false;
            havaleYapGroup.Visible = false;
        }

        private void programCikisBtn_Click(object sender, EventArgs e)  // Programı sonlandırma buton
        {
            Environment.Exit(0);
        }

        private void musteriKaydetBtn_Click(object sender, EventArgs e)  // Müşteri kaydı oluşturma buton
        {
            SqlCommand komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "insert into  MusterilerTBL values ('"+kayitAdTxt.Text+"', '"+kayitSoyadTxt.Text+"','"+kayitAdresTxt.Text+"','"+kayitTelefonTxt.Text+"','"+kayitMailTxt.Text+"')";
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Başarılı.");
            kayitAdTxt.Text = "";
            kayitSoyadTxt.Text = "";
            kayitAdresTxt.Text = "";
            kayitMailTxt.Text = "";
            kayitTelefonTxt.Text = "";
        }

        private void hesapOlusturBtn_Click(object sender, EventArgs e)  // Yeni Hesap(No) kaydı oluşturma buton
        {
            SqlCommand komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            decimal kullanılabilir = Convert.ToDecimal(textBox5.Text) + Convert.ToDecimal(textBox6.Text);
            komut.CommandText = "insert into  HesaplarTBL values ('"+comboBox1.SelectedValue.ToString()+"','"+textBox5.Text+"', '"+textBox6.Text+"', '"+kullanılabilir+"')";
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hesap Açımı Başarılı.");
        }

        private void hesapKapatBtn_Click(object sender, EventArgs e)  // Hesap kapatma Buton
        {
            SqlCommand komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select Bakiye from HesaplarTBL";
            komut.ExecuteNonQuery();
            int x = Convert.ToInt32(comboBox1.SelectedValue);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetDecimal(0) == 0)
                {
                    uye.ozan(x);  // Delete komutu uyeKaydıOlusturma classındaki ozan methodunda 
                }
            }
            reader.Close();
            baglanti.Close();
            MessageBox.Show("Hesap Kapatma Başarılı.");
        }

        private void paraCekBtn_Click(object sender, EventArgs e)  // Para çekme işlemi
        {
            decimal para = 0;
            uyeKaydiOlusturma uye = new uyeKaydiOlusturma();
            SqlCommand komut2 = new SqlCommand();
            baglanti.Open();
            komut2.Connection = baglanti;
            komut2.CommandText = "SELECT Miktar FROM IslemlerTBL WHERE IslemId = 1 AND Tarih = '"+dateTimePicker1.Value.ToString("yyyy-MM-dd")+"' AND HesapNo = "+textBox1.Text+"";
            SqlDataReader reader = komut2.ExecuteReader();
            while (reader.Read())
            {
                para += reader.GetDecimal(0);
            }
            reader.Close();
            if (para <= 750 && Convert.ToDecimal(paraCekTxt.Text) <= 750)  // Para çekme limitinin kontrol edildiği yer
            {
                try
                {
                    SqlCommand komut = new SqlCommand();
                    
                    komut.Connection = baglanti;
                    komut.CommandText = "update HesaplarTBL set Bakiye = (Bakiye-" + paraCekTxt.Text + ") , KullanılabilirBakiye=(Bakiye - " + paraCekTxt.Text + ")+EkHesap where HesapNo = " + textBox1.Text + ";";
                    komut.ExecuteNonQuery();
                    uye.sahin(textBox1, paraCekTxt, 1, dateTimePicker1);  // Diğer classtan parametrelere göre methodu çekiyor
                    
                    MessageBox.Show("Para Çekme Başarılı.");
                }
                catch (Exception)
                {
                    MessageBox.Show("İşlem Gerçekleştirilemedi");
                }
            }
            else
            {
                MessageBox.Show("Günlük çekme limitinizi aştınız.");
            }
            baglanti.Close();
        }

        private void paraYatirBtn_Click(object sender, EventArgs e)  // Para yatırma işlemi
        {
            try
            {
                SqlCommand komut = new SqlCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "update HesaplarTBL set Bakiye = (Bakiye + "+paraYatirTxt.Text+") , KullanılabilirBakiye = (Bakiye +"+paraYatirTxt.Text+") + EkHesap where HesapNo = "+textBox2.Text+";";
                komut.ExecuteNonQuery();
                uye.sahin(textBox2, paraYatirTxt, 2, dateTimePicker2);  // Diğer classtan parametrelere methodu göre çekiyor
                baglanti.Close();
                MessageBox.Show("Para Yatırma Başarılı.");
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem Gerçekleştirilemedi");
            }
        }        

        private void havaleYapBtn_Click(object sender, EventArgs e)  // Havale işlemi
        {
            try
            {
                SqlCommand komut = new SqlCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "update HesaplarTBL set Bakiye = (Bakiye - " + havaleYapTxt.Text + ") , KullanılabilirBakiye = (Bakiye - " + havaleYapTxt.Text + ") + EkHesap where HesapNo = " + textBox3.Text + ";";
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand();
                komut2.Connection = baglanti;
                komut2.CommandText = "update HesaplarTBL set Bakiye = (Bakiye + " + havaleYapTxt.Text + ") , KullanılabilirBakiye = (Bakiye +" + havaleYapTxt.Text + ") + EkHesap where HesapNo = " + textBox4.Text + ";";
                komut2.ExecuteNonQuery();
                uye.sahin(textBox3, havaleYapTxt, 3, dateTimePicker3);  // Diğer classtan parametrelere methodu göre çekiyor
                SqlCommand komut3 = new SqlCommand();
                komut3.Connection = baglanti;
                komut3.CommandText = "insert into HavaleTBL values('" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "')";
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Havale İşlemi Başarılı.");
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem Gerçekleştirilemedi.");
            }
        }

        private void islemTuruCombo_SelectedIndexChanged(object sender, EventArgs e)  // Hesap işlemleri "göster gizle"ler
        {
            if (islemTuruCombo.SelectedItem.ToString() == "Para Çek")
            {
                paraCekGroup.Visible = true;
                paraYatirGroup.Visible = false;
                havaleYapGroup.Visible = false;
            }
            else if (islemTuruCombo.SelectedItem.ToString() == "Para Yatır")
            {
                paraYatirGroup.Visible = true;
                paraCekGroup.Visible = false;
                havaleYapGroup.Visible = false;
            }
            else if (islemTuruCombo.SelectedItem.ToString() == "Havale Yap")
            {
                havaleYapGroup.Visible = true;
                paraCekGroup.Visible = false;
                paraYatirGroup.Visible = false;
            }
        }

        private void gelirGiderSorgula_Click(object sender, EventArgs e)  // Banka gelir-gider gösterme işlemi
        {
            SqlCommand komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select SUM(Miktar) from IslemlerTBL where IslemId = 1 and Tarih = '"+dateTimePicker4.Value.ToString("yyyy-MM-dd")+"'";
            komut.ExecuteNonQuery();

            SqlCommand komut2 = new SqlCommand();
            komut2.Connection = baglanti;
            komut2.CommandText = "select SUM(Miktar) from IslemlerTBL where IslemId = 2 and Tarih = '" + dateTimePicker4.Value.ToString("yyyy-MM-dd") + "'";
            komut2.ExecuteNonQuery();

            SqlCommand komut3 = new SqlCommand();
            komut3.Connection = baglanti;
            komut3.CommandText= "select SUM(KullanılabilirBakiye) from HesaplarTBL";
            komut3.ExecuteNonQuery();

            textBox7.Text = komut.ExecuteScalar().ToString();
            textBox8.Text = komut2.ExecuteScalar().ToString();
            textBox9.Text = komut3.ExecuteScalar().ToString();
            baglanti.Close();
        }

        private void hesapSorgulaBtn_Click(object sender, EventArgs e)  // Hesap özeti sorgulama
        {
            SqlCommand komut = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from IslemlerTBL where HesapNo='"+hesapSorgulaTxt.Text+"' and Tarih between '"+dateTimePicker5.Value.ToString("yyyy-MM-dd")+ "' and '" + dateTimePicker6.Value.ToString("yyyy-MM-dd") + "'";
            komut.ExecuteNonQuery();
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;
            baglanti.Close();
            dataGridView1.Visible = true;
        }
    }
}