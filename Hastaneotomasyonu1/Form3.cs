using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastaneotomasyonu1
{
    public partial class Hasta_işlemleri : Form
    {
        public Hasta_işlemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-V6GU9LEB\\SERVER;Initial Catalog=hastaneotomasyonu1;Integrated Security=True");
        string ülke, adres, meslek, egitim, ev_tel, is_tel, cep_tel, veli_yakin_tel, dosya_no, kurum_kodu, kurum_adi;
        string TC, Yabancı_tc, Hasta_adi, Hasta_soyadi, Hasta_Baba_adi, Hasta_Ana_adi, dgmtrh, Dgmyr, yas, cinsiyet, kan_grubu, hasta_türü, sgk, yakinlik, medeni_hali, Komut;

        private void button5_Click(object sender, EventArgs e)
        {
            ülke_cbx1.SelectedItem = null;
            adres_txt1.Clear();
            meslek_txt1.Clear();
            egitim_cmx1.SelectedItem = null;
            ev_tel_tct.Clear();
            is_txt.Clear();
            cep_txt.Clear();
            veli_txt.Clear();
            dosyano_txt1.Clear();
            kurumkodu_txt1.Clear();
            kurumadi_txt1.Clear();


        }
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"server=LAPTOP-V6GU9LEB\\SERVER;database=hastaneotomasyonu1;Integrated Security=true");
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "delete from hastabilgileri2 where TC=" + textBox4.Text + "";
                cmd.ExecuteNonQuery();
                con.Close();
                güncelle1();
            }
            catch (Exception)
            {
                MessageBox.Show("GEÇERLİ TC GİRİNİZ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        
    }
        void güncelle1()
        {
            
                SqlConnection baglanti = new SqlConnection(@"server=LAPTOP-V6GU9LEB\\SERVER;database=hastaneotomasyonu1;Integrated Security=true");
                baglanti.Open();
                da = new SqlDataAdapter("Select * from hastabilgileri2", baglanti);
                ds = new DataSet();
                da.Fill(ds, "TC");
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            DialogResult kapat = MessageBox.Show("Form kapatılacak eminmisin", Environment.UserName, MessageBoxButtons.YesNo);
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form2 frm11 = new Form2();
            frm11.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 frm11 = new Form2();
            frm11.Show();
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            güncelle1();
         
        }

        private void button8_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            String kayit = "select * from hastabilgileri2 WHERE TC=" + textBox5.Text.ToString();
            SqlCommand komut2 = new SqlCommand(kayit, baglanti);
            SqlDataReader reader = komut2.ExecuteReader();
            while (reader.Read())
            {

                tc_numara2.Text = reader["Yabancı_tc"].ToString();
                adı_txt1.Text = reader["Hasta_adi"].ToString();
                soyadı_txt1.Text = reader["Hasta_soyadi"].ToString();
                baba_txt1.Text = reader["Hasta_Baba_adi"].ToString();
                ana_txt1.Text = reader["Hasta_Ana_adi"].ToString();
                dgmtrh_txt1.Text = reader["dgmtrh"].ToString();
                dogumyeri_txt1.Text = reader["dgmyr"].ToString();
                yas_cbx1.Text = reader["yas"].ToString();
                cinsiyet_cbx1.Text = reader["cinsiyet"].ToString();
                kangrubu_cbx1.Text = reader["kan_grubu"].ToString();
                hastatürü_cbx1.Text = reader["hasta_türü"].ToString();
                sgk_cbx1.Text = reader["sgk"].ToString();
                medenihali_cbx1.Text = reader["medeni_hali"].ToString();
                yakılıgı_cbx1.Text = reader["yakinlik"].ToString();
            }
            baglanti.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            verial1();
            sqlveriyaz1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            tc_numara3.Clear();
            ana_txt1.Clear();
            tc_numara2.Clear();
            adı_txt1.Clear();
            soyadı_txt1.Clear();
            dgmtrh_txt1.Clear();
            sgk_cbx1.SelectedItem = null;
            yakılıgı_cbx1.SelectedItem = null;
            medenihali_cbx1.SelectedItem = null;
            hastatürü_cbx1.SelectedItem = null;
            kangrubu_cbx1.SelectedItem = null;
            cinsiyet_cbx1.SelectedItem = null;
            yas_cbx1.SelectedItem = null;





            tc_numara3.Clear();
            baba_txt1.Clear();
            dogumyeri_txt1.Clear();

        }
        void sqlveriyaz1()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=LAPTOP-V6GU9LEB\\SERVER;Initial Catalog=hastaneotomasyonu1;Integrated Security=True";
                Komut = "insert into nüfus1(TC,ülke, adres,meslek,egitim,ev_tel,is_tel,cep_tel,veli_yakin_tel,dosya_no,kurum_kodu,kurum_adi) values ('" + TC + "','" + ülke + "','" + adres + "','" + meslek + "','" + egitim + "','" + ev_tel + "','" + is_tel + "','" + cep_tel + "','" + veli_yakin_tel + "','" + dosya_no + "','" + kurum_kodu + "','" + kurum_adi + "')";
                con.Open();
                SqlCommand komutsatiri = new SqlCommand(Komut, con);
                komutsatiri.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Bilgiler sisteme yüklenmiştir");


            }
            catch (Exception HATA)
            {

                MessageBox.Show("Bir hata oluştu", HATA.ToString());

            }
        }

        void sqlveriyaz()
        {


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-V6GU9LEB\\SERVER;Initial Catalog=hastaneotomasyonu1;Integrated Security=True";
            Komut = "insert into hastabilgileri2(TC, Yabancı_tc, Hasta_adi, Hasta_soyadi, Hasta_Baba_adi, Hasta_Ana_adi, dgmtrh, Dgmyr, yas, cinsiyet, kan_grubu, hasta_türü, sgk,yakinlik,medeni_hali) values ('" + TC + "','" + Yabancı_tc + "','" + Hasta_adi + "','" + Hasta_soyadi + "','" + Hasta_Baba_adi + "','" + Hasta_Ana_adi + "','" + dgmtrh + "','" + Dgmyr + "','" + yas + "','" + cinsiyet + "','" + kan_grubu + "','" + hasta_türü + "','" + sgk + "','" + yakinlik + "','" + medeni_hali + "')";
            con.Open();
            SqlCommand komutsatiri = new SqlCommand(Komut, con);
            komutsatiri.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Bilgiler sisteme yüklenmiştir");


        }







        void verial1()
        {
            TC = tc_numara9.Text;
            ülke = ülke_cbx1.Text;
            adres = adres_txt1.Text;
            meslek = meslek_txt1.Text;
            egitim = egitim_cmx1.Text;
            ev_tel = ev_tel_tct.Text;
            is_tel = is_txt.Text;
            cep_tel = cep_txt.Text;
            veli_yakin_tel = veli_txt.Text;
            dosya_no = dosyano_txt1.Text;
            kurum_kodu = kurumkodu_txt1.Text;
            kurum_adi = kurumadi_txt1.Text;


        }

        void verial()

        {
            TC = tc_numara3.Text;
            Yabancı_tc = tc_numara2.Text;
            Hasta_adi = adı_txt1.Text;
            Hasta_soyadi = soyadı_txt1.Text;
            Hasta_Baba_adi = baba_txt1.Text;
            Hasta_Ana_adi = ana_txt1.Text;
            dgmtrh = dgmtrh_txt1.Text;
            Dgmyr = dogumyeri_txt1.Text;
            yas = yas_cbx1.Text;
            cinsiyet = cinsiyet_cbx1.Text;
            kan_grubu = kangrubu_cbx1.Text;
            hasta_türü = hastatürü_cbx1.Text;
            yakinlik = yakılıgı_cbx1.Text;
            medeni_hali = medenihali_cbx1.Text;
            sgk = sgk_cbx1.Text;



        }

        private void button6_Click(object sender, EventArgs e)
        {
            long TcNo, sonuc;

            if (tc_numara3.Text.Length == 11)
            {
                long ATCNO, BTCNO;
                long C1, C2, C3, C4, C5, C6, C7, C8, C9, Q1, Q2;

                TcNo = Int64.Parse(tc_numara3.Text);

                ATCNO = TcNo / 100;
                BTCNO = TcNo / 100;

                C1 = ATCNO % 10; ATCNO = ATCNO / 10;
                C2 = ATCNO % 10; ATCNO = ATCNO / 10;
                C3 = ATCNO % 10; ATCNO = ATCNO / 10;
                C4 = ATCNO % 10; ATCNO = ATCNO / 10;
                C5 = ATCNO % 10; ATCNO = ATCNO / 10;
                C6 = ATCNO % 10; ATCNO = ATCNO / 10;
                C7 = ATCNO % 10; ATCNO = ATCNO / 10;
                C8 = ATCNO % 10; ATCNO = ATCNO / 10;
                C9 = ATCNO % 10; ATCNO = ATCNO / 10;
                Q1 = ((10 - ((((C1 + C3 + C5 + C7 + C9) * 3) + (C2 + C4 + C6 + C8)) % 10)) % 10);
                Q2 = ((10 - (((((C2 + C4 + C6 + C8) + Q1) * 3) + (C1 + C3 + C5 + C7 + C9)) % 10)) % 10);

                sonuc = BTCNO * 100 + (Q1 * 10) + Q2;

                if (sonuc == TcNo)
                {

                    pictureBox1.Visible = true;

                }


                else
                    pictureBox2.Visible = true;


            }





        }

        private void tc_numara1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tc_numara1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tc_numara3_KeyPress(object sender, KeyPressEventArgs e)
        {

            //textBoxa metin girişini engelledik.
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }


            if (tc_numara3.TextLength == 11)
            {
                e.Handled = true;
            }

        }

        private void tc_numara3_TextChanged(object sender, EventArgs e)
        {
            if (tc_numara3.Text.Length == 11)
            {
                MessageBox.Show("TC KONTROL ETMEYİ UNUTMAYINIZ");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            {
                timer1.Enabled = true;
            }


           

        }

    
           
        

        private void timer1_Tick(object sender, EventArgs e)

        {
            label28.Text = DateTime.Now.Day.ToString() + ":" + DateTime.Now.Month + ":" + DateTime.Now.Year + " " + DateTime.Now.DayOfWeek;
            label29.Text = DateTime.Now.Hour + " : " + DateTime.Now.Minute + " : " + DateTime.Now.Second;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm11 = new Form2();
            frm11.Show();
            this.Hide();
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            verial();
            sqlveriyaz();
        }
    }
}

