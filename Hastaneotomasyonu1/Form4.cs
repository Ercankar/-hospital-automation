using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace Hastaneotomasyonu1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            {
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm11 = new Form2();
            frm11.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             try
	            {
	                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
	                MailMessage mesaj = new MailMessage();
	                mesaj.To.Add(textBox4.Text);
	                mesaj.From = new MailAddress(textBox1.Text);
	                mesaj.Subject = textBox3.Text;
	                mesaj.Body = textBox5.Text;
	                NetworkCredential guvenlik = new NetworkCredential(textBox1.Text,textBox2.Text);
	                client.Credentials = guvenlik;
	                client.EnableSsl = true;
	                client.Send(mesaj);
	                MessageBox.Show("Destek ekibimize bilgilendirme GÖNDERİLDİ en yakın zamanda iletişime geçilecektir.", "GÖNDERİLDİ");
	            }
	            catch
	            {
	                MessageBox.Show("Mail Gönderme Başarısız.", "Mail Gönderme");
	            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
