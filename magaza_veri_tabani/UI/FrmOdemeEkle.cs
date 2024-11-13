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
    public partial class FrmOdemeEkle : Form
    {
        public FrmOdemeEkle()
        {
            InitializeComponent();
        }

        private void FrmOdemeEkle_Load(object sender, EventArgs e)
        {
            List<Musteri> musteriler = BL.MusterileriListele();
            comboBox1.DataSource = musteriler;
            comboBox1.DisplayMember = "musteriID";
            comboBox1.ValueMember = "musteriID";

            comboBox2.Items.AddRange(new string[] { "Nakit", "Kredi Kartı", "Havale/EFT" });
        }

        public int musteriID
        {
            get { return Convert.ToInt32(comboBox1.SelectedValue); }
            set { comboBox1.SelectedValue = value; }
        }
        public DateTime odemeTarihi
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }
        public string odemeTutar
        {
            get { return maskedTextBox1.Text; }
            set { maskedTextBox1.Text = value; }
        }
        public string odemeTur
        {
            get { return comboBox2.SelectedItem.ToString(); }
            set { comboBox2.SelectedItem = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ödeme türü seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
