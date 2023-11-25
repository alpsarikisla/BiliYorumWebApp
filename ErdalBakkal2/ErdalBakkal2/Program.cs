using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdalBakkal2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = {"Domates", "Biber", "Soğan", "Yumurta", "Ekmek", "Doritos", "Kola  " };
            double[] fiyatlar = { 29.90, 35.50, 22.40, 3.5, 7, 26, 45 };
            string[] birimler = { "Kg", "Kg", "Kg", "Adet", "Adet", "Paket", "Adet" };
            
            Console.WriteLine("Erdal Bakkal'a hoş geldiniz");

            for (int i = 0; i < 7; i++)
            {
                //Console.WriteLine((i + 1) + " " + isimler[i]);
                Console.WriteLine($"{i+1}) {isimler[i]}\t{fiyatlar[i]} TL");
            }

            #region Başlangıçta alınacak adet sorarak Ürün Satın Aldırma
            //Kaç adet ürün alacaksın diye sorup alınan ürünlerin toplam fiyatını yazdırınız

            //Console.WriteLine("kaç adet ürün alacaksınız?");
            //int urunsayi = Convert.ToInt32(Console.ReadLine());
            //double toplam = 0;

            //for (int i = 0; i < urunsayi; i++)
            //{
            //    Console.WriteLine("Lütfen satın almak istediğiniz ürünün numarasını giriniz?");
            //    int urunno = Convert.ToInt32(Console.ReadLine());

            //    toplam += fiyatlar[urunno - 1];
            //}

            //Console.WriteLine("Teşekkür ederiz.");
            //Console.WriteLine("Toplam = " + toplam + " TL");

            #endregion

            #region Başlangıçta adet sormadan Ürün satın aldırma

            //string secenek = "e";
            //double toplam = 0;

            //while (secenek == "e")
            //{
            //    Console.WriteLine("Satın almak istediğiniz ürünün numarasını giriniz");
            //    int urunno = Convert.ToInt32(Console.ReadLine());

            //    toplam += fiyatlar[urunno - 1];

            //    Console.WriteLine("Alışverişe devam edilsin mi? e/h");
            //    secenek = Console.ReadLine();
            //}

            //Console.WriteLine("Teşekkür ederiz");
            //Console.WriteLine("Toplam = " + toplam + " TL");

            #endregion

            #region her seçimde Bu üründen kaç adet alacaksın diye sorup satın aldırma

            //string secenek = "e";
            //double toplam = 0;

            //while (secenek == "e")
            //{
            //    Console.WriteLine("Satın almak istediğiniz ürünün numarasını giriniz");
            //    int urunno = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Bu üründen kaç adet alacaksınız");
            //    int adet = Convert.ToInt32(Console.ReadLine());

            //    toplam += fiyatlar[urunno - 1] * adet;

            //    Console.WriteLine("Alışverişe devam edilsin mi? e/h");
            //    secenek = Console.ReadLine();
            //}
            //Console.WriteLine("Toplam = " + toplam + " TL");


            #endregion

            #region Her seçimde kaç adet ....... alacaksın diye sordurma

            //string secenek = "e";
            //double toplam = 0;

            //while (secenek == "e")
            //{
            //    Console.WriteLine("hangi ürünü satın alacaksın");
            //    int urunno = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Kaç adet " + isimler[urunno -1] + " alacaksın");
            //    int adet = Convert.ToInt32(Console.ReadLine());

            //    toplam += fiyatlar[urunno - 1] * adet;

            //    Console.WriteLine("Alışverişe devam edilsin mi?e/h");
            //    secenek = Console.ReadLine();
            //}

            //Console.WriteLine("Teşekkür ederiz");
            //Console.WriteLine("Toplam = " + toplam + " TL");

            #endregion

            #region Kaç Adet, KG, paket şeklinde sordurarak ürün satın aldırma

            //string secenek = "e";
            //double toplam = 0;

            //while (secenek == "e")
            //{
            //    Console.WriteLine("Satın almak istediğiniz ürünün numarasını yazınız");
            //    int urunNo = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine($"Kaç {birimler[urunNo -1]} {isimler[urunNo - 1]} alacaksınız?");
            //    int adet = Convert.ToInt32(Console.ReadLine());

            //    toplam += fiyatlar[urunNo - 1] * adet;

            //    Console.WriteLine("Alışverişe devam edilsin mi?e/h");
            //    secenek = Console.ReadLine();
            //}

            //Console.WriteLine("Teşekkür ederiz");
            //Console.WriteLine("Toplam = " + toplam + " TL");

            #endregion

            #region ÖDEV - Ürünlerin  KDV toplamını  ayrı yazdırma

            //Ara Toplam
            //KDV
            //Toplam

            #endregion
        }
    }
}
