
using KutuphaneOtomasyonu.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KutuphaneOtomasyonu.Models
{

    [Table("Yazarlar")]
    public class Yazar:Insan
    {

        public Yazar()
        {
            YazarTurler = new List<Yazar_Tur>();
        }

        [Key]
        public int YazarId { get; set; }


        public virtual List<Yazar_Tur> YazarTurler { get; set; }
        public virtual List<Kitap> YazarKitaplar { get; set; }



        public override string ToString()
        {
            return $"{this.Ad} {this.Soyad} ";
        }

    }
}
