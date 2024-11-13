using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magaza_veri_tabani
{
    public partial class FrmSatisEkle : Form
    {
        public FrmSatisEkle()
        {
            InitializeComponent();
        }

        private void FrmSatisEkle_Load(object sender, EventArgs e)
        {
            List<Musteri> musteriler = BL.MusterileriListele();
            comboBox1.DataSource = musteriler;
            comboBox1.DisplayMember = "musteriID";
            comboBox1.ValueMember = "musteriID";

            List<Urun> urunler = BL.UrunleriListele();
            comboBox2.DataSource = urunler;
            comboBox2.DisplayMember = "urunID";
            comboBox2.ValueMember = "urunID";
        }

        public int musteriID
        {
            get { return Convert.ToInt32(comboBox1.SelectedValue); }
            set { comboBox1.SelectedValue = value; }
        }
        public int urunID
        {
            get { return Convert.ToInt32(comboBox2.SelectedValue); }
            set { comboBox2.SelectedValue = value; }
        }
        public DateTime satisTarihi
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }
        public string satisFiyati
        {
            get { return maskedTextBox1.Text; }
            set { maskedTextBox1.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}

