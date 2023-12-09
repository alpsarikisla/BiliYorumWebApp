using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //Metot Ana programın parçalara ayrılarak daha kolay yönetilmesini sağlar
            //Birden çok kez kullanılacak işlemlerin tekrar tekrar yazılmasını önler

            //İhtiyaç duyulduğunda çalıştırılmak üzere tanımlanan küçük program parçasıdır.


            #endregion

            #region Çırak Sınıfı

            //Cirak murtaza = new Cirak();
            //murtaza.SelamSoyle(); //Metodun çağırılması

            ////murtaza.IsmeSelamSoyle();//Parametre alan metotlara parametre verisi mutlaka gönderilmelidir.
            //murtaza.IsmeSelamSoyle("Tevfik");

            //murtaza.IsmeCokSelamsoyle("Süleyman", 10);

            //murtaza.KisilereSelamSoyle("Murat", "Hakkı", "Şuayip", "Remzi");

            //double gelen = murtaza.CaySoyle(3, 100);
            //Console.WriteLine(gelen + " TL para üstün usta");

            //int sayi = Convert.ToInt32("23");

            #endregion

            #region Matematik sınıfı

            //Matematik mat = new Matematik();
            //mat.Topla(45, 3);

            //int kare = mat.KareAl(12);
            //Console.WriteLine("Girilen sayının karesi = " + kare);

            //mat.Topla(mat.KareAl(5), 2);

            //int gelen = mat.UsAl(2, 5);
            //Console.WriteLine(gelen);

            #endregion

            #region Metinsel İşlemler sınıfı

            MetinselIslemler mi = new MetinselIslemler();

            Console.WriteLine(mi.IngilizceDondur("sarıkışla"));

            #endregion
        }
    }
}
