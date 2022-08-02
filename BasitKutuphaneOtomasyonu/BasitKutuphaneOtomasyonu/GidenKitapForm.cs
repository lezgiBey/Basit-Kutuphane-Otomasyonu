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
    public partial class GidenKitapForm : Form
    {
        DataBaseGridViewForm dtb = new DataBaseGridViewForm();
        public GidenKitapForm()
        {
            InitializeComponent();
            panelMain.Anchor = AnchorStyles.None;
        }

        private void btnKitabiGonder_Click(object sender, EventArgs e)
        {
            string kitapTeslimTarihi = dtpKitabinGeriVerilisTarihi.Value.ToShortDateString();

            dtb.KitabiZiyaretciyeTeslimEt(txtBxAlanNo.Text, txtBxKitapNumarasi.Text, kitapTeslimTarihi, rTxtBxAciklama.Text, labelUyari);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtBxAlanNo.Clear();
            txtBxKitapNumarasi.Clear();
            rTxtBxAciklama.Clear();
            labelUyari.Text = "Temizlendi!";
        }
    }
}
