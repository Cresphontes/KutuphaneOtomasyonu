using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Models.Entities
{
    [Table("Yazar_Turler")]
    public class Yazar_Tur
    {

        [Key]
        public int Yazar_Tur_Id { get; set; }

        public int YazarId { get; set; }
        public int TurId { get; set; }

        [ForeignKey("YazarId")]
        public virtual Yazar Yazar { get; set; }

        [ForeignKey("TurId")]
        public virtual Tur Tur { get; set; }

    }
}
