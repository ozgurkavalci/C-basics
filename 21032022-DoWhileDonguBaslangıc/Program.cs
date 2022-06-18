using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21032022_DoWhileDonguBaslangıc
{
    class Program
    {
        static void Main(string[] args)
        {

            //DOngu ıslemını en az bır kere yapan ve belırtılen kosul saglandıgı surece calısan dongudur. While dongusunde kosul donguye gırerken k
            // kullanılıyor. Do while da kosul en sonda kullanılırç


            //int sayi = 1;
            //do
            //{
            //    Console.WriteLine(sayi);
            //} while (sayi < 1);
            //Console.ReadLine();



            //1 den 20ye kadar tek olan sayıların carpımı

            //int sayi = 0;
            //int sonuc = 1;
            //do
            //{
            //    sayi++;

            //    if (sayi%2!=0)
            //    {
            //        sonuc *= sayi;

            //    }



            //} while (sayi<=20);

            //Console.WriteLine(sonuc);

            //Console.ReadLine();



            //1 ıle 100 arasında rastgele sayı uretıp , uretılen sayı 50 olana kadar uretılen sayıları yazan program



            //Random elliyibul = new Random();

            //int elli = elliyibul.Next(1, 100);
            //int sayi = 0;


            //do
            //{

            //    elli = elliyibul.Next(1, 100);
            //    sayi = elli;



            //    Console.Write(sayi);


            //} while (sayi!=50);

            //Console.ReadLine();








            // 10 ogrencının notu alınıp ortalaması hesaplanacak

            //int ogrsayac = 0;

            //double not = 0;
            //double toplam=0;
            //double ortalama = 0;


            //do
            //{
            //    Console.Clear();
            //    ogrsayac++;

            //    Console.WriteLine("Lutfen ogrencı notunu gırınız:");

            //    not = Convert.ToDouble(Console.ReadLine());

            //    toplam+= not;


            //} while (ogrsayac<=10);

            //Console.WriteLine("Ogrencılerın not ortalamsı:"+(toplam/10)) ;
            //Console.ReadLine();







            //kullanıcı adı ve sıfre dogru ıse asagadakı yonlendırmeyı yapan ve yonlenırme ıcın ıf kousulu kullanan programı yazınız (do whıle)


            string ad = string.Empty;
            string sifre = string.Empty;



            do
            {
                Console.WriteLine("Kullanıcı adınızı gırınız:") ;
                ad = Console.ReadLine();
                Console.WriteLine("Sıfrenızı gırınız:");
                sifre = Console.ReadLine();





            } while (ad!="demo"&& sifre!="demo");







        }
    }
}
