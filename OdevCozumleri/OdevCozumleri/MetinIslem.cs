using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevCozumleri
{
    public class MetinIslem
    {
        //kendisine gönderilen metnin tüm karakterlerini büyüten metot
        public string BuyukKarakter(string metin)//AnKarA
        {
            string buyukMetin = "";
            for (int i = 0; i < metin.Length; i++)
            {
                char karakter = metin[i];
                int sayisal = (int)karakter;
               
                if (sayisal >= 97 && sayisal <= 122)
                {
                    sayisal -= 32;
                    char buyukkarakter = (char)sayisal;
                    buyukMetin += buyukkarakter;
                }
                else
                {
                    buyukMetin += metin[i];
                }
            }
            return buyukMetin;
        }
        public string KucukKarakter(string metin)//AnKarA
        {
            string buyukMetin = "";
            for (int i = 0; i < metin.Length; i++)
            {
                char karakter = metin[i];
                int sayisal = (int)karakter;

                if (sayisal >= 65 && sayisal <= 90)
                {
                    sayisal += 32;
                    char buyukkarakter = (char)sayisal;
                    buyukMetin += buyukkarakter;
                }
                else
                {
                    buyukMetin += metin[i];
                }
            }
            return buyukMetin;
        }

        //Kendisine gönderilen yazının başındaki boşluğu silen metot

        //          Alp
        //Alp
        public string BastanBoslukSil(string metin)
        {
            int baslangicIndex = -1;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] != ' ')
                {
                    baslangicIndex = i;
                    break;
                }
            }
            string bosluksuz = "";
            for (int i = baslangicIndex; i < metin.Length; i++)
            {
                bosluksuz += metin[i];
            }
            return bosluksuz;
        }


        //Alp Sarıkışla
        public string SondanBoslukSil(string metin)
        {
            int bitisIndex = -1;
            for (int i = metin.Length-1; i >= 0; i--)
            {
                if (metin[i] != ' ')
                {
                    bitisIndex = i;
                    break;
                }
            }
            string bosluksuz = "";
            for (int i = 0; i <= bitisIndex; i++)
            {
                bosluksuz += metin[i];
            }
            return bosluksuz;
        }

        public string BoslukSil(string metin)
        {
            string bosluksuz = BastanBoslukSil(SondanBoslukSil(metin));
            return bosluksuz;
        }

        //Kendisine Gönderilen metnin içindeki boşlukları '_' ye döndüren metot
        public string BoslukTemizle(string metin)
        {
            string bosluksuz = string.Empty;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == ' ')
                {
                    bosluksuz += '_';
                }
                else
                {
                    bosluksuz += metin[i];
                }
            }
            return bosluksuz;
        }
        public bool KullaniciKontrol(string kullaniciAdi, string sifre)
        {
            if (kullaniciAdi == "admin" && sifre == "1234")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool KarakterVarMi(string metin, char karakter)
        {
            bool varmi = false;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == karakter)
                {
                    varmi = true;
                    break;
                }
            }
            return varmi;
        }
    }
}
