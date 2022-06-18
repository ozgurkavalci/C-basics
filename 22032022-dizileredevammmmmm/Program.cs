using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22032022_dizileredevammmmmm
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] benzersiz = new int[15];

            Random sayıgelsın = new Random();

            int aracı = 0;


            for (int i = 0; i < 15; i++)
            {


                aracı = sayıgelsın.Next(1, 50);

                benzersiz[i] = aracı;




            }

        }
    }
}
