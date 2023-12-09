using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotKavrami
{
    internal class Matematik
    {
        //Kendisine Gönderilen 2 sayının toplamını yazdıran metot
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam = " + toplam);
        }

        //Kendisine gönderilen sayının karesini döndüren metot
        public int KareAl(int sayi)
        {
            int kare = sayi * sayi;
            return kare;
        }

        //kendisine gönderilen taban ve üs değerine göre sayının kuvvetini alan metot
        public int UsAl(int taban, int us)
        {
            int sonuc = 1;
            for (int i = 0; i < us; i++)
            {
                sonuc *= taban;
            }
            return sonuc;
        }
    }
}
