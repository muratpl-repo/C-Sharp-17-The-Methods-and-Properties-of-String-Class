using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58DersStringlerinOzellikleriVeMetotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = "Kaan Academy";
            Console.WriteLine(isim.Length);                 //Stringin elaman sayisi
            Console.WriteLine(isim.IndexOf('y'));           //Stringin herhangi bir karakterinin indexi
            isim = isim.Insert(0, "Fatih ");                //Stringin 0. indisine Fatih kelimesini ekledi
            Console.WriteLine(isim);
            isim = isim.Replace("Fatih","Mehmet");          //Stringteki 'Fatih' kelimelerini 'Mehmet ile degistirdi'
            Console.WriteLine(isim);
            Console.WriteLine(isim.Contains("Mehmet"));     //Mehmet ifadesini iceriyorsa True dondurur.(bool)
            Console.WriteLine(isim.Remove(0,7));            //İki indis arasindaki degerleri siler
            Console.WriteLine(isim.Substring(0,7));         //İki indis arasindaki degerleri alir.
        }   
    }
}
