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
    public partial class FormDersEkle : Form
    {
        public FormDersEkle()
        {
            InitializeComponent();
        }
        Ders Ders { get; set; }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (var context = new FinalProjectContext())
            {
                try
                {
                    string dersad = txtDersAd.Text.Trim();
                    string derskod = txtDersKod.Text.Trim();
                    var yeniDers = new Ders { DersAd = dersad, DersKod = derskod };
                    context.Dersler.Add(yeniDers);
                    context.SaveChanges();

                    MessageBox.Show("İşlem Başarılı");
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
                string drsAd = txtDersAd.Text.Trim();
                string drsKod = txtDersKod.Text.Trim();
                try
                {
                    var drs = ctx.Dersler.FirstOrDefault(o => o.DersAd == drsAd || o.DersKod == drsKod);
                    if (drs != null)
                    {
                        Ders = drs;
                        txtDersAd.Text = drs.DersAd;
                        txtDersKod.Text = drs.DersKod;
                    }
                    else
                    {
                        MessageBox.Show("Bir Hata Oluştu. Öğrenci Bulunamadı");
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
                    var drs = Ders;
                    if (drs != null && txtDersAd.Text.Trim() != string.Empty && txtDersKod.Text.Trim() != string.Empty)
                    {
                        drs.DersKod = txtDersKod.Text;
                        drs.DersAd = txtDersAd.Text;
                        ctx.Entry(drs).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    }
                    else {
                        MessageBox.Show("Bir Şeyler Ters Gitti. Lütfen Tüm Kutucukların Dolu Olduğuna Emin Olun");
                    }
                    //ctx.Update(ogr);
                    int sonuc = ctx.SaveChanges();
                    MessageBox.Show(sonuc > 0 ? "İşlem Başarılı" : "İşlem Başarısız");

                    txtDersAd.Clear();
                    txtDersKod.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bilinmeyen Bir Hata Oluştu: {ex.Message}");
                }
            }
        }
    }
}
