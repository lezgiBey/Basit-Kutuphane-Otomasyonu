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
    public partial class GeriGelenKitapForma : Form
    {
        DataBaseGridViewForm dtb = new DataBaseGridViewForm();

        public void btnClear()
        {
            txtBxGeriGetirenNo.Clear();
            txtBxKitapNumarasi.Clear();
            rTxtBxAciklama.Clear();
            labelUyari.Text = "Temizlendi!";
        }
        public GeriGelenKitapForma()
        {
            InitializeComponent();
            panelMain.Anchor = AnchorStyles.None;
            rTxtBxAciklama.Text = "Kitap sorunsuz geldi ve teslim alındı.";
        }

        private void btnKitabiIadeAl_Click(object sender, EventArgs e)
        {
            string kitapGeriAlimTarihi = dtpKitabinGeriVerilisTarihi.Value.ToShortDateString();

            dtb.KitabiZiyaretciGeriGetirdi(txtBxGeriGetirenNo.Text, txtBxKitapNumarasi.Text, kitapGeriAlimTarihi, rTxtBxAciklama.Text, labelUyari);
            btnClear();
        }

        private void btnKitabiIadeAlma_Click(object sender, EventArgs e)
        {

        }

        private void btnSorunBildir_Click(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            btnClear();
        }
    }
}
