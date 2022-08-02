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
    public partial class ZiyaretciDuzenleForm : Form
    {
        DataBaseGridViewForm dtb = new DataBaseGridViewForm();

        public ZiyaretciDuzenleForm()
        {
            InitializeComponent();
            panelMain.Anchor = AnchorStyles.None;
        }

        private void btnYeniZiyaretciEkle_Click(object sender, EventArgs e)
        {
            string kayitTarihi = dtpZiyaretciKayitTarihi.Value.ToShortDateString();
            string yetkiSecimi = cmbBxZiyaretciYetkisi.SelectedItem.ToString();
            dtb.ZiyaretciGuncelle(txtBxZiyaretciId.Text, txtBxAdiSoyadi.Text, txtBxZiyaretciTelefon.Text, rTxtBxAdres.Text, kayitTarihi, txtBxZiyaretciUyrugu.Text, txtBxZiyaretciMeslegi.Text, txtBxZiyaretciUnvani.Text, yetkiSecimi, labelUyari);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtBxZiyaretciId.Clear();
            txtBxAdiSoyadi.Clear();
            txtBxZiyaretciTelefon.Clear();
            rTxtBxAdres.Clear();
            txtBxZiyaretciUyrugu.Clear();
            txtBxZiyaretciMeslegi.Clear();
            txtBxZiyaretciUnvani.Clear();
            cmbBxZiyaretciYetkisi.SelectedIndex.Equals(0);

            labelUyari.Text = "Temizlendi!";
        }

        private void ziyaretciGetir(object sender, EventArgs e)
        {
            dtb.ziyaretciCagir(txtBxZiyaretciId.Text, txtBxAdiSoyadi, txtBxZiyaretciTelefon, rTxtBxAdres, dtpZiyaretciKayitTarihi, txtBxZiyaretciUyrugu, txtBxZiyaretciMeslegi, txtBxZiyaretciUnvani, cmbBxZiyaretciYetkisi);
        }
    }
}
