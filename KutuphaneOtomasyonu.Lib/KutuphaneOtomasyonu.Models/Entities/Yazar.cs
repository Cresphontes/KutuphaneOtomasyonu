
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
            YazarKitaplar = new List<Kitap>();
            YazarTurler = new List<Tur>();
        }

        [Key]
        public int YazarId { get; set; }


        public virtual List<Tur> YazarTurler { get; set; }
        public virtual List<Kitap> YazarKitaplar { get; set; }



        public override string ToString()
        {
            return $"{this.Ad} {this.Soyad} ";
        }

    }
}
