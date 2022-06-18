using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21032022_10_ıle250_arasındakı_10_cıft_sayı
{
    class Program
    {
        static void Main(string[] args)
        {

            Random ciftatar = new Random();
            int toplam = 0;
            int sayi;
            int sayac = 0;

            while (sayac<=9)
            {

                
                sayi= ciftatar.Next(10, 250);

                if (sayi%2==0)
                {
                    Console.WriteLine(sayi);
                    sayac++;
                }

               

            }

            Console.ReadLine();
        }
    }
}
