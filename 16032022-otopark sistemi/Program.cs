using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16032022_otopark_sistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abonelık ucret tarıfısıne hosgeldınız");
            Console.Write("Abonelıgınız var mı? <e/h>");
            char yanıt = Convert.ToChar(Console.ReadLine());
            Console.Write("Aracınız kalacagı sureyı gırınız:");
            int saat = Convert.ToInt32(Console.ReadLine());



            if (yanıt=='e' || yanıt=='E')
            {
                

                if (saat<=2)
                {
                    Console.WriteLine("Odemenız gereken ucret 10 tl");
                }
                else if (saat<2 && saat<8)
                {
                    Console.WriteLine("Odemenız gereken ucret 20 Tl");
                }

                else
                {
                    Console.WriteLine("Odemenız gerken ucret 40 tldır");
                }
            }

            else
            {

                if (saat <= 2)
                {
                    Console.WriteLine("Odemenız gereken ucret 20 tl");
                }
                else if (saat < 2 && saat < 8)
                {
                    Console.WriteLine("Odemenız gereken ucret 40 Tl");
                }

                else
                {
                    Console.WriteLine("Odemenız gerken ucret 60 Tldır");
                }



            }
            Console.ReadLine();


        }
    }
}
