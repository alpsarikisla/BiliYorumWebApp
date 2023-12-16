using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorYapiciMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan ins = new Insan("murtaza");
        }
    }
    public class Insan
    {
        public string isim;

        //Constructor
        //Yapıcı Metot
        //Constructorların geri dönüş türü olmaz
        //Constructorlar Sınıfın adı ile aynı isimde olmalıdır
        //Constructor Parametre almak zorunda değildir
        public Insan(string p_isim)
        {
            isim = p_isim;
            //Nesne oluştuğunda yapılmasını zorunlu kılmak istediğimiz her şeyi
            //Constructor ile yapıyoruz. Çünkü metodun Çağırılmasına gerek kalmadan nesne oluşurken otomatik olarak çalışır
        }
    }
}
