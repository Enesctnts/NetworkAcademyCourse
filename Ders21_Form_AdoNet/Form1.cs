using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Ders21_Form_AdoNet
{
    public partial class Form1 : Form
    {
        //Sql Server kullanıcısı ile bağlanmak için:
        //SqlConnection baglanti = new SqlConnection($"Server=DESKTOP-5177M0F; Database=DB_Test; user=sa; pwd=1234;");
        //DataTable dtOgrenci = new DataTable();


        ////Windows kullanıcısı ile bağlanmak için:
        SqlConnection baglanti = new SqlConnection($"Server=DESKTOP-5177M0F; Database=DB_Test; Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OgrenciListUpdate();
            //LoadGuncelleForm();
        }

        private void LoadGuncelleForm()
        {

            //int ID = int.Parse(cmb_guncelle.SelectedValue.ToString());

            DataRowView item = (DataRowView)cmb_guncelle.SelectedItem;
            int ID = int.Parse(item[0].ToString());

            List<string> data = new List<string>();
            data = GetOgrenciBilgi(ID);
            txt_ad_guncelle.Text = data.ElementAt(0);
            txt_soyad_guncelle.Text = data.ElementAt(1);
            txt_telefon_guncelle.Text = data.ElementAt(2);
            txt_tc_guncelle.Text = data.ElementAt(3); ;
        }

        private string GetOgrenciAd(int id)
        {
            DBConnect();
            SqlCommand sorgu = new SqlCommand($"SELECT CONCAT(ad,' ',soyad) as adSoyad FROM tb_ogrenci WHERE ID={id};",baglanti);
            SqlDataReader dr = sorgu.ExecuteReader();
            string adSoyad = "";
            while (dr.Read())
            {
                //MessageBox.Show(dr.GetString(0));
                adSoyad = dr.GetString(0); // sorgudaki 0. kolonu string olarak döndür.
            }
            DBDisconnect();
            return adSoyad;
        }

        private List<string> GetOgrenciBilgi(int id)
        {
            DBConnect();
            SqlCommand sorgu = new SqlCommand($"SELECT ID,ad,soyad,telefon,tc FROM tb_ogrenci WHERE ID={id};", baglanti);
            SqlDataReader dr = sorgu.ExecuteReader();
            List<string> data = new List<string>();
            while (dr.Read())
            {
                data.Add(dr.GetString(1));
                data.Add(dr.GetString(2));
                data.Add(dr.GetString(3));
                data.Add(dr.GetString(4));
            }
            DBDisconnect();
            return data;
        }

        private void OgrenciListUpdate()
        {
            // SqlDataAdapter tablo olarak veri çekmemizi sağlar.
            SqlDataAdapter adpOgrenci = new SqlDataAdapter("SELECT ID,CONCAT(ad,' ',soyad) as [Ad Soyad],telefon as Telefon,tc as [TC K. Nu.],ad,soyad FROM tb_ogrenci", baglanti);
            DataTable dtOgrenci = new DataTable();
            adpOgrenci.Fill(dtOgrenci);
            data_ogrenciler.DataSource = dtOgrenci;
            data_ogrenciler.Columns["ID"].Visible = false; // ID kolonunu gizle.
            data_ogrenciler.Columns["ad"].Visible = false; // ID kolonunu gizle.
            data_ogrenciler.Columns["soyad"].Visible = false; // ID kolonunu gizle.

            // Silme combobox'ını doldurduk.
            // Öğrenci ad ve soyadı gösterilecek.
            // Seçilen öğrencinin ID si tutulacak.
            cmb_sil_liste.DataSource = dtOgrenci;
            cmb_sil_liste.DisplayMember = "Ad Soyad";
            cmb_sil_liste.ValueMember = "ID";

            // Düzenleme sekmesindeki combobox ı da güncelledik.
            cmb_guncelle.DataSource = dtOgrenci;
            cmb_guncelle.DisplayMember = "Ad Soyad";
            cmb_guncelle.ValueMember = "ID";
            //cmb_guncelle.SelectedIndex=0;

        }

        private void DBConnect()
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                    //MessageBox.Show("Bağlantı Başarılı !");
                }
            }
            catch
            {
                Console.WriteLine("Bağlantı Başarısız !!!");
            }
        }
        private void DBDisconnect()
        {
            try
            {
                if (baglanti.State != ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }
            catch
            {
                Console.WriteLine("We could not disconnect from db !!!");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        // SQL INJECTION a açık.
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //SqlCommand insertCommand = new SqlCommand($"INSERT INTO [dbo].[tb_ogrenci]([ad],[soyad],[telefon],[tc]) VALUES('{txt_ad.Text}','{txt_soyad.Text}','{txt_telefon.Text}','{txt_tc.Text}')",baglanti);

            SqlCommand insertCommand = new SqlCommand();

            insertCommand.CommandText = $"INSERT INTO [dbo].[tb_ogrenci]([ad],[soyad],[telefon],[tc]) VALUES '{txt_ad.Text}','{txt_soyad.Text}','{txt_telefon.Text}','{txt_tc.Text}')";
            Console.WriteLine(insertCommand.CommandText);
            MessageBox.Show(insertCommand.CommandText);

            insertCommand.Connection = baglanti; // Yukarıda tanımladığımız sql komutu baglanti nesnesi aracılığı ile veritabanında çalışacak.

            DBConnect(); // Bağlantı kapalı ise açsın.

            int affectedRowsCount = insertCommand.ExecuteNonQuery(); // Komut çalıştırıldıktan sonra
                                                                     // Kaç satır etkilendi.

            DBDisconnect();// Bağlantı açık ise kapatılsın.

            if (affectedRowsCount > 0)
            {
                MessageBox.Show("Student added succesfully !!");
                txt_ad.Clear();
                txt_soyad.Clear();
                txt_tc.Clear();
                txt_telefon.Clear();
            }
            else
                MessageBox.Show("No students added !!");

        }
        // SQL INJECTION a kapalı !!!
        private void btn_ekle_Click_AddWithValue (object sender, EventArgs e)
        {

        }

        

        private void btn_sil_Click(object sender, EventArgs e)
        {

            int silinecekID = int.Parse(cmb_sil_liste.SelectedValue.ToString());

            SqlCommand silCommand = new SqlCommand("DELETE FROM tb_ogrenci WHERE ID=@id;", baglanti);
            silCommand.Parameters.Clear();
            silCommand.Parameters.AddWithValue("@id", silinecekID);

            string adSoyad = GetOgrenciAd(silinecekID);
            DialogResult cevap =  MessageBox.Show($"{adSoyad} silmek istediğinizden emin misiniz?", "SİLME ONAYI", MessageBoxButtons.YesNo);

            if(cevap==DialogResult.Yes)
            {
                DBConnect();
                int etkilenenSatirSayisi = silCommand.ExecuteNonQuery();
                if (etkilenenSatirSayisi > 0)
                    MessageBox.Show("Silme işlemi tamamdır.");
                else
                    MessageBox.Show("herhangi bir kayıt silinmedi!");
                DBDisconnect();
            }
            OgrenciListUpdate();



        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            //int ID = int.Parse(cmb_guncelle.SelectedValue.ToString());
            DataRowView item = (DataRowView)cmb_guncelle.SelectedItem;
            int ID = int.Parse(item[0].ToString());

            SqlCommand updateCommand = new SqlCommand($"UPDATE tb_ogrenci SET ad=@ad,soyad=@soyad,telefon=@telefon,tc=@tc WHERE ID={ID};", baglanti);

            updateCommand.Parameters.AddWithValue("@ad", txt_ad_guncelle.Text);
            updateCommand.Parameters.AddWithValue("@soyad", txt_soyad_guncelle.Text);
            updateCommand.Parameters.AddWithValue("@telefon", txt_telefon_guncelle.Text);
            updateCommand.Parameters.AddWithValue("@tc", txt_tc_guncelle.Text);
            DBConnect();
            int etk = updateCommand.ExecuteNonQuery();
            DBDisconnect();
            if ( etk > 0)
            { 
                MessageBox.Show("Güncelleme başarılı!");
                OgrenciListUpdate();
            }
            else
                MessageBox.Show("Güncelleme Hatalı !!");


        }
        private void cmb_guncelle_TextChanged(object sender, EventArgs e)
        {
            LoadGuncelleForm();
        }

        private void btn_ogretmen_Click(object sender, EventArgs e)
        {
            OgretmenForm ogretmenForm = new OgretmenForm();
            ogretmenForm.Show();
            this.Hide();

        }

        private void btn_ekle_SP(object sender, EventArgs e)
        {

               
                SqlCommand insertCommand = new SqlCommand($"SP_OgrenciEkle", baglanti);
                insertCommand.CommandType = CommandType.StoredProcedure;
                insertCommand.Parameters.AddWithValue("@ad", txt_ad.Text);
                insertCommand.Parameters.AddWithValue("@soyad", txt_soyad.Text);
                insertCommand.Parameters.AddWithValue("@telefon", txt_telefon.Text);
                insertCommand.Parameters.AddWithValue("@tc", txt_tc.Text);

                DBConnect(); // Bağlantı kapalı ise açsın.


                int sonID = Convert.ToInt32(insertCommand.ExecuteScalar()); // Eklemeden sonra ilk satırın ilk kolonunu döndürür.
                MessageBox.Show(sonID.ToString());
                DBDisconnect();// Bağlantı açık ise kapatılsın.



                if (sonID > 0)
                {
                    MessageBox.Show($"Student added succesfully !!\nÖğrenci ID: {sonID}");
                    txt_ad.Clear();
                    txt_soyad.Clear();
                    txt_tc.Clear();
                    txt_telefon.Clear();
                    OgrenciListUpdate();
                }
                else
                    MessageBox.Show("No students added !!");
            
        }
    }
}
