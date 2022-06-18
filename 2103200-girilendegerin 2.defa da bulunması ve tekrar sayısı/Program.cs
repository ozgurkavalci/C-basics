using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103200_girilendegerin_2.defa_da_bulunması_ve_tekrar_sayısı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lutfen bir sayı giriniz");

            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            int sayac2 = 0;
            
            
            Random ikincitekrar = new Random();


            while (sayac<2)
            {
                int randsayi = ikincitekrar.Next(1, 100);
                Console.WriteLine(randsayi);
                sayac2++;

                if (randsayi==sayi)
                {
                    sayac++;
                }
                

            }

            Console.WriteLine(sayac2+".defada bulundu");
            Console.ReadLine();
        }
    }
}
