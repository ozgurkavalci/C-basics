using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22032022_arrayornekleredevam
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] onelemanlı = new int[10];

            //Random sayıat = new Random();
            //int negatifsay = 0;
            //int pozsay = 0;
            //int sıfırsay = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    onelemanlı[i] = sayıat.Next(-50, 50);

            //    if (onelemanlı[i]<0)
            //    {
            //        negatifsay++;
            //    }
            //    else if (onelemanlı[i]>0)
            //    {
            //        pozsay++;
            //    }
            //    else
            //    {
            //        sıfırsay++;
            //    }
            //    Console.WriteLine("Dizinin "+i+". indexe atanan elemanı:"+onelemanlı[i]);
            //}

            //Console.WriteLine("Pozitif sayi adedi:"+pozsay);
            //Console.WriteLine("Negatif sayi adedi:"+negatifsay);
            //Console.WriteLine("İsaretsız sayı adedi:"+sıfırsay);
            //Console.ReadLine();



            //int[] onelamanlı = new int[10];

            //Random sayıat = new Random();
            //int gelensayi = 0;
            //int ellidenkucuk = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    gelensayi= sayıat.Next(10, 100);
            //    if (gelensayi%2==0)
            //    {


            //        onelamanlı[i] = gelensayi;

            //        i++;

            //        if (onelamanlı[i] < 50)
            //        {
            //            ellidenkucuk++;
            //            Console.WriteLine(onelamanlı[i]);
            //        }


            //    }



            //}

            //Console.WriteLine("Elliden kucuk sayı adeti:"+ellidenkucuk);
            //Console.ReadLine();



            Console.WriteLine("Kac elemanlı bır dızı olusturmak ıstersınız:");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] tekcift = new int[a];

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Lutfen "+i+". indexe atanacak degeri giriniz:");
                tekcift[i] = Convert.ToInt32(Console.ReadLine());

                
            }

            for (int i = 0; i<a ; i++)
            {

                if (tekcift[i]%2!=0)
                {
                    Console.WriteLine(tekcift[i]);
                    Console.WriteLine();
                }
                
                
            }
            

            for (int i = 0; i<a ; i++)
            {
                if (tekcift[i]%2==0)
                {
                    Console.WriteLine(tekcift[i]);
                }
                
            }
            Console.ReadLine();
        }
    }
}
