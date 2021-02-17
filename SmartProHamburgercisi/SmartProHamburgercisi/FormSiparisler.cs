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
    public partial class FormSiparisler : Form
    {
        public FormSiparisler()
        {
            InitializeComponent();
        }      
        private void FormSiparisler_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
            CiroHesapla();
            ToplamSiparisSayisiniHesapla();
            EkstraMalzemeGeliriniHesapla();
            SatilanUrunAdediniHesapla();
        }

        void ListeyiDoldur()
        {
            lstTumSiparisler.Items.Clear();
            lstTumSiparisler.Items.AddRange(Database.Siparisler.ToArray());
        }

        void CiroHesapla()
        {
            decimal toplamCiro = 0;

            foreach (var item in Database.Siparisler)
            {
                toplamCiro += item.FiyatHesapla();
            }

            lblCiro.Text = toplamCiro.ToString("C2");
        }

        void ToplamSiparisSayisiniHesapla()
        {
            lblToplamSiparis.Text = Database.Siparisler.Count.ToString();
        }

        void EkstraMalzemeGeliriniHesapla()
        {
            decimal toplamEkstraMalzemeGeliri = 0;

            foreach (var item in Database.Siparisler)
            {
                toplamEkstraMalzemeGeliri += item.EkstraMalzeFiyatHesapla();
            }

            lblEkstraMalzemeTutar.Text = toplamEkstraMalzemeGeliri.ToString("C2");
        }

        void SatilanUrunAdediniHesapla()
        {
            int toplamAdet = 0;

            foreach (var item in Database.Siparisler)
            {
                toplamAdet += item.Adet;
            }

            lblSatilanUrunAdedi.Text = toplamAdet.ToString();
        }

    }
}
