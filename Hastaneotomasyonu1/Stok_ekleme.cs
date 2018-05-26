using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hastaneotomasyonu1
{
    public partial class Stok_ekleme : Form
    {
        public Stok_ekleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-UBFID3CB;Initial Catalog=hastaneotomasyonu1;Integrated Security=True");
        

        string urun_kodu, urun_adı, urun_fıyatı, urun_cınsı, urun_adedı, krıtık_stok;
        string Komut;
        baglantı bg = new baglantı();
        string resimPath = string.Empty;
        private void button2_Click(object sender, EventArgs e)
        {
            urun_cınsı_ekleme uce = new urun_cınsı_ekleme();
            uce.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            String kayit = "select * from Stok WHERE urun_kodu=" + textBox7.Text.ToString();
            SqlCommand komut2 = new SqlCommand(kayit, baglanti);
            SqlDataReader reader = komut2.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = reader["urun_kodu"].ToString();
                textBox2.Text = reader["urun_adı"].ToString();
                textBox3.Text = reader["urun_fıyatı"].ToString();
                textBox4.Text = reader["urun_cınsı"].ToString();
                textBox5.Text = reader["urun_adedı"].ToString();
                textBox6.Text = reader["krıtık_stok"].ToString();
               
            }
            baglanti.Close();

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Kar Yazılım";
            openFileDialog1.FileName = "Resim sec";
            openFileDialog1.Filter = "Jpeg Dosyası(*.jpg)|*.jpg|Gif Dosyası(*.gif)|*.gif|Png Dosyası (*.png)|*.png";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                resimPath = openFileDialog1.FileName.ToString();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                
            }
        }

        private void Stok_ekleme_Load(object sender, EventArgs e)
        {  
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            verial2();
            sqlveriyaz2();


        }
        void verial2()
        {
            urun_kodu = textBox1.Text;
            urun_adı = textBox2.Text;
            urun_fıyatı = textBox3.Text;
            urun_cınsı = textBox4.Text;
            urun_adedı = textBox5.Text;
            krıtık_stok = textBox6.Text; 
        }

        void sqlveriyaz2()
        {
            
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-UBFID3CB;Initial Catalog=hastaneotomasyonu1;Integrated Security=True";
                Komut = "insert into Stok(urun_kodu, urun_adı, urun_fıyatı, urun_cınsı, urun_adedı, krıtık_stok) values ('" + urun_kodu + "','" + urun_adı + "','" + urun_fıyatı + "','" + urun_cınsı + "','" + urun_adedı + "','" + krıtık_stok + "')";
                con.Open();
                SqlCommand komutsatiri = new SqlCommand(Komut, con);
                komutsatiri.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Bilgiler sisteme yüklenmiştir");
           

        }
    }
}
