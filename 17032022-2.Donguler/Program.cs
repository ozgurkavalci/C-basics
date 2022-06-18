using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17032022_2.Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            //int i;
            //for ( i = 100; i >=0 ; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //for (int sayac = 0; sayac<=100; sayac++)
            //{
            //    Console.WriteLine(sayac);
            //}




            //1 den 100 e kadar cift sayiların toplamını bulan program

            //int toplam=0;
            //int cift = 0;

            //for ( cift = 0; cift <=100; cift++)
            //{
            //    if (cift%2==0)
            //    {  
            //        toplam = toplam + cift;

            //        Console.WriteLine("Cift sayi={0},",cift);
            //    }

            //}

            //Console.WriteLine("Toplam sonucu= " + toplam);
            //Console.ReadLine();


            Console.WriteLine("Lutfen ıslem yapmak ıstedgınız sayı degerını gırınız: ");
            int tekmiciftmi = Convert.ToInt32(Console.ReadLine());
            int tektoplam = 0;
            int cifttoplam = 0;

            for (int i = 0; i <= tekmiciftmi; i++)
            {

                if (i % 2 == 0)
                {

                    Console.WriteLine("Çift sayı= " + i);
                    cifttoplam = cifttoplam + i;

                }



                else
                {
                    Console.WriteLine("Tek sayı=" + i);
                    tektoplam = tektoplam + i;
                }
            }

            Console.WriteLine("Cift sayıların toplamı=" + cifttoplam);
            Console.WriteLine("Tek sayıların toplamı=" + tektoplam);
            Console.ReadLine();


            int toplam100200 = 0;
            for (int i = 100; i <= 200; i+=5)
            {
                toplam100200 += i;

            }
            Console.WriteLine(toplam100200);
            Console.ReadLine();

        }
    }
}
