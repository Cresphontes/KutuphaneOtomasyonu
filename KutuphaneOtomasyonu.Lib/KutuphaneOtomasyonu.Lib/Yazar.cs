﻿using KutuphaneOtomasyonu.Lib.Data;
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
        [Key]
        public int YazarId { get; set; }
        public List<KitapTurler> YazarTurler { get; set; } = new List<KitapTurler>();
        public static List<CheckBox> CheckBoxes { get; set; } = new List<CheckBox>();

     

        public virtual ICollection<Kitap> YazarKitaplar { get; set; } = new HashSet<Kitap>();

        public virtual KitapTurler KitapTurler { get; set; }




        public override string ToString()
        {
            string TurlerToString = string.Join(",", YazarTurler.ToArray());

            return this.Ad +" "+ this.Soyad +" "+ this.DogumTarihi +" "+ TurlerToString;
        }

    }
}
