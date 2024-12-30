namespace OBS_FinalProjectApp
{
    partial class FrmGiris
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
            lblMsj = new Label();
            btnOgrenci = new Button();
            btnDers = new Button();
            btnSinif = new Button();
            SuspendLayout();
            // 
            // lblMsj
            // 
            lblMsj.AutoSize = true;
            lblMsj.Location = new Point(154, 87);
            lblMsj.Name = "lblMsj";
            lblMsj.Size = new Size(153, 20);
            lblMsj.TabIndex = 0;
            lblMsj.Text = "Yapılacak İşlemi Seçin";
            // 
            // btnOgrenci
            // 
            btnOgrenci.Location = new Point(154, 137);
            btnOgrenci.Name = "btnOgrenci";
            btnOgrenci.Size = new Size(153, 29);
            btnOgrenci.TabIndex = 1;
            btnOgrenci.Text = "Öğrenci İşlemleri";
            btnOgrenci.UseVisualStyleBackColor = true;
            btnOgrenci.Click += btnOgrenci_Click;
            // 
            // btnDers
            // 
            btnDers.Location = new Point(154, 195);
            btnDers.Name = "btnDers";
            btnDers.Size = new Size(153, 29);
            btnDers.TabIndex = 2;
            btnDers.Text = "Ders İşlemleri";
            btnDers.UseVisualStyleBackColor = true;
            btnDers.Click += btnDers_Click;
            // 
            // btnSinif
            // 
            btnSinif.Location = new Point(154, 244);
            btnSinif.Name = "btnSinif";
            btnSinif.Size = new Size(153, 29);
            btnSinif.TabIndex = 3;
            btnSinif.Text = "Sınıf İşlemleri";
            btnSinif.UseVisualStyleBackColor = true;
            btnSinif.Click += btnSinif_Click;
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 352);
            Controls.Add(btnSinif);
            Controls.Add(btnDers);
            Controls.Add(btnOgrenci);
            Controls.Add(lblMsj);
            Name = "FrmGiris";
            Text = "FrmGiris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMsj;
        private Button btnOgrenci;
        private Button btnDers;
        private Button btnSinif;
    }
}