using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Cemre","Ali","Cihan","Mine"};
            //System.Console.WriteLine(isimler[0]);
            //System.Console.WriteLine(isimler[1]);
            //System.Console.WriteLine(isimler[2]);
            //System.Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "Mete";
            //System.Console.WriteLine(isimler[4]);
            //System.Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Cemre", "Ali", "Cihan", "Mine" };

            System.Console.WriteLine(isimler2[0]);
            System.Console.WriteLine(isimler2[1]);
            System.Console.WriteLine(isimler2[2]);
            System.Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            System.Console.WriteLine(isimler2[4]);
            System.Console.WriteLine(isimler2[0]);

            
        }
    }
}
