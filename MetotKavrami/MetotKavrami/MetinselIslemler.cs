using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotKavrami
{
    internal class MetinselIslemler
    {
        //Tüm metotlar veri döndürsün
        //Kendisine Gönderilen Metnin tüm karakterlerini büyüten metot
        //Kendisine gönderilen yazının başındaki boşlukları silen metot
        //kendisine gönderilen yazının başındaki ve sonundaki boşlukları silen metot
        //kendisine gönderilen metnin içindeki boşlukları _ ye çeviren metot
        //Kendisine gönderilen metnin içindeki tüm türkçe karakterleri ingilizce karakterler ile değiştiren metot

        //s  a   r   ı   k   ı   ş   l   a
        //0  1   2   3   4   5   6   7   8

        public string IngilizceDondur(string metin)
        {
            char[] turkcekarakterler = { 'ç', 'ğ', 'ı', 'ü', 'ö', 'ş' };
            char[] Ingilizcekarakterler = { 'c', 'g', 'i', 'u', 'o', 's' };

            string yenimetin = "";
            for (int i = 0; i < metin.Length; i++)
            {
                bool turkcemi = false;
                for (int j = 0; j < turkcekarakterler.Length; j++)
                {
                    if (metin[i] == turkcekarakterler[j])
                    {
                        yenimetin += Ingilizcekarakterler[j];
                        turkcemi = true;
                    }
                }
                if (turkcemi == false)
                {
                    yenimetin += metin[i];
                }
            }
            return yenimetin;

        }
        //kendisine gönderilen kullanıcı adı admin şifre 1234 ise true değilse false sonucunu döndüren metot
        //kendisine gönderilen metnin içinde kendisine gönderilen karakteri arayan metot varsa true yoksa false döndürecek
    }
}
