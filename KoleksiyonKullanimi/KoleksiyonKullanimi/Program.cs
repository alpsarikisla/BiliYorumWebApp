using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KoleksiyonKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add(45);
            liste.Add(90);
            liste.Add(-3);
            liste.Add(20);
            liste.Add(22);//ekle
            liste.TrimToSize();//Capacity'i Counta eşitle(Boştakileri sil)
            liste.Insert(1, 70);//Araya Ekle
            liste.AddRange(new int[] { 22, 36, 78, 90, 52 });//Çoklu Ekle
            liste.Add("Nassınız??");
            //Array list Object türnde verialdığı için Her türlü veriyi kabul eder

            //liste.Sort();//Sırala
            //liste.Reverse();//Ters Çevir
            //liste.Remove(22);//Bulursan sil
            //liste.RemoveAt(7);//İndex numarasındakini sil
            //liste.Clear();//Geçmiş Olsun
            liste.RemoveRange(1, 5);//1. indexten başlayarak 5 adet sil

            Console.WriteLine("Eleman Sayısı = " + liste.Count);
            Console.WriteLine("Dizi Kapasitesi = " + liste.Capacity);
            Console.WriteLine("Son index numarası = " + liste.LastIndexOf(22));
            Console.WriteLine("Index Numarası = " + liste.IndexOf(22));
            Console.WriteLine("Index Numarası = " + liste.IndexOf(220));
            

            Console.WriteLine("Elemanlar");
            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine(liste[i]);
            }


        }
    }
}
