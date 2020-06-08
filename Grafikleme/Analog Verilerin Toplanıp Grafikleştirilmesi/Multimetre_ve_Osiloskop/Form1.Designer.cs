namespace Multimetre_ve_Osiloskop
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimOlarakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metinOlarakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümPencereResimOlarakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resimOlarakToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.metinOlarakToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tümEkranıResimOlarakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sayfayıBoyutlandırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekranıKaplaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boyutlandırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlantıSeçimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kabloluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kablosuzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriAlımBiçimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.değerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanımKılavuzuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriBildirimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolBaglanti = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.araçlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem,
            this.yazdırToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.OpenFile;
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.Save;
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.differentSave;
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            this.farklıKaydetToolStripMenuItem.Click += new System.EventHandler(this.farklıKaydetToolStripMenuItem_Click);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.print;
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.yazdırToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.exit;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopyalaToolStripMenuItem,
            this.kaydetToolStripMenuItem1,
            this.sayfayıBoyutlandırToolStripMenuItem});
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resimOlarakToolStripMenuItem,
            this.metinOlarakToolStripMenuItem,
            this.tümPencereResimOlarakToolStripMenuItem});
            this.kopyalaToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.copy;
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            // 
            // resimOlarakToolStripMenuItem
            // 
            this.resimOlarakToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.ss;
            this.resimOlarakToolStripMenuItem.Name = "resimOlarakToolStripMenuItem";
            this.resimOlarakToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.resimOlarakToolStripMenuItem.Text = "Resim olarak";
            this.resimOlarakToolStripMenuItem.Click += new System.EventHandler(this.resimOlarakToolStripMenuItem_Click);
            // 
            // metinOlarakToolStripMenuItem
            // 
            this.metinOlarakToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.text;
            this.metinOlarakToolStripMenuItem.Name = "metinOlarakToolStripMenuItem";
            this.metinOlarakToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.metinOlarakToolStripMenuItem.Text = "Metin olarak";
            this.metinOlarakToolStripMenuItem.Click += new System.EventHandler(this.metinOlarakToolStripMenuItem_Click);
            // 
            // tümPencereResimOlarakToolStripMenuItem
            // 
            this.tümPencereResimOlarakToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.allss;
            this.tümPencereResimOlarakToolStripMenuItem.Name = "tümPencereResimOlarakToolStripMenuItem";
            this.tümPencereResimOlarakToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.tümPencereResimOlarakToolStripMenuItem.Text = "Tüm pencere resim olarak";
            this.tümPencereResimOlarakToolStripMenuItem.Click += new System.EventHandler(this.tümPencereResimOlarakToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem1
            // 
            this.kaydetToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resimOlarakToolStripMenuItem1,
            this.metinOlarakToolStripMenuItem1,
            this.tümEkranıResimOlarakToolStripMenuItem});
            this.kaydetToolStripMenuItem1.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.Save;
            this.kaydetToolStripMenuItem1.Name = "kaydetToolStripMenuItem1";
            this.kaydetToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.kaydetToolStripMenuItem1.Text = "Kaydet";
            // 
            // resimOlarakToolStripMenuItem1
            // 
            this.resimOlarakToolStripMenuItem1.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.ss;
            this.resimOlarakToolStripMenuItem1.Name = "resimOlarakToolStripMenuItem1";
            this.resimOlarakToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.resimOlarakToolStripMenuItem1.Text = "Resim olarak";
            this.resimOlarakToolStripMenuItem1.Click += new System.EventHandler(this.resimOlarakToolStripMenuItem1_Click);
            // 
            // metinOlarakToolStripMenuItem1
            // 
            this.metinOlarakToolStripMenuItem1.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.text;
            this.metinOlarakToolStripMenuItem1.Name = "metinOlarakToolStripMenuItem1";
            this.metinOlarakToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.metinOlarakToolStripMenuItem1.Text = "Metin olarak";
            this.metinOlarakToolStripMenuItem1.Click += new System.EventHandler(this.metinOlarakToolStripMenuItem1_Click);
            // 
            // tümEkranıResimOlarakToolStripMenuItem
            // 
            this.tümEkranıResimOlarakToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.allss;
            this.tümEkranıResimOlarakToolStripMenuItem.Name = "tümEkranıResimOlarakToolStripMenuItem";
            this.tümEkranıResimOlarakToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.tümEkranıResimOlarakToolStripMenuItem.Text = "Tüm ekranı resim olarak";
            this.tümEkranıResimOlarakToolStripMenuItem.Click += new System.EventHandler(this.tümEkranıResimOlarakToolStripMenuItem_Click);
            // 
            // sayfayıBoyutlandırToolStripMenuItem
            // 
            this.sayfayıBoyutlandırToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekranıKaplaToolStripMenuItem,
            this.boyutlandırToolStripMenuItem});
            this.sayfayıBoyutlandırToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.boyutlandirma;
            this.sayfayıBoyutlandırToolStripMenuItem.Name = "sayfayıBoyutlandırToolStripMenuItem";
            this.sayfayıBoyutlandırToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.sayfayıBoyutlandırToolStripMenuItem.Text = "Sayfayı Boyutlandır";
            // 
            // ekranıKaplaToolStripMenuItem
            // 
            this.ekranıKaplaToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.full_screen;
            this.ekranıKaplaToolStripMenuItem.Name = "ekranıKaplaToolStripMenuItem";
            this.ekranıKaplaToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.ekranıKaplaToolStripMenuItem.Text = "Ekranı Kapla";
            this.ekranıKaplaToolStripMenuItem.Click += new System.EventHandler(this.ekranıKaplaToolStripMenuItem_Click);
            // 
            // boyutlandırToolStripMenuItem
            // 
            this.boyutlandırToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.ruler;
            this.boyutlandırToolStripMenuItem.Name = "boyutlandırToolStripMenuItem";
            this.boyutlandırToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.boyutlandırToolStripMenuItem.Text = "Boyutlandır";
            this.boyutlandırToolStripMenuItem.Click += new System.EventHandler(this.boyutlandırToolStripMenuItem_Click);
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bağlantıSeçimiToolStripMenuItem,
            this.veriAlımBiçimiToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.araçlarToolStripMenuItem.Text = "Araçlar";
            // 
            // bağlantıSeçimiToolStripMenuItem
            // 
            this.bağlantıSeçimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kabloluToolStripMenuItem,
            this.kablosuzToolStripMenuItem});
            this.bağlantıSeçimiToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.connect_choose;
            this.bağlantıSeçimiToolStripMenuItem.Name = "bağlantıSeçimiToolStripMenuItem";
            this.bağlantıSeçimiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.bağlantıSeçimiToolStripMenuItem.Text = "Bağlantı Seçimi";
            // 
            // kabloluToolStripMenuItem
            // 
            this.kabloluToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.wire;
            this.kabloluToolStripMenuItem.Name = "kabloluToolStripMenuItem";
            this.kabloluToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.kabloluToolStripMenuItem.Text = "Kablolu";
            this.kabloluToolStripMenuItem.Click += new System.EventHandler(this.kabloluToolStripMenuItem_Click);
            // 
            // kablosuzToolStripMenuItem
            // 
            this.kablosuzToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.wireles;
            this.kablosuzToolStripMenuItem.Name = "kablosuzToolStripMenuItem";
            this.kablosuzToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.kablosuzToolStripMenuItem.Text = "Kablosuz";
            this.kablosuzToolStripMenuItem.Click += new System.EventHandler(this.kablosuzToolStripMenuItem_Click);
            // 
            // veriAlımBiçimiToolStripMenuItem
            // 
            this.veriAlımBiçimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafikToolStripMenuItem,
            this.değerToolStripMenuItem1});
            this.veriAlımBiçimiToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.receiving_data;
            this.veriAlımBiçimiToolStripMenuItem.Name = "veriAlımBiçimiToolStripMenuItem";
            this.veriAlımBiçimiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.veriAlımBiçimiToolStripMenuItem.Text = "Veri Alım Biçimi";
            // 
            // grafikToolStripMenuItem
            // 
            this.grafikToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.line;
            this.grafikToolStripMenuItem.Name = "grafikToolStripMenuItem";
            this.grafikToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.grafikToolStripMenuItem.Text = "Grafik";
            this.grafikToolStripMenuItem.Click += new System.EventHandler(this.grafikToolStripMenuItem_Click);
            // 
            // değerToolStripMenuItem1
            // 
            this.değerToolStripMenuItem1.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.data;
            this.değerToolStripMenuItem1.Name = "değerToolStripMenuItem1";
            this.değerToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.değerToolStripMenuItem1.Text = "Değer";
            this.değerToolStripMenuItem1.Click += new System.EventHandler(this.değerToolStripMenuItem1_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanımKılavuzuToolStripMenuItem,
            this.geriBildirimToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // kullanımKılavuzuToolStripMenuItem
            // 
            this.kullanımKılavuzuToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.user_guide;
            this.kullanımKılavuzuToolStripMenuItem.Name = "kullanımKılavuzuToolStripMenuItem";
            this.kullanımKılavuzuToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.kullanımKılavuzuToolStripMenuItem.Text = "Kullanım Kılavuzu";
            this.kullanımKılavuzuToolStripMenuItem.Click += new System.EventHandler(this.kullanımKılavuzuToolStripMenuItem_Click);
            // 
            // geriBildirimToolStripMenuItem
            // 
            this.geriBildirimToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.feedback;
            this.geriBildirimToolStripMenuItem.Name = "geriBildirimToolStripMenuItem";
            this.geriBildirimToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.geriBildirimToolStripMenuItem.Text = "Geri Bildirim";
            this.geriBildirimToolStripMenuItem.Click += new System.EventHandler(this.geriBildirimToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Image = global::Multimetre_ve_Osiloskop.Properties.Resources.user_guide1;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 437);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(734, 368);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.chart1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(734, 336);
            this.panel6.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(110, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 170);
            this.label1.TabIndex = 2;
            this.label1.Text = "0 V";
            this.label1.Visible = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(734, 336);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.statusStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 336);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(734, 32);
            this.panel4.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBaglanti,
            this.toolPort});
            this.statusStrip1.Location = new System.Drawing.Point(0, 10);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(734, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolBaglanti
            // 
            this.ToolBaglanti.Name = "ToolBaglanti";
            this.ToolBaglanti.Size = new System.Drawing.Size(47, 17);
            this.ToolBaglanti.Text = "Kablolu";
            // 
            // toolPort
            // 
            this.toolPort.Name = "toolPort";
            this.toolPort.Size = new System.Drawing.Size(0, 17);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 69);
            this.panel2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(331, 69);
            this.panel7.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bağlantıyı Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "Form1";
            this.Text = "Analog Verilerin Toplanarak Bilgisayar Ortamında Analiz Edilmesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimOlarakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metinOlarakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümPencereResimOlarakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resimOlarakToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem metinOlarakToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tümEkranıResimOlarakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanımKılavuzuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriBildirimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sayfayıBoyutlandırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekranıKaplaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boyutlandırToolStripMenuItem;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolBaglanti;
        private System.Windows.Forms.ToolStripMenuItem bağlantıSeçimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kabloluToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kablosuzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veriAlımBiçimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem değerToolStripMenuItem1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ToolStripStatusLabel toolPort;
    }
}

