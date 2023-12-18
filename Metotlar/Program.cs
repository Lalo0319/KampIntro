using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 10;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 50;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[]urunler= new Urun[] {urun1, urun2};
            foreach(Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                

            }
            Console.WriteLine("-------Metotlar------");

            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 10,12);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 10, 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 10, 12);

        }
    }
}