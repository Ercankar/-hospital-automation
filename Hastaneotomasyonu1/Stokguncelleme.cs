using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Hastaneotomasyonu1
{
    public partial class Stokguncelleme : Form
    {
        public Stokguncelleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlDataAdapter da;
        DataSet ds;
        private void Stokguncelleme_Load(object sender, EventArgs e)
        {

            baglanti = new SqlConnection("Data Source=LAPTOP-UBFID3CB;Initial Catalog=hastaneotomasyonu1;Integrated Security=True");
            baglanti.Open();
            DataTable dt = baglanti.GetSchema("Tables");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["TABLE_NAME"]);
            }
            baglanti.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tablo = comboBox1.Text;
            string sorgu = "SELECT *FROM " + tablo;
            da = new SqlDataAdapter(sorgu, baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, tablo);
            dataGridurun.DataSource = ds.Tables[tablo];
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

       
    }
}
