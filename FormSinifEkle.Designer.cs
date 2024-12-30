namespace OBS_FinalProjectApp
{
    partial class FormSinifEkle
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
            grpSinif = new GroupBox();
            txtKontenjan = new TextBox();
            txtSinifAd = new TextBox();
            lblKontenjan = new Label();
            lblSinifAd = new Label();
            btnKaydet = new Button();
            btnBul = new Button();
            btnGuncelle = new Button();
            grpSinif.SuspendLayout();
            SuspendLayout();
            // 
            // grpSinif
            // 
            grpSinif.Controls.Add(txtKontenjan);
            grpSinif.Controls.Add(txtSinifAd);
            grpSinif.Controls.Add(lblKontenjan);
            grpSinif.Controls.Add(lblSinifAd);
            grpSinif.Location = new Point(72, 73);
            grpSinif.Name = "grpSinif";
            grpSinif.Size = new Size(405, 172);
            grpSinif.TabIndex = 0;
            grpSinif.TabStop = false;
            grpSinif.Text = "Sınıf Ekle";
            // 
            // txtKontenjan
            // 
            txtKontenjan.Location = new Point(217, 94);
            txtKontenjan.Name = "txtKontenjan";
            txtKontenjan.Size = new Size(125, 27);
            txtKontenjan.TabIndex = 3;
            // 
            // txtSinifAd
            // 
            txtSinifAd.Location = new Point(217, 49);
            txtSinifAd.Name = "txtSinifAd";
            txtSinifAd.Size = new Size(125, 27);
            txtSinifAd.TabIndex = 2;
            // 
            // lblKontenjan
            // 
            lblKontenjan.AutoSize = true;
            lblKontenjan.Location = new Point(56, 94);
            lblKontenjan.Name = "lblKontenjan";
            lblKontenjan.Size = new Size(113, 20);
            lblKontenjan.TabIndex = 1;
            lblKontenjan.Text = "Sınıf Kontenjanı";
            // 
            // lblSinifAd
            // 
            lblSinifAd.AutoSize = true;
            lblSinifAd.Location = new Point(56, 49);
            lblSinifAd.Name = "lblSinifAd";
            lblSinifAd.Size = new Size(65, 20);
            lblSinifAd.TabIndex = 0;
            lblSinifAd.Text = "Sınıf Adı";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(289, 288);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(125, 64);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(168, 288);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(94, 29);
            btnBul.TabIndex = 2;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(168, 323);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // FormSinifEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 450);
            Controls.Add(btnGuncelle);
            Controls.Add(btnBul);
            Controls.Add(btnKaydet);
            Controls.Add(grpSinif);
            Name = "FormSinifEkle";
            Text = "FormSinifEkle";
            grpSinif.ResumeLayout(false);
            grpSinif.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpSinif;
        private TextBox txtKontenjan;
        private TextBox txtSinifAd;
        private Label lblKontenjan;
        private Label lblSinifAd;
        private Button btnKaydet;
        private Button btnBul;
        private Button btnGuncelle;
    }
}