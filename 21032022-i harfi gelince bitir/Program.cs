using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21032022_i_harfi_gelince_bitir
{
    class Program
    {
        static void Main(string[] args)
        {

            string harf = string.Empty;
            string enson = string.Empty;

            while (true)
            {
                Console.Clear();
                Console.Write("Lutfen bir harf giriniz:");
                harf = Console.ReadLine();
                enson += harf;
                if (harf == "i")
                {
                    break;

                    
                }

                
            }

            Console.Write("Girmıs oldugunuz metin:" + enson);
            Console.ReadLine();
        }
    }
}
