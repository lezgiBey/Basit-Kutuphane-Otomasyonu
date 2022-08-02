namespace BasitKutuphaneOtomasyonu
{
    partial class GidenKitapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSol1 = new System.Windows.Forms.Panel();
            this.labelUyari = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKitabiGonder = new System.Windows.Forms.Button();
            this.panelSag1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBxAlanNo = new System.Windows.Forms.TextBox();
            this.rTxtBxAciklama = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpKitabinGeriVerilisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxKitapNumarasi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelSol1.SuspendLayout();
            this.panelSag1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelMain.Controls.Add(this.panelSol1);
            this.panelMain.Controls.Add(this.panelSag1);
            this.panelMain.Location = new System.Drawing.Point(51, 28);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(682, 387);
            this.panelMain.TabIndex = 1;
            // 
            // panelSol1
            // 
            this.panelSol1.Controls.Add(this.labelUyari);
            this.panelSol1.Controls.Add(this.btnTemizle);
            this.panelSol1.Controls.Add(this.btnKitabiGonder);
            this.panelSol1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSol1.Location = new System.Drawing.Point(482, 0);
            this.panelSol1.Name = "panelSol1";
            this.panelSol1.Size = new System.Drawing.Size(200, 387);
            this.panelSol1.TabIndex = 7;
            // 
            // labelUyari
            // 
            this.labelUyari.AutoSize = true;
            this.labelUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelUyari.Location = new System.Drawing.Point(18, 287);
            this.labelUyari.Name = "labelUyari";
            this.labelUyari.Size = new System.Drawing.Size(0, 25);
            this.labelUyari.TabIndex = 4;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTemizle.Location = new System.Drawing.Point(0, 315);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(200, 36);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Tüm Sayfayı Temizle!";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKitabiGonder
            // 
            this.btnKitabiGonder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKitabiGonder.Location = new System.Drawing.Point(0, 351);
            this.btnKitabiGonder.Name = "btnKitabiGonder";
            this.btnKitabiGonder.Size = new System.Drawing.Size(200, 36);
            this.btnKitabiGonder.TabIndex = 0;
            this.btnKitabiGonder.Text = "Kitabı Teslim Et";
            this.btnKitabiGonder.UseVisualStyleBackColor = true;
            this.btnKitabiGonder.Click += new System.EventHandler(this.btnKitabiGonder_Click);
            // 
            // panelSag1
            // 
            this.panelSag1.Controls.Add(this.label5);
            this.panelSag1.Controls.Add(this.label3);
            this.panelSag1.Controls.Add(this.label10);
            this.panelSag1.Controls.Add(this.txtBxAlanNo);
            this.panelSag1.Controls.Add(this.rTxtBxAciklama);
            this.panelSag1.Controls.Add(this.label1);
            this.panelSag1.Controls.Add(this.dtpKitabinGeriVerilisTarihi);
            this.panelSag1.Controls.Add(this.label2);
            this.panelSag1.Controls.Add(this.label4);
            this.panelSag1.Controls.Add(this.txtBxKitapNumarasi);
            this.panelSag1.Controls.Add(this.label7);
            this.panelSag1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSag1.Location = new System.Drawing.Point(0, 0);
            this.panelSag1.Name = "panelSag1";
            this.panelSag1.Size = new System.Drawing.Size(476, 387);
            this.panelSag1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(-5, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(-5, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(-5, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "*";
            // 
            // txtBxAlanNo
            // 
            this.txtBxAlanNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtBxAlanNo.Location = new System.Drawing.Point(192, 11);
            this.txtBxAlanNo.Name = "txtBxAlanNo";
            this.txtBxAlanNo.Size = new System.Drawing.Size(277, 31);
            this.txtBxAlanNo.TabIndex = 3;
            // 
            // rTxtBxAciklama
            // 
            this.rTxtBxAciklama.Location = new System.Drawing.Point(192, 122);
            this.rTxtBxAciklama.Name = "rTxtBxAciklama";
            this.rTxtBxAciklama.Size = new System.Drawing.Size(277, 265);
            this.rTxtBxAciklama.TabIndex = 5;
            this.rTxtBxAciklama.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitabı Alanın Numarası:";
            // 
            // dtpKitabinGeriVerilisTarihi
            // 
            this.dtpKitabinGeriVerilisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.dtpKitabinGeriVerilisTarihi.Location = new System.Drawing.Point(192, 85);
            this.dtpKitabinGeriVerilisTarihi.Name = "dtpKitabinGeriVerilisTarihi";
            this.dtpKitabinGeriVerilisTarihi.Size = new System.Drawing.Size(277, 31);
            this.dtpKitabinGeriVerilisTarihi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kitabın Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(13, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kitabın Teslim Tarihi:";
            // 
            // txtBxKitapNumarasi
            // 
            this.txtBxKitapNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtBxKitapNumarasi.Location = new System.Drawing.Point(192, 48);
            this.txtBxKitapNumarasi.Name = "txtBxKitapNumarasi";
            this.txtBxKitapNumarasi.Size = new System.Drawing.Size(277, 31);
            this.txtBxKitapNumarasi.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(13, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Açıklama";
            // 
            // GidenKitapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GidenKitapForm";
            this.Text = "GidenKitapForm";
            this.panelMain.ResumeLayout(false);
            this.panelSol1.ResumeLayout(false);
            this.panelSol1.PerformLayout();
            this.panelSag1.ResumeLayout(false);
            this.panelSag1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelSol1;
        private System.Windows.Forms.Button btnKitabiGonder;
        private System.Windows.Forms.Panel panelSag1;
        private System.Windows.Forms.TextBox txtBxAlanNo;
        private System.Windows.Forms.RichTextBox rTxtBxAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpKitabinGeriVerilisTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxKitapNumarasi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelUyari;
    }
}