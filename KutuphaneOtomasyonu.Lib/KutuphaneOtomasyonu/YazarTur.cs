using KutuphaneOtomasyonu.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu
{
    [Table("Yazar Tür")]
    public class YazarTur
    {
        public int YazarId { get; set; }
        public int TurId { get; set; }



        [ForeignKey("YazarId")]
        public Yazar Yazar { get; set; }
        [ForeignKey("TurId")]
        public Tur Tur { get; set; }


        
    }
}
