namespace OBS_FinalProjectApp
{
    partial class FormDersEkle
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
            grpDers = new GroupBox();
            txtDersKod = new TextBox();
            txtDersAd = new TextBox();
            lblDersKod = new Label();
            lblDersAd = new Label();
            btnKaydet = new Button();
            btnBul = new Button();
            btnGuncelle = new Button();
            grpDers.SuspendLayout();
            SuspendLayout();
            // 
            // grpDers
            // 
            grpDers.Controls.Add(txtDersKod);
            grpDers.Controls.Add(txtDersAd);
            grpDers.Controls.Add(lblDersKod);
            grpDers.Controls.Add(lblDersAd);
            grpDers.Location = new Point(86, 54);
            grpDers.Name = "grpDers";
            grpDers.Size = new Size(454, 242);
            grpDers.TabIndex = 0;
            grpDers.TabStop = false;
            grpDers.Text = "Ders Ekle";
            // 
            // txtDersKod
            // 
            txtDersKod.Location = new Point(190, 129);
            txtDersKod.Name = "txtDersKod";
            txtDersKod.Size = new Size(125, 27);
            txtDersKod.TabIndex = 3;
            // 
            // txtDersAd
            // 
            txtDersAd.Location = new Point(190, 67);
            txtDersAd.Name = "txtDersAd";
            txtDersAd.Size = new Size(125, 27);
            txtDersAd.TabIndex = 2;
            // 
            // lblDersKod
            // 
            lblDersKod.AutoSize = true;
            lblDersKod.Location = new Point(65, 129);
            lblDersKod.Name = "lblDersKod";
            lblDersKod.Size = new Size(78, 20);
            lblDersKod.TabIndex = 1;
            lblDersKod.Text = "Ders Kodu";
            // 
            // lblDersAd
            // 
            lblDersAd.AutoSize = true;
            lblDersAd.Location = new Point(65, 70);
            lblDersAd.Name = "lblDersAd";
            lblDersAd.Size = new Size(66, 20);
            lblDersAd.TabIndex = 0;
            lblDersAd.Text = "Ders Adı";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(276, 331);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(125, 64);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(151, 331);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(94, 29);
            btnBul.TabIndex = 4;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(151, 366);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // FormDersEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 450);
            Controls.Add(btnGuncelle);
            Controls.Add(btnBul);
            Controls.Add(btnKaydet);
            Controls.Add(grpDers);
            Name = "FormDersEkle";
            Text = "FormDersEkle";
            grpDers.ResumeLayout(false);
            grpDers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDers;
        private TextBox txtDersKod;
        private TextBox txtDersAd;
        private Label lblDersKod;
        private Label lblDersAd;
        private Button btnKaydet;
        private Button btnBul;
        private Button btnGuncelle;
    }
}