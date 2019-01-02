
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Models
{
    [Table("Turler")]
    public class Tur
    {

        public Tur()
        {
            TurYazarlar = new List<Yazar>();
        }

        [Key]
        public int TurId { get; set; }

        public string TurAdi { get; set; }
        public List<Yazar> TurYazarlar { get; set; }
    }
}
