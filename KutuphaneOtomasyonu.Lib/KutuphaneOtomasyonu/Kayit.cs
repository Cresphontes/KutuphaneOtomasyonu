using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Lib
{

    [Table("Kayitlar")]
    public class Kayit
    {
        [Key]
        public int KayitId { get; set; }

        
        public int UyeId { get; set; }

        [ForeignKey("UyeId")]
        public Uye Uye { get; set; }
        
        

    }
}
