using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22032022_arraysornekleredevamm
{
    class Program
    {
        static void Main(string[] args)
        {

            //gırılen 10 urunden fıyatı2 basamaklı olanlara yuzde  20 zam, 3 basamaklıysa yuzde 50 zam

            //int[] zam = new int[10];
            //int yuzdenkucukzam = 0;
            //int yuzdenbuyukzam = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Lutfen bir ürün fiyatı giriniz:");
            //    zam[i] = Convert.ToInt32(Console.ReadLine());

            //    if (zam[i]<100)
            //    {
            //        yuzdenkucukzam += zam[i] * 20 / 100;
            //    }

            //    if (zam[i]>100)
            //    {
            //        yuzdenbuyukzam += zam[i] * 50 / 100;
            //    }
            //}

            //Console.WriteLine("100 lira altındaki ürün zammı:"+yuzdenkucukzam+" , 100 lira ustundeki urun zammı:"+yuzdenbuyukzam);
            //Console.ReadLine();



            string[] isimler = { "ozgur", "fatih", "derya", "samet", "nihal", "ahmet","banane" };
            string giris = string.Empty;


            for (int i = 0; i <= 0; i++)
            {
                Console.WriteLine("Lutfen bir isin giriniz:");
                giris = Console.ReadLine();


                for (int j = 0; j < 7; j++)
                {
                    if (giris== isimler[j])
                    {
                        Console.WriteLine("Girdiginiz :"+giris+" degeri"+ "listede "+j+". indextedir.");
                    }
                }
                

            }
            Console.ReadLine();

        }

    }
}
