using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartProHamburgercisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hamburgerEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            FormHamburgeEkle sform = new FormHamburgeEkle();
            sform.MdiParent = this;
            sform.Show();
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            FormEkstraMalzemeEkle sform = new FormEkstraMalzemeEkle();
            sform.MdiParent = this;
            sform.Show();
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            FormSiparisEkle sform = new FormSiparisEkle();
            sform.MdiParent = this;
            sform.Show();

        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            FormSiparisler sform = new FormSiparisler();
            sform.MdiParent = this;
            sform.Show();

        }

       void FormlariKapat()
        {
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
        }

       
    }
}
