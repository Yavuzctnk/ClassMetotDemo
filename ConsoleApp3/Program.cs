namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriAdi = "Yavuz Çetinkaya";
            musteri1.musteriTc = 123456789;
            musteri1.krediNotu = 4;

            Musteri musteri2 = new Musteri();
            musteri2.musteriAdi = "Çağatay Arı";
            musteri2.musteriTc = 126231465;
            musteri2.krediNotu = 3;

            Musteri musteri3 = new Musteri();
            musteri3.musteriAdi = "Mustafa Küçüköksüz";
            musteri3.musteriTc = 646543217;
            musteri3.krediNotu = 7;

            Musteri musteri4 = new Musteri();
            musteri4.musteriAdi = "Yusuf Aslan";
            musteri4.musteriTc = 654653415;
            musteri4.krediNotu = 9;

            string[] musteriAdi = new string[4] { "Yavuz Çetinkaya", "Çağatay Arı", "Mustafa Küçüköksüz", "Yusuf Aslan" };
            double[] musteriKN = new double[4] { 3.89, 7.57, 2.61, 9.97 };
            int[] musteriTc = new int[4] { 123456789, 126231465, 646543217, 654653415 };

            int a = 0;

            while (true)
            {
                if (musteriKN[a] < 5)
                {
                    Console.WriteLine("Sayın" + " " + musteriAdi[a] + " " + "Üzgünüz Kredi Almaya Uygun Değilsiniz");
                    a++;



                }
                else if (musteriKN[a] == 5)
                {
                    Console.WriteLine("Sayın" + " " + musteriAdi[a] + " " + "Tebrikler Kredi Başvurusu Yapabilirsiniz");
                    a++;
                    MusteriMeneger musteriMeneger = new MusteriMeneger();
                    musteriMeneger.Ekle2();

                }


                else
                {
                    Console.WriteLine("Sayın" + " " + musteriAdi[a] + " " + "Tebrikler Kredi Başvurusu yapabilirsiniz");
                    a++;
                    MusteriMeneger musteriMeneger = new MusteriMeneger();
                    musteriMeneger.Ekle2();
                }
            }
        }
    }
}
  
