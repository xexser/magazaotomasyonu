using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace magaza_veri_tabani
{
    public partial class FrmUrunEkle : Form
    {
        public FrmUrunEkle()
        {
            InitializeComponent();
        }

        public string urunAdi
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string urunKategori
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string urunStok
        {
            get { return maskedTextBox1.Text; }
            set { maskedTextBox1.Text = value; }
        }

        public string urunFiyat
        {
            get { return maskedTextBox2.Text; }
            set { maskedTextBox2.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmUrunEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
