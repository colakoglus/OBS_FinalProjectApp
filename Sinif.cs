using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS_FinalProjectApp
{
    internal class Sinif
    {
        public int SinifId { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(6)]
        [Required]
        public string SinifAd { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(6)]
        [Required]
        public string Kontenjan { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }
        public override string ToString()
        {
            return SinifAd;
        }
    }
}
