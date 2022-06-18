using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17032022.Faktorıyel
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sistem girdiginiz sayının faktöriyel degerini hesaplayacaktir.");
            Console.Write("Lutfen bir deger giriniz:");
            int faktoriyel = Convert.ToInt32(Console.ReadLine());
            int carpim = 1;

            for (int i = faktoriyel; i >=1; i--)
            {
                
                

                carpim *= i;

                

            }

            Console.WriteLine("faktoriyel=" + carpim);

            Console.ReadLine();

        }
    }
}
