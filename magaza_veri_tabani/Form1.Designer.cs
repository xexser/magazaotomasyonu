namespace magaza_veri_tabani
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnSatisEkle = new System.Windows.Forms.ToolStripButton();
            this.btnSatisDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnSatisSil = new System.Windows.Forms.ToolStripButton();
            this.listSatislar = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMüsteriEkle = new System.Windows.Forms.ToolStripButton();
            this.btnMusteriDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnMusteriSil = new System.Windows.Forms.ToolStripButton();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.btnOdemeEkle = new System.Windows.Forms.ToolStripButton();
            this.btnOdemeDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnOdemeSil = new System.Windows.Forms.ToolStripButton();
            this.listOdemeler = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listUrunler = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnUrunEkle = new System.Windows.Forms.ToolStripButton();
            this.btnUrunDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnUrunSil = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip3);
            this.splitContainer1.Panel1.Controls.Add(this.listSatislar);
            this.splitContainer1.Panel1.Controls.Add(this.listMusteriler);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip4);
            this.splitContainer1.Panel2.Controls.Add(this.listOdemeler);
            this.splitContainer1.Panel2.Controls.Add(this.listUrunler);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer1.Size = new System.Drawing.Size(1275, 613);
            this.splitContainer1.SplitterDistance = 629;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSatisEkle,
            this.btnSatisDuzenle,
            this.btnSatisSil});
            this.toolStrip3.Location = new System.Drawing.Point(0, 304);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(629, 31);
            this.toolStrip3.TabIndex = 3;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnSatisEkle
            // 
            this.btnSatisEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSatisEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnSatisEkle.Image")));
            this.btnSatisEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatisEkle.Name = "btnSatisEkle";
            this.btnSatisEkle.Size = new System.Drawing.Size(75, 28);
            this.btnSatisEkle.Text = "Satış Ekle";
            this.btnSatisEkle.Click += new System.EventHandler(this.btnSatisEkle_Click);
            // 
            // btnSatisDuzenle
            // 
            this.btnSatisDuzenle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSatisDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnSatisDuzenle.Image")));
            this.btnSatisDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatisDuzenle.Name = "btnSatisDuzenle";
            this.btnSatisDuzenle.Size = new System.Drawing.Size(102, 28);
            this.btnSatisDuzenle.Text = "Satış Düzenle";
            this.btnSatisDuzenle.Click += new System.EventHandler(this.btnSatisDuzenle_Click);
            // 
            // btnSatisSil
            // 
            this.btnSatisSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSatisSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSatisSil.Image")));
            this.btnSatisSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatisSil.Name = "btnSatisSil";
            this.btnSatisSil.Size = new System.Drawing.Size(64, 28);
            this.btnSatisSil.Text = "Satış Sil";
            this.btnSatisSil.Click += new System.EventHandler(this.btnSatisSil_Click);
            // 
            // listSatislar
            // 
            this.listSatislar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listSatislar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listSatislar.FullRowSelect = true;
            this.listSatislar.GridLines = true;
            this.listSatislar.HideSelection = false;
            this.listSatislar.Location = new System.Drawing.Point(0, 335);
            this.listSatislar.Name = "listSatislar";
            this.listSatislar.Size = new System.Drawing.Size(629, 278);
            this.listSatislar.TabIndex = 2;
            this.listSatislar.UseCompatibleStateImageBehavior = false;
            this.listSatislar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "SatışID";
            this.columnHeader11.Width = 81;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "MüşteriID";
            this.columnHeader12.Width = 106;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "ÜrünID";
            this.columnHeader13.Width = 125;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Satış Tarih";
            this.columnHeader14.Width = 126;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Satış Fiyat";
            this.columnHeader15.Width = 98;
            // 
            // listMusteriler
            // 
            this.listMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listMusteriler.Dock = System.Windows.Forms.DockStyle.Top;
            this.listMusteriler.FullRowSelect = true;
            this.listMusteriler.GridLines = true;
            this.listMusteriler.HideSelection = false;
            this.listMusteriler.Location = new System.Drawing.Point(0, 31);
            this.listMusteriler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listMusteriler.Name = "listMusteriler";
            this.listMusteriler.Size = new System.Drawing.Size(629, 273);
            this.listMusteriler.TabIndex = 0;
            this.listMusteriler.UseCompatibleStateImageBehavior = false;
            this.listMusteriler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad Soyad";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefon";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mail";
            this.columnHeader4.Width = 125;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adres";
            this.columnHeader5.Width = 300;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMüsteriEkle,
            this.btnMusteriDuzenle,
            this.btnMusteriSil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(629, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMüsteriEkle
            // 
            this.btnMüsteriEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMüsteriEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnMüsteriEkle.Image")));
            this.btnMüsteriEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMüsteriEkle.Name = "btnMüsteriEkle";
            this.btnMüsteriEkle.Size = new System.Drawing.Size(93, 28);
            this.btnMüsteriEkle.Text = "Müşteri Ekle";
            this.btnMüsteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnMusteriDuzenle
            // 
            this.btnMusteriDuzenle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMusteriDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriDuzenle.Image")));
            this.btnMusteriDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusteriDuzenle.Name = "btnMusteriDuzenle";
            this.btnMusteriDuzenle.Size = new System.Drawing.Size(120, 28);
            this.btnMusteriDuzenle.Text = "Müşteri Düzenle";
            this.btnMusteriDuzenle.Click += new System.EventHandler(this.btnMusteriDuzenle_Click);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMusteriSil.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriSil.Image")));
            this.btnMusteriSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(82, 28);
            this.btnMusteriSil.Text = "Müşteri Sil";
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // toolStrip4
            // 
            this.toolStrip4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOdemeEkle,
            this.btnOdemeDuzenle,
            this.btnOdemeSil});
            this.toolStrip4.Location = new System.Drawing.Point(0, 304);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(642, 31);
            this.toolStrip4.TabIndex = 3;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // btnOdemeEkle
            // 
            this.btnOdemeEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOdemeEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeEkle.Image")));
            this.btnOdemeEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdemeEkle.Name = "btnOdemeEkle";
            this.btnOdemeEkle.Size = new System.Drawing.Size(93, 28);
            this.btnOdemeEkle.Text = "Ödeme Ekle";
            this.btnOdemeEkle.Click += new System.EventHandler(this.btnOdemeEkle_Click);
            // 
            // btnOdemeDuzenle
            // 
            this.btnOdemeDuzenle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOdemeDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeDuzenle.Image")));
            this.btnOdemeDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdemeDuzenle.Name = "btnOdemeDuzenle";
            this.btnOdemeDuzenle.Size = new System.Drawing.Size(120, 28);
            this.btnOdemeDuzenle.Text = "Ödeme Düzenle";
            this.btnOdemeDuzenle.Click += new System.EventHandler(this.btnOdemeDuzenle_Click);
            // 
            // btnOdemeSil
            // 
            this.btnOdemeSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOdemeSil.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeSil.Image")));
            this.btnOdemeSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdemeSil.Name = "btnOdemeSil";
            this.btnOdemeSil.Size = new System.Drawing.Size(82, 28);
            this.btnOdemeSil.Text = "Ödeme Sil";
            this.btnOdemeSil.Click += new System.EventHandler(this.btnOdemeSil_Click);
            // 
            // listOdemeler
            // 
            this.listOdemeler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20});
            this.listOdemeler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listOdemeler.FullRowSelect = true;
            this.listOdemeler.GridLines = true;
            this.listOdemeler.HideSelection = false;
            this.listOdemeler.Location = new System.Drawing.Point(0, 335);
            this.listOdemeler.Name = "listOdemeler";
            this.listOdemeler.Size = new System.Drawing.Size(642, 278);
            this.listOdemeler.TabIndex = 3;
            this.listOdemeler.UseCompatibleStateImageBehavior = false;
            this.listOdemeler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "ÖdemeID";
            this.columnHeader16.Width = 90;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "MüşteriID";
            this.columnHeader17.Width = 93;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Ödeme Tarih";
            this.columnHeader18.Width = 153;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Ödeme Tutar";
            this.columnHeader19.Width = 158;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Ödeme Tür";
            this.columnHeader20.Width = 104;
            // 
            // listUrunler
            // 
            this.listUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listUrunler.Dock = System.Windows.Forms.DockStyle.Top;
            this.listUrunler.FullRowSelect = true;
            this.listUrunler.GridLines = true;
            this.listUrunler.HideSelection = false;
            this.listUrunler.Location = new System.Drawing.Point(0, 31);
            this.listUrunler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listUrunler.Name = "listUrunler";
            this.listUrunler.Size = new System.Drawing.Size(642, 273);
            this.listUrunler.TabIndex = 1;
            this.listUrunler.UseCompatibleStateImageBehavior = false;
            this.listUrunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ürün Ad";
            this.columnHeader7.Width = 79;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ürün Kategori";
            this.columnHeader8.Width = 121;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ürün Stok";
            this.columnHeader9.Width = 145;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ürün Fiyat";
            this.columnHeader10.Width = 196;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUrunEkle,
            this.btnUrunDuzenle,
            this.btnUrunSil});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(642, 31);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUrunEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunEkle.Image")));
            this.btnUrunEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(75, 28);
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunDuzenle
            // 
            this.btnUrunDuzenle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUrunDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunDuzenle.Image")));
            this.btnUrunDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUrunDuzenle.Name = "btnUrunDuzenle";
            this.btnUrunDuzenle.Size = new System.Drawing.Size(102, 28);
            this.btnUrunDuzenle.Text = "Ürün Düzenle";
            this.btnUrunDuzenle.Click += new System.EventHandler(this.btnUrunDuzenle_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUrunSil.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunSil.Image")));
            this.btnUrunSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(64, 28);
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1275, 613);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mağaza Veri Tabanı";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMüsteriEkle;
        private System.Windows.Forms.ToolStripButton btnMusteriDuzenle;
        private System.Windows.Forms.ToolStripButton btnMusteriSil;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnUrunEkle;
        private System.Windows.Forms.ToolStripButton btnUrunDuzenle;
        private System.Windows.Forms.ToolStripButton btnUrunSil;
        private System.Windows.Forms.ListView listMusteriler;
        private System.Windows.Forms.ListView listUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ListView listSatislar;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ListView listOdemeler;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnSatisEkle;
        private System.Windows.Forms.ToolStripButton btnSatisDuzenle;
        private System.Windows.Forms.ToolStripButton btnSatisSil;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton btnOdemeEkle;
        private System.Windows.Forms.ToolStripButton btnOdemeDuzenle;
        private System.Windows.Forms.ToolStripButton btnOdemeSil;
    }
}

