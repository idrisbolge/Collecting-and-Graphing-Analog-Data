using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO.Ports;
using System.Threading;
using System.Collections.Concurrent;
using System.IO;
using System.Drawing.Imaging;

namespace Multimetre_ve_Osiloskop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }
        private static bool isgraph=true;

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddY(0);
        
            ToolBaglanti.Text = Properties.Settings.Default.Baglanti;
            toolPort.Text = "Bir bağ yok";
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.Text=="Bağlantıyı Başlat")
            {
                if (ToolBaglanti.Text == "Kablolu")
                {
                    if (toolPort.Text == "Bir bağ yok")
                        FindPort();
                        Wire();
                }

                else if (ToolBaglanti.Text == "Kablosuz")
                {
                    if (toolPort.Text == "Bir bağ yok")
                        FindSerialNumber();
                    Wireless();
                }
            }
            else if (button1.Text=="Bağlantıyı Durdur")
            {
                if (ToolBaglanti.Text == "Kablolu")
                    serialPort1.Close();

                else if (ToolBaglanti.Text == "Kablosuz")
                    Baglantilar.state = false;
                button1.Text = "Bağlantıyı Başlat";
            }

        
        
        
        }

        #region Çıkış
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen||!Baglantilar.state)
            {
                serialPort1.Close();
                Baglantilar.state = false;
            }
            Application.Exit();

        }
        #endregion
        #region KabloluKablosuzTool
        private void kabloluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolBaglanti.Text = "Kablolu";
            toolPort.Text = "Bir bağ yok";
            FindPort();
        }
        private void kablosuzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolBaglanti.Text = "Kablosuz";
            toolPort.Text = "Bir bağ yok";
            FindSerialNumber();
        }
        #endregion
        #region Grafik-Veri
        private void grafikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isgraph = true;
            chart1.Visible = true;
            label1.Visible = false;
        }

        private void değerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            isgraph = false;
            label1.Visible = true;
            chart1.Visible = false;
        }
        #endregion
        #region FindPort/SerialNumber
        private void FindSerialNumber()
        {
            String SeriNo = Properties.Settings.Default.SeriNo;
            if (SeriNo != "")
                toolPort.Text = SeriNo;    
            else
            {
                DialogResult a;
                a = MessageBox.Show("Bağlanacak bir cihaz yok. Cihaz eklemek ister misiniz?", "UYARI",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (a == DialogResult.Yes)
                {
                    SeriNo = Interaction.InputBox("Lütfen Cihazınızın seri numarasını giriniz : ",
                        "Cihaz Ekleme Sayfası", "Örnek: ABC123", 0, 0);
                    Properties.Settings.Default.SeriNo = SeriNo;
                    Properties.Settings.Default.Save();
                    toolPort.Text = SeriNo;
                }
            }
        }


        private void FindPort()
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Count() == 1)
                toolPort.Text = ports[0].ToString();
            else
            {
                string sonuc = "";
                int sayac = 0;
                foreach (string p in ports)
                {
                    sayac++;
                    sonuc += sayac.ToString() + " : " + p + "\n";
                }
                string Portismi = Interaction.InputBox("Hangisi porta bağlanmak istersiniz? \n\n" + sonuc,
                    "Kablolu bağlantı", "Örnek: 2", 0, 0);
                if (Portismi != "")
                {
                    try
                    {
                        toolPort.Text = ports[int.Parse(Portismi) - 1].ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("hatalı giriş yaptınız.");
                    }
                }
            }
        }
        #endregion
        #region Kopyala

        private void resimOlarakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resimolarakkopyala();
        }

        private void metinOlarakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metinolarakkopyala();
        }

        private void tümPencereResimOlarakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TumEkraniKopyala();
        }

        void Resimolarakkopyala() {
            using (MemoryStream ms = new MemoryStream())
            {
                chart1.SaveImage(ms, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Bmp);
                Bitmap bm = new Bitmap(ms);
                Clipboard.SetImage(bm);}
        }
        void TumEkraniKopyala() {
            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap foto = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics grafik = Graphics.FromImage(foto);
                grafik.CopyFromScreen(0, 0, 0, 0, new Size(foto.Width, foto.Height));
                Clipboard.SetImage(foto); }
        }
        void Metinolarakkopyala()
        {
            string sonuc = "";
            foreach (var item in chart1.Series[0].Points)
                sonuc += item + "\n";
            Clipboard.SetText(sonuc);
        }

   







        #endregion
        #region Kaydet
        private void resimOlarakToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "Png Dosyası|*.png";
            kaydet.FileName = DateTime.Now.ToString().Replace(':','-').Replace('.','-').Replace(' ','-');
            if (kaydet.ShowDialog()==DialogResult.OK)
            {
                chart1.SaveImage(kaydet.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                MessageBox.Show("Kaydetme işleminiz başarılı");
            }
        }
        private void tümEkranıResimOlarakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "Png Dosyası|*.png";
            kaydet.FileName = DateTime.Now.ToString().Replace(':', '-').Replace('.', '-').Replace(' ', '-');
            if (kaydet.ShowDialog() == DialogResult.OK)
            {       
                Bitmap foto = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics grafik = Graphics.FromImage(foto);
                grafik.CopyFromScreen(0, 0, 0, 0, new Size(foto.Width, foto.Height));
                foto.Save(kaydet.FileName,ImageFormat.Png);
                MessageBox.Show("Kaydetme işleminiz başarılı");
            }
        }
        private void metinOlarakToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string sonuc = "";
            foreach (var item in chart1.Series[0].Points)
                sonuc += item + "\n";
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "Text Dosyası|*.txt";
            kaydet.FileName = DateTime.Now.ToString().Replace(':', '-').Replace('.', '-').Replace(' ', '-');
            if (kaydet.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Kayit = new StreamWriter(kaydet.FileName);
                Kayit.Write(sonuc);
                Kayit.Close();
                MessageBox.Show("Kaydetme işleminiz başarılı");
            }
        }





        #endregion
        #region Boyutlandırma
        private void ekranıKaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        public static int genislik = 750, yukseklik = 500;
        private void boyutlandırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EkranBoyut byt = new EkranBoyut();
            byt.Show();
        }

        public void boyutlandır()
        {
            this.WindowState = FormWindowState.Normal;
            this.Width = genislik;
            this.Height = yukseklik;
        }
        #endregion
        #region Yardım
        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkında hk = new hakkında();
            hk.Show();
        }

        private void kullanımKılavuzuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şuanlık yönlendirilecek bir web sitesi yok");
        }

        private void geriBildirimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            feedback fd = new feedback();
            fd.Show();
        }

        #endregion
        #region yazdir
        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            this.chart1.Printing.PrintDocument.DocumentName = "Chart Yazdırma";
            this.chart1.Printing.PrintDocument.DefaultPageSettings.Landscape = true;
            ppd.Document = this.chart1.Printing.PrintDocument;
            ppd.ShowDialog();
        }

        #endregion
        #region Save-Open

        //Şifreleme için gerekli password
        string Secret = "L(e47SrR@n!Y3_99l$uZ4+zIkSwcwo6oEAD9hv)Ox?D/i-%=ASk@+0d!ed-s0&A1j?)ZLdozHgOb(9vd95tUJWLhK0MYTgcy&";

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sonuc="";
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog()==DialogResult.OK)
            {
                string filePath = file.FileName;
                StreamReader sr = new StreamReader(File.OpenRead(filePath));
                sonuc=StringCipher.Decrypt(sr.ReadToEnd(), Secret);
                sr.Dispose();
                chart1.Series[0].Points.Clear();
            }
            sonuc=sonuc.Replace("{X=0, Y=","").Replace("}","") ;

            string result="";
            for (int i = 0; i < sonuc.Length; i++)
            {
                if (sonuc[i]!='\n')
                    result += sonuc[i];
                else
                {
                    Console.WriteLine(result);
                    chart1.Series[0].Points.AddY(result);
                    result = "";
                }
            }
        }

         void kaydet() {
            string sonuc = "";
            foreach (var item in chart1.Series[0].Points)
            {
                sonuc += item + "\n";
            }

            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "Mai Data Dosyası|*.mai";
            kaydet.FileName = DateTime.Now.ToString().Replace(':', '-').Replace('.', '-').Replace(' ', '-');
            if (kaydet.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Kayit = new StreamWriter(kaydet.FileName);
                Kayit.Write(StringCipher.Encrypt(sonuc, Secret));
                Kayit.Close();
                MessageBox.Show("Kaydetme işleminiz başarılı");
            }
        }


        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        #endregion
        #region Addpoint
        Baglantilar bag = new Baglantilar();
        public delegate void OnSerialDataReceived(string pnt);

        private void AddPointToChart(string pnt)
        {
            Console.WriteLine(pnt);
            if (isgraph)
                chart1.Series[0].Points.AddY(pnt);

            else
                label1.Text = pnt+"  V ";
            
            
        }

        private void addPoint()
        {
            string pnt;
            while (true)
            {
                if (!bag.kuyruk.IsEmpty)
                {
                    if (bag.kuyruk.TryDequeue(out pnt))
                    {
                        var safeInvoker = new OnSerialDataReceived(AddPointToChart);
                        chart1.Invoke(safeInvoker, pnt);
                    }
                }
            }
        }
        #endregion
        #region Kablosuz
        public void Wireless()
        {
            if (Baglantilar.state == false)
            {
                Baglantilar.state = true;
                bag.serialNumber = Properties.Settings.Default.SeriNo;
                Thread thread2 = new Thread(new ThreadStart(bag.login));
                Thread thread = new Thread(new ThreadStart(addPoint));
                thread.Start();
                thread2.Start();
                button1.Text = "Bağlantıyı Durdur";
            }
            else
            {
                Baglantilar.state = false;
            }
        }
        #endregion
        #region Wire
        string result;
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var indata = serialPort1.ReadChar();
            if (indata != 13 && indata != 10)
                result += Convert.ToChar(indata);
            else
            {
                if (result != null)
                    bag.kuyruk.Enqueue(result.ToString());
                result = null;
            } }
        void Wire()
        {
            try
            {
                serialPort1.PortName = toolPort.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                serialPort1.WriteLine("start");
                Thread thread = new Thread(new ThreadStart(addPoint));
                thread.Start();
                button1.Text = "Bağlantıyı Durdur";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        #endregion



    }
}
