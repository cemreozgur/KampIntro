using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#: ";
            kurs1.Egitmen = "Engin D.";
            kurs1.izlenmeOrani = 98;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java:";
            kurs2.Egitmen = "Mehmet F.";
            kurs2.izlenmeOrani = 87;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Sistem ve Network: ";
            kurs3.Egitmen = "Cemre T.";
            kurs3.izlenmeOrani = 23;


            //Console.WriteLine(kurs1.KursAdi + " "+ kurs1.Egitmen+ " "+kurs1.izlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ ":"+kurs.Egitmen);
            }



        }


    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}
