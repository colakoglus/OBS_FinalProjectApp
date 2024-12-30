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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            var formogr = new FormOgr();
            formogr.Show();
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            var formders = new FormDersEkle();
            formders.Show();
        }

        private void btnSinif_Click(object sender, EventArgs e)
        {
            var formsinif = new FormSinifEkle();
            formsinif.Show();
        }
    }
}
