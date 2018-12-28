using KutuphaneOtomasyonu.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu
{

    [Table("Türler")]
    public class Tur
    {
        [Key]
        public int TurId{ get; set; }

        public string TurAd { get; set; }

        public int YazarId { get; set; }
        [ForeignKey("YazarId")]
        public Yazar yazar { get; set; }


        public int KitapId { get; set; }
        [ForeignKey("KitapId")]
        public Kitap kitap { get; set; }








        public virtual ICollection<Kitap> TurKitaplar { get; set; } = new HashSet<Kitap>();
        public virtual ICollection<Yazar> TurYazarlar { get; set; } = new HashSet<Yazar>();
    }
}
