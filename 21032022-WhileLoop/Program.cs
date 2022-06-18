using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21032022_WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi = 0;
            //while (sayi<100)
            //{
            //    sayi++;
            //    Console.WriteLine("Sayı degerı:"+sayi);
            //}
            //Console.ReadLine();



            //int sayi = 0, toplam = 0;

            //while (sayi%2==0)
            //{
            //    toplam += sayi;

            //    Console.WriteLine("Bir sayı giriniz:");
            //    sayi = Convert.ToInt32(Console.ReadLine());

            //}
            //Console.WriteLine("Girilen cift sayıların toplamı :"+toplam);
            //Console.ReadLine();


            //double kira = 1000;
            //double baslangıc = 2006;
            //double bıtıs = 2022;
            //double yuzde = 0.15;


            //while (baslangıc!=2023)
            //{

            //    kira = kira + (kira * yuzde);

            //    baslangıc++;


            //}
            //Console.WriteLine("Evin 2022 yılı kirası:" +kira);
            //Console.ReadLine();







            //negatif sayı gırılence dongudakı sayıların toplamı



            
            int toplam=0;
            int sayı;
            Console.WriteLine("Lütfen bir sayı giriniz.");
            Console.WriteLine("Negatif deger girildgiğinde toplama işlemi duracaktır.");
            
            
            while (sayı>-1)
            {

                

                sayı = Convert.ToInt32(Console.ReadLine());
                toplam += sayı;

                Console.WriteLine("Girdiğiniz sayıların toplamı:" + toplam);
            }

            
            Console.ReadLine();

        }
    }
}
