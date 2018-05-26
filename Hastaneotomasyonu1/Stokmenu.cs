using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastaneotomasyonu1
{
    public partial class Stokmenu : Form
    {
        public Stokmenu()
        {
            InitializeComponent();
        }

        private void Stokmenu_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void stokGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void stokEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stok_ekleme stke = new Stok_ekleme();
            stke.Show();                                            
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canlısatis cnls = new Canlısatis();
            cnls.Show();
        }

        private void stokGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stokguncelleme stkg = new Stokguncelleme();
            stkg.Show();
        }

        private void stokTemizlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stoksilme stks = new Stoksilme();
            stks.Show();
        }

        private void günlükToolStripMenuItem_Click(object sender, EventArgs e)
        {
            günlükrapor gnlr = new günlükrapor();
            gnlr.Show();
        }

        private void aylıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aylıkraporcs aylk = new aylıkraporcs();
            aylk.Show();
        }

        private void yıllıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yıllıkrapor ylkr = new yıllıkrapor();
            ylkr.Show();
        }

        private void günlükStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Günlük_mail gnlkml = new Günlük_mail();
            gnlkml.Show();
        }

        private void günlükSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Günlük_satıs_mail gnlkstm = new Günlük_satıs_mail();
            gnlkstm.Show();
        }

        private void aylıkSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aylık_satıs_mail aylksts = new Aylık_satıs_mail();
            aylksts.Show();
        }

        private void senelikSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Senelik_satıs_mail snlkst = new Senelik_satıs_mail();
            snlkst.Show();
        }

        private void mailAktarımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mail_bilgiler mlbg = new Mail_bilgiler();
            mlbg.Show();
        }

        private void senelikStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Senelik_mail snlk = new Senelik_mail();
            snlk.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stok_ekleme stke = new Stok_ekleme();
            stke.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm11 = new Form2();
            frm11.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stokguncelleme stkg = new Stokguncelleme();
            stkg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stoksilme stks = new Stoksilme();
            stks.Show();
        }
    }
}
