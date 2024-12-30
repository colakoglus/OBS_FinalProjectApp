using System;
using Microsoft.EntityFrameworkCore;

namespace OBS_FinalProjectApp
{
    public partial class FormOgr : Form
    {
        Ogrenci Ogrenci { get; set; }

        public FormOgr()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (var dbContext = new FinalProjectContext())
            {
                try
                {
                    var siniflar = dbContext.Siniflar
                                                    .Select(s => new Sinif
                                                    {
                                                        SinifId = s.SinifId,
                                                        SinifAd = s.SinifAd
                                                    })
                                                    .ToList();

                    cmbxSinif.DataSource = siniflar;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir Hata Olu�tu: {ex.Message}");
                }

            }

        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            using (var ctx = new FinalProjectContext())
            {

                string OgrNum = txtNumara.Text;
                try
                {
                    var ogr = ctx.Ogrenciler.FirstOrDefault(o => o.Numara == OgrNum);
                    var snf = ctx.Siniflar.FirstOrDefault(s => s.SinifId == ogr.SinifId);
                    if (ogr != null && txtNumara.Text!=string.Empty)
                    {
                        Ogrenci = ogr;
                        txtAd.Text = ogr.Ad;
                        txtSoyad.Text = ogr.Soyad;
                        cmbxSinif.Text = snf.SinifAd;
                    }
                    else
                    {
                        MessageBox.Show("Bir Hata Olu�tu. ��renci Bulunamad�. L�tfen Numaray� Do�ru Yazd���n�zdan Emin Olun Ve Tekrar Deneyin");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Beklenmeyen Bir Hata Olu�tu:{ex.Message}");
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (var ctx = new FinalProjectContext())
            {
                try
                {
                    var ogr = Ogrenci;
                    var seciliSnf = (Sinif)cmbxSinif.SelectedItem;
                    int seciliSnfId = seciliSnf.SinifId;
                    if (doluMu(seciliSnfId) &&ogr != null && txtAd.Text.Trim() != string.Empty && txtNumara.Text.Trim() != string.Empty && txtSoyad.Text.Trim() != string.Empty)
                    {
                        ogr.Ad = txtAd.Text;
                        ogr.Soyad = txtSoyad.Text;
                        ogr.Numara = txtNumara.Text;
                        ogr.SinifId = seciliSnfId;
                        ctx.Entry(ogr).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        
                        //ctx.Update(ogr);
                        int sonuc = ctx.SaveChanges();
                        MessageBox.Show(sonuc > 0 ? "��lem Ba�ar�l�" : "��lem Ba�ar�s�z");

                        txtAd.Clear();
                        txtSoyad.Clear();
                        txtNumara.Clear();
                    }
                    else
                    {
                        MessageBox.Show("T�m Kutucuklar�n Dolu Oldu�una Emin Olun! Kaydetmeye �al��t���n�z S�n�f�n Kontenjan� Dolmu� Olabilir!");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bilinmeyen Bir Hata Olu�tu: {ex.Message}");
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string numara = txtNumara.Text.Trim();
            var seciliSnf = (Sinif)cmbxSinif.SelectedItem;
            int seciliSnfId = seciliSnf.SinifId;

            using (var context = new FinalProjectContext())
            {
                try
                {
                    if (doluMu(seciliSnfId) && txtAd.Text.Trim() != string.Empty && txtNumara.Text.Trim() != string.Empty && txtSoyad.Text.Trim() != string.Empty)
                    {
                        var ogr = new Ogrenci();
                        ogr.Ad = ad;
                        ogr.Soyad = soyad;
                        ogr.Numara = numara;
                        ogr.SinifId = seciliSnfId;
                        context.Ogrenciler.Add(ogr);
                        context.SaveChanges();
                        Ogrenci = ogr;

                        MessageBox.Show("��renci ba�ar�yla kaydedildi!");

                        txtAd.Clear();
                        txtSoyad.Clear();
                        txtNumara.Clear();
                    }
                    else {
                        MessageBox.Show("Bir �eyler Ters Gitti! T�m Kutucuklar�n Dolu Oldu�una Emin Olun!\n Kaydetmeye �al��t���n�z S�n�f�n Kontenjan� Dolmu� Olabilir!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata olu�tu: {ex.Message}");
                }
            }
        }

        private void btnDersSecimi_Click(object sender, EventArgs e)
        {
            int ogrId = Ogrenci.OgrenciId;
            string ogrAd= Ogrenci.Ad;
            string ogrSoyad = Ogrenci.Soyad;
            var frmdersSecimi = new FormDersSecim(ogrId, ogrAd, ogrSoyad);
            if (txtAd.Text.Trim() != string.Empty && txtNumara.Text.Trim() != string.Empty && txtSoyad.Text.Trim() != string.Empty)
            {
                frmdersSecimi.Show();
            }
            else {
                MessageBox.Show("�ncelikle Bir ��renci Se�iniz");
            }
            
        }
        private bool doluMu(int sinifId)
        {
            using (var context = new FinalProjectContext())
            {
                try
                {
                    var sinif = context.Siniflar.FirstOrDefault(s => s.SinifId == sinifId);
                    var doluluk = context.Ogrenciler.Count(o => o.SinifId == sinifId);

                    return doluluk >= int.Parse(sinif.Kontenjan);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata olu�tu: {ex.Message}");
                    throw;
                }
            }

        }
    }
}
