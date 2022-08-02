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
    public partial class YeniZiyaretciEkleForm : Form
    {
        DataBaseGridViewForm dtb = new DataBaseGridViewForm();

        public YeniZiyaretciEkleForm()
        {
            InitializeComponent();
            panelMain.Anchor = AnchorStyles.None;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtBxAdiSoyadi.Clear();
            txtBxZiyaretciTelefon.Clear();
            rTxtBxAdres.Clear();
            txtBxZiyaretciUyrugu.Clear();
            txtBxZiyaretciMeslegi.Clear();
            txtBxZiyaretciUnvani.Clear();
            cmbBxZiyaretciYetkisi = null;
            labelUyari.Text = "Temizlendi!";
        }

        private void btnYeniZiyaretciEkle_Click(object sender, EventArgs e)
        {

            string kayitTarihi = dtpZiyaretciKayitTarihi.Value.ToShortDateString();
            var yetkiSecimi = cmbBxZiyaretciYetkisi.SelectedItem as string;

            dtb.YeniZiyaretciEkle(txtBxAdiSoyadi.Text, txtBxZiyaretciTelefon.Text, rTxtBxAdres.Text, kayitTarihi, txtBxZiyaretciUyrugu.Text, txtBxZiyaretciMeslegi.Text, txtBxZiyaretciUnvani.Text, yetkiSecimi, labelUyari);
        }
    }
}
