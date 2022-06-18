using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23032022_Metotlar_gırıs
{
    class Program
    {


        public static void Mesaj()    //geriye deger dondurmeyen parametresiz metod.
        {

            Console.WriteLine("Hosgeldiniz .....");

        }



        public static void Gelenbilgi(int yas,string adsoyad)// geri deger döndürmeyen iki parametreli metod
        {

            if (yas>18)
            {
                Console.WriteLine(adsoyad+" sistemimize katılım kazandınız ver paraları");
            }
            else
            {
                Console.WriteLine(adsoyad+" büyüyünce gel.");
            }

        }



        static void Main(string[] args)
        {

            //Console.WriteLine("İskur oyun grubu game developers.");
            //Mesaj();
            //Console.WriteLine("Yallah işe");
            //Console.ReadLine();

            //Console.WriteLine("ad soyad giriniz:");
            //string adsoyad = Console.ReadLine();
            //Console.WriteLine("Yas giriniz:");
            //int yas = Convert.ToInt32(Console.ReadLine());
            //Gelenbilgi(yas, adsoyad);
            //Console.ReadLine();

            //Console.WriteLine("Lutfen bir sayı giriniz:");
            //int gelensayi = Convert.ToInt32(Console.ReadLine());
            //TekmiCiftmi(gelensayi);
            //Console.ReadLine();






            //Console.WriteLine("Ad ve soyadınızı giriniz:");
            //string adsoyad = Console.ReadLine();
            //Console.WriteLine("Kullanıcı adınızı giriniz:");
            //string kullanıcıAdi = Console.ReadLine();
            //Console.WriteLine("Sifrenizi giriniz:");
            //string sifre = Console.ReadLine();

            //KullanıcıGırısı(adsoyad, kullanıcıAdi, sifre);
            //Console.ReadLine();



            //--------------------------------------

            //Console.WriteLine("Lutfen bir sayı giriniz:");
            //int teksayibulan = Convert.ToInt32(Console.ReadLine());
            //TekSayi(teksayibulan);
            //Console.ReadLine();






            //------------------------------------




            Console.WriteLine("Lutfen ilk degeri giriniz:");
            int ilkdeger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lutfen ıkıncı degeri giriniz:");
            int ikincideger = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Buyuk olan deger: "+ Buyukdeger(ilkdeger, ikincideger));
            Console.ReadLine();

        }

        public static void TekmiCiftmi(int sayi)
        {
            if (sayi%2==0)
            {
                Console.WriteLine("Sayı cifttir");
            }
            else
            {
                Console.WriteLine("Sayı tektir.");
            }
        }



        public static void KullanıcıGırısı(string adsoyad, string kullanıcıadı, string sifre)
        {
           
            
            if (kullanıcıadı=="admin" && sifre=="1234")
            {
                Console.WriteLine(adsoyad+" giris basarılı");
            }
            else
            {
                Console.WriteLine(adsoyad+" kullanıcı adı veya sifre hatalı.");
            }

        
        
        }


        //-----------------------------
        // bir deger giriyoruz kac tane tek sayı varsa adetini buluyor.

        public static void TekSayi(int teksayi)
        {

            int sayac = 0;
            for (int i = 0; i <=teksayi; i++)
            {

                if (i%2!=0)
                {

                    sayac++;
                }
            }

            Console.WriteLine("Girdiginiz:"+teksayi+"degeri icinde "+sayac+" kadar tek sayı vardır.");
        }






        public static int Kareal(int sayi)
        {

            return sayi * sayi;
        
        }





        public static int Buyukdeger(int sayi1, int sayi2)
        {


            if (sayi1<sayi2)
            {
                
                return sayi2;
            }
            else
            {
                
                return sayi1;
            }
        
        }

    }
}
