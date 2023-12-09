using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiliYorumWebApp.YoneticiPanel
{
    public partial class KategoriDuzenle : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //QueryString = ?kid ile belirtilen kısım
                if (Request.QueryString.Count != 0)
                {
                    int id = Convert.ToInt32(Request.QueryString["kid"]);
                    Kategori kat = dm.KategoriGetir(id);
                    if (kat != null)
                    {
                        tb_isim.Text = kat.Isim;
                        cb_durum.Checked = kat.Durum;
                    }
                    else
                    {
                        Response.Redirect("KategoriListele.aspx");
                    }
                }
                else
                {
                    Response.Redirect("KategoriListele.aspx");
                }
            }
        }

        protected void lbtn_duzenle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["kid"]);
            Kategori kat = new Kategori();
            kat.ID = id;
            kat.Isim = tb_isim.Text;
            kat.Durum = cb_durum.Checked;
            if (dm.KategoriDuzenle(kat))
            {
                pnl_basarili.Visible = true;
                pnl_hata.Visible = false;
            }
            else
            {
                pnl_basarili.Visible = false;
                pnl_hata.Visible = true;
                lbl_mesaj.Text = "Kategori düzenlerken bir hata oluştu";
            }
        }
    }
}