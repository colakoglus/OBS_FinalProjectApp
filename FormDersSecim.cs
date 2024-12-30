using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OBS_FinalProjectApp
{
    public partial class FormDersSecim : Form
    {
        public FormDersSecim(int OgrenciId, string OgrenciAd, string OgrenciSoyad)
        {
            InitializeComponent();
            ogr = OgrenciId;
            ograd= OgrenciAd;
            ogrsoyad = OgrenciSoyad;
        }
        int ogr;
        string ograd;
        string ogrsoyad;
        private void Form2_Load(object sender, EventArgs e)
        {
            lblOgrBilgi.Text = ogr.ToString()+" "+ ograd +" " +ogrsoyad;
            using (var ctx = new FinalProjectContext())
            {
                try
                {
                    var dersler = ctx.Dersler
                                .Select(u => new
                                {
                                    u.DersId,
                                    u.DersKod,
                                    u.DersAd
                                })
                                .ToList();

                    dtGridDers.DataSource = dersler;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}");
                    throw;
                }
            }

        }
        private void btnDersKaydet_Click(object sender, EventArgs e)
        {
            if (dtGridDers.SelectedRows.Count > 0)
            {
                var seciliSutun = dtGridDers.SelectedRows[0];
                var DersId = Convert.ToInt32(seciliSutun.Cells["DersId"].Value);

                DbKaydet(DersId, ogr);
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            var seciliSutun = dtGridDers.SelectedRows[0];
            var DersId = Convert.ToInt32(seciliSutun.Cells["DersId"].Value);
            var DersKod = seciliSutun.Cells["DersKod"].Value.ToString();
            var DersAd = seciliSutun.Cells["DersAd"].Value.ToString();
            lblSecili.Text += "Ders id:" + DersId + "/ Ders Kodu: " + DersKod + "/ Ders Adı: " + DersAd + "\n";
        }

        private void DbKaydet(int DersId, int OgrenciId)
        {
            using (var context = new FinalProjectContext())
            {
                try
                {
                    var ogrders = new OgrenciDers
                    {
                        DersId = DersId,
                        OgrenciId = OgrenciId
                    };
                    context.OgrenciDersler.Add(ogrders);
                    context.SaveChanges();

                    MessageBox.Show("Kayıt başarıyla kaydedildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Beklenmeyen Bir Hata Oluştu:{ex.Message}");
                }
            }

        }
    }
}
