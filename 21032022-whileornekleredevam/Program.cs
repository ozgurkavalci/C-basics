using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21032022_whileornekleredevam
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sayılar = new Random();

            

            int sayac=0;
            int tekve3sayac = 0;
            int randomgelencarpım = 1;

            while (sayac<10)
            {
                int randomgelen = sayılar.Next(1, 11);

                if (randomgelen%2!=0 && randomgelen%3==0)
                {
                    tekve3sayac++;
                }

                else
                {
                    randomgelencarpım *= randomgelen;
                }


                sayac++;
            }

            Console.WriteLine(tekve3sayac);
            Console.WriteLine(randomgelencarpım);
            Console.ReadLine();
        }
    }
}
