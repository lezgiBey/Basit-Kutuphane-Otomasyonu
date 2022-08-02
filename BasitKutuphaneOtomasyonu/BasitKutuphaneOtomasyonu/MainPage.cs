using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BasitKutuphaneOtomasyonu
{
    public partial class MainPage : Form
    {
        DataBaseGridViewForm dataBaseGridViewForm = new DataBaseGridViewForm();
        GeriGelenKitapForma geriGelenKitapForm = new GeriGelenKitapForma();
        YeniZiyaretciEkleForm yeniZiyaretciEkleForm = new YeniZiyaretciEkleForm();
        YeniKitapEkleForm yeniKitapEkleForm = new YeniKitapEkleForm();
        GidenKitapForm gidenKitapForm = new GidenKitapForm();
        KitapDuzenleForm kitapDuzenleForm = new KitapDuzenleForm();
        ZiyaretciDuzenleForm ziyaretciDuzenleForm = new ZiyaretciDuzenleForm();

        MainPage mainPage;
        public MainPage()
        {
            InitializeComponent();
        }

        public void panelSolMainVeriCek(Form name) {

            panelSolMain.Controls.Clear();
            name.TopLevel = false;
            panelSolMain.Controls.Add(name);
            name.Show();
            name.Dock = DockStyle.Fill;
            name.BringToFront();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            panelSolMainVeriCek(dataBaseGridViewForm);
            dataBaseGridViewForm.DataBaseListele("Select * from Kitap");

            mainPage = this;
        }

        private void kitapDataBaseBtn_Click(object sender, EventArgs e)
        {
            panelSolMainVeriCek(dataBaseGridViewForm);
            dataBaseGridViewForm.DataBaseListele("Select * from Kitap");
            mainPage.Text = "Kitaplar";
        }

        private void ziyaretcilerBtn_Click(object sender, EventArgs e)
        {
            panelSolMainVeriCek(dataBaseGridViewForm);
            dataBaseGridViewForm.DataBaseListele("Select * from Ziyaretci");
            mainPage.Text = "Ziyaretçiler";
        }

        private void kitapYeniBtn_Click(object sender, EventArgs e)
        {
            panelSolMainVeriCek(yeniKitapEkleForm);
            mainPage.Text = "Yeni Kitap Ekle";
        }

        private void ziyaretciYeniBtn_Click(object sender, EventArgs e)
        {
            panelSolMainVeriCek(yeniZiyaretciEkleForm);
            mainPage.Text = "Yeni Ziyaretçi Ekle";
        }

        private void kitapGidenBtn_Click(object sender, EventArgs e)
        {
            panelSolMainVeriCek(gidenKitapForm);
            mainPage.Text = "Ziyaretçinin Aldığı Kitap";
        }

        private void kitapGelenBtn_Click(object sender, EventArgs e)
        {
            panelSolMainVeriCek(geriGelenKitapForm);
            mainPage.Text = "Kütüphaneye Geri Gelen Kitap";
        }

        private void cikisYapBtn_Click(object sender, EventArgs e)
        {

        }

        private void kitapDuzenleBtn_Click(object sender, EventArgs e)
        {
            panelSolMainVeriCek(kitapDuzenleForm);
            mainPage.Text = "Kitap Düzenle";
        }

        private void ziyaretciDuzenleBtn_Click(object sender, EventArgs e)
        {
            panelSolMainVeriCek(ziyaretciDuzenleForm);
            mainPage.Text = "Ziyaretçi Düzenle";
        }
    }
}
