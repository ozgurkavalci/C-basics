using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemeforfor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir deger giriniz:");
            int deger = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <=deger ; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
