using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.girilensayıtekmiciftmi
{
    class Program
    {
        static void Main(string[] args)
        {

            //gırılen sayı tek mı cıft mı


            //Console.WriteLine("Bır sayı gırınız:");

            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi%2==0)
            //{
            //    Console.WriteLine("Gırılen sayı cıfttır.");
            //}
            //else
            //{
            //    Console.WriteLine("Gırılen sayı tektır.");
            //}
            //Console.ReadLine();

            //yası 20 den buyuk olanlar askere gıdebılır olmayanlar gıdemez yazsısı alsın

            //Console.Write("Lutfen yasınızı gırınız: ");

            //int askeryas = Convert.ToInt32(Console.ReadLine());

            //if (askeryas>=20)
            //{
            //    Console.WriteLine("Askere gıdebılırsınız.");
            //}
            //else
            //{
            //    Console.WriteLine("Askere gıdemezsınız.");
            //}
            //Console.ReadLine();


            //git:
            //Console.Write("Kullanıcı adınızı gırınız: ");
            //string kullanıcadi = Console.ReadLine();

            //Console.Write("Sıfrenızı gırınız:");
            //int kullanıcısifre = Convert.ToInt32(Console.ReadLine());

            //if (kullanıcadi=="admin" && kullanıcısifre==1234)
            //{
            //    Console.WriteLine("basarılı gırıs");
            //}
            //else
            //{
            //    Console.WriteLine("Basarısız gırıs.Tekrar deneyınız");
            //    Console.Write("Tekrar denemek ister misiniz<e/h>");
            //    char cevap = Convert.ToChar(Console.ReadLine());
            //    if (cevap =='E' || cevap=='e')
            //    {
            //        Console.Clear();
            //        goto git;    //dongu mantıgında ıstedıgımız yere yonlendırme yapar
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hoscakalın");
            //        Console.ReadLine();

            //        Environment.Exit(0);            // uygulamayı kapatır
            //    }
            //}

            //Console.ReadLine();



            // tc kımlık no al
            //eger dogru ıse emeklılık yası ve mezunıyet  ıste (yas 65 mezunıyet lısans)  emeklı olabılrısınız 
            // olamazsın


            //

            Console.Write("Tc nonuzu gırınız: ");
            string tcno = Console.ReadLine();

            if (tcno=="1234")
            {

                Console.Write("Yasınız 65 veya daha buyukmmu ?<e/h>");
                char Yas = Convert.ToChar(Console.ReadLine());

                Console.Write("Lisans mezunu musunuz ?<e/h>");
                char Lisans = Convert.ToChar(Console.ReadLine());

                if (Yas=='e' || Yas=='E' && Lisans=='e' || Lisans=='E')
                {

                    Console.WriteLine("Emekli olabilirsiniz");
                }

                else
                {
                    Console.WriteLine("Emekli olamazsınız.");
                    
                }

            }

            Console.ReadLine();
           
        }
    }
}
