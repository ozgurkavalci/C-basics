using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16032022_ılk
{
    class Program
    {
        static void Main(string[] args)
        {
            //+ toplama
            //- cıkarma
            //* carpma
            //bolme
            //%mod alma


            Console.WriteLine("sıstem sectıgınız ıslemı yaoacaktır.");

            Console.WriteLine("'+' ıfadesı ıle toplama:");
            Console.WriteLine("'-' ıfadesı ıle cıkartma:");
            Console.WriteLine("'*' ıfadesı ıle carpma:");
            Console.WriteLine("'/' ıfadesı ıle bolme:");
            Console.WriteLine("'%' ıfadesı ıle mod alma:");

            git:

            Console.Write("Islem yapmak ıstedıgınız ılk sayıyı gırınız: ");

            int ilksayi = Convert.ToInt32(Console.ReadLine());

            Console.Write("yapmak ıstedıgınız ıslemı gırnız:");

            char ıslem = Convert.ToChar(Console.ReadLine());



            Console.Write("Islem yapmak ıstedıgınız ıkıncı sayıyı gırınız: ");

            int ikincisayi= Convert.ToInt32(Console.ReadLine());

            int sonuc;
            if (ıslem=='+')
            {
                sonuc = ilksayi + ikincisayi;

                Console.WriteLine(sonuc);

                Console.WriteLine("Yeni bir islem yapmak ister misiniz? <e/h>");

                char yanit = Convert.ToChar(Console.ReadLine());

                if (yanit=='e' || yanit=='E')
                {
                    goto git;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else if (ıslem=='-')
            {
                sonuc = ilksayi - ikincisayi;

                Console.WriteLine(sonuc);

                Console.WriteLine("Yeni bir islem yapmak ister misiniz? <e/h>");

                char yanit = Convert.ToChar(Console.ReadLine());

                if (yanit == 'e' || yanit == 'E')
                {
                    goto git;
                }

                else
                {
                    Environment.Exit(0);
                }

            }
            else if (ıslem=='*')
            {
                sonuc = ilksayi * ikincisayi;
                Console.WriteLine(sonuc);
                Console.WriteLine("Yeni bir islem yapmak ister misiniz? <e/h>");

                char yanit = Convert.ToChar(Console.ReadLine());

                if (yanit == 'e' || yanit == 'E')
                {
                    goto git;
                }

                else
                {
                    Environment.Exit(0);
                }
            }
            else if (ıslem=='/')
            {
                sonuc = ilksayi / ikincisayi;
                Console.WriteLine(sonuc);
                Console.WriteLine("Yeni bir islem yapmak ister misiniz? <e/h>");

                char yanit = Convert.ToChar(Console.ReadLine());

                if (yanit == 'e' || yanit == 'E')
                {
                    goto git;
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            else
            {
                sonuc = ilksayi % ikincisayi;
                Console.WriteLine(sonuc);
                Console.WriteLine("Yeni bir islem yapmak ister misiniz? <e/h>");

                char yanit = Convert.ToChar(Console.ReadLine());

                if (yanit == 'e' || yanit == 'E')
                {
                    goto git;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            Console.ReadLine();
        }
    }
}
                                   