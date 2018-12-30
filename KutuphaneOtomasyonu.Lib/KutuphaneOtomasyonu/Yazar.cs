using KutuphaneOtomasyonu.Lib.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Lib
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


        public List<Tur> YazarTurler { get; set; }
        public virtual List<Kitap> YazarKitaplar { get; set; }
       




    }
}
