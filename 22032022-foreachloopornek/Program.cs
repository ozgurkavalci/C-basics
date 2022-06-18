using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22032022_foreachloopornek
{
    class Program
    {
        static void Main(string[] args)
        {
            //string harf = "afrtyrtytr";
            //string rakam = "0123";


            //foreach (char karakter in harf)
            //{
            //    Console.WriteLine(karakter);
            //    Console.ReadKey();
            //}

            //foreach (char  rakamlar in rakam)
            //{
            //    Console.WriteLine(rakamlar);

            //    Console.ReadKey();
            //}




            //-------------------------------------



            //string sesliharf = "aeıioöuü";
            //int sayac = 0;

            //Console.Write("Bir metin giriniz:");
            //string metin = Console.ReadLine();
            //foreach (char  karakter in metin)
            //{
            //    foreach (char  sesli in sesliharf)
            //    {

            //        if (karakter==sesli)
            //        {
            //            sayac++;
            //        }

            //    }

            //}

            //Console.WriteLine("Metin uzunlugu:" +metin.Length);
            //Console.WriteLine("Metindeki  sesli harf sayısı:"+sayac);
            //Console.ReadLine();



            string sesliharf = "aeıioöuü";
            string sessizharf = "qwrtypğsdfghjklşzxcvbnmç";
            int sayacsesli = 0;
            int sayacsessiz = 0;
            int rakammm = 0;

            string rakamlar = "0123456789";


            


            Console.WriteLine("Kafanıza gore yazın nasıl olsa hesaplıyo:");

            string kullanıcıgiris = Console.ReadLine();

            foreach (char karakter in kullanıcıgiris)
            {

                foreach (char sesli in sesliharf)
                {
                    if (karakter==sesli)
                    {
                        sayacsesli ++;
                    }
                }

                foreach (char sessiz in sessizharf)
                {
                    if (karakter==sessiz)
                    {
                        sayacsessiz++;
                    }
                }

                foreach (char rakam in rakamlar)
                {
                    if (rakam==karakter)
                    {
                        rakammm++;
                    }
                }
            }

            Console.WriteLine("Metin uzunlugu:"+kullanıcıgiris.Length);
            Console.WriteLine("Sesi harf sayısı:"+sayacsesli) ;
            Console.WriteLine("Sessiz harf sayısı:"+sayacsessiz);
            Console.WriteLine("Rakam sayısı:"+rakammm);
            Console.WriteLine("Ozel karakter sayısı"+(kullanıcıgiris.Length-sayacsesli-sayacsessiz-rakammm));
            Console.ReadLine();

        }
    }
}
