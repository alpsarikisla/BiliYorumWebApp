using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziElemanSayisiArttirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //Dolu bir dizinin eleman sayısı ARTTIRILAMAZ

            //Nedenleri...
            // new anahtar sözcüğü ile oluştutlan her araç(Nesne, Dizi) Ram üzerinde sıfırdan oluşturulur


            //int[] sayilar = new int[5];
            //sayilar[0] = 12;
            //sayilar[1] = 15;
            //sayilar[2] = -3;
            //sayilar[3] = 45;
            //sayilar[4] = 21;
            //sayilar = new int[10];

            #endregion

            #region Çözüm nedir?

            //int[] sayilar = new int[0];

            //string secenek = "e";

            //while (secenek == "e")
            //{
            //    Console.WriteLine("Lütfen sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    int[] gecici = new int[sayilar.Length + 1];

            //    for (int i = 0; i < sayilar.Length; i++)
            //    {
            //        gecici[i] = sayilar[i];
            //    }

            //    gecici[gecici.Length - 1] = sayi;
            //    sayilar = gecici;

            //    Console.WriteLine("Sayı girmeye devam edilsin mi?e/h");
            //    secenek = Console.ReadLine();
            //}

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            #endregion

            #region Koleksiyon Yaklaşımı

            IntegerDepo id = new IntegerDepo();
            id.Ekle(85);
            id.Ekle(10);
            id.Ekle(36);
            id.Ekle(90);

            Console.WriteLine("Eleman Sayısı = " + id.Count);

            id.Yazdir();

            IntegerDepo id2 = new IntegerDepo();


            #endregion
        }
    }
}
