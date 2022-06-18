using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18032022_10sayıyı_toplayıp_5.bolen_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 1;
            int toplam = 0;
            int bes = 0;
            int sayi = 0;
            
            for (int i = 1; i <=10; i++)
            {

                Console.WriteLine("Lutfen bir deger giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                
                if (i==5)
                {
                    bes = sayi;
                }


                toplam += sayi;
                
            }

            Console.WriteLine(toplam/bes);
            Console.ReadLine();
        }
    }
}
