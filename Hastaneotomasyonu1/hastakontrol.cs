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
    public partial class hastakontrol : Form
    {
       
        
        public hastakontrol()
        {
            InitializeComponent();
        }
        public static string gonderilecekveri;
        SqlConnection baglanti = new SqlConnection(@"server=LAPTOP-V6GU9LEB\\SERVER;database=hastaneotomasyonu1;Integrated Security=true");
        private void btnGonder_Click(object sender, EventArgs e)
        {
            gonderilecekveri = maskedtxtTC.Text;

            if (baglanti.State == ConnectionState.Closed)
            baglanti.Open();
            SqlCommand sorgula = new SqlCommand("select * from hastabilgileri2 where TC = '" + maskedtxtTC.Text + "'", baglanti);
            SqlDataReader dr = sorgula.ExecuteReader();
            if (dr.Read())
            {
                hasabılgısıekranı frm = new hasabılgısıekranı();
                frm.Show();
            }
            else
            {
                MessageBox.Show("TC YANLIŞ GİRDİNİZ VEYA HASTA SİSTEMDE KAYITLI DEĞİL");

            }
            baglanti.Close();
        }

        private void hastakontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
