using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23032022_baslangic
{
    class Program
    {
        static void Main(string[] args)
        {

            

            int uzunluk = 0;
            int indis = 0;
            string enuzun = "";
            string[] dizi = new string[10];


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. elemanı giriniz :",i);
                dizi[i] = Convert.ToString(Console.ReadLine());

                if (dizi[i].Length>uzunluk)
                {

                    uzunluk = dizi[i].Length;
                    enuzun = dizi[i];
                    indis = i;

                }
            }


            Console.WriteLine("En uzun metın:"+enuzun);
            Console.WriteLine("en uzun metnin indisi:"+indis);
            Console.WriteLine("En uzun metnin karekter sayısı:"+uzunluk);

            Console.ReadLine();


        }
    }
}
