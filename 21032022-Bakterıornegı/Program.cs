using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21032022_Bakterıornegı
{
    class Program
    {
        static void Main(string[] args)
        {

            int bakteri = 1;
            

            for (int i = 4; i<=60; i+=4)
            {
                 bakteri *= 2;
            }

            Console.Write("1 saat sonraki bakteri miktarı:" + bakteri);
            Console.ReadLine();



        
        }
    }
}
