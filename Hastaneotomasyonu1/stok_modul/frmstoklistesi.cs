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
    public partial class frmstoklistesi : Form
    {

        public bool secim = false; 
        public frmstoklistesi()
        {
            InitializeComponent();
        }

        private void frmstoklistesi_Load(object sender, EventArgs e)
        {
            listeleme();
        }
        void listeleme()
        {

        
        }
    }
}
