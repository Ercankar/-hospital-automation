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
    public partial class hastayatis : Form
    {
        public hastayatis()
        {
            InitializeComponent();
        }
     
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-V6GU9LEB\\SERVER;Initial Catalog=hastaneotomasyonu1;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm11 = new Form2();
            frm11.Show();
            
        }

        private void hastayatis_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            SqlConnection baglanti = new SqlConnection(@"server=LAPTOP-V6GU9LEB\\SERVER;database=hastaneotomasyonu1;Integrated Security=true");
            baglanti.Open();
            da = new SqlDataAdapter("Select * from hastayatıs2", baglanti);
            ds = new DataSet();
            da.Fill(ds, "TC");
            dataGridView2.DataSource = ds.Tables[0];
            baglanti.Close();


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

                    label2.Text = reader["Hasta_adi"].ToString();
                    label3.Text = reader["Hasta_soyadi"].ToString();
                    label4.Text = reader["yas"].ToString();
                    label5.Text = reader["cinsiyet"].ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("HASTA BULUNAMADI","UYARI");
            }

            
            baglanti.Close();
        }
        void güncelle1()
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(@"server=LAPTOP-UBFID3CB;database=hastaneotomasyonu1;Integrated Security=true");
                baglanti.Open();
                da = new SqlDataAdapter("Select * from hastayatıs2", baglanti);
                ds = new DataSet();
                da.Fill(ds, "TC");
                dataGridView2.DataSource = ds.Tables[0];
                baglanti.Close();
                MessageBox.Show("HASTA BULUNDU VE ÇIKIŞI YAPILDI", "TAMAMLANDI...");
            }
            catch (Exception)
            {
                MessageBox.Show("BÖYLE BİR YATAN HASTA BULUNAMADI", "DOĞRU TC GİRDİĞİNİZDEN EMİN OLUNUZ...");
            }
        }
        void güncelle()
        {
            SqlConnection baglanti = new SqlConnection(@"server=LAPTOP-UBFID3CB;database=hastaneotomasyonu1;Integrated Security=true");
            baglanti.Open();
            da = new SqlDataAdapter("Select * from hastayatıs2", baglanti);
            ds = new DataSet();
            da.Fill(ds, "TC");
            dataGridView2.DataSource = ds.Tables[0];
            baglanti.Close();
            MessageBox.Show("GÜNCELLENDİ", "TAMAMLANDI...");
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            güncelle();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 frm11 = new Form2();
            frm11.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form6 frm11 = new Form6();
            frm11.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            try
            {


                baglanti.Open();
                SqlCommand ekle = new SqlCommand("INSERT INTO hastayatıs2 (TC,hasta_adi,hasta_soyadi,hasta_yatıcagı_servis,hasta_yatıcagı_tarıh,hasta_cıkıs_tarıh) Values (@TC,@hasta_adi,@hasta_soyadi,@hasta_yatıcagı_servis,@hasta_yatıcagı_tarıh,@hasta_cıkıs_tarıh)", baglanti);

                ekle.Parameters.AddWithValue("@TC", textBox1.Text);
                ekle.Parameters.AddWithValue("@hasta_adi", label2.Text);
                ekle.Parameters.AddWithValue("@hasta_soyadi", label3.Text);
                ekle.Parameters.AddWithValue("@hasta_yatıcagı_servis", hstytcsr_cbx.Text);
                ekle.Parameters.AddWithValue("@hasta_yatıcagı_tarıh", ytsarh_txt.Text);
                ekle.Parameters.AddWithValue("@hasta_cıkıs_tarıh", hstckstrh_txt.Text);

                ekle.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("İŞLEM BAŞARILI", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("ZATEN BU HASTA SİSTEMDE KAYITLI", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        SqlDataAdapter da;
        DataSet ds;
        private void button1_Click_1(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection(@"server=LAPTOP-UBFID3CB;database=hastaneotomasyonu1;Integrated Security=true");
            baglanti.Open();
            da = new SqlDataAdapter("Select * from Bırım", baglanti);
            ds = new DataSet();
            da.Fill(ds, "personel");
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"server=LAPTOP-UBFID3CB;database=hastaneotomasyonu1;Integrated Security=true");
            baglanti.Open();
            da = new SqlDataAdapter("Select * from hastayatıs2", baglanti);
            ds = new DataSet();
            da.Fill(ds, "TC");
            dataGridView2.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"server=LAPTOP-UBFID3CB;database=hastaneotomasyonu1;Integrated Security=true");
            baglanti.Open();
            da = new SqlDataAdapter("Select * from Bırım", baglanti);
            ds = new DataSet();
            da.Fill(ds, "personel");
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"server=LAPTOP-UBFID3CB;database=hastaneotomasyonu1;Integrated Security=true");
            baglanti.Open();
            da = new SqlDataAdapter("Select * from hastayatıs2", baglanti);
            ds = new DataSet();
            da.Fill(ds, "TC");
            dataGridView2.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"server=LAPTOP-UBFID3CB;database=hastaneotomasyonu1;Integrated Security=true");
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("Select * From hastayatıs2 where TC LIKE '% + textBox2.Text + %'", con);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            con.Close();
        }
       
        SqlCommand cmd;
        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"server=LAPTOP-UBFID3CB;database=hastaneotomasyonu1;Integrated Security=true");
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "delete from hastayatıs2 where TC=" + textBox4.Text + "";
                cmd.ExecuteNonQuery();
                con.Close();
                güncelle1();
            }
            catch(Exception)
            {
                MessageBox.Show("GEÇERLİ TC GİRİNİZ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
