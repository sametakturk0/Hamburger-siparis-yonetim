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
    public partial class FormSiparisEkle : Form
    {
        public FormSiparisEkle()
        {
            InitializeComponent();
        }

        void HamburgerDoldur()
        {
            cbHamburgerler.Items.Clear();
            cbHamburgerler.SelectedIndex = -1;
            cbHamburgerler.Items.AddRange(Database.Hamburgerler.ToArray());
        }

        void EkstraMalzemeDoldur()
        {
            fpnlEkstraMalzemeler.Controls.Clear();
            foreach (var item in Database.EkstraMalzemeler)
            {
                CheckBox cb = new CheckBox();
                cb.Text = item.Adi;
                cb.Tag = item;
                
                fpnlEkstraMalzemeler.Controls.Add(cb);

            }
        }

        private void FormSiparisEkle_Load(object sender, EventArgs e)
        {
            HamburgerDoldur();
            EkstraMalzemeDoldur();
        }

        private void cbHamburgerler_SelectedValueChanged(object sender, EventArgs e)
        {
            EkstraMalzemeDoldur();

            Hamburger hamburger = (Hamburger)cbHamburgerler.SelectedItem;

            foreach (var ekstraMalzeme in hamburger.ekstraMalzemeler)
            {
                foreach (CheckBox cb in fpnlEkstraMalzemeler.Controls)
                {
                    if (cb.Text == ekstraMalzeme.Adi)
                    {
                        cb.Checked = true;
                    }
                }
            }
        }      

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            //Siparis nesnesi olusturduk
            Siparis siparis = new Siparis();

            //Secili hamburgeri bulduk
            siparis.Hamburger = (Hamburger)cbHamburgerler.SelectedItem;

            //Hamburger menusunun boyutunu bulduk
            if (rbKucuk.Checked == true)
            {
                siparis.menuBoy = MenuBoy.Kucuk;
            }
            else if (rbOrta.Checked == true)
            {
                siparis.menuBoy = MenuBoy.Orta;
            }
            else
            {
                siparis.menuBoy = MenuBoy.Buyuk;
            }

            //Ekstra malzemelerden secili olanları bulduk
            List<EkstraMalzemeler> seciliEkstraMalzemeler = new List<EkstraMalzemeler>();

            foreach (CheckBox cb in fpnlEkstraMalzemeler.Controls)
            {
                if (cb.Checked == true)
                {
                    seciliEkstraMalzemeler.Add((EkstraMalzemeler)cb.Tag);
                }
            }

            //Ekstra malzemelerden secili olanların içinden hamburgere ait ekstra malzemeleri cıkardık
            foreach (EkstraMalzemeler ekstraMalzemeler in siparis.Hamburger.ekstraMalzemeler)
            {
                seciliEkstraMalzemeler.Remove(ekstraMalzemeler);
            }

            //kalan secili malzemeleri siparisin ekstra malzemelerine ekledik
            siparis.EkstraMalzemeler.AddRange(seciliEkstraMalzemeler);

            //Siparis adedini siparise ekledik
            siparis.Adet = (int)nudAdet.Value;

            //siparisi siparis listbox ına ekledik
            lstSiparisler.Items.Add(siparis);

            //Formu temizledik
            FormuTemizle();

            //Toplam sipariş tutarını hesapladık
            ToplamTuarHesapla();
            
        }

        void FormuTemizle()
        {
            HamburgerDoldur();
            EkstraMalzemeDoldur();
            rbKucuk.Checked = true;
            //nudAdet.Value = 0;
        }

        void ToplamTuarHesapla()
        {
            decimal toplamTutar = 0;

            foreach (Siparis item in lstSiparisler.Items)
            {
                toplamTutar += item.FiyatHesapla(); 
            }
            
            lblToplamTutar.Text = toplamTutar.ToString("C2");
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            //Kullanıcıdan siparisi tamamlama onayini al

            DialogResult siparisTamamlamaDurumu = MessageBox.Show("Siparisi tamamlamak istediginize emin misiniz ?", "Siparisi Tamamla", MessageBoxButtons.YesNo);

            if (siparisTamamlamaDurumu == DialogResult.Yes)
            {
                //Siparisi database e ekleyecek

                foreach (Siparis item in lstSiparisler.Items)
                {
                    Database.Siparisler.Add(item);
                }

                //Siparis listesini temizledik
                lstSiparisler.Items.Clear();

                //Toplam tutarı 0 a esitledik
                lblToplamTutar.Text = "0";
            }
        }
    }
}
