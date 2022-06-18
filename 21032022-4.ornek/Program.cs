using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21032022_4.ornek
{
    class Program
    {
        static void Main(string[] args)
        {  //  1urunekle 2zam yap   swıtcg case

            // urun ekle kac tane eklemek ıstersınız adet fıyat random vergı   toplam fıyat ve vergılı fıyat
            // 

            Console.WriteLine("******MENU******");
            Console.WriteLine("1-Urun Ekle");
            Console.WriteLine("2-Zam Yap");

            int menusecimi = Convert.ToInt32(Console.ReadLine());
            Random vergiatama = new Random();
            int vergiatama2 = vergiatama.Next(1,10);                //0,50  50 100 100 200 200 400
            int vergiatama3 = vergiatama.Next(10, 21);
            int vergiatama4 = vergiatama.Next(21, 31);
            int vergiatama5 = vergiatama.Next(31, 51);
            int vergiatama6 = vergiatama.Next(51, 151);
            int elliliralatı = 0;
            int elliyuz = 0;
            int yuzıkıyuz = 0;
            int ıkıyuzdortyuz = 0;
            int dortyuzveustu = 0;
            int vergimiktarıelli = 0;
            int vergimiktarıelliyuz = 0;
            int vergimiktarıyuzıkıyuz = 0;
            int vergimiktarııkıyuzdortuz = 0;
            int vergimiktarıdortyuzustu = 0;
            int toplamfiyat = 0;
            int toplamvergi = 0;
            


            switch (menusecimi)
            {
                case 1:
                    Console.WriteLine("Kac adet urun eklemek ıstıyorsunuz?:");
                    int ürünadeti = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <=ürünadeti; i++)
                    {
                        Console.WriteLine(i+". ürünün fiyatını giriniz");
                        int fiyat = Convert.ToInt32(Console.ReadLine());

                        if (fiyat<=50)
                        {
                            elliliralatı += fiyat;

                            vergimiktarıelli += vergiatama2;


                        }

                        else if (50<fiyat && fiyat<100)
                        {

                            elliyuz += fiyat;
                            vergimiktarıelliyuz += vergiatama3;
                        }

                        else if (100 <= fiyat && fiyat < 200)
                        {

                            yuzıkıyuz+= fiyat;
                            vergimiktarıyuzıkıyuz += vergiatama4;
                        }

                        else if (200 <=fiyat && fiyat < 400)
                        {

                            ıkıyuzdortyuz += fiyat;
                            vergimiktarııkıyuzdortuz += vergiatama4;
                        }

                        else if ( fiyat <=400 )
                        {

                            dortyuzveustu += fiyat;
                            vergimiktarıdortyuzustu += vergiatama4;
                        }


                        toplamfiyat = elliliralatı + yuzıkıyuz + ıkıyuzdortyuz + dortyuzveustu;
                        toplamvergi = vergimiktarıelli + vergimiktarıelliyuz + vergimiktarıyuzıkıyuz + vergimiktarıdortyuzustu;

                    }

                    Console.WriteLine("Girdiginiz "+ürünadeti+ "adet urunun toplam fiyati:"+toplamfiyat+" Vergi miktari:"+toplamvergi) ;
                    Console.ReadLine();



                    break;
                default:
                    break;
            }



        }
    }
}
