using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18032022_ilk_uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir komisyoncu sattıgı mallardan fiyatı 50 tl ye kadar olanlardan yuzde 3
            // daha fazla olanlarda ıse yuzde 2 komısyon almaktadır
            //klavyeden teker teker gırılen 5 malın komısyonlarını bulup ekrana yazdıran 
            //ve en sonunda toplam komısyonu da yazdıran program

            Console.WriteLine("Komısyon hesapmala programına hosgeldınız.");

           

            double sayac = 5;
            double toplamkomisyon=0 ;

            for (double i = sayac; i>=1; i--)
            {

                Console.Write("Lutfen komısyonunu hesaplamak ıstedıgınız  urunun fıyatını gırınız:");
                double fiyat = Convert.ToDouble(Console.ReadLine());
                if (fiyat<=50)
                {
                    double komisyon = 1;
                    komisyon = fiyat* 0.03;
                    
                    toplamkomisyon += komisyon;
                    Console.WriteLine(komisyon);

                }

                else
                {
                    double komisyon = 1;
                    komisyon = fiyat * 0.02;
                    
                    toplamkomisyon += komisyon;
                    Console.WriteLine(komisyon);
                }

               


            }
            Console.WriteLine("Toplam komisyon=" + toplamkomisyon);
            Console.ReadLine();



        }
    }
}
