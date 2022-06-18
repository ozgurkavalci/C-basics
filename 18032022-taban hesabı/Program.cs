using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18032022_taban_hesabı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uslu degerler hesaplayan programa hosgeldiniz");

            Console.WriteLine("Lutfen taban degerını gırınız:");
            int taban = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lutfen us degerini giriniz:");
            int üs = Convert.ToInt32(Console.ReadLine());
            int sonuc = 1;

            for (int i = 0; i< üs; i++)
            {

                sonuc *= taban;
            }

            Console.WriteLine(sonuc);
            Console.ReadLine();

        }
    }
}
