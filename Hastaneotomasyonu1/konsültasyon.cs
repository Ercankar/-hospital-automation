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
    public partial class konsültasyon : Form
    {
        public konsültasyon()
        {
            InitializeComponent();
        }
        string id, kon_tarih, kon_ist_birim, kon_isty_doktor, kon_istn_doktor, istek, Komut;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-V6GU9LEB\\SERVER;Initial Catalog=hastaneotomasyonu1;Integrated Security=True");
            baglanti.Open();
            string sorgu = "SELECT * FROM konsultasyon2";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader verioku = komut.ExecuteReader();
            listView1.Items.Clear();

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.CheckBoxes = true;


            listView1.Columns.Add("no", 0, HorizontalAlignment.Left);
            listView1.Columns.Add("kon_tarih",0, HorizontalAlignment.Left);
            listView1.Columns.Add("kon_ist_birim", 0, HorizontalAlignment.Left);
            listView1.Columns.Add("kon_isty_doktor", 0, HorizontalAlignment.Left);
            listView1.Columns.Add("kon_istn_doktor", 0, HorizontalAlignment.Left);
            listView1.Columns.Add("istek",0, HorizontalAlignment.Left);

            while (verioku.Read())
            {
                ListViewItem item = new ListViewItem();

                item.SubItems.Add(verioku["kon_tarih"].ToString());
                item.SubItems.Add(verioku["kon_ist_birim"].ToString());
                item.SubItems.Add(verioku["kon_isty_doktor"].ToString());
                item.SubItems.Add(verioku["kon_istn_doktor"].ToString());
                item.SubItems.Add(verioku["istek"].ToString());




                listView1.Items.Add(item);
            }

            baglanti.Close();
            MessageBox.Show("GÜNCELLENDİ",
                "İşlem tamam."
                 );
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            verial3();
            sqlveriyaz3();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-V6GU9LEB\\SERVER;Initial Catalog=hastaneotomasyonu1;Integrated Security=True");
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String kayit = "select * from konsultasyon2 WHERE id=" + kon_no.Text.ToString();
            SqlCommand komut2 = new SqlCommand(kayit, baglanti);
            SqlDataReader reader = komut2.ExecuteReader();
            while (reader.Read())
            {

                kon_ist_tarih1.Text = reader["kon_tarih"].ToString();
                kon_ist_birim1.Text = reader["kon_ist_birim"].ToString();
                kon_istyn_doktor1.Text = reader["kon_isty_doktor"].ToString();
                kon_istnn_doktor1.Text = reader["kon_istn_doktor"].ToString();
                istekk1.Text = reader["istek"].ToString();
               
            }
            baglanti.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form6 frm11 = new Form6();
            
            frm11.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form2 frm11 = new Form2();
            frm11.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            DialogResult kapat = MessageBox.Show("Form kapatılacak eminmisin", Environment.UserName, MessageBoxButtons.YesNo);
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void konsültasyon_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-V6GU9LEB\\SERVER;Initial Catalog=hastaneotomasyonu1;Integrated Security=True");
            baglanti.Open();
            string sorgu = "SELECT * FROM konsultasyon2";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader verioku = komut.ExecuteReader();
            listView1.Items.Clear();

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.CheckBoxes = true;


            listView1.Columns.Add("no",30, HorizontalAlignment.Left);
            listView1.Columns.Add("kon_tarih", 110, HorizontalAlignment.Left);
            listView1.Columns.Add("kon_ist_birim", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("kon_isty_doktor", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("kon_istn_doktor", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("istek", 100, HorizontalAlignment.Left);
          
            while (verioku.Read())
            {
                ListViewItem item = new ListViewItem();
               
                item.SubItems.Add(verioku["kon_tarih"].ToString());
                item.SubItems.Add(verioku["kon_ist_birim"].ToString());
                item.SubItems.Add(verioku["kon_isty_doktor"].ToString());
                item.SubItems.Add(verioku["kon_istn_doktor"].ToString());
                item.SubItems.Add(verioku["istek"].ToString());
               



                listView1.Items.Add(item);
            }

            baglanti.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        void sqlveriyaz3()
        {
           
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-UBFID3CB;Initial Catalog=hastaneotomasyonu1;Integrated Security=True";
                Komut = "insert into konsultasyon2(kon_tarih, kon_ist_birim, kon_isty_doktor, kon_istn_doktor, istek) values ('" + kon_tarih + "','" + kon_ist_birim + "','" + kon_isty_doktor + "','" + kon_istyn_doktor1 + "','" + istek + "')";
                con.Open();
                SqlCommand komutsatiri = new SqlCommand(Komut, con);
                komutsatiri.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Bilgiler sisteme yüklenmiştir");
            
           

        }
        void verial3()
        {
            
            kon_tarih = kon_ist_tarih1.Text;
            kon_ist_birim = kon_ist_birim1.Text;
            kon_isty_doktor = kon_istyn_doktor1.Text;
            kon_istn_doktor = kon_istnn_doktor1.Text;
            istek = istekk1.Text;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
