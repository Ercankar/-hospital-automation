using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Hastaneotomasyonu1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-V6GU9LEB\\SERVER;Initial Catalog=hastaneotomasyonu1;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kullanicilar where adi ='" + kullanıcı_giris.Text + "' and sifre = '" + kullanıcı_sifre.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {

                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adi veya sifre hatali");
            }
            baglanti.Close();

        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                timer1.Enabled = true;
            }
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hakkımda aRandevu = new Hakkımda();
            aRandevu.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.Day.ToString() + ":" + DateTime.Now.Month + ":" + DateTime.Now.Year + " " + DateTime.Now.DayOfWeek;
            label4.Text = DateTime.Now.Hour + " : " + DateTime.Now.Minute + " : " + DateTime.Now.Second;

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
