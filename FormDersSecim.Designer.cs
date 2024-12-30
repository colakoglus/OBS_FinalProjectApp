namespace OBS_FinalProjectApp
{
    partial class FormDersSecim
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
            lblOgrBilgi = new Label();
            dtGridDers = new DataGridView();
            btnDersKaydet = new Button();
            lblDersler = new Label();
            lblSecili = new Label();
            btnSec = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGridDers).BeginInit();
            SuspendLayout();
            // 
            // lblOgrBilgi
            // 
            lblOgrBilgi.AutoSize = true;
            lblOgrBilgi.Location = new Point(61, 19);
            lblOgrBilgi.Name = "lblOgrBilgi";
            lblOgrBilgi.Size = new Size(116, 20);
            lblOgrBilgi.TabIndex = 0;
            lblOgrBilgi.Text = "Ogrenci Bilgileri";
            // 
            // dtGridDers
            // 
            dtGridDers.AllowUserToDeleteRows = false;
            dtGridDers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridDers.Location = new Point(61, 100);
            dtGridDers.Name = "dtGridDers";
            dtGridDers.ReadOnly = true;
            dtGridDers.RowHeadersWidth = 51;
            dtGridDers.Size = new Size(660, 250);
            dtGridDers.TabIndex = 1;
            // 
            // btnDersKaydet
            // 
            btnDersKaydet.Location = new Point(401, 356);
            btnDersKaydet.Name = "btnDersKaydet";
            btnDersKaydet.Size = new Size(320, 29);
            btnDersKaydet.TabIndex = 2;
            btnDersKaydet.Text = "Seçili Dersleri Kaydet";
            btnDersKaydet.UseVisualStyleBackColor = true;
            btnDersKaydet.Click += btnDersKaydet_Click;
            // 
            // lblDersler
            // 
            lblDersler.AutoSize = true;
            lblDersler.Location = new Point(61, 77);
            lblDersler.Name = "lblDersler";
            lblDersler.Size = new Size(56, 20);
            lblDersler.TabIndex = 3;
            lblDersler.Text = "Dersler";
            // 
            // lblSecili
            // 
            lblSecili.AutoSize = true;
            lblSecili.Location = new Point(61, 413);
            lblSecili.Name = "lblSecili";
            lblSecili.Size = new Size(15, 20);
            lblSecili.TabIndex = 4;
            lblSecili.Text = "/";
            // 
            // btnSec
            // 
            btnSec.Location = new Point(61, 356);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(94, 29);
            btnSec.TabIndex = 5;
            btnSec.Text = "Seç";
            btnSec.UseVisualStyleBackColor = true;
            btnSec.Click += btnSec_Click;
            // 
            // FormDersSecim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 566);
            Controls.Add(btnSec);
            Controls.Add(lblSecili);
            Controls.Add(lblDersler);
            Controls.Add(btnDersKaydet);
            Controls.Add(dtGridDers);
            Controls.Add(lblOgrBilgi);
            Name = "FormDersSecim";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridDers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOgrBilgi;
        private DataGridView dtGridDers;
        private Button btnDersKaydet;
        private Label lblDersler;
        private Label lblSecili;
        private Button btnSec;
    }
}