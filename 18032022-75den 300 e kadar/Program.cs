using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18032022_75den_300_e_kadar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sıstem 75 ile 300 arasıdakı sayıların sızın ıstedıgınız sayıya bolunme kontrolunu ve adetını hesaplayacaktır.");

            Console.WriteLine("Lutfen bolunme kontrolu yapmak ıstedıgınız sayıyı gırınız: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;

            for (int i = 75; i <= 300; i++)
            {

                if (i%sayi==0)
                {

                    sayac++;
                }

            }

            Console.WriteLine(sayi+" ya bolunnen sayı adeti="+sayac);

            Console.ReadLine();
        }
    }
}
