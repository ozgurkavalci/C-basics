using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayıtahmını
{
    class Program
    {
        static void Main(string[] args)
        {

            Random sayi = new Random();

            int rastgele = sayi.Next(1, 7);

            int sayac = 0;
            Console.WriteLine("Sistem 1 ıle 7 arsında bır degerı sectı");
            
            git:

            Console.Write("Bır deger gırınız: ");

            int x = Convert.ToInt32(Console.ReadLine());

            sayac++;

            if (rastgele==x)
            {
                Console.WriteLine(sayac + ". denemenızde " + rastgele + "degerını dogru tahmın ettınız");
            }

            else if (rastgele>x)
            {

                Console.WriteLine("daha buyuk bır deger gırınız");
                goto git;


            }

            else
            {
                Console.WriteLine("daha kucuk bır deger gırınız");
                goto git;
            }

            Console.ReadLine();
        }
    }
}
