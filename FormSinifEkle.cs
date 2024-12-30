using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS_FinalProjectApp
{
    public partial class FormSinifEkle : Form
    {
        public FormSinifEkle()
        {
            InitializeComponent();
        }
        Sinif Sinif { get; set; }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (var context = new FinalProjectContext())
            {
                try
                {
                    if (txtKontenjan.Text.Trim() != string.Empty && txtSinifAd.Text.Trim() != string.Empty)
                    {
                        string sinifad = txtSinifAd.Text.Trim();
                        string kontenjan = txtKontenjan.Text.Trim();
                        var yeniSinif = new Sinif { SinifAd = sinifad, Kontenjan = kontenjan };
                        context.Siniflar.Add(yeniSinif);
                        context.SaveChanges();
                        MessageBox.Show("İşlem Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Bir Şeyler Ters Gitti. Lütfen Tüm Kutucukların Dolu Olduğuna Emin Olun");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir Hata Oluştu: {ex.Message}");
                }
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            using (var ctx = new FinalProjectContext())
            {
                string snfAd = txtSinifAd.Text.Trim();
                try
                {
                    var snf = ctx.Siniflar.FirstOrDefault(o => o.SinifAd == snfAd);
                    if (snf != null)
                    {
                        Sinif = snf;
                        txtSinifAd.Text = snf.SinifAd;
                        txtKontenjan.Text = snf.Kontenjan;
                    }
                    else
                    {
                        MessageBox.Show("Bir Hata Oluştu. Sınıf Bulunamadı");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Beklenmeyen Bir Hata Oluştu:{ex.Message}");
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (var ctx = new FinalProjectContext())
            {
                try
                {
                    var snf = Sinif;
                    if (snf != null && txtSinifAd.Text.Trim() != string.Empty && txtKontenjan.Text.Trim() != string.Empty)
                    {
                        snf.SinifAd = txtSinifAd.Text;
                        snf.Kontenjan = txtKontenjan.Text;
                        ctx.Entry(snf).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    }
                    else
                    {
                        MessageBox.Show("Bir Şeyler Ters Gitti. Lütfen Tüm Kutucukların Dolu Olduğuna Emin Olun");
                    }
                    int sonuc = ctx.SaveChanges();
                    MessageBox.Show(sonuc > 0 ? "İşlem Başarılı" : "İşlem Başarısız");

                    txtKontenjan.Clear();
                    txtSinifAd.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bilinmeyen Bir Hata Oluştu: {ex.Message}");
                }
            }
        }
    }
}
