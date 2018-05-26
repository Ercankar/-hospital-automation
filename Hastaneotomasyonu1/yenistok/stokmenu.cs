using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastaneotomasyonu1.yenistok
{
    public partial class stokmenu : Form
    {
        public stokmenu()
        {
            InitializeComponent();
        }

        private void stokMenüsüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stokToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stokmenu_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}
