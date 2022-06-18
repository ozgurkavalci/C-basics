using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18032022_girilensayıadetikadartoplama
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1 den girilen sayı degerıne kadar toplamı hesaplayan program");

            Console.WriteLine("Lutfen bir sayi giriniz: ");
            int sayideger = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for (int i = sayideger; i>=1; i--)
            {

               toplam+=i;

            }

            Console.WriteLine("Toplam deger= "+toplam);
            Console.ReadLine();

        }
    }
}
