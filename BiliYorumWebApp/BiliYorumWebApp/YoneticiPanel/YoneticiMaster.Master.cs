using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiliYorumWebApp.YoneticiPanel
{
    public partial class YoneticiMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Masterpage Yüklenirken yapılacak olanlar burada yazılır
            if (Session["yonetici"] != null)
            {
                Yonetici yon = (Yonetici)Session["yonetici"];//Unboxing
                lbtn_kullanici.Text = yon.KullaniciAdi;
            }
            else
            {
                Response.Redirect("YoneticiGiris.aspx");
            }
        }

        protected void lbtn_cikis_Click(object sender, EventArgs e)
        {
            Session["yonetici"] = null;
            Response.Redirect("YoneticiGiris.aspx");
        }
    }
}