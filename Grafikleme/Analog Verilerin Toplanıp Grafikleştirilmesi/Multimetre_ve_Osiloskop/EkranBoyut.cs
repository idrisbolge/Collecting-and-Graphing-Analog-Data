using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multimetre_ve_Osiloskop
{
    public partial class EkranBoyut : Form
    {
        public EkranBoyut()
        {
            InitializeComponent();
        }
        private void EkranBoyut_Load(object sender, EventArgs e)
        {
            int genislik, yukseklik;
            genislik = Screen.PrimaryScreen.Bounds.Width;
            yukseklik = Screen.PrimaryScreen.Bounds.Height;
            label4.Text = "Maximum ekran boyutları :\n Genişlik = "+genislik+"\n yükseklik = "+yukseklik;

            numericUpDown1.Maximum = genislik;
            numericUpDown2.Maximum = yukseklik;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1.genislik=int.Parse(numericUpDown1.Value.ToString());
            Form1.yukseklik = int.Parse(numericUpDown2.Value.ToString());
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EkranBoyut_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = (Form1)Application.OpenForms["Form1"];
            f1.boyutlandır();
        }
    }
}
