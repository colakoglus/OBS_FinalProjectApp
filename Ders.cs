using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS_FinalProjectApp
{
    internal class Ders
    {
        public int DersId { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(6)]
        [Required]
        public string DersKod { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        [Required]
        public string DersAd { get; set; }
        public ICollection<OgrenciDers> OgrenciDersler { get; set; }
    }
}
