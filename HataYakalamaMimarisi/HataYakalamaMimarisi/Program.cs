using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYakalamaMimarisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Hata Yakalama
            ////try hata potansiyeli olan bölgedir
            ////try tek başına çalışamaz
            //try
            //{
            //    Console.WriteLine("Lütfen bir sayı giriniz");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Lütfen Bir Sayı Giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi1 / sayi2;
            //    Console.WriteLine("Sonuç = " + sonuc);
            //}
            //catch//Oluşan hatayı yakalar
            //{
            //    Console.WriteLine("Bir Hata Oluştu");
            //}
            //Console.WriteLine("Hata Alanı Dışı");


            #endregion

            #region Özel Hata Yakalama

            //try
            //{
            //    Console.WriteLine("Lütfen bir sayı giriniz");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Lütfen Bir Sayı Giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi1 / sayi2;
            //    Console.WriteLine("Sonuç = " + sonuc);
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine("Hatalı sayı girildi");
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine("Hata Alanı Dışı");

            #endregion

            #region Mimari Oluşturma

            //try
            //{
            //    Console.WriteLine("Lütfen bir sayı giriniz");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Lütfen Bir Sayı Giriniz");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    string str = null;
            //    str.ToUpper();//NullReferanceException

            //    int sonuc = sayi1 / sayi2;
            //    Console.WriteLine("Sonuç = " + sonuc);
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine("Hatalı veri girildi");
            //    Console.WriteLine(ex.Message);
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("Sıfıra bölme tanımsızdır");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Bir Hata Oluştu");
            //    Console.WriteLine(ex.Message);
            //    //Console.WriteLine(ex.StackTrace);
            //}

            //Console.WriteLine("Hata Yakalama alanı dışı");

            #endregion

            #region try catch finally

            try
            {
                Console.WriteLine("Lütfen bir sayı giriniz");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen Bir Sayı Giriniz");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                int sonuc = sayi1 / sayi2;
                Console.WriteLine("Sonuç = " + sonuc);
            }
            catch(FormatException)
            {
                Console.WriteLine("Hatalı veri girildi");
            }
            finally//Her Durumda Çalışır
            {
                Console.WriteLine("Finally Çalıştı");
            }

            Console.WriteLine("Hata alanı dışı");

            #endregion
        }
    }
}
