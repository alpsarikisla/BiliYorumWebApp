using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziElemanSayisiArttirma
{
    public class IntegerDepo
    {
        int[] sayilar;//Global Tanımlama
        //Sınıfın içindeki tüm metotlarda erişilebilir
        public int Count;
        public IntegerDepo()
        {
           sayilar = new int[0];
            Count=0;
        }

        public void Ekle(int veri)
        {
            int[] gecici = new int[sayilar.Length + 1];
            Array.Copy(sayilar, gecici, sayilar.Length);
            gecici[gecici.Length - 1] = veri;
            sayilar = gecici;
            Count++;
        }

        public void Yazdir()
        {
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
        }
    }
}
