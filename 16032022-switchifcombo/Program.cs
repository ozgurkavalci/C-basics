using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16032022_switchifcombo
{
    class Program
    {
        static void Main(string[] args)
        {
            basagit:
            Console.WriteLine("**Suleyman giyimcilik**");
            Console.WriteLine("1-Bayan");
            Console.WriteLine("2-Bay");
            Console.WriteLine("3-Cocuk");
            
            Console.WriteLine("Secım yapınız:");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.WriteLine("Bayan giyim urunlerını secınız");
                    Console.WriteLine("Ic gıyım");
                    Console.WriteLine("Dıs gıyım");
                    string secenek = Console.ReadLine();
                    if (secenek=="Ic gıyım")
                    {
                        Console.WriteLine("Fıyat gırınız: ");
                        float fiyat = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Indırım fıyatını gırınız: ");
                        float indirim= Convert.ToSingle(Console.ReadLine());
                        fiyat -= indirim;
                        Console.WriteLine("Odemenız geren tutar: "+fiyat);
                    }

                    else
                    {
                        Console.WriteLine("a-Ayakkabı");
                        Console.WriteLine("b-Çanta");
                        char sec = Convert.ToChar(Console.ReadLine());
                        switch (sec)
                        {
                            case 'a':
                                Console.WriteLine("İnci akakkabılarda indirim var");
                                Console.WriteLine("Marka seciniz:");
                                string marka = Console.ReadLine();
                                if (marka=="inci" || marka=="kemal tanca")
                                {
                                    Console.WriteLine("Tebrikler %25 indirim kazandınız , hemen al");
                                    Console.WriteLine("Ayakkaı fiyatı giriniz: ");
                                    float fiyat = Convert.ToSingle(Console.ReadLine());

                                    fiyat -= fiyat * 25/100;
                                    Console.WriteLine("Odemenız gereken ucret: "+fiyat);
                                }
                                break;
                            default:
                                break;
                        }

                    }

                    break;

                case 2:
                    Console.WriteLine("Erkek giyim urunlerını seciniz");

                    Console.WriteLine("Bay giyim urunlerini seciniz: ");
                    Console.WriteLine("1- Kıslık ürünler");
                    Console.WriteLine("2-Yazlık ürünler");
                    string ürün = Console.ReadLine();

                    if (ürün== "Kışlık ürünler")
                    {
                        Console.WriteLine("Fiyat giriniz:");
                        float erkekkış = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Indırım fiyatını giriniz: ");
                        float indiirmerkekkış = Convert.ToSingle(Console.ReadLine());

                        erkekkış -= indiirmerkekkış;
                        Console.WriteLine("Odemenız gerken tutar: "+erkekkış);

                    }
                    else
                    {
                        Console.WriteLine("Yazlık urunlerde  indirim var. Kaçırmayın");
                        Console.WriteLine("a- deniz şortu");
                        Console.WriteLine("b- t-shirt ve atletler");
                        char erkekyaz = Convert.ToChar(Console.ReadLine());

                        switch (erkekyaz)
                        {
                            case 'a':
                                Console.WriteLine("Billabong ve quicksilver sortlarda yüzde 50 indirim var");
                                Console.WriteLine("Lutfen marka secınız:");
                                string markasort = Console.ReadLine();

                                if (markasort=="Billabong" || markasort=="quicksilver")
                                {

                                    Console.WriteLine("Tebrikler yüzde 50 indirim kazandınız.");
                                    Console.WriteLine("Urun fiyatını giriniz: ");
                                    float sortfiyatı = Convert.ToSingle(Console.ReadLine());
                                    Console.WriteLine("Indırım miktarını giriniz: ");
                                    float indirimsortfiyatı = Convert.ToSingle(Console.ReadLine());
                                    sortfiyatı -= sortfiyatı * 50 / 100;
                                    Console.WriteLine("Odemenız gereken ucret "+sortfiyatı);

                                }
                                break;

                            default:
                                break;
                        }
                    }

                    break;
                case 3:
                    Console.WriteLine("Cocuk gıyım urunlerını secınız");
                    break;
                
                default:

                    Console.WriteLine("Boyle bır secım yok...");
                    Console.WriteLine("Isleme devam etmek ıster mısınız? <e/h>");
                    char islem1 = Convert.ToChar(Console.ReadLine());
                    if (islem1=='E' || islem1=='e')
                    {
                        goto basagit;
                    }
                    else
                    {
                        Console.WriteLine("Yine bekleriz..");
                        Environment.Exit(0);
                    }
                    break;
            }

            Console.WriteLine("Isleme devam etmek ıster mısınız? <e/h>");
            char islem = Convert.ToChar(Console.ReadLine());
            if (islem == 'E' || islem == 'e')
            {
                goto basagit;
            }
            else
            {
                Console.WriteLine("Yine bekleriz..");
                Environment.Exit(0);
            }
            Console.ReadLine();
        }
    }
}
