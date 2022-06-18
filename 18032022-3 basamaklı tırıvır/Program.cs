using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18032022_3_basamaklı_tırıvır
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Degısık davranan programa hosgeldiniz.");

            int sayac = 2;
            int toplam = 0;
            int ücbasamaklıadeti = 0;

            for (int i = sayac; i >= 1; i--)
            {


                Console.Write("Lutfen Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi>=100)
                {
                   

                    ücbasamaklıadeti++;

                }

                else
                {
                    
                    toplam += sayi;

                }


            }

            Console.WriteLine("Girdiginiz 2 basamaklı sayıların toplamı={0}, digerlerinin adeti={1}", toplam, ücbasamaklıadeti);
            Console.ReadLine();

        }
    }
}
