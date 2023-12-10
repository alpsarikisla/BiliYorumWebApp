using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiliYorumWebApp.YoneticiPanel
{
    public partial class MakaleEkle : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            ddl_kategoriler.DataSource = dm.KategoriListele(true);
            ddl_kategoriler.DataBind();
        }

        protected void lbtn_kaydet_Click(object sender, EventArgs e)
        {

        }
    }
}