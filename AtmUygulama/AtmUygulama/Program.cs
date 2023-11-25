using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region örnek - 6 -  ATM

            int bakiye = 2000;

            bool devam = true;

            while (devam == true)
            {
                Console.WriteLine("BurakBank'a Hoş geldiniz.");
                Console.WriteLine("Lütfen bir işlem seçiniz");
                Console.WriteLine(" 1 - Bakiye sorgulama");
                Console.WriteLine(" 2 - Para çekme");
                Console.WriteLine(" 3 - Para Yatırma");
                Console.WriteLine(" 4 - Çıkış yap");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":

                        Console.WriteLine("Bakiyeniz = " + bakiye);
                        break;

                    case "2":

                        Console.WriteLine("Lütfen çekme istediğiniz tutarı giriniz");
                        int cekim = Convert.ToInt32(Console.ReadLine());

                        if (cekim > bakiye)
                        {
                            Console.WriteLine("Bakiyenizden fazla para çekemezsiniz");
                        }
                        else
                        {
                            bakiye -= cekim;
                            Console.WriteLine("Kalan tutarınız : " + (bakiye));
                        }
                        break;

                    case "3":
                        Console.WriteLine("Yatırmak istediğiniz tutarı giriniz");
                        int yatirma = Convert.ToInt32(Console.ReadLine());

                        bakiye += yatirma;

                        Console.WriteLine("Yeni bakiyeniz " + (bakiye));
                        break;

                    case "4":
                        Console.WriteLine("Hesabınızdan çıkış yapılıyor");
                        devam = false;
                        break;

                    default:
                        Console.WriteLine("Lütfen bir değer giriniz");
                        break;
                }
            }

           
            #endregion
        }
    }
}
