using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastaneotomasyonu1.stok_modul
{
    public partial class frmstokgrup : Form
    {
        public bool secim = false;
        public frmstokgrup()
        {
            InitializeComponent();
        }

        private void frmstokgrup_Load(object sender, EventArgs e)
        {
            listele();
        }
        void listele()
        {

        }
    }
}
