using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace magaza_veri_tabani
{
    public class DL
    {
        static MySqlConnection baglanti = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {
                Server = "127.0.0.1",
                Database = "magazam",
                UserID = "tester",
                Password = "Tester_74"
            }.ConnectionString
            );

        public static int MusteriEkle(string adisoyadi, string telefon, string mail, string adres)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string insert = "INSERT INTO musteriler (musteri_adi_soyadi, musteri_telefon, musteri_mail, musteri_adres) VALUES (@adisoyadi, @telefon, @mail, @adres)";
                MySqlCommand komut = new MySqlCommand(insert, baglanti);
                komut.Parameters.AddWithValue("@adisoyadi", adisoyadi);
                komut.Parameters.AddWithValue("@telefon", telefon);
                komut.Parameters.AddWithValue("@mail", mail);
                komut.Parameters.AddWithValue("@adres", adres);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int MusteriDuzenle(string musteri_id, string adisoyadi, string telefon, string mail, string adres)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string update = "update musteriler " +
                    "set musteri_adi_soyadi=@adisoyadi, musteri_telefon=@telefon, musteri_mail=@mail, musteri_adres=@adres " +
                "where musteri_id=@musteri_id";
                MySqlCommand komut = new MySqlCommand(update, baglanti);

                komut.Parameters.AddWithValue("@adisoyadi", adisoyadi);
                komut.Parameters.AddWithValue("@telefon", telefon);
                komut.Parameters.AddWithValue("@mail", mail);
                komut.Parameters.AddWithValue("@adres", adres);
                komut.Parameters.AddWithValue("@musteri_id", musteri_id);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int MusteriSil(string musteri_id)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string delete = "delete from musteriler where musteri_id=@musteri_id";
                MySqlCommand komut = new MySqlCommand(delete, baglanti);

                komut.Parameters.AddWithValue("@musteri_id", musteri_id);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int UrunEkle(string urunAdi, string urunKategori, string urunStok, string urunFiyat)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string insert = "insert into urunler (urun_adi, urun_kategori, urun_stok, urun_fiyat) VALUES (@urunAdi, @urunKategori, @urunStok, @urunFiyat)";
                MySqlCommand komut = new MySqlCommand(insert, baglanti);

                komut.Parameters.AddWithValue("@urunAdi", urunAdi);
                komut.Parameters.AddWithValue("@urunKategori", urunKategori);
                komut.Parameters.AddWithValue("@urunStok", urunStok);
                komut.Parameters.AddWithValue("@urunFiyat", urunFiyat);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int UrunDuzenle(string urunID, string urunAdi, string urunKategori, string urunStok, string urunFiyat)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string update = "UPDATE urunler SET urun_adi = @urunAdi, urun_kategori = @urunKategori, urun_stok = @urunStok, urun_fiyat = @urunFiyat WHERE urun_id = @urunID";
                MySqlCommand komut = new MySqlCommand(update, baglanti);

                komut.Parameters.AddWithValue("@urunAdi", urunAdi);
                komut.Parameters.AddWithValue("@urunKategori", urunKategori);
                komut.Parameters.AddWithValue("@urunStok", urunStok);
                komut.Parameters.AddWithValue("@urunFiyat", urunFiyat);
                komut.Parameters.AddWithValue("@urunID", urunID);

                return komut.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.Message}\n\nHata kodu: {ex.Number}\n\nHata detayları: {ex.StackTrace}");
                return -1;
            }
            catch (Exception hata)
            {
                MessageBox.Show($"Genel hata: {hata.Message}\n\nHata detayları: {hata.StackTrace}");
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int UrunSil(string urunID)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string sil = "delete from urunler where urun_id = @urunID";
                MySqlCommand komut = new MySqlCommand(sil, baglanti);

                komut.Parameters.AddWithValue("@urunID", urunID);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int SatisEkle(int musteriID, int urunID, DateTime satisTarihi, string satisFiyati)
        {
            int sonuc = -1;

            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string insert = "INSERT INTO satislar (musteri_id, urun_id, satis_tarihi, satis_fiyati) VALUES (@musteriID, @urunID, @satisTarihi, @satisFiyati)";
                MySqlCommand komut = new MySqlCommand(insert, baglanti);
                komut.Parameters.AddWithValue("@musteriID", musteriID);
                komut.Parameters.AddWithValue("@urunID", urunID);
                komut.Parameters.AddWithValue("@satisTarihi", satisTarihi);
                komut.Parameters.AddWithValue("@satisFiyati", satisFiyati);

                sonuc = komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }

            return sonuc;
        }

        public static int SatisDuzenle(string satisID, int musteriID, int urunID, DateTime satisTarihi, string satisFiyati)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string update = "update satislar set musteri_id = @musteriID, urun_id = @urunID, satis_tarihi = @satisTarihi, satis_fiyati = @satisFiyati WHERE satis_id = @satisID";
                MySqlCommand komut = new MySqlCommand(update, baglanti);

                komut.Parameters.AddWithValue("@musteriID", musteriID);
                komut.Parameters.AddWithValue("@urunID", urunID);
                komut.Parameters.AddWithValue("@satisTarihi", satisTarihi);
                komut.Parameters.AddWithValue("@satisFiyati", satisFiyati);
                komut.Parameters.AddWithValue("@satisID", satisID);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int SatisSil(string satisID)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string sil = "delete from satislar where satis_id = @satisID";
                MySqlCommand komut = new MySqlCommand(sil, baglanti);

                komut.Parameters.AddWithValue("@satisID", satisID);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int OdemeEkle(int musteriID, DateTime odemeTarih, string odemeTutar, string odemeTur)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string insert = "insert into odemeler (musteri_id, odeme_tarih, odeme_tutar, odeme_tur) VALUES (@musteriID, @odemeTarih, @odemeTutar, @odemeTur)";
                MySqlCommand komut = new MySqlCommand(insert, baglanti);

                
                komut.Parameters.AddWithValue("@musteriID", musteriID);
                komut.Parameters.AddWithValue("@odemeTarih", odemeTarih);
                komut.Parameters.AddWithValue("@odemeTutar", odemeTutar);
                komut.Parameters.AddWithValue("@odemeTur", odemeTur);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int OdemeDuzenle(string odemeID, int musteriID, DateTime odemeTarih, string odemeTutar, string odemeTur)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string update = "UPDATE odemeler SET musteri_id = @musteriID, odeme_tarih = @odemeTarih, odeme_tutar = @odemeTutar, odeme_tur = @odemeTur WHERE odeme_id = @odemeID";
                MySqlCommand komut = new MySqlCommand(update, baglanti);

                komut.Parameters.AddWithValue("@musteriID", musteriID);
                komut.Parameters.AddWithValue("@odemeTarih", odemeTarih);
                komut.Parameters.AddWithValue("@odemeTutar", odemeTutar);
                komut.Parameters.AddWithValue("@odemeTur", odemeTur);
                komut.Parameters.AddWithValue("@odemeID", odemeID);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int OdemeSil(string odemeID)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string sil = "delete from odemeler where odeme_id = @odemeID";
                MySqlCommand komut = new MySqlCommand(sil, baglanti);

                komut.Parameters.AddWithValue("@odemeID", odemeID);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static List<Musteri> MusterileriListele()
        {
            List<Musteri> musteriler = new List<Musteri>();
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string select = "SELECT * FROM musteriler";
                MySqlCommand komut = new MySqlCommand(select, baglanti);
                MySqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    musteriler.Add(new Musteri()
                    {
                        musteriID = Convert.ToInt32(dr["musteri_id"]),
                        musteriAdiSoyadi = dr["musteri_adi_soyadi"].ToString(),
                        musteriTelefon = dr["musteri_telefon"].ToString(),
                        musteriMail = dr["musteri_mail"].ToString(),
                        musteriAdres = dr["musteri_adres"].ToString()
                    });
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }

            return musteriler;
        }

        public static List<Urun> UrunleriListele()
        {
            List<Urun> Urunler = new List<Urun>();
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string select = "SELECT * FROM urunler";
                MySqlCommand komut = new MySqlCommand(select, baglanti);

                MySqlDataReader dr = komut.ExecuteReader();
                List<Urun> urunler = new List<Urun>();
                while (dr.Read())
                {
                    urunler.Add(new Urun()
                    {
                        urunID = Convert.ToInt32(dr["urun_id"]),
                        urunAdi = dr["urun_adi"].ToString(),
                        urunKategori = dr["urun_kategori"].ToString(),
                        urunStok = dr["urun_stok"].ToString(),
                        urunFiyat = dr["urun_fiyat"].ToString()
                    });
                }
                return urunler;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return null;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static List<Satis> SatislariListele()
        {
            List<Satis> satislar = new List<Satis>();

            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string select = "SELECT * FROM satislar";
                MySqlCommand komut = new MySqlCommand(select, baglanti);
                MySqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    satislar.Add(new Satis()
                    {
                        satisID = Convert.ToInt32(dr["satis_id"]),
                        musteriID = Convert.ToInt32(dr["musteri_id"]),
                        urunID = Convert.ToInt32(dr["urun_id"]),
                        satisTarihi = Convert.ToDateTime(dr["satis_tarihi"]),
                        satisFiyati = dr["satis_fiyati"].ToString()
                    });
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }

            return satislar;
        }

        public static List<Odeme> OdemeleriListele()
        {
            List<Odeme> odemeler = new List<Odeme>();
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string select = "SELECT * FROM odemeler";
                MySqlCommand komut = new MySqlCommand(select, baglanti);
                MySqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    odemeler.Add(new Odeme()
                    {
                        odemeID = Convert.ToInt32(dr["odeme_id"]),
                        musteriID = Convert.ToInt32(dr["musteri_id"]),
                        odemeTarih = Convert.ToDateTime(dr["odeme_tarih"]),
                        odemeTutar = dr["odeme_tutar"].ToString(),
                        odemeTur = dr["odeme_tur"].ToString()
                    });
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }

            return odemeler;
        }

    }
}
