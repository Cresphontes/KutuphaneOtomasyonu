using KutuphaneOtomasyonu.Lib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Lib
{
    public class Yazar:Insan
    {
        public List<Kitap> YazarKitaplar { get; set; } = new List<Kitap>();
        public List<KitapTurler> YazarTurler { get; set; } = new List<KitapTurler>();
        public static List<CheckBox> CheckBoxes { get; set; } = new List<CheckBox>();
        

        public override string ToString()
        {
            string TurlerToString = string.Join(",", YazarTurler.ToArray());

            return this.Ad +" "+ this.Soyad +" "+ this.DogumTarihi +" "+ TurlerToString;
        }

    }
}
