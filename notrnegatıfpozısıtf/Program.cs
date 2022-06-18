using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notrnegatıfpozısıtf
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Sıstem gırdıgınız sayı notr ,nefatif veya pozıtif mi degerlendirmesi yapacaktir");

            Console.Write("Bir deger giriniz:");

            int deger = Convert.ToInt32(Console.ReadLine());

            if (deger == 0)
            {
                Console.WriteLine("gırılen deger notrdur");
            }

            else if (deger > 0)
            {
                Console.WriteLine("gırılen deger pozıtıftır");

            }
            else
            {
                Console.WriteLine("gırılen deger negatiftir");
            }

            Console.ReadLine();




            Console.WriteLine("Gectı mı kaldı mı sıstemıne hosgeldınız");

            Console.WriteLine("Lutfen vize notunuzu giriniz: ");

            double vize = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Lutfen fınal notunuzu gırınız: ");

            double final = Convert.ToDouble(Console.ReadLine());


            double formul = vize * 0.4 + final * 0.6;

            if (formul>=50)
            {
                Console.WriteLine("Ortalamanız " + formul + "tebrikler , geçtiniz");

            }
            else
            {
                Console.WriteLine("Ortalamanız " + formul + "ne yazık kı kaldınız");

            }
            Console.ReadLine();








        }    


    }
}
