using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16032022switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            //if elseif
            //switch kullanımı


            Console.WriteLine("Burcunuzun elementini giriniz");

            string element = Console.ReadLine();

            switch (element)
            {
                case "ates":
                Console.WriteLine("ates grubu koc,yay,aslandır");
                    
                    break;

                case "toprak":
                    Console.WriteLine("toprak grubu ");
                    break;

                case "hava":
                    Console.WriteLine("hava grubu ");
                    break;

                default:
                    Console.WriteLine("Tekrar deneyınız yanlıs gırdınız");
                    break;

                   
            }
            Console.ReadLine();

        }
    }
}
