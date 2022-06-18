using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23032022_metod2
{
    class Program
    {

        public static bool Islemcevap()
        {



            return true;
           
        
        
        }










        public static int Fatura(int fiyat, int kdv)
        {

            fiyat += fiyat * kdv / 100;
            fiyat=Indirim(fiyat);
            return fiyat;

        
        
        
        
        }


        public static int Indirim(int fatura)
        {
            Console.WriteLine("İndirim miktarını gir:");
            int ifiyat = Convert.ToInt32(Console.ReadLine());

            fatura -= ifiyat;
            return fatura;
        
        }

        public static void HediyeCeki()
        {

            Console.WriteLine("Hediye cekiniz var mı?");
            string cvp = Console.ReadLine();
            if (cvp.ToLower()=="evet")
            {
                Console.WriteLine("Karaca nevresim takımında 100 tl indirim kazanabilirsiniz kaçırmayın.");
            }
            else
            {
                Console.WriteLine("2500 tl üzerinde alışveriş yapanlara 200 Tl hediye çekilişi var sende katıl....");
            }
        
        }



        static void Main(string[] args)
        {

            Console.WriteLine("*******ÖZ ZÜCCACİYE********");
            anamenü:
            Console.WriteLine("1-Nevresim Takımı");
            Console.WriteLine("2-Bardak-Çanak");
            Console.WriteLine("3-Ev Aletleri");

            //3- uncu secenege 
            //1- mUtfak aletleri --> fiyat eger 500 v 750 arasında ise yüzde 5 zam , 750 fazla ise %10 zam yapacaksın.
            //2-kücük ev aletleri--->    fiyat+%5 ötv+kurulumücreti hesapla
            Console.WriteLine("Ürün Seçiniz");
            int ürünAl = Convert.ToInt32(Console.ReadLine());
            switch (ürünAl)
            {

                case 1:
                    Console.WriteLine("Fiyat giriniz:");
                    int fiyat = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("KDV tuarı hesaplat.");
                    int kdv = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ödemeniz geren tutar: "+Fatura(fiyat,kdv));
                    HediyeCeki();
                    Console.ReadLine();
                    Console.WriteLine("İsleme devam etmek ister misiniz? <e/h>:");
                    string islemcevap = Console.ReadLine();
                    if (islemcevap.ToLower()=="e")
                    {
                        goto anamenü;
                    }
                    

                    break;

                case 2:

                    Console.WriteLine("İndirim kazanmak isistersen Devam yaz");
                    string a = Console.ReadLine();
                    if (a.ToLower()=="devam")
                    {

                        Console.WriteLine("Fiyat giriniz:");
                        int fiyat1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("KDV tuarı hesaplat.");
                        int kdv1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ödemeniz geren tutar" + Fatura(fiyat1, kdv1));




                    }
                    HediyeCeki();
                    break;
                case 3:
                    Console.WriteLine("1-Mutfak Aletleri");
                    Console.WriteLine("2-Kucuk Ev aletleri");
                    Console.WriteLine("Lutfen bir secin yapınız:");
                    int caseucsecim = Convert.ToInt32(Console.ReadLine());

                    if (caseucsecim==1)
                    {

                        Console.WriteLine("Lutfen almak istediginiz urunun fiyatını giriniz:");
                        int case3birfiyat = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Almak isteginiz ürünün zamlı fiyat" + caseuc(case3birfiyat));


                    }
                    else if (caseucsecim==2)
                    {
                        Console.WriteLine("Lutfen almak istediginiz urunun fiyatını giriniz:");
                        int case3ikifiyat = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Almak istediginiz ürünün zam artı kurulum ücretli fiyatı:"+ caseuc2(case3ikifiyat));


                    }
                    else
                    {
                        Console.WriteLine("Gecerli bir tercih yapmadınız.Ana menuye yonlendırılıyorsunuz");
                        goto anamenü;
                    }

                    HediyeCeki();
                    break;

                default:
                    break;
            }
       
        
        }

        public static double caseuc(double fiyat)
        {

            if (500<=fiyat && fiyat>=750)
            {
                fiyat += fiyat * 5 / 100;
                return fiyat;
            }

            else if (fiyat<500)
            {
                fiyat += fiyat * 2 / 100;
                return fiyat;
            }
            
            
            
          
            else
            {
                fiyat += fiyat * 10 / 100;
                return fiyat;
            }
        
        
        
        }


        public static double caseuc2(double fiyat)
        {
            fiyat += fiyat * 5 / 100;
            double kurulumücreti = fiyat * 5 / 100;
            fiyat += kurulumücreti;


            return fiyat;
        
        
        }










    }


}
