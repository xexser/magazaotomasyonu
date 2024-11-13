using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace magaza_veri_tabani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BL veri = new BL();

            MusterileriListele();
            UrunleriListele();
            SatislariListele();
            OdemeleriListele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MusterileriListele();
            UrunleriListele();
            SatislariListele();
            OdemeleriListele();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle frmMusteriEkle = new FrmMusteriEkle()
            {
                Text = "Müşteri Ekle",
                StartPosition = FormStartPosition.CenterParent
            };

            if (frmMusteriEkle.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string adSoyad = frmMusteriEkle.adisoyadi;
                    string telefon = frmMusteriEkle.telefon;
                    string mail = frmMusteriEkle.mail;
                    string adres = frmMusteriEkle.adres;

                    BL.MusteriEkle(adSoyad, telefon, mail, adres);


                    MessageBox.Show("Müşteri başarıyla eklendi.");
                    MusterileriListele();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Müşteri eklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        public void MusterileriListele()
        {
            var musteriler = BL.MusterileriListele();
            listMusteriler.Items.Clear();
            foreach (var m in musteriler)
            {
                ListViewItem veri = new ListViewItem(new string[]
                {
                    m.musteriID.ToString(),
                    m.musteriAdiSoyadi,
                    m.musteriTelefon,
                    m.musteriMail,
                    m.musteriAdres
                });
                listMusteriler.Items.Add(veri);
            }
        }

        private void btnMusteriDuzenle_Click(object sender, EventArgs e)
        {
            if (listMusteriler.SelectedItems.Count == 0)
                return;

            ListViewItem selected = listMusteriler.SelectedItems[0];
            string musteriID = selected.SubItems[0].Text;
            string adSoyad = selected.SubItems[1].Text;
            string telefon = selected.SubItems[2].Text;
            string mail = selected.SubItems[3].Text;
            string adres = selected.SubItems[4].Text;

            FrmMusteriEkle frmMusteriEkle = new FrmMusteriEkle()
            {
                Text = "Müşteri Güncelle",
                StartPosition = FormStartPosition.CenterParent,
                adisoyadi = adSoyad,
                telefon = telefon,
                mail = mail,
                adres = adres
            };

            if (frmMusteriEkle.ShowDialog() == DialogResult.OK)
            {
                BL.MusteriDuzenle(musteriID, frmMusteriEkle.adisoyadi, frmMusteriEkle.telefon, frmMusteriEkle.mail, frmMusteriEkle.adres);
                MusterileriListele();
            }
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            if (listMusteriler.SelectedItems.Count == 0)
                return;

            DialogResult result = MessageBox.Show("Seçili müşteriyi silmek istediğinizden emin misiniz?", "Müşteri Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ListViewItem selected = listMusteriler.SelectedItems[0];
                string musteriID = selected.SubItems[0].Text;

                BL.MusteriSil(musteriID);

                listMusteriler.Items.Remove(selected);
            }
        }

        public void UrunleriListele()
        {
            listUrunler.Items.Clear();
            List<Urun> urunler = BL.UrunleriListele();

            foreach (var urun in urunler)
            {
                ListViewItem item = new ListViewItem(urun.urunID.ToString());
                item.SubItems.Add(urun.urunAdi);
                item.SubItems.Add(urun.urunKategori);
                item.SubItems.Add(urun.urunStok);
                item.SubItems.Add(urun.urunFiyat);

                listUrunler.Items.Add(item);
            }
        }


        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            FrmUrunEkle frmUrunEkle = new FrmUrunEkle()
            {
                Text = "Ürün Ekle",
                StartPosition = FormStartPosition.CenterParent
            };

            if (frmUrunEkle.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string urunAdi = frmUrunEkle.urunAdi;
                    string kategori = frmUrunEkle.urunKategori;
                    string stok = frmUrunEkle.urunStok;
                    string fiyat = frmUrunEkle.urunFiyat;

                    BL.UrunEkle(urunAdi, kategori, stok, fiyat);

                    MessageBox.Show("Ürün başarıyla eklendi.");
                    UrunleriListele();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ürün eklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnUrunDuzenle_Click(object sender, EventArgs e)
        {
            if (listUrunler.SelectedItems.Count == 0)
                return;

            ListViewItem selected = listUrunler.SelectedItems[0];
            string urunID = selected.SubItems[0].Text;
            string urunAdi = selected.SubItems[1].Text;
            string urunKategori = selected.SubItems[2].Text;
            string urunStok = selected.SubItems[3].Text;
            string urunFiyat = selected.SubItems[4].Text;

            FrmUrunEkle frmUrunEkle = new FrmUrunEkle()
            {
                Text = "Ürün Güncelle",
                StartPosition = FormStartPosition.CenterParent,
                urunAdi = urunAdi,
                urunKategori = urunKategori,
                urunStok = urunStok,
                urunFiyat = urunFiyat
            };

            if (frmUrunEkle.ShowDialog() == DialogResult.OK)
            {
                BL.UrunDuzenle(urunID, frmUrunEkle.urunAdi, frmUrunEkle.urunKategori, frmUrunEkle.urunStok, frmUrunEkle.urunFiyat);
                UrunleriListele();
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (listUrunler.SelectedItems.Count == 0)
                return;

            DialogResult result = MessageBox.Show("Seçili ürünü silmek istediğinizden emin misiniz?", "Ürün Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ListViewItem selected = listUrunler.SelectedItems[0];
                string urunID = selected.SubItems[0].Text;

                BL.UrunSil(urunID);

                listUrunler.Items.Remove(selected);

                UrunleriListele();
            }
        }

        public void SatislariListele()
        {
            listSatislar.Items.Clear();
            List<Satis> satislar = BL.SatislariListele();

            foreach (var satis in satislar)
            {
                ListViewItem item = new ListViewItem(satis.satisID.ToString());
                item.SubItems.Add(satis.musteriID.ToString());
                item.SubItems.Add(satis.urunID.ToString());
                item.SubItems.Add(satis.satisTarihi.ToString());
                item.SubItems.Add(satis.satisFiyati);

                listSatislar.Items.Add(item);
            }
        }

        private void btnSatisEkle_Click(object sender, EventArgs e)
        {
            FrmSatisEkle frmSatisEkle = new FrmSatisEkle()
            {
                Text = "Satış Ekle",
                StartPosition = FormStartPosition.CenterParent
            };

            if (frmSatisEkle.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int musteriID = frmSatisEkle.musteriID;
                    int urunID = frmSatisEkle.urunID;
                    DateTime satisTarihi = frmSatisEkle.satisTarihi;
                    string satisFiyati = frmSatisEkle.satisFiyati;

                    int sonuc = BL.SatisEkle(musteriID, urunID, satisTarihi, satisFiyati);

                    if (sonuc != -1)
                    {
                        MessageBox.Show("Satış başarıyla eklendi.");
                        SatislariListele(); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Satış eklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnSatisDuzenle_Click(object sender, EventArgs e)
        {
            if (listSatislar.SelectedItems.Count == 0)
                return;

            ListViewItem selected = listSatislar.SelectedItems[0];
            string satisID = selected.SubItems[0].Text;
            int musteriID = Convert.ToInt32(selected.SubItems[1].Text); 
            int urunID = Convert.ToInt32(selected.SubItems[2].Text); 
            string satisTarihi = selected.SubItems[3].Text;
            string satisFiyati = selected.SubItems[4].Text;

            FrmSatisEkle frmSatisEkle = new FrmSatisEkle()
            {
                Text = "Satış Güncelle",
                StartPosition = FormStartPosition.CenterParent,
                musteriID = musteriID,
                urunID = urunID,
                satisTarihi = Convert.ToDateTime(satisTarihi),
                satisFiyati = satisFiyati
            };

            if (frmSatisEkle.ShowDialog() == DialogResult.OK)
            {
                BL.SatisDuzenle(satisID, frmSatisEkle.musteriID, frmSatisEkle.urunID, frmSatisEkle.satisTarihi, frmSatisEkle.satisFiyati);
                SatislariListele();
            }
        }

        private void btnSatisSil_Click(object sender, EventArgs e)
        {
            if (listSatislar.SelectedItems.Count == 0)
                return;

            DialogResult result = MessageBox.Show("Seçili satışı silmek istediğinizden emin misiniz?", "Satış Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ListViewItem selected = listSatislar.SelectedItems[0];
                string satisID = selected.SubItems[0].Text;

                BL.SatisSil(satisID);

                listSatislar.Items.Remove(selected);

                SatislariListele();
            }
        }

        public void OdemeleriListele()
        {
            listOdemeler.Items.Clear();
            List<Odeme> odemeler = BL.OdemeleriListele();

            foreach (var odeme in odemeler)
            {
                ListViewItem item = new ListViewItem(odeme.odemeID.ToString());
                item.SubItems.Add(odeme.musteriID.ToString());
                item.SubItems.Add(odeme.odemeTarih.ToString());
                item.SubItems.Add(odeme.odemeTutar);
                item.SubItems.Add(odeme.odemeTur);

                listOdemeler.Items.Add(item);
            }
        }

        private void btnOdemeEkle_Click(object sender, EventArgs e)
        {
            FrmOdemeEkle frmOdemeEkle = new FrmOdemeEkle()
            {
                Text = "Ödeme Ekle",
                StartPosition = FormStartPosition.CenterParent
            };

            if (frmOdemeEkle.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int musteriID = frmOdemeEkle.musteriID;
                    DateTime odemeTarihi = frmOdemeEkle.odemeTarihi;
                    string odemeTutar = frmOdemeEkle.odemeTutar;
                    string odemeTur = frmOdemeEkle.odemeTur;

                    int sonuc = BL.OdemeEkle(musteriID, odemeTarihi, odemeTutar, odemeTur);

                    if (sonuc != -1)
                    {
                        MessageBox.Show("Ödeme başarıyla eklendi.");
                        OdemeleriListele();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ödeme eklenirken bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnOdemeDuzenle_Click(object sender, EventArgs e)
        {
            if (listOdemeler.SelectedItems.Count == 0)
                return;

            ListViewItem selected = listOdemeler.SelectedItems[0];
            string odemeID = selected.SubItems[0].Text;
            int musteriID = Convert.ToInt32(selected.SubItems[1].Text);
            string odemeTarih = selected.SubItems[2].Text;
            string odemeTutar = selected.SubItems[3].Text;
            string odemeTur = selected.SubItems[4].Text;

            FrmOdemeEkle frmOdemeEkle = new FrmOdemeEkle()
            {
                Text = "Ödeme Güncelle",
                StartPosition = FormStartPosition.CenterParent,
                musteriID = musteriID,
                odemeTarihi = Convert.ToDateTime(odemeTarih),
                odemeTutar = odemeTutar,
                odemeTur = odemeTur
            };

            if (frmOdemeEkle.ShowDialog() == DialogResult.OK)
            {
                    BL.OdemeDuzenle(odemeID, frmOdemeEkle.musteriID, frmOdemeEkle.odemeTarihi, frmOdemeEkle.odemeTutar, frmOdemeEkle.odemeTur);
                    OdemeleriListele();
            }
        }

        private void btnOdemeSil_Click(object sender, EventArgs e)
        {
            if (listOdemeler.SelectedItems.Count == 0)
                return;

            DialogResult result = MessageBox.Show("Seçili ödemeyi silmek istediğinizden emin misiniz?", "Ödeme Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ListViewItem selected = listOdemeler.SelectedItems[0];
                string odemeID = selected.SubItems[0].Text;

                BL.OdemeSil(odemeID);

                listOdemeler.Items.Remove(selected);

                OdemeleriListele();
            }
        }
    }
}
