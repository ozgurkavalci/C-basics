using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22032022_Diziler_Arrays_
{
    class Program
    {
        static void Main(string[] args)
        {

            ////int[] sayilar = new int[5];

            ////sayilar[1] = 12;
            ////sayilar[3] = 4;
            ////sayilar[4]= 11;

            ////for (int i = 4; i >= 0; i--)
            ////{
            ////    Console.WriteLine("Dizinin degerleri:" + sayilar[i]);
            ////}
            ////Console.ReadLine();



            //foreach (int item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();


            //-------------------------------------

            //string[] isimler = { "nihos", "pek", "hos" };

            //foreach (string item in isimler)
            //{
            //    Console.WriteLine("isimler:"+item);
            //}

            //Console.ReadLine();


            //-----------------------------------------------------


            ////int toplam = 0;
            ////Console.WriteLine("Dizimiz kac elemanlı olsun");
            ////int a = Convert.ToInt32(Console.ReadLine());
            ////int[] sayi = new int[a];

            ////for (int i = 0; i < a; i++)
            ////{

            ////    Console.Write("Dizinin "+i+". elemanını giriniz:");
            ////    sayi[i] = Convert.ToInt32(Console.ReadLine());
            ////    toplam += sayi[i];

            ////}
            ////Console.WriteLine("Dizideki elemannların toplamı:"+toplam);

            ////Console.ReadLine();


            //-----------------------------------------------------


            //5 deger alıyoruz yazdırıyoruz.



            //Console.WriteLine("Kac elamanlı bır dızı olusturmak ıstıyorsunuz:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //string[] kullanıcı = new string[a];
            //string sonisimler = string.Empty;

            //for (int i = 0; i < a; i++)
            //{
            //    Console.Write("Lutfen "+i+". indekse atanacak ismi giriniz:");

            //    kullanıcı[i] = Console.ReadLine();

            //    sonisimler += kullanıcı[i] + " ,";

            //}
            //Console.WriteLine("Girilen isimler:"+sonisimler);
            //Console.ReadLine();






            Console.WriteLine("Kac elamanlı bır dızı olusturmak ıstıyorsunuz:");
            int a = Convert.ToInt32(Console.ReadLine());
            string[] kullanıcı = new string[a];
            string sonisimler = string.Empty;

            for (int i = 0; i < a; i++)
            {
                Console.Write("Lutfen " + i + ". indekse atanacak ismi giriniz:");

                kullanıcı[i] = Console.ReadLine();

                foreach (string item in kullanıcı)
                {
                    Console.WriteLine(item);
                }
                

            }

            Console.ReadLine();
        }   
               
    }


}
