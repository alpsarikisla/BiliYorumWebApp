using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            cmd = con.CreateCommand();
        }

        #region Giriş Metotları

        public Yonetici YoneticiGiris(string kullaniciAdi, string sifre)
        {
            try//hata çıkma durumunu denetler
            {
                
                cmd.CommandText = "SELECT COUNT(*) FROM Yoneticiler WHERE KullaniciAdi=@ka AND Sifre=@sif";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ka", kullaniciAdi);
                cmd.Parameters.AddWithValue("@sif", sifre);
                con.Open();
                int sayi = Convert.ToInt32(cmd.ExecuteScalar());
                if (sayi > 0)//Yonetici var ise
                {
                    cmd.CommandText = "SELECT Y.ID, Y.YoneticiTur_ID, YT.Isim, Y.Isim, Y.Soyisim, Y.KullaniciAdi, Y.Mail, Y.Sifre, Y.KayitTarihi, Y.Silinmis, Y.Durum FROM Yoneticiler AS Y JOIN YoneticiTurleri AS YT ON Y.YoneticiTur_ID = YT.ID WHERE Y.KullaniciAdi = @ka AND Y.Sifre = @sif";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ka", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sif", sifre);
                    //con.Open(); Bağlantı Zaten Açık
                    SqlDataReader reader = cmd.ExecuteReader();
                    Yonetici y = new Yonetici();
                    while (reader.Read())
                    {
                        y.ID = reader.GetInt32(0);
                        y.YoneticiTur_ID = reader.GetInt32(1);
                        y.YoneticiTur = reader.GetString(2);
                        y.Isim = reader.GetString(3);
                        y.Soyisim = reader.GetString(4);
                        y.KullaniciAdi = reader.GetString(5);
                        y.Mail = reader.GetString(6);
                        y.Sifre = reader.GetString(7);
                        y.KayitTarihi = reader.GetDateTime(8);//18.11.2023 00:00:00:000
                        //y.KayitTarihiStr = y.KayitTarihi.ToLongDateString(); //18 Kasım 2023
                        y.KayitTarihiStr = y.KayitTarihi.ToShortDateString(); //18.11.2023
                        y.Silinmis = reader.GetBoolean(9);
                        y.Durum = reader.GetBoolean(10);
                    }
                    return y;
                }
                return null;
            }
            catch//Hata Çıkar ise burası çalışır
            {
                return null;
            }
            finally
            {
                con.Close();
                //her durumda ne olursa olsun bağlantıyı kapat
            }
        }

        #endregion
    }
}
