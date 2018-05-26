using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastaneotomasyonu1
{
    public partial class Form2 : Form
    {

        public Form2(string ad, string soyad)
        {
            InitializeComponent();
            nAd = ad;
            nSoyad = soyad;
        }

        public string nAd = "";
        public string nSoyad = "";
        public Form1 form1 = new Form1();

       
        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = "Hoşgeldiniz, sayın " + nAd + " İYİ GÜNLER DİLERİZ ";
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            
        }

        public Form2()
        {
           
            InitializeComponent();
        }
       
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }
        
       

       

        private void button1_Click(object sender, EventArgs e)
        {
         
            System.Diagnostics.Process.Start(@"C:\Users\User\Desktop\HastaneKayit\bin\Debug\HastaneKayit.exe");
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\User\Desktop\HastaneKayit\bin\Debug\HastaneKayit.exe");
        }
       
        private void button6_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 frm11 = new Form5();
            frm11.Show();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\User\Desktop\201413172067\Hastaneotomasyonurandevu\bin\Debug\HastaneKayit.exe");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\User\Desktop\201413172067\Hastaneotomasyonurandevu\bin\Debug\HastaneKayit.exe");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Hasta_işlemleri frm2 = new Hasta_işlemleri();
            frm2.Show();
            this.Hide();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
    
           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form6 frm11 = new Form6();
            frm11.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Stokmenu stm = new Stokmenu();
            stm.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
         
        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {

            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            hastateshıs hst = new hastateshıs();
            hst.Show();
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            hastakontrol hstk = new hastakontrol();
            hstk.Show();
            this.Show();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

            hastateshıs hst = new hastateshıs();
            hst.Show();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Form4 frm1 = new Form4();
            frm1.Show();
        }
    }
}
