using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 12;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "cilek";
            urun2.Fiyati = 18;
            urun2.Aciklama = "kıpkırmızı";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");



            }


            Console.WriteLine("---------Metotlar--------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "cok iyi", 12,9);
            sepetManager.Ekle2("elma", " iyi", 10,4);
            sepetManager.Ekle2("karpuz", "cok iyi değil", 19,5);



        }
    }
}
