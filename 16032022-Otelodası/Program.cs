using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16032022_Otelodası
{
    class Program
    {
        static void Main(string[] args)
        {
        gotorezervasyonsecimi:

            Console.WriteLine("Merhabalar Otelemize hosgeldiniz.");
            Console.WriteLine("1-Kral oldası");
            Console.WriteLine("2-Standart ekonomik oda");
            Console.WriteLine("3-VİP oda");
            Console.WriteLine("Lutfen kalmak istediginiz oda turunu gırıniz: ");
            int odaturu = Convert.ToInt32(Console.ReadLine());





            double indirim = 1;
            double ücret = 1;
            double ötv = 1;
            double final = 1;
            double kdv = 1;






            switch (odaturu)
            {
                case 1:

                    Console.WriteLine("Kral odasında ıkı cesıt ozellık bulunmaktadır. Sauna veya Havuz. ");
                    Console.WriteLine("Lutfen bir secım yapınız <s/h> : ");
                    char secim = Convert.ToChar(Console.ReadLine());

                    Console.WriteLine("Kac kısı kalacaksınız?");
                    double kişi = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Kac gun kalacaksınız?: ");
                    double gün = Convert.ToDouble(Console.ReadLine());




                    if (secim == 's')
                    {



                        if (kişi >= 2 && kişi <= 8)
                        {
                            ücret = kişi * gün;
                            indirim = ücret - ücret * (7.5 / 100);
                            ötv = indirim * 1.02;

                            final = ötv;

                            Console.WriteLine("Odemenız gereken ucret: " + final);
                        }
                        else
                        {
                            ücret = kişi * gün;
                            Console.WriteLine("Ödemeniz gereken tutar: " + ücret);

                        }


                    }
                    else
                    {
                        Console.Write("Termal kaynaklardan faydalanmak ister misininiz? <e/h>");
                        char termal = Convert.ToChar(Console.ReadLine());

                        if (termal == 'e' || termal == 'E')
                        {
                            ücret = kişi * gün;

                            final = final * 1.025;
                            final = final * 1.085;
                            Console.WriteLine("Ödemeniz gereken tutar: " + final);
                        }
                        else
                        {
                            final = final * 1.075;
                            Console.WriteLine("Ödemeniz gereken tutar: " + final);
                        }
                    }
                    break;




                case 2:
                    Console.WriteLine("Rezervasyon yapmak ıster mısın fakir insan? <e/h>");
                    char fakirinsan = Convert.ToChar(Console.ReadLine());

                    if (fakirinsan == 'e' || fakirinsan == 'E')
                    {
                    standartodagoto:

                        Console.WriteLine("Hangı ay ıcın rezervasyon yapmak istiyorsunuz? Lutfen ilgili ayi temsil eden harfi giriniz:");
                        Console.WriteLine("h-haziran");
                        Console.WriteLine("t-temmuz");
                        Console.WriteLine("a-agustos");


                        Console.WriteLine("Seciminiz: ");
                        string aydegeri = Console.ReadLine();

                        Console.WriteLine("Kac kısı kalacaksınız?");
                        double kişi1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Kac gun kalacaksınız?: ");
                        double gün1 = Convert.ToDouble(Console.ReadLine());



                        switch (aydegeri)
                        {





                            case "h":


                                ücret = kişi1 * gün1;
                                indirim = ücret - ücret * 4 / 100;
                                kdv = indirim * 1.08;
                                Console.WriteLine("Odemenız gereken ucret: " + kdv);



                                break;

                            case "t":

                                ücret = kişi1 * gün1;
                                ücret = ücret * 1.18;
                                ücret = ücret * 1.025;
                                Console.WriteLine("Odemenız gereken ucret: " + ücret);


                                break;

                            case "a":

                                ücret = kişi1 * gün1;
                                ücret = ücret * 1.08;
                                ücret = ücret * 1.025;
                                Console.WriteLine("Odemenız gereken ucret: " + ücret);
                                break;


                            default:
                                Console.WriteLine("Gecerli bir secim yapmadiniz.");
                                Console.Write("Ana menuye geri donmek ister misiniz? <e/h>:");
                                char standartodacik = Convert.ToChar(Console.ReadLine());

                                if (standartodacik == 'e' || standartodacik == 'E')
                                {
                                    goto standartodagoto;
                                }
                                else
                                {
                                    Environment.Exit(0);
                                }

                                break;





                        }
                    }

                    else
                    {
                        Console.WriteLine("Gecerli bir secim yapmadıgınız. Tekrar denemek ister misiniz? <e/h>: ");
                        char standartodaanasecim = Convert.ToChar(Console.ReadLine());
                        if (standartodaanasecim == 'e' || standartodaanasecim == 'E')
                        {
                            goto gotorezervasyonsecimi;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }


                    }

                    break;


                case 3:

                    Console.WriteLine("Vip oda secımınde 3 farklı yemek secenegı bulunmaktadır:");
                    Console.WriteLine("1-Açık bufe");
                    Console.WriteLine("2-Oglen yemegı");
                    Console.WriteLine("3-aksam yemegı");

                    Console.WriteLine("Tek bır secım ucretı 900 tl dır");
                    Console.WriteLine("Ikı secım kampanya dahılınde 1000 tl");
                    Console.WriteLine("Ûclu paket secım ucretı 1500 tl dır");

                    Console.WriteLine("Menu secım kodları asagıdadır");
                    Console.WriteLine("a-sadece acık bufe");
                    Console.WriteLine("b-sadece oglen yemegı");
                    Console.WriteLine("c- sadece aksam yemegı");
                    Console.WriteLine("d-acık bufe ve oglen yemegı");
                    Console.WriteLine("e-acık bufe ve aksam yemegı");
                    Console.WriteLine("f-oglen yemegı ve aksam yemgı");
                    Console.WriteLine("g-Full paket");

                    Console.WriteLine("lutfen secımınızı yapınız:");
                    char secımkodu = Convert.ToChar(Console.ReadLine());

                    switch (secımkodu)
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                            Console.WriteLine("Odemeniz gereken ücret 900 tldir");


                            break;

                        case 'd':
                        case 'e':
                        case 'f':
                            Console.WriteLine("Odemenız gereken ucret 1000 tldır");




                            break;

                        case 'g':

                            Console.WriteLine("1500 Tl degerinde full paket sectiginiz icin size ozel taksit avantajindan faydalanmak  ister misiniz? <e/h>");
                            char taksıtıste = Convert.ToChar(Console.ReadLine());

                            if (taksıtıste == 'e')
                            {
                                Console.WriteLine("1. 6 ay taksit");
                                Console.WriteLine("2. 8 ay taksit");
                                Console.WriteLine("3. 12 ay taksit");
                                Console.WriteLine("Secımınıze %2 vade farkı eklenecektir");
                                Console.Write("Lutfen seciminizi giriniz(1,2 veya 3): ");
                                string taksitsecimi = Console.ReadLine();

                                switch (taksitsecimi)
                                {
                                    case "1":
                                        double yemekodenectutar = 1500;
                                        double faiz = yemekodenectutar * 6 / 12 * 0.02;
                                        yemekodenectutar += faiz;
                                        double aylikyemekodenecektutar = yemekodenectutar / 6;

                                        Console.WriteLine("Sectiginiz 6 ay taksitli odeme planinin toplam odemesi {0} =Tl, aylik odemesi ise ={1}", yemekodenectutar, aylikyemekodenecektutar);
                                        break;

                                    case "2":
                                        double yemekodenectutar2 = 1500;
                                        double faiz2 = yemekodenectutar2 * 8 / 12 * 0.02;
                                        yemekodenectutar2 += faiz2;
                                        double aylikyemekodenecektutar2 = yemekodenectutar2 / 8;
                                        Console.WriteLine("Sectiginiz 8 ay taksitli odeme planinin toplam odemesi {0} =Tl, aylik odemesi ise ={1}", yemekodenectutar2, aylikyemekodenecektutar2);

                                        break;

                                    case "3":
                                        double yemekodenectutar3 = 1500;
                                        double faiz3 = yemekodenectutar3 * 12 / 12 * 0.02;
                                        yemekodenectutar3 += faiz3;
                                        double aylikyemekodenecektutar3 = yemekodenectutar3 / 12;

                                        Console.WriteLine("Sectiginiz 12 ay taksitli odeme planinin toplam odemesi {0} =Tl, aylik odemesi ise ={1}", yemekodenectutar3, aylikyemekodenecektutar3);
                                        break;


                                    default:

                                        break;
                                }





                            }

                            else
                            {
                                Console.WriteLine("Sectiginiz planin taksitsiz fiyati 1500 TLdir.");
                            }


                            break;

                        default:
                            break;
                    }


                    break;

                default:
                    break;



            }

            Console.ReadLine();




        }
    }
}


