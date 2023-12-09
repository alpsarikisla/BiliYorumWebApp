using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotKavrami
{
    internal class Cirak
    {
        public void SelamSoyle()
        {
            Console.WriteLine("Ustamın selamı var");
        }

        public void IsmeSelamSoyle(string isim)//parametre alan metot
        {
            Console.WriteLine(isim + " abi! Ustamın selamı var");
        }

        //parametreler istenilen türde ve sayıda eklenebilir
        public void IsmeCokSelamsoyle(string isim, int adet)
        {
            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine(isim + " abi. Ustam selam soyledi");
            }
        }
        public void KisilereSelamSoyle(params string[] kisiler)
        {
            for (int i = 0; i < kisiler.Length; i++)
            {
                Console.WriteLine(kisiler[i] + " abi. Ustam selam soyledi");
            }
        }

        //metot ile sonuc üretilip program sınıfına veri döndürmek istenirse void yerine uygun veri türü yazılmalıdır.
        public double CaySoyle(int adet, double para)
        {
            double cayfiyat = 15.50;
            double caytoplam = cayfiyat * adet;

            double kalan = para - caytoplam;
            return kalan;//return MUTLAKA kullanılmalıdır
        }
    }
}
