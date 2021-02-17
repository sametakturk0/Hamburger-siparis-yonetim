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
    public partial class FormHamburgeEkle : Form
    {
        public FormHamburgeEkle()
        {
            InitializeComponent();
        }

        Hamburger editHamburger;

        private void txtHamburgerAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormHamburgeEkle_Load(object sender, EventArgs e)
        {
            ListeyiGuncelle();
            EkstraMalzemeEkle();
        }


        void ListeyiGuncelle()
        {
            lstHamburgerListesi.Items.Clear();
            lstHamburgerListesi.Items.AddRange(Database.Hamburgerler.ToArray());
        }

        void FormTemizle()
        {
            txtHamburgerAdi.Clear();
            txtHamburgerFiyat.Value = 0;

            foreach (var item in fpnlHamburgerMalzemeleri.Controls)
            {
                CheckBox cb = new CheckBox();
                cb.Checked = false;
            }
        }

        void EkstraMalzemeEkle()
        {
            foreach (var item in Database.EkstraMalzemeler)
            {
                CheckBox cb = new CheckBox();
                cb.Text = item.Adi;
                cb.Tag = item;

                fpnlHamburgerMalzemeleri.Controls.Add(cb);
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (editHamburger == null)
            {
                Hamburger hamburger = new Hamburger();

                hamburger.ekstraMalzemeler = new List<EkstraMalzemeler>();

                hamburger.Ad = txtHamburgerAdi.Text;
                hamburger.Fiyat = txtHamburgerFiyat.Value;

                foreach (CheckBox cb in fpnlHamburgerMalzemeleri.Controls)
                {
                    if (cb.Checked == true)
                    {
                        EkstraMalzemeler ekstraMalzemeler = (EkstraMalzemeler)cb.Tag;
                        hamburger.ekstraMalzemeler.Add(ekstraMalzemeler);
                    }
                }

                Database.Hamburgerler.Add(hamburger);

            }
            else
            {
                editHamburger.Ad = txtHamburgerAdi.Text;
                editHamburger.Fiyat = txtHamburgerFiyat.Value;

                editHamburger.ekstraMalzemeler.Clear();

                foreach (CheckBox item in fpnlHamburgerMalzemeleri.Controls)
                {
                    if (item.Checked == true)
                    {
                        EkstraMalzemeler ekstraMalzemeler = (EkstraMalzemeler)item.Tag;
                        editHamburger.ekstraMalzemeler.Add(ekstraMalzemeler);
                    }
                }

                editHamburger = null;
                btnEkle.Text = "Ekle";
            }

            FormTemizle();
            ListeyiGuncelle();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstHamburgerListesi.SelectedIndex >= 0)
            {
                Hamburger hamburger = (Hamburger)lstHamburgerListesi.SelectedItem;
                Database.Hamburgerler.Remove(hamburger);
                ListeyiGuncelle();

            }
        }

        private void lstHamburgerListesi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstHamburgerListesi.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Hamburger hamburger = (Hamburger)lstHamburgerListesi.Items[index];

                txtHamburgerAdi.Text = hamburger.Ad;
                txtHamburgerFiyat.Value = hamburger.Fiyat;

                foreach (CheckBox cb in fpnlHamburgerMalzemeleri.Controls)
                {
                    EkstraMalzemeler itemEkstraMalzeme = cb.Tag as EkstraMalzemeler;

                    if (hamburger.ekstraMalzemeler.IndexOf(itemEkstraMalzeme)>0)
                    {
                        cb.Checked = true;
                    }
                }

                btnEkle.Text = "Guncelle";
                editHamburger = hamburger;
            }
        }
    }
}
