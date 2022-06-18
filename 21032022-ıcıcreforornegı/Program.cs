using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21032022_ıcıcreforornegı
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bır metın giriniz:");
            string metin = Console.ReadLine();

            for (int i = 0; i < metin.Length; i++)
            {

                if (i==(metin.Length-1))
                {
                    Console.Write(metin[i]);
                }

                else
                {
                    Console.Write(metin[i]+"-");
                }
                

               

            }

            Console.ReadLine();
        }
    }
}
