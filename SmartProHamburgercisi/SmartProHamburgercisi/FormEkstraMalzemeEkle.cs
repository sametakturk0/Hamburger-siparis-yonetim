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
    public partial class FormEkstraMalzemeEkle : Form
    {
        public FormEkstraMalzemeEkle()
        {
            InitializeComponent();
        }
        
        EkstraMalzemeler editEkstraMalzemeler;
        void listeyiGüncelle()
        {
            lstEkstraMalzemeler.Items.Clear();
            lstEkstraMalzemeler.Items.AddRange(Database.EkstraMalzemeler.ToArray());
        }

        void ekxtraMalzemeDoldur ()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in Database.EkstraMalzemeler)
            {
                  CheckBox cb =new CheckBox ();
                cb.Text = item.Adi;
                cb.Tag = item;
                flowLayoutPanel1.Controls.Add(cb);
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (editEkstraMalzemeler == null)
            {
                EkstraMalzemeler eks = new EkstraMalzemeler();

                eks.Adi = txtEkstraMalzemeAdi.Text;
                eks.Fiyat = txtEkstraMalzemeFiyat.Value;

                Database.EkstraMalzemeler.Add(eks);
                listeyiGüncelle();
                txtEkstraMalzemeAdi.Clear();
                txtEkstraMalzemeFiyat.Value = 0;



            }
    }

        private void FormEkstraMalzemeEkle_Load(object sender, EventArgs e)
        {
            ekxtraMalzemeDoldur();
            listeyiGüncelle();
        }
    }
}
