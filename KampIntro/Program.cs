namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {

       
            //type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 300;
            double faizOranı = 1.45;

            double dolarDun = 25.47;
            double dolarBugun = 25.50;
            if (dolarDun>dolarBugun) 
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if(dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }


            bool sistemeGirisYapmısMı=false;
            if (sistemeGirisYapmısMı==false)
            {
                Console.WriteLine("Kayıt ol butonu");

            }
            else
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}