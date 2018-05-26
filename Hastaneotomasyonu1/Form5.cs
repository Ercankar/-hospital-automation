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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-V6GU9LEB\\SERVER;Initial Catalog=hastaneotomasyonu1;Integrated Security=True");
        string personel_adi, sicil_numarasi, görev_türü, personel_görev_kodu, nöbet_baslangic_tarihi, nöbet_bitis_tarihi, personel_telefon, Komut;
        void sqlveriyaz2()
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-V6GU9LEB\\SERVER;Initial Catalog=hastaneotomasyonu1;Integrated Security=True";
            Komut = "insert into nöbet_cizelgesi_tablosu(personel_adi,sicil_numarasi,görev_türü,personel_görev_kodu,nöbet_baslangic_tarihi,nöbet_bitis_tarihi,personel_telefon) values ('" + personel_adi + "','" + sicil_numarasi + "','" + görev_türü + "','" + personel_görev_kodu + "','" + nöbet_baslangic_tarihi + "','" + nöbet_bitis_tarihi + "','" + personel_telefon + "')";
            con.Open();
            SqlCommand komutsatiri = new SqlCommand(Komut, con);
            komutsatiri.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Bilgiler sisteme yüklenmiştir");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                String kayit = "select * from nöbet_cizelgesi_tablosu WHERE nöbet_baslangic_tarihi=" + textBox4.Text.ToString();
                SqlCommand komut2 = new SqlCommand(kayit, baglanti);
                SqlDataReader reader = komut2.ExecuteReader();
                while (reader.Read())
                {
                    textBox6.Text = reader["personel_telefon"].ToString();


                }
            }



            catch (Exception HATA)
            {

                MessageBox.Show("Bir hata oluştu", HATA.ToString());

            }
            baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String kayit = "select * from nöbet_cizelgesi_tablosu WHERE sicil_numarasi=" + textBox5.Text.ToString();
            SqlCommand komut2 = new SqlCommand(kayit, baglanti);
            SqlDataReader reader = komut2.ExecuteReader();
            while (reader.Read())
            {
                labell1.Text = reader["nöbet_baslangic_tarihi"].ToString();
                label15.Text = reader["nöbet_bitis_tarihi"].ToString();


            }
            baglanti.Close();
        }

        void verial2()
        {
            
            personel_adi = textBox1.Text;
            sicil_numarasi =sicilno_txt2.Text;
            görev_türü = görevturu_cbx2.Text;
            personel_görev_kodu = personel_görev_kodu_txt2.Text;
            nöbet_baslangic_tarihi = textBox2.Text;
            nöbet_bitis_tarihi = textBox3.Text;
            personel_telefon = prsonel_tel.Text;
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1_yukle();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kapat = MessageBox.Show("Form kapatılacak eminmisin", Environment.UserName, MessageBoxButtons.YesNo);

            if (kapat == DialogResult.No) {
                e.Cancel = true;
                }
        }

        private void button3_Leave(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-V6GU9LEB\\SERVER;Initial Catalog=hastaneotomasyonu1;Integrated Security=True");
            baglanti.Open();
            string sorgu = "SELECT * FROM nöbet_cizelgesi_tablosu";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader verioku = komut.ExecuteReader();
            listView1.Items.Clear();

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.CheckBoxes = true;


            listView1.Columns.Add("no", 0, HorizontalAlignment.Left);
            listView1.Columns.Add("id", 0, HorizontalAlignment.Left);
            listView1.Columns.Add("personel_adi", 0, HorizontalAlignment.Left);
            listView1.Columns.Add("sicil_numarasi", 0, HorizontalAlignment.Left);
            listView1.Columns.Add("görev_türü", 0, HorizontalAlignment.Left);
            listView1.Columns.Add("personel_görev_kodu", 0, HorizontalAlignment.Left);
            listView1.Columns.Add("nöbet_baslangic_tarihi", 0, HorizontalAlignment.Left);
            listView1.Columns.Add("nöbet_bitis_tarihi", 0, HorizontalAlignment.Left);
            listView1.Columns.Add("personel_telefon", 0, HorizontalAlignment.Left);
            while (verioku.Read())
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(verioku["id"].ToString());
                item.SubItems.Add(verioku["personel_adi"].ToString());
                item.SubItems.Add(verioku["sicil_numarasi"].ToString());
                item.SubItems.Add(verioku["görev_türü"].ToString());
                item.SubItems.Add(verioku["personel_görev_kodu"].ToString());
                item.SubItems.Add(verioku["nöbet_baslangic_tarihi"].ToString());
                item.SubItems.Add(verioku["nöbet_bitis_tarihi"].ToString());
                item.SubItems.Add(verioku["personel_telefon"].ToString());




                listView1.Items.Add(item);
            }

            baglanti.Close();
            MessageBox.Show("GÜNCELLENDİ",
                  "İşlem tamam."
                   );
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 frm11 = new Form2();
            frm11.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verial2();
            sqlveriyaz2();
        }

      

        private void Form5_Load(object sender, EventArgs e)
        {
            
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-V6GU9LEB\\SERVER;Initial Catalog=hastaneotomasyonu1;Integrated Security=True");
            baglanti.Open();
            string sorgu = "SELECT * FROM nöbet_cizelgesi_tablosu";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader verioku = komut.ExecuteReader();
            listView1.Items.Clear();

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.CheckBoxes = true;


            listView1.Columns.Add("no", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("id", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("personel_adi", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("sicil_numarasi", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("görev_türü", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("personel_görev_kodu", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("nöbet_baslangic_tarihi", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("nöbet_bitis_tarihi", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("personel_telefon", 100, HorizontalAlignment.Left);
            while (verioku.Read())
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(verioku["id"].ToString());
                item.SubItems.Add(verioku["personel_adi"].ToString());
                item.SubItems.Add(verioku["sicil_numarasi"].ToString());
                item.SubItems.Add(verioku["görev_türü"].ToString());
                item.SubItems.Add(verioku["personel_görev_kodu"].ToString());
                item.SubItems.Add(verioku["nöbet_baslangic_tarihi"].ToString());
                item.SubItems.Add(verioku["nöbet_bitis_tarihi"].ToString());
                item.SubItems.Add(verioku["personel_telefon"].ToString());




                listView1.Items.Add(item);
            }

            baglanti.Close();
            MessageBox.Show("Veriler SQL Server'dan yükleniyor TAMAM ' a basarak devam ediniz ",
                  "İşlem tamam."
                   );
        }
        public void listView1_yukle()
        {
           

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 frm11 = new Form2();
            frm11.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult kapat = MessageBox.Show("Form kapatılacak eminmisin", Environment.UserName, MessageBoxButtons.YesNo);

            if (kapat == DialogResult.No)
            {
               
            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
