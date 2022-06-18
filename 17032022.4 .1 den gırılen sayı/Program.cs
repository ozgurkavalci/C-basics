using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17032022._4._1_den_gırılen_sayı
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayac = 0;

            Console.WriteLine("Program sızın gırdıgınız deger ıle 1 arasında sayıların 7 ye bolunme kontrol,adetve toplamını hesap edecektır.");
            Console.Write("Lutfen bir deger giriniz: ");
            int hesapdegeri = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for (int i = 1; i <= hesapdegeri; i++)
            {

                if (i%7==0)
                {
                    sayac++;
                    toplam +=i;
                    Console.WriteLine(i);

                }
            }
            Console.WriteLine("1 degerile ile {0} degeri arasında 7 ye tam bolunen sayiların  adeti= {1}, toplamı={2}",hesapdegeri,sayac,toplam);
            Console.ReadLine();


        }
    }
}
