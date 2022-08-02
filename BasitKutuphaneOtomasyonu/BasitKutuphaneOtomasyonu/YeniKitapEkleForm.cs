using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasitKutuphaneOtomasyonu
{
    public partial class YeniKitapEkleForm : Form
    {
        DataBaseGridViewForm dtb = new DataBaseGridViewForm();

        public YeniKitapEkleForm()
        {
            InitializeComponent();
            panelMain.Anchor = AnchorStyles.None;            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtBxKitabinAdi.Clear();
            txtBxKitabinYazari.Clear();
            txtBxKitabinTuru.Clear();
            txtBxKitabinRafKodu.Clear();
            txtBxKitabinBarkodu.Clear();
            rTxtBxAciklama.Clear();
            labelUyari.Text = "Temizlendi!";
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            string kitapCikisTarih = dtpKitabinCikisTarihi.Value.ToShortDateString();
            string kitapBaskiTarihi = dtpKitabinBaskiYili.Value.ToShortDateString();
            string kitapGirisTarihi = dtpKitabinKutuphaneyeGirisTarihi.Value.ToShortDateString();

            dtb.DataBaseYeniKitapEkle(txtBxKitabinAdi.Text, txtBxKitabinYazari.Text, kitapCikisTarih, kitapBaskiTarihi, txtBxKitabinRafKodu.Text, kitapGirisTarihi, txtBxKitabinBarkodu.Text, rTxtBxAciklama.Text, txtBxKitabinTuru.Text, labelUyari);
        }
    }
}
