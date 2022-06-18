using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23032022_Kur_hesabı_metord
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kur hesabı programına hosgeldiniz.");
            Console.WriteLine("Lütfen kac tl nin degerini görmek istiyorsanız giriniz:");
            double Tl = Convert.ToDouble(Console.ReadLine());    
            sterlin(Tl);

            Console.ReadLine();
        }

        public static void sterlin(double sterlin)
        {

            double sterlin1= sterlin / 20;
            double sterlin2 = sterlin / 15;
            double sterlin3 = sterlin / 17;
            double sterlin4 = sterlin / 1500;

            Console.WriteLine("Girdiginiz " + sterlin + " Tl nin pound karsiligi:" + sterlin1);
            Console.WriteLine("Girdiginiz " + sterlin + " Tl nin dolar karsiligi:" + sterlin2);
            Console.WriteLine("Girdiginiz " + sterlin + " Tl nin euro karsiligi:" + sterlin3);
            Console.WriteLine("Girdiginiz " + sterlin + " Tl nin altin karsiligi:" + sterlin4+" gramdir.");


        }


        public static double dolar(double dolar)
        {

            dolar = dolar / 15;
            return dolar;


        }



        public static double euro(double euro)
        {

            euro = euro / 20;
            return euro;


        }


        public static double altin(double altin)
        {

            altin = altin / 1500;
            return altin;


        }
    }




}
