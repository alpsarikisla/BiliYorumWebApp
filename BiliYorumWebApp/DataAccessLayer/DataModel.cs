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

        #region Kategori Metotları

        public bool KategoriEkle(Kategori model)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Kategoriler(Isim, Durum) VALUES(@i, @d)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@i", model.Isim);
                cmd.Parameters.AddWithValue("@d", model.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Kategori> KategoriListele()
        {
            try
            {
                List<Kategori> kategoriler = new List<Kategori>();
                cmd.CommandText = "SELECT ID, Isim, Durum FROM Kategoriler";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
               
                while (reader.Read())
                {
                    Kategori k = new Kategori();
                    k.ID = reader.GetInt32(0);
                    k.Isim = reader.GetString(1);
                    k.Durum = reader.GetBoolean(2);
                    kategoriler.Add(k);
                }
                return kategoriler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public void KategoriDurumDegistir(int id)
        {
            try
            {
                cmd.CommandText = "SELECT Durum FROM Kategoriler WHERE ID =@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                bool durum = Convert.ToBoolean(cmd.ExecuteScalar());
                cmd.CommandText = "UPDATE Kategoriler SET Durum =@d WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@d", !durum);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void KategoriSil(int id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM Kategoriler WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public Kategori KategoriGetir(int id)
        {
            try
            {
                cmd.CommandText = "SELECT * FROM Kategoriler WHERE ID =@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                Kategori kat = null;
                while (reader.Read())
                {
                    kat = new Kategori();
                    kat.ID = reader.GetInt32(0);
                    kat.Isim = reader.GetString(1);
                    kat.Durum = reader.GetBoolean(2);
                   
                }
                return kat;

            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool KategoriDuzenle(Kategori model)
        {
            try
            {
                cmd.CommandText = "UPDATE Kategoriler SET Isim =@isim, Durum=@durum WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", model.ID);
                cmd.Parameters.AddWithValue("@isim", model.Isim);
                cmd.Parameters.AddWithValue("@durum", model.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion
    }
}
