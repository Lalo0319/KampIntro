namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.EgitmenAdı = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.EgitmenAdı = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.EgitmenAdı = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs[]kurslar = new Kurs[] { kurs1, kurs2,kurs3 };
            foreach(var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" : "+kurs.EgitmenAdı+" : "+kurs.IzlenmeOrani);
            }

        }



    }
    class Kurs
    {
        public string EgitmenAdı { get; set; }
        public string KursAdi { get; set; }
        public int IzlenmeOrani { get; set; }
    }
    
    
}