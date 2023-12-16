using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevCozumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetinIslem mi = new MetinIslem();

            //Console.WriteLine(mi.BuyukKarakter("AnKarA"));
            //Console.WriteLine(mi.BastanBoslukSil("         Alp"));
            //Console.WriteLine(mi.SondanBoslukSil("Alp Sarıkışla       ") + "#");
            //Console.WriteLine(mi.BoslukSil("     Alp     ") + "#");
            //Console.WriteLine(mi.BoslukTemizle("Alp Sarıkışla    "));
            //Console.WriteLine(mi.BoslukTemizle(mi.BoslukSil("       Alp Sarıkışla    "))+ "#");

            //Console.Write("Kullanıcı Adı=\t");
            //string kullaniciAdi = Console.ReadLine();

            //Console.Write("Şifre = \t");
            //string sifre = Console.ReadLine();

            //string validKullaniciAdi = mi.KucukKarakter(mi.BoslukSil(kullaniciAdi));

            //if (mi.KullaniciKontrol(validKullaniciAdi, sifre))
            //{
            //    Console.WriteLine("Giriş Başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("Başarısız");
            //}

            //Console.WriteLine(mi.KarakterVarMi("alpsarikisla@hotmail.com", 'q'));

            Random rnd = new Random();
            int tahminedilecek = rnd.Next(0, 100);
            Console.WriteLine(tahminedilecek);

            //Kendisine gönderilen metni safeUrl'e dönüştüren metot

            //Iphone 11 Uyumlu Fast and Furious Tasarım Baskılı Şeffaf Kılıf
            //iphone-11-uyumlu-fast-and-furious-tararim-baskili-seffaf-kilif
            //iphone-11-uyumlu-fast-and-furious-tasarim-baskili-seffaf-kilif
        }
    }
}
