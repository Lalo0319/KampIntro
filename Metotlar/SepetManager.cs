using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle (Urun urun)
        {
            Console.WriteLine("Sepete eklendi: " + urun.Adi +":"+ urun.Fiyat);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Sepetinize eklendi"+urunAdi);
        }
    }
}
