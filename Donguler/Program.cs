using System.Security.Cryptography.X509Certificates;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Python Kampı";
            string kurs3 = "Java Kampı";

            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı",
                "Python Kampı",
                "Java Kampı","C#"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("------------");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


        }
    }
}