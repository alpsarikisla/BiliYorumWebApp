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
        SqlConnection con;SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            cmd = con.CreateCommand();
        }

        #region Giriş

        public Yonetici YoneticiGiris(string kullaniciAdi, string sifre)
        {
            try
            {
                cmd.CommandText = "SELECT Y.ID, Y.Yetki_ID, YO.Isim, Y.Isim,Y.Soyisim,Y.KullaniciAdi,Y.Sifre,Y.IsDeleted,Y.IsActive FROM Yoneticiler AS Y JOIN YoneticiYetkiler AS YO ON Y.Yetki_ID = YO.ID WHERE Y.KullaniciAdi = @ka AND Y.Sifre = @s";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ka", kullaniciAdi);
                cmd.Parameters.AddWithValue("@s", sifre);
                con.Open();
                Yonetici y = null;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    y = new Yonetici();
                    y.ID = reader.GetInt32(0);
                    y.Yetki_ID = reader.GetInt32(1);
                    y.YetkiIsim = reader.GetString(2);
                    y.Isim = reader.GetString(3);
                    y.Soyisim = reader.GetString(4);
                    y.KullaniciAdi = reader.GetString(5);
                    y.Sifre = reader.GetString(6);
                    y.IsDeleted = reader.GetBoolean(7);
                    y.IsActive = reader.GetBoolean(8);
                }
                return y;
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

        #endregion
    }
}
