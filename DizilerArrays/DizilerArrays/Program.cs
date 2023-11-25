using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //Aynı türden verilerin bir arada numaralandırılarak tutlmasını sağlayan yapıdır
            //index numarası= sıra numarası
            //index numarası HER ZAMAN 0 dan başlar

            #endregion

            #region Dizi Oluşturma

            //int[] sayilar = new int[10];
            ////RAM Üzerinde 10 adet integer veri tutabilecek alan açıldı

            //sayilar[5] = 30;
            //sayilar[0] = 10;
            //sayilar[1] = 22;
            //sayilar[2] = -3;
            //sayilar[3] = 22;
            //sayilar[4] = 90;
            //sayilar[6] = 15;
            //sayilar[7] = 158;
            //sayilar[8] = -7;
            //sayilar[9] = 32;

            ////sayilar[10] = 80;

            //Console.WriteLine(sayilar[7]);
            //Console.WriteLine("Eleman Sayısı = " + sayilar.Length);

            //Console.WriteLine("Elemanlar");
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}


            #endregion

            int[] sayilar = { 20, 8, 15, 7, -2, 60, 80, 158, 65, 44, 18 };

            string[] isimler = { "runi", "manolung", "tanju", "sabri", "erkan", "sergen", "messi", "Metin", "ali", "feyyaz" };

            #region Dizi Elelmanlarını Yazdıralım

            //Console.WriteLine("Eleman Sayısı = " + sayilar.Length);

            ////sayilar = new int[20];
            ////Dizi Eleman Sayısı ARTTIRILAMAZ
            ////Yeni dizi tanımlanmış olur

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine($"Index = {i} Değer = {sayilar[i]}");
            //}

            #endregion

            #region Dizi İçerisindeki sayıların toplamını yazdırınız

            //int toplam = 0;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    toplam += sayilar[i];
            //}

            //Console.WriteLine("Toplam = " + toplam);

            #endregion

            #region isimler dizisi içerisindeki tüm isimleri yazdırınız

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}

            #endregion

            #region Sayılar dizisi içerisindeki çift sayıları yazdırınız

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}

            #endregion

            #region ÖDEV Sayılar Dizisi içerisindeki sayıların ortalamasını yazınız



            #endregion

            #region ÖDEV Sayılar Dizisi içerisindeki çift sayıların ortalamasını yazınız



            #endregion

            #region sayılar dizisi içerisinde 81 var mı?

            //bool varmi = false;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] == 81)
            //    {
            //        varmi = true;
            //    }

            //}

            //if (varmi == true)
            //{
            //    Console.WriteLine("Vardır");
            //}
            //else
            //{
            //    Console.WriteLine("yoktur");
            //}

            #endregion

            #region ÖDEV Konsoldan Alınan isim isimler dizisinde var mı?



            #endregion

        }
    }
}
