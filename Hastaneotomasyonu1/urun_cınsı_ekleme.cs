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
    public partial class urun_cınsı_ekleme : Form
    {

        public urun_cınsı_ekleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlDataAdapter da;
        DataSet ds;
        private void urun_cınsı_ekleme_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"server=LAPTOP-UBFID3CB;database=hastaneotomasyonu1;Integrated Security=true");
            baglanti.Open();
            da = new SqlDataAdapter("Select * from uruncınsıtalosu", baglanti);
            ds = new DataSet();
            da.Fill(ds, "TC");
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();

            baglanti = new SqlConnection("Data Source=LAPTOP-UBFID3CB;Initial Catalog=hastaneotomasyonu1;Integrated Security=True");
            baglanti.Open();
            DataTable dt = baglanti.GetSchema("Tables");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["TABLE_NAME"]);
            }
            baglanti.Close();

        }
        
     

        private void button3_Click(object sender, EventArgs e)
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
            dataGridView1.DataSource = ds.Tables[tablo];
            baglanti.Close();
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            tablo.Columns.Add("id", typeof(int));
            tablo.Columns.Add("urun_cınsı", typeof(string));

            tablo.Rows.Add(textBox1.Text, textBox2.Text);
            dataGridView1.DataSource = tablo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        

      
        private void button5_Click_1(object sender, EventArgs e)
        {
          
        }
    }

    }