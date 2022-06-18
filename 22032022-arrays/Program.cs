using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22032022_arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // dısardan gırılen 5 elemandan tek sayı olanların adetı


            ////int[] beslı = new int[5];

            ////int sayac = 0;

            ////for (int i = 0; i < 5; i++)
            ////{

            ////    Console.WriteLine("Lutfen ılk sayıyı gırınız:");
            ////    beslı[i] = Convert.ToInt32(Console.ReadLine());

            ////    if (beslı[i]%2!=0)
            ////    {
            ////        sayac++;
            ////    }
            ////}

            ////Console.WriteLine("Girdiğiniz 5 değerden "+sayac+" kadarı tek sayıdır.");
            ////Console.ReadLine();
            ///




            //-------------------------------------------
            //dizide iceriden tanımlanmıs negatif sayıları pozıtife ceviren program.


            ////int[] negatif = new int[5];
            ////negatif[0] = -15;
            ////negatif[1] = -5;
            ////negatif[2] = -1;
            ////negatif[3] = -7;
            ////negatif[4] = -11;


            ////for (int i = 0; i < 5; i++)
            ////{
            ////    negatif[i] *= -1;



            ////        Console.WriteLine("Girilen degerlerin pozitifler:"+negatif[i]);

            ////}
            ////Console.ReadLine();



            //--------------------------------
            //dısarıdan gırılen 10 elemanın ıcınden sonu 0 olanların adetını yazan program

            //int[] onelemanlı = new int[10];
            //int sayac = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Lutfen "+i +". index degerini giriniz:");
            //    onelemanlı[i] = Convert.ToInt32(Console.ReadLine());

            //    if (onelemanlı[i]%10==0)
            //    {
            //        sayac++;
            //    }
            //}
            //Console.WriteLine("Girdiğiniz 10 adet elemandan "+sayac+" kadarının sonu sıfırdır.");
            //Console.ReadLine();


            //-------------------------------------------------------------
            //dısarıdan gırılen eleman degerıne gore random(10,200) arasında fıyat atan ve fıyat 100 kucukse %2 komısyon alan
            // 100 den buyukse yuzde %5 komısyon alan ve toplam komısyonu veren program.


            //Console.WriteLine("Kac adet eleman olusturmak ıstıyorsunuz:");
            //int elemanadet = Convert.ToInt32(Console.ReadLine());

            //int[] randomdizi = new int[elemanadet];
            //Random fiyatatama = new Random();

            //int yuzaltıkomısyon = 0;
            //int yuzustukomısyon = 0;
            //int toplamkomısyon = 0;


            //for (int i = 0; i < elemanadet; i++)
            //{
            //    randomdizi[i]= fiyatatama.Next(10, 200);

            //    if (randomdizi[i]<100)
            //    {
            //        yuzaltıkomısyon+=randomdizi[i]*2/100;

            //    }
            //    else
            //    {
            //        yuzustukomısyon += randomdizi[i] * 5 / 100;

            //    }


            //}

            //Console.WriteLine("Girilen "+elemanadet+" urunden alınan toplam komısyon:"+(yuzaltıkomısyon+yuzustukomısyon));
            //Console.ReadLine();


            ////Console.WriteLine(randomdizi[i]);
            ////Console.WriteLine("yusustukomısyon:" + yuzustukomısyon);
            ///



            //---------------------------------------------
            //girilen 5 sayının karelerını ,sayıları toplamını, ve karalerı toplamını bulan program




            int[] sayılar = new int[5];

            int sayılartoplamı = 0;
            int karelertoplmaı = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Lutfen "+i +". indexe atanacak sayı degerını gırıniz:");
                sayılar[i] = Convert.ToInt32(Console.ReadLine());

                karelertoplmaı += sayılar[i] * sayılar[i];
                sayılartoplamı += sayılar[i];
                
                Console.Clear();
                Console.WriteLine(karelertoplmaı);
                for (int j =0  ; j<=i; j++)
                {
                    Console.WriteLine("Girilen sayılar:"+sayılar[j]);

                }
                
                

            }

            Console.WriteLine("girilen sayıların kareleri toplamı="+karelertoplmaı);
            Console.WriteLine("girilen sayılar toplamı:"+sayılartoplamı);
            Console.ReadLine();



        }
    }
}
