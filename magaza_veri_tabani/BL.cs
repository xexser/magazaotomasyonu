using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magaza_veri_tabani
{
    public class BL
    {
        public static List<Musteri> Musteriler = new List<Musteri>();
        public static List<Urun> Urunler = new List<Urun>();
        public static List<Satis> Satislar = new List<Satis>();
        public static List<Odeme> Odemeler = new List<Odeme>();


        public static void MusteriEkle(string adisoyadi, string telefon, string mail, string adres)
        {
            Musteri m = new Musteri()
            {
                musteriAdiSoyadi = adisoyadi,
                musteriTelefon = telefon,
                musteriMail = mail,
                musteriAdres = adres
            };

            int sonuc = DL.MusteriEkle(m.musteriAdiSoyadi, m.musteriTelefon, m.musteriMail, m.musteriAdres);
            if (sonuc != -1)
                Musteriler.Add(m);
        }

        public static void MusteriDuzenle(string musteri_id, string adisoyadi, string telefon, string mail, string adres)
        {
            Musteri m = Musteriler.Find(o => o.musteriID.ToString() == musteri_id);
            int sonuc = DL.MusteriDuzenle(musteri_id, adisoyadi, telefon, mail, adres);
            if (sonuc != -1)
            {
                m.musteriAdiSoyadi = adisoyadi;
                m.musteriTelefon = telefon;
                m.musteriMail = mail;
                m.musteriAdres = adres;
            }
        }

        public static void MusteriSil(string musteri_id)
        {
            int sonuc = DL.MusteriSil(musteri_id);
            if (sonuc != -1)
            {
                Musteri m = Musteriler.Find(o => o.musteriID.ToString() == musteri_id);
                Musteriler.Remove(m);
            }
        }

        public static void UrunEkle( string urunAdi, string urunKategori, string urunStok, string urunFiyat)
        {
            Urun u = new Urun()
            {
                urunAdi = urunAdi,
                urunKategori = urunKategori,
                urunStok = urunStok,
                urunFiyat = urunFiyat
            };

            int sonuc = DL.UrunEkle(u.urunAdi, u.urunKategori, u.urunStok, u.urunFiyat);
            if (sonuc != -1)
                Urunler.Add(u);
        }

        public static void UrunDuzenle(string urunID, string urunAdi, string urunKategori, string urunStok, string urunFiyat)
        {
            Urun u = Urunler.Find(o => o.urunID.ToString() == urunID);
                int sonuc = DL.UrunDuzenle(urunID, urunAdi, urunKategori, urunStok, urunFiyat);
                if (sonuc != -1)
                {
                    u.urunAdi = urunAdi;
                    u.urunKategori = urunKategori;
                    u.urunStok = urunStok;
                    u.urunFiyat = urunFiyat;
                }
        }

        public static void UrunSil(string urunID)
        {
            Urun urun = Urunler.Find(u => u.urunID.ToString() == urunID);
            if (urun != null)
            {
                int sonuc = DL.UrunSil(urunID);
                if (sonuc != -1)
                    Urunler.Remove(urun);
            }
        }

        public static int SatisEkle(int musteriID, int urunID, DateTime satisTarihi, string satisFiyati)
        {
            int sonuc = DL.SatisEkle(musteriID, urunID, satisTarihi, satisFiyati);
            if (sonuc != -1)
            {
                Satis satis = new Satis()
                {
                    musteriID = musteriID,
                    urunID = urunID,
                    satisTarihi = satisTarihi,
                    satisFiyati = satisFiyati
                };
            }
            return sonuc;
        }

        public static void SatisDuzenle(string satisID, int musteriID, int urunID, DateTime satisTarihi, string satisFiyati)
        {
            Satis satis = Satislar.Find(s => s.satisID.ToString() == satisID);
            if (satis != null)
            {
                int sonuc = DL.SatisDuzenle(satisID, musteriID, urunID, satisTarihi, satisFiyati);
                if (sonuc != -1)
                {
                    
                    satis.satisTarihi = satisTarihi;
                    satis.satisFiyati = satisFiyati;
                }
            }
        }

        public static void SatisSil(string satisID)
        {
            Satis satis = Satislar.Find(s => s.satisID.ToString() == satisID);
            if (satis != null)
            {
                int sonuc = DL.SatisSil(satisID);
                if (sonuc != -1)
                    Satislar.Remove(satis);
            }
        }

        public static int OdemeEkle(int musteriID, DateTime odemeTarihi, string odemeTutar, string odemeTur)
        {
            int sonuc = DL.OdemeEkle(musteriID, odemeTarihi, odemeTutar, odemeTur);
            if (sonuc != -1)
            {
                Odeme odeme = new Odeme()
                {
                    musteriID = musteriID,
                    odemeTarih = odemeTarihi,
                    odemeTutar = odemeTutar,
                    odemeTur = odemeTur
                };
            }
            return sonuc;
        }

        public static void OdemeDuzenle(string odemeID, int musteriID, DateTime odemeTarih, string odemeTutar, string odemeTur)
        {
            Odeme odeme = Odemeler.Find(o => o.odemeID.ToString() == odemeID);
            if (odeme != null)
            {
                int sonuc = DL.OdemeDuzenle(odemeID, musteriID, odemeTarih, odemeTutar, odemeTur);
                if (sonuc != -1)
                {
                    odeme.odemeTarih = odemeTarih;
                    odeme.odemeTutar = odemeTutar;
                    odeme.odemeTur = odemeTur;
                }
            }
        }

        public static void OdemeSil(string odemeID)
        {
            Odeme odeme = Odemeler.Find(o => o.odemeID.ToString() == odemeID);
            if (odeme != null)
            {
                int sonuc = DL.OdemeSil(odemeID);
                if (sonuc != -1)
                    Odemeler.Remove(odeme);
            }
        }

        public static List<Musteri> MusterileriListele()
        {
            Musteriler = DL.MusterileriListele();
            return Musteriler;
        }

        public static List<Urun> UrunleriListele()
        {
            Urunler = DL.UrunleriListele();
            return Urunler;
        }

        public static List<Satis> SatislariListele()
        {
            Satislar = DL.SatislariListele();
            return Satislar;
        }

        public static List<Odeme> OdemeleriListele()
        {
            Odemeler = DL.OdemeleriListele();
            return Odemeler;
        }
    }
}
