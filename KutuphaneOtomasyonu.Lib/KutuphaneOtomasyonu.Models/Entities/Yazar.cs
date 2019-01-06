
using KutuphaneOtomasyonu.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KutuphaneOtomasyonu.Models.Entities
{

    [Table("Yazarlar")]
    public class Yazar:Insan
    {


        [Key]
        public int YazarId { get; set; }


        public virtual ICollection<Tur> Turler { get; set; } = new HashSet<Tur>();
        public virtual ICollection<Kitap> Kitaplar { get; set; } = new HashSet<Kitap>();



        public override string ToString()
        {
            return $"{this.Ad} {this.Soyad} ";
        }

    }
}
