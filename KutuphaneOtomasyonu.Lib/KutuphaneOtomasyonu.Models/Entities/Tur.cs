using KutuphaneOtomasyonu.Models.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneOtomasyonu.Models
{
    [Table("Turler")]
    public class Tur
    {

        public Tur()
        {
            YazarTurler = new List<Yazar_Tur>();
        }

        [Key]
        public int TurId { get; set; }

        public string TurAdi { get; set; }


        public virtual List<Yazar_Tur> YazarTurler { get; set; }
    }
}
