using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Geliştirme Kampı";
            string kurs2 = "Programlamaya Giriş Temel Kurs";
            string kurs3 = "Java Kursu";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);



            string[] kurslar = new string[] { "Yazılım Geliştirici Geliştirme Kampı" , "Programlamaya Giriş Temel Kurs",
                "Java Kursu" };



            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("-----sayfa sonu--------");
        }
    }
}
