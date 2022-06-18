using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.tur_donusumu
{
    class Program
    {
        static void Main(string[] args)
        {

            //tur donusumu -- verı donusumu parse ve ya convert kullanılır.
            //c# her turlu verıyı strıng olarak alır bu yuzden tur donusumu yapılır.

            //Console.Write("İsminizi giriniz: ");

            //string isim = Console.ReadLine();

            //Console.Write("Yasınızı gırınız: ");
            //string yas = Console.ReadLine();    //ınt yas1 = Convert.ToInt32(Console.ReadLine());
            //int yas1 = Convert.ToInt32(yas);

            //Console.WriteLine("İsminiz: "+isim);
            //Console.WriteLine("Yasınız: "+yas1);
            //Console.ReadLine();


            //Console.Write("Dogum tarıhınızı gırınız: ");

            //int dogumyili = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Icınde bulundugunuz  yili giriniz: ");

            //int mevcutyil = Convert.ToInt32(Console.ReadLine());

            //int yashesabı = mevcutyil - dogumyili;

            //Console.WriteLine("Yasınız: "+yashesabı);
            //Console.ReadLine();


            //Console.WriteLine("Sistem sizin gireceginiz dikdörtgenin alanını hesaplayacaktır.");

            //Console.Write("Dıkdortgenın kısa kenarını gırınız: ");

            //int kısakenar = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Dıkdortgenın uzun kenarını gırınız: ");

            //int uzunkenar = Convert.ToInt32(Console.ReadLine());

            //int alan = kısakenar * uzunkenar;

            //Console.WriteLine("Dikdortgenin alanı: "+alan);
            //Console.ReadLine();


            //Console.WriteLine("Cinsiyetinizi giriniz <E/K>");
            //char cinsiyet = Convert.ToChar(Console.ReadLine());


            //bool cek = Convert.ToBoolean(Console.ReadLine());

            //Console.WriteLine("Cek tutarını gırınız");
            //float cektutar = Convert.ToSingle(Console.ReadLine());

            // her veri tipinin bir karsılıgı var "CTS" (common type system)

            //int ------ > toint2
            //string----->Tostring
            //char----->ToChar
            //double--->toDouble
            //Bool---->ToBoolean
            //float----> ToSingle



            // daire alan ve cevre hesabı

            //Console.WriteLine("Sistem yarıcapını gırdıgınız daırenın alan ve cevresını hesaplayacaktır");
            //Console.Write("Lutfen bir yarıcap degerı giriniz: ");

            //float yarıcap = Convert.ToSingle(Console.ReadLine());
            //float sabit= 3.14f;
            //float cevre = 2 *sabit * yarıcap;

            //float alan = sabit * yarıcap * yarıcap;

            //Console.WriteLine(yarıcap+" degerli dairenin alanı=" +alan+", cevresi= "+cevre);
            //Console.ReadLine();

            // karsılastırma opt.

            //== ıkı degısken arası esıtlık kontrolu
            //!= ıkı degısken arası esıt olmaması kontrolu
            //|| veya 
            //&& ve
            //>=
            //<=
            //% mod alma
            //Kontrol mekanızması

            // if(eger)  else(degılse)


            Console.WriteLine("1.sayıy giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı gırınız:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi>sayi2)
            {
                Console.WriteLine("1.sayı daha buyuk bir degere sahiptir.");
            }

            else if (sayi==sayi2)
            {
                Console.WriteLine("Sayılar esittir.");
            }
            else
            {
                Console.WriteLine("2.sayı daha buyuktur.");
            }

            Console.ReadLine();





        }
    }
}
