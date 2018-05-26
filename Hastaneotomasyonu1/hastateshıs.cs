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
    public partial class hastateshıs : Form
    {
        public hastateshıs()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"server=LAPTOP-V6GU9LEB\\SERVER;database=hastaneotomasyonu1;Integrated Security=true");
        String TC, basboyun, genitoürünersistem, kalpdamarsistemi, solunumsistemi, kasveiskeletsistemi, cilt, Komut;

        private void hastateshıs_Load(object sender, EventArgs e)
        {
            


        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

            Form2 frm11 = new Form2();
            frm11.Show();
            this.Hide();
        }

        private void checkBox24_Click(object sender, EventArgs e)
        {

           
        }

        private void checkBox14_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                String kayit = "select * from hastabilgileri2 WHERE TC=" + textBox1.Text.ToString();
                SqlCommand komut2 = new SqlCommand(kayit, baglanti);
                SqlDataReader reader = komut2.ExecuteReader();
                while (reader.Read())
                {


                    label1.Text = reader["Hasta_adi"].ToString();
                    label2.Text = reader["Hasta_soyadi"].ToString();
                    label3.Text = reader["yas"].ToString();
                    label4.Text = reader["cinsiyet"].ToString();
                    label10.Text = reader["kan_grubu"].ToString();
                    label11.Text = reader["hasta_türü"].ToString();
                    label12.Text = reader["sgk"].ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("HASTA BULUNAMADI", "UYARI");
            }

            baglanti.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            veriyaz();
            sqlveriyaz();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            DialogResult kapat = MessageBox.Show("Form kapatılacak eminmisin", Environment.UserName, MessageBoxButtons.YesNo);
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 frm11 = new Form2();
            frm11.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm11 = new Form2();
            frm11.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
           



     

        }
        void veriyaz()
        {
            TC = textBox1.Text;
            basboyun = checkedListBox1.Text;          
            genitoürünersistem = checkedListBox2.Text;          
            kalpdamarsistemi = checkedListBox3.Text;
            solunumsistemi = checkedListBox4.Text;
            kasveiskeletsistemi = checkedListBox5.Text;
            cilt = checkedListBox6.Text;
        }
        void sqlveriyaz()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-V6GU9LEB\\SERVER;Initial Catalog=hastaneotomasyonu1;Integrated Security=True";
                Komut = "insert into hastateshis(TC, basboyun, genitoürünersistem, kalpdamarsistemi, solunumsistemi, kasveiskeletsistemi, cilt) values ('" + TC + "','" + basboyun + "','" + genitoürünersistem + "','" + kalpdamarsistemi + "','" + solunumsistemi + "','" + kasveiskeletsistemi + "','" + cilt + "')";
                con.Open();
                SqlCommand komutsatiri = new SqlCommand(Komut, con);
                komutsatiri.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Bilgiler sisteme yüklenmiştir");
            }
            catch (Exception)
            {
                MessageBox.Show("TC Girişi yapılmadı veya eksik giriş yaptınız", "UYARI");
            }
        }




    }
}
