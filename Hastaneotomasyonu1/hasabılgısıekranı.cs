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
    public partial class hasabılgısıekranı : Form
    {
        
        public hasabılgısıekranı()
        {
            InitializeComponent();
           

        }
       


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm11 = new Form2();
            frm11.Show();
            this.Hide();
        }

        private void hasabılgısıekranı_Load(object sender, EventArgs e)
        {
            label1.Text = hastakontrol.gonderilecekveri;   
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection(@"server=LAPTOP-V6GU9LEB\\SERVER;database=hastaneotomasyonu1;Integrated Security=true");
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                String kayit = "select * from hastabilgileri2 WHERE TC=" + label1.Text.ToString();
              
                SqlCommand komut2 = new SqlCommand(kayit, baglanti);
                SqlDataReader reader = komut2.ExecuteReader();
                while (reader.Read())
                {

                    label3.Text = reader["Hasta_adi"].ToString();
                    label4.Text = reader["Hasta_soyadi"].ToString();
                    label5.Text = reader["yas"].ToString();
                    label6.Text = reader["cinsiyet"].ToString();
                    label7.Text = reader["dgmtrh"].ToString();
                    label8.Text = reader["kan_grubu"].ToString();
                    label15.Text = reader["Hasta_Ana_adi"].ToString();
                    label17.Text = reader["Hasta_Baba_adi"].ToString();
                   

                }
            }
            catch (Exception)
            {
                MessageBox.Show("HASTA BULUNAMADI", "UYARI");
            }


            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                String kayit = "select * from hastateshis WHERE TC=" + label1.Text.ToString();

                SqlCommand komut2 = new SqlCommand(kayit, baglanti);
                SqlDataReader reader = komut2.ExecuteReader();
                while (reader.Read())
                {

                    label19.Text = reader["basboyun"].ToString();
                    label20.Text = reader["genitoürünersistem"].ToString();
                    label21.Text = reader["kalpdamarsistemi "].ToString();
                    label22.Text = reader["solunumsistemi"].ToString();
                    label23.Text = reader["kasveiskeletsistemi"].ToString();
                    label24.Text = reader["cilt"].ToString();



                }
            }
            catch (Exception)
            {
                MessageBox.Show("Belirlenen ön teşhis konuldu ", "MUAYENE GİRİŞİ YAPILMAMIŞ");
            }


            baglanti.Close();

        }
    }
}
