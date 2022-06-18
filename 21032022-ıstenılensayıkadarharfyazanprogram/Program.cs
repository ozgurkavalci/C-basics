using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21032022_ıstenılensayıkadarharfyazanprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            //  random istenilen sayı kadar harf yazan program


            string harf = "abcdefghijklmnoprestuvyz";
            string uret = "";
            int sayi;
            Random rastgele = new Random();

            Console.WriteLine("Kac harflı olmasını ıstersınız:");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                uret += harf[rastgele.Next(harf.Length)];

            }

            Console.WriteLine("Uretılen harfler:"+uret);
            Console.ReadLine();
        }
    }
}
