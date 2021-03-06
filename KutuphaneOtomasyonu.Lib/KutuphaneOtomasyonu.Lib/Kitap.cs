﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Lib
{
    [Table("Kitaplar")]
    public class Kitap
    {
        [Key]
        public int KitapId { get; set; }
        public string KitapAd { get; set; }
        public KitapTurler Tur { get; set; }
        public string Yayin { get; set; }
        public static List<RadioButton> RadioButtons { get; set; } = new List<RadioButton>();


        public int YazarId { get; set; }
        [ForeignKey("YazarId")]
        public virtual Yazar Yazar { get; set; }


        public int UyeId { get; set; }
        [ForeignKey("UyeId")]
        public virtual Uye Uye { get; set; }


        

    }
}
