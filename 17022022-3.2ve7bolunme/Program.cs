using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17022022_3._2ve7bolunme
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Islemin yapılacagı baslangıc degerini giriniz: ");
            int baslangic = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Islemın yapılacagı bıtıs degerını gırınız: ");
            int bitis = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            int toplam = 0;
            for (int i = baslangic; i <=bitis; i++)
            {


                if (i%2==0 || i%7==0)
                {
                    sayac++;

                    toplam += i;

                    
                }
            }
            Console.WriteLine("{0} ve{1}arasındaki degerlerden 2 ye ve ya 7 bolunenlerin toplamı= {2}, adedi= {3}", baslangic, bitis, toplam, sayac);

            Console.ReadLine();
        }
    }
}
