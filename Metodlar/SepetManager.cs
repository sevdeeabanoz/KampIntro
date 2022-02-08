using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    //naming convention -- isimlendirme
    internal class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi: " + urun.Adi);

        }
        public void Ekle2(string urunAdi, string Aciklama, double fiyat, int stokadedi)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi: " + urunAdi + " - " + Aciklama + " - " + fiyat + " - " + stokadedi);
        }
    }
    
}
