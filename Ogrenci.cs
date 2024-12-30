using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OBS_FinalProjectApp
{
    internal class Ogrenci
    {
        public int OgrenciId { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        [Required]
        public string Ad { get; set; } = null!;
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        [Required]
        public string Soyad { get; set; } = null!;
        [Column(TypeName = "varchar")]
        [MaxLength(6)]
        [Required]
        public string Numara { get; set; } = null!;

        public int SinifId { get; set; }
        public Sinif Sinif {  get; set; }
        public ICollection<OgrenciDers> OgrenciDersler { get; set; }
        public override string ToString()
        {
            return $"{this.Numara}-{this.Ad}-{this.Soyad}";
        }
    }
}
