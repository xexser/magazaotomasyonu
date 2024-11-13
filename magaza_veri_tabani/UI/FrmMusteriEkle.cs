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
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }

        public string adisoyadi
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string telefon
        {
            get { return maskedTextBox1.Text; }
            set { maskedTextBox1.Text = value; }
        }
        public string mail
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string adres
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
