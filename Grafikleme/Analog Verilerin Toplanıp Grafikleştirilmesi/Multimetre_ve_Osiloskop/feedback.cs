using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


namespace Multimetre_ve_Osiloskop
{
    public partial class feedback : Form
    {
        public feedback()
        {
            InitializeComponent();
        }


        public void SendMail()
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp-mail.outlook.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("mailadres", "şifre");
            MailMessage eposta = new MailMessage();
            eposta.From = new MailAddress("mail adres", "Multimetre&Osiloskop");
            eposta.To.Add("mailadres@hotmail.com");
            eposta.Subject = "Multimetre&Osiloskop-" + textBox1.Text + " " + textBox2.Text;
            eposta.Body = richTextBox1.Text;
            try
            {
                smtp.Send(eposta);
                MessageBox.Show("Geri Bildiriminiz ulaşmıştır. ");
                textBox1.Text = "";
                textBox2.Text = "";
                richTextBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && richTextBox1.Text != "")
                SendMail();
            else
                MessageBox.Show("Lütfen Gerekli alanları doldurunuz. ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || richTextBox1.Text != "")
            {
                DialogResult a = new DialogResult();
                a = MessageBox.Show("Eğer Evet derseniz doldurulmuş alanlar silinecektir. Çıkmak istediğinize emin misiniz?",
                    "Uyarı", MessageBoxButtons.YesNo);
                if (a == DialogResult.Yes)
                    this.Close();
            }
            else
                this.Close();
        }

        private void feedback_Load(object sender, EventArgs e)
        {

        }
    }
}
