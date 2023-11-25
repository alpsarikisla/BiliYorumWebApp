using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiliYorumWebApp.YoneticiPanel
{
    public partial class YoneticiGiris : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Sayfa Yüklenirken/yüklenmeden önce çalışan metot
            //tb_kullaniciAdi.Text = "Selam!!!!";
        }

        protected void btn_giris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_kullaniciAdi.Text) && !string.IsNullOrEmpty(tb_sifre.Text))
            {
                Yonetici yonetici = dm.YoneticiGiris(tb_kullaniciAdi.Text, tb_sifre.Text);
                if (yonetici != null)
                {
                    Session["yonetici"] = yonetici;
                    Response.Redirect("Anasayfa.aspx");
                }
                else
                {
                    pnl_hata.Visible = true;
                    lbl_mesaj.Text = "Kullanıcı bulunamadı. Bilgileri kontrol ediniz.";
                }
            }
            else
            {
                pnl_hata.Visible = true;
                lbl_mesaj.Text = "Kullanıcı Adı ve şifre boş bırakılmamalıdır";
            }
        }
    }
}