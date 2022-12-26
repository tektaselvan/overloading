using System;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Overloading
            //out parametreler

            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outsayi);


            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outsayi);
            }
            else
            {
                Console.WriteLine("Başarız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int ToplamSonucu);
            Console.WriteLine(ToplamSonucu);

            //Metot aşırı yükleme - Overloading
            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Elvan" + "Tektaş");

        }

    }
    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);

        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);

        }
        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);

        }

    }
}
