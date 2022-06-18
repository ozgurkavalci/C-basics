using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17032022_Baslangıc
{
    class Program
    {
        static void Main(string[] args)
        {

            //

            Console.WriteLine("Maas ve prim hesaplama sistemine hosgeldiniz.");
            Console.Write("Lutfen maas miktarınızı giriniz:");

            int maas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Urettiginiz parca miktarını giriniz: ");

            int parca = Convert.ToInt32(Console.ReadLine());
            if (10<=parca && parca<=25)
            {

                Random parcabası = new Random();
                int parcamiktarı = parcabası.Next(10, 21);

                int ücret = maas + parca * parcamiktarı;

                Console.WriteLine("Alacagınız toplam ucret= "+ücret);
            }


            else if (26<=parca && parca<=40)
            {
                Random parcabası = new Random();
                int parcamiktarı = parcabası.Next(20, 26);

                int ücret = maas + parca * parcamiktarı;

                Console.WriteLine("Alacagınız toplam ucret= " + ücret);
            }

            else if ( parca > 40)
            {

                Random parcabası = new Random();
                int parcamiktarı = parcabası.Next(50, 101);

                int ücret = maas + parca * parcamiktarı;

                Console.WriteLine("Alacagınız toplam ucret= " + ücret);

            }

            else
            {
                Console.WriteLine("Hatalı giris yaptınız.");
            }

            Console.ReadLine();
        }
    }
}
