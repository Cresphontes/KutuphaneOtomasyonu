﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Models.Entities
{
    [Table("Uyeler")]

    public class Uye:Insan
    {
        [Key]
        public int UyeId { get; set; }
        public string TCKN { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }




   

    }
}
