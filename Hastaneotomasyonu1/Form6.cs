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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hastayatis frm11 = new hastayatis();
            frm11.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            konsültasyon knt = new konsültasyon();
            knt.Show();
            this.Hide();        }
    }
}
