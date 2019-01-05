using KutuphaneOtomasyonu.Models.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneOtomasyonu.Models.Entities
{
    [Table("Turler")]
    public class Tur
    {


        [Key]
        public int TurId { get; set; }

        public string TurAdi { get; set; }


        public virtual ICollection<Yazar> Yazarlar { get; set; } = new HashSet<Yazar>();
    }
}
