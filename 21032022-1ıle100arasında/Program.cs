using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21032022_1ıle100arasında
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            int toplam = 0;

            Random bırıleyuz = new Random();

            while (toplam<=1000)
            {

                sayi = bırıleyuz.Next(1, 100);


                if (sayi%5==0)
                {

                    Console.WriteLine(sayi);
                    toplam += sayi;

                }

            }
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}
