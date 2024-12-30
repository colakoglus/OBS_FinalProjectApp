namespace OBS_FinalProjectApp
{
    partial class FormOgr
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpEkle = new GroupBox();
            cmbxSinif = new ComboBox();
            txtNumara = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            lblSinif = new Label();
            lblNumara = new Label();
            lblSoyad = new Label();
            lblAd = new Label();
            btnKaydet = new Button();
            btnBul = new Button();
            btnGuncelle = new Button();
            btnDersSecimi = new Button();
            grpEkle.SuspendLayout();
            SuspendLayout();
            // 
            // grpEkle
            // 
            grpEkle.Controls.Add(cmbxSinif);
            grpEkle.Controls.Add(txtNumara);
            grpEkle.Controls.Add(txtSoyad);
            grpEkle.Controls.Add(txtAd);
            grpEkle.Controls.Add(lblSinif);
            grpEkle.Controls.Add(lblNumara);
            grpEkle.Controls.Add(lblSoyad);
            grpEkle.Controls.Add(lblAd);
            grpEkle.Location = new Point(52, 40);
            grpEkle.Name = "grpEkle";
            grpEkle.Size = new Size(360, 247);
            grpEkle.TabIndex = 0;
            grpEkle.TabStop = false;
            grpEkle.Text = "Öğrenci Ekle";
            // 
            // cmbxSinif
            // 
            cmbxSinif.FormattingEnabled = true;
            cmbxSinif.Location = new Point(153, 162);
            cmbxSinif.Name = "cmbxSinif";
            cmbxSinif.Size = new Size(125, 28);
            cmbxSinif.TabIndex = 7;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(153, 105);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(125, 27);
            txtNumara.TabIndex = 6;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(153, 66);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(153, 30);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 4;
            // 
            // lblSinif
            // 
            lblSinif.AutoSize = true;
            lblSinif.Location = new Point(43, 170);
            lblSinif.Name = "lblSinif";
            lblSinif.Size = new Size(38, 20);
            lblSinif.TabIndex = 3;
            lblSinif.Text = "Sınıf";
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(43, 112);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(62, 20);
            lblNumara.TabIndex = 2;
            lblNumara.Text = "Numara";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(43, 73);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(50, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(43, 37);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(205, 314);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(125, 64);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(95, 314);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(94, 29);
            btnBul.TabIndex = 9;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(95, 349);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnDersSecimi
            // 
            btnDersSecimi.Location = new Point(115, 393);
            btnDersSecimi.Name = "btnDersSecimi";
            btnDersSecimi.Size = new Size(194, 43);
            btnDersSecimi.TabIndex = 11;
            btnDersSecimi.Text = "Ders Seçimi";
            btnDersSecimi.UseVisualStyleBackColor = true;
            btnDersSecimi.Click += btnDersSecimi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 459);
            Controls.Add(btnDersSecimi);
            Controls.Add(btnGuncelle);
            Controls.Add(btnBul);
            Controls.Add(btnKaydet);
            Controls.Add(grpEkle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpEkle.ResumeLayout(false);
            grpEkle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEkle;
        private Label lblSinif;
        private Label lblNumara;
        private Label lblSoyad;
        private Label lblAd;
        private ComboBox cmbxSinif;
        private TextBox txtNumara;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Button btnKaydet;
        private Button btnBul;
        private Button btnGuncelle;
        private Button btnDersSecimi;
    }
}
