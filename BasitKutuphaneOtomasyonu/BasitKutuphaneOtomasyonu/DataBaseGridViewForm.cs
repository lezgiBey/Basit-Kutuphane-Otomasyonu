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

namespace BasitKutuphaneOtomasyonu
{
    public partial class DataBaseGridViewForm : Form
    {
        SqlConnection dataBaseBaglanti = new SqlConnection("Data Source=DESKTOP-DKDGEHS;Initial Catalog=BasitKutuphaneOtomasyonuDataBase;Integrated Security=True");
        SqlCommand cmd = null;
        public DataBaseGridViewForm()
        {
            InitializeComponent();
            dataBaseBaglanti.Open();
            cmd = new SqlCommand();
            cmd.Connection = dataBaseBaglanti;
        }
        
        public void DataBaseListele(string bilgiler)
        {
            SqlDataAdapter da = new SqlDataAdapter(bilgiler, dataBaseBaglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        public void DataBaseYeniKitapEkle(string kitapAdi, string yazarAdi, string kitapCikisTarihi, string kitapBaskiYili, string rafKodu, string kitapGirisYili, string barkodu, string aciklama, string kitapTuru, Label label)
        {
            DateTime kCT = Convert.ToDateTime(kitapCikisTarihi);
            DateTime kBT = Convert.ToDateTime(kitapBaskiYili);
            DateTime kKGT = Convert.ToDateTime(kitapGirisYili);

            DataTable dt = new DataTable();

            if (kitapAdi == "" || yazarAdi == "" || rafKodu == "" || kitapGirisYili == "" || barkodu == "")
            {
                label.Text = "Kayıt Başarısız";
                label.ForeColor = Color.Red;
            }
            else
            {
                cmd.CommandText = "INSERT INTO Kitap(kitap_Adi, kitap_Yazari, kitap_Cikis_Tarihi, kitap_Baski_Yili, kitap_Raf_Kodu, kitap_Giris_Yili, kitap_Barkodu, kitap_Aciklama, kitap_Turu) VALUES('" + kitapAdi + "','" + yazarAdi + "', @kitap_Cikis_Tarihi , @kitap_Basim_Tarihi ,'" + rafKodu + "', @kitap_Giris_Tarihi ,'" + barkodu + "','" + aciklama + "','" + kitapTuru + "')";
                cmd.Parameters.AddWithValue("kitap_Cikis_Tarihi", kCT);
                cmd.Parameters.AddWithValue("kitap_Basim_Tarihi", kBT);
                cmd.Parameters.AddWithValue("kitap_Giris_Tarihi", kKGT);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                dataBaseBaglanti.Close();

                label.Text = "Kayıt Başarılı";
                label.ForeColor = Color.Black;
            }
        }

        public void YeniZiyaretciEkle(string ziyaretciAdi, string ziyaretciTelNo, string ziyaretciAdresi, string ziyaretciKayitTarihi, string ziyaretciUyrugu, string ziyaretciMeslegi, string ziyaretciUnvani, string ziyaretciYetkisi, Label label)
        {
            DateTime zKT = Convert.ToDateTime(ziyaretciKayitTarihi);

            if (ziyaretciAdi == "" || ziyaretciTelNo == "" || ziyaretciAdresi == "" || ziyaretciKayitTarihi == "" || ziyaretciYetkisi == "")
            {
                label.Text = "Kayıt Başarısız";
                label.ForeColor = Color.Red;
            }
            else
            {
                if (ziyaretciYetkisi == null) ziyaretciYetkisi = "Standart";

                cmd.CommandText = "INSERT INTO Ziyaretci(ziyaretci_Adi_Soyadi, ziyaretci_Telefon_Numarasi, ziyaretci_Adresi, ziyaretci_Kayit_Tarihi, ziyaretci_Uyrugu, ziyaretci_Meslegi, ziyaretci_Unvani, ziyaretci_Yetkisi) VALUES('" + ziyaretciAdi + "','" + ziyaretciTelNo + "', '" + ziyaretciAdresi + "', @ziyaretci_Kayit_Tarihi , '" + ziyaretciUyrugu + "', '" + ziyaretciMeslegi + "', '" + ziyaretciUnvani + "', '" + ziyaretciYetkisi + "')";
                cmd.Parameters.AddWithValue("ziyaretci_Kayit_Tarihi", zKT);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                dataBaseBaglanti.Close();

                label.Text = "Kayıt Başarılı";
                label.ForeColor = Color.Black;
            }
        }


        public void KitabiZiyaretciyeTeslimEt(string kitabiAlanZiyaretci, string kitapId,string kitabiAlanTarihi, string kitabiAlanAciklama, Label label)
        {
            DateTime kTAT = Convert.ToDateTime(kitabiAlanTarihi);

            try
            {
                if (kitabiAlanZiyaretci == "" || kitapId == "" || kitabiAlanTarihi == "")
                {
                    label.Text = "Teslim Edilemedi!";
                    label.ForeColor = Color.Red;
                }
                else
                {
                    cmd.CommandText = "UPDATE Kitap SET kitap_Ziyartci= '" + Convert.ToInt32(kitabiAlanZiyaretci) + "', kitap_Ziyartci_Alim_Tarihi=@kitap_Teslim_Alim_Tarihi, kitap_Ziyartci_Aciklama='" + kitabiAlanAciklama + "' WHERE id=" + Convert.ToInt32(kitapId) + "";
                    cmd.Parameters.AddWithValue("kitap_Teslim_Alim_Tarihi", kTAT);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    dataBaseBaglanti.Close();

                    label.Text = "Kayıt Başarılı";
                    label.ForeColor = Color.Black;
                }
            }
            catch (Exception e)
            {
                label.Text = "Kayıt bulunamadı!";
                label.ForeColor = Color.Red;

                
            }
        }

        public void KitabiZiyaretciGeriGetirdi(string kitabiAlan, string kitapId, string kitabTeslimTarihi,string kitapTeslimAciklama, Label label)
        {
            DateTime kKTET = Convert.ToDateTime(kitabTeslimTarihi);

            try
            {
                if (kitabiAlan == "" || kitapId == "" || kitabTeslimTarihi == "" || kitapTeslimAciklama == "")
                {
                    label.Text = "Teslim Alınamadı!";
                    label.ForeColor = Color.Red;
                }
                else
                {
                    cmd.CommandText = "UPDATE Kitap SET kitap_Geri_Gelis_Aciklama='" + kitapTeslimAciklama + "', kitap_Geri_Gelis_Tarihi=@geri_Gelis_Tarihi WHERE id=" + Convert.ToInt32(kitapId) + " AND kitap_Ziyartci=" + kitabiAlan + "";
                    cmd.Parameters.AddWithValue("geri_Gelis_Tarihi", kKTET);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    dataBaseBaglanti.Close();

                    label.Text = "Teslim Alındı";
                    label.ForeColor = Color.Black;
                }
            }
            catch (Exception e)
            {
                label.Text = "Kayıt bulunamadı!";
                label.ForeColor = Color.Red;
            }
        }
        
        public void KitabiGuncelle(string id, string kitapAdi, string yazarAdi, string kitapCikisTarihi, string kitapBaskiYili, string rafKodu, string kitapGirisYili, string barkodu, string aciklama, string kitapTuru, Label label)
        {
            try{
                DateTime kCT = Convert.ToDateTime(kitapCikisTarihi);
                DateTime kBT = Convert.ToDateTime(kitapBaskiYili);
                DateTime kKGT = Convert.ToDateTime(kitapGirisYili);

                DataTable dt = new DataTable();

                if (id == "" || kitapAdi == "" || yazarAdi == "" || kitapCikisTarihi == "" || kitapBaskiYili == "" || rafKodu == "" || kitapGirisYili == "" || barkodu == "" || kitapTuru == "")
                {
                    label.Text = "Kayıt Güncellenmedi";
                    label.ForeColor = Color.Red;
                }
                else
                {
                    cmd.CommandText = "Update Kitap SET kitap_Adi='" + kitapAdi + "', kitap_Yazari='" + yazarAdi + "', kitap_Cikis_Tarihi=@cikis_Tarihi, kitap_Baski_Yili=@basim_Tarihi, kitap_Raf_Kodu='" + rafKodu + "', kitap_Giris_Yili=@giris_Tarihi, kitap_Barkodu='" + barkodu + "', kitap_Aciklama='" + aciklama + "', kitap_Turu ='" + kitapTuru + "' WHERE id=" + id + "";
                    cmd.Parameters.AddWithValue("cikis_Tarihi", kCT);
                    cmd.Parameters.AddWithValue("basim_Tarihi", kBT);
                    cmd.Parameters.AddWithValue("giris_Tarihi", kKGT);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    dataBaseBaglanti.Close();

                    label.Text = "Kayıt Güncellendi";
                    label.ForeColor = Color.Black;
                }
            }
            catch (Exception e) {
                label.Text = "Kayıt Bulunamadı!";
            }
            
        }

        public void ZiyaretciGuncelle(string id,string ziyaretciAdi, string ziyaretciTelNo, string ziyaretciAdresi, string ziyaretciKayitTarihi, string ziyaretciUyrugu, string ziyaretciMeslegi, string ziyaretciUnvani, string ziyaretciYetkisi, Label label)
        {
            try
            {
                DateTime zKT = Convert.ToDateTime(ziyaretciKayitTarihi);

                if (ziyaretciAdi == "" || ziyaretciTelNo == "" || ziyaretciAdresi == "" || ziyaretciKayitTarihi == "" || ziyaretciUyrugu == "" || ziyaretciMeslegi == "" || ziyaretciUnvani == "" || ziyaretciYetkisi == "")
                {
                    label.Text = "Kayıt Başarısız";
                    label.ForeColor = Color.Red;
                }
                else
                {
                    cmd.CommandText = "Update Ziyaretci Set ziyaretci_Adi_Soyadi='" + ziyaretciAdi + "', ziyaretci_Telefon_Numarasi='" + ziyaretciTelNo + "', ziyaretci_Adresi='" + ziyaretciAdresi + "', ziyaretci_Kayit_Tarihi=@kayit_Tarihi, ziyaretci_Uyrugu='" + ziyaretciUyrugu + "', ziyaretci_Meslegi='" + ziyaretciMeslegi + "', ziyaretci_Unvani='" + ziyaretciUnvani + "', ziyaretci_Yetkisi='" + ziyaretciYetkisi + "' WHERE id=" + id + "";
                    cmd.Parameters.AddWithValue("kayit_Tarihi", zKT);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    dataBaseBaglanti.Close();

                    label.Text = "Kayıt Başarılı";
                    label.ForeColor = Color.Black;
                }
            }
            catch(Exception e)
            {
                label.Text = "Kayıt Bulunamadı!";
            }            
        }

        public void kitapCagir(string kitapId, TextBox kitapAdi, TextBox yazarAdi, DateTimePicker cikisTarihi, DateTimePicker basimTarihi, TextBox kitapTuru, TextBox rafKodu, DateTimePicker duzenlemeTarihi, TextBox kitabinBarkodu, RichTextBox kitabinAciklamasi)
        {
            cmd.CommandText = "SELECT * FROM Kitap WHERE id = '" + kitapId +"'";
            cmd.Parameters.AddWithValue("id", kitapId);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                kitapAdi.Text = dr["kitap_Adi"].ToString();
                yazarAdi.Text = dr["kitap_Yazari"].ToString();
                cikisTarihi.Text = dr["kitap_Cikis_Tarihi"].ToString();
                basimTarihi.Text = dr["kitap_Baski_Yili"].ToString();
                kitapTuru.Text = dr["kitap_Turu"].ToString();
                rafKodu.Text = dr["kitap_Raf_Kodu"].ToString();
                duzenlemeTarihi.Text = dr["kitap_Geri_Gelis_Tarihi"].ToString();
                kitabinBarkodu.Text = dr["kitap_Barkodu"].ToString();
                kitabinAciklamasi.Text = dr["kitap_Aciklama"].ToString();
            }
            cmd.Parameters.Clear();
            dr.Close();
        }

        public void ziyaretciCagir(string ziyaretciId, TextBox ziyaretciAdiSoyadi, TextBox telefonNumarasi, RichTextBox adresi, DateTimePicker kayitTarihi, TextBox uyrugu, TextBox meslegi, TextBox unvani, ComboBox yetkisi)
        {
            cmd.CommandText = "SELECT * FROM Ziyaretci WHERE id = '" + ziyaretciId + "'";
            cmd.Parameters.AddWithValue("id", ziyaretciId);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ziyaretciAdiSoyadi.Text = dr["ziyaretci_Adi_Soyadi"].ToString();
                telefonNumarasi.Text = dr["ziyaretci_Telefon_Numarasi"].ToString();
                adresi.Text = dr["ziyaretci_Adresi"].ToString();
                kayitTarihi.Text = dr["ziyaretci_Kayit_Tarihi"].ToString();
                uyrugu.Text = dr["ziyaretci_Uyrugu"].ToString();
                meslegi.Text = dr["ziyaretci_Meslegi"].ToString();
                unvani.Text = dr["ziyaretci_Unvani"].ToString();
                yetkisi.Text = dr["ziyaretci_Yetkisi"].ToString();
            }
            cmd.Parameters.Clear();
            dr.Close();
        }

    }
}
