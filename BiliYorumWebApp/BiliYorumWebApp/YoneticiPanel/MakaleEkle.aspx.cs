using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.IO;
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
            if (!IsPostBack)
            {
                ddl_kategoriler.DataSource = dm.KategoriListele(true);
                ddl_kategoriler.DataBind();
            }
        }

        protected void lbtn_kaydet_Click(object sender, EventArgs e)
        {
            Makale mak = new Makale();
            mak.Baslik = tb_isim.Text;
            mak.Ozet = tb_ozet.Text;
            //Ck editör kullanıldığı için web.config dosyasına requestValidationMode="2.0" yazdık
            mak.Icerik = tb_icerik.Text;
            mak.Durum = cb_aktif.Checked;
            Yonetici y = (Yonetici)Session["yonetici"];
            mak.Yazar_ID = y.ID;
            mak.EklemeTarih = DateTime.Now;
            mak.Kategori_ID = Convert.ToInt32(ddl_kategoriler.SelectedItem.Value);
            mak.GoruntulemeSayi = 0;
            mak.Silinmis = false;

            if(fu_resim.HasFile)//FileUpload'ta dosya seçilmiş ise
            {
                FileInfo fi = new FileInfo(fu_resim.FileName);
                string isim = Guid.NewGuid().ToString();
                string uzanti = fi.Extension;//.jpg .png
                string dosyaIsim = isim + uzanti;
                fu_resim.SaveAs(Server.MapPath("../MakaleResimleri/" + dosyaIsim));
                mak.Resim = dosyaIsim;
            }
            else
            {
                mak.Resim = "none.gif";
            }

            if (dm.MakaleEkle(mak))
            {
                pnl_basarili.Visible = true;
                pnl_hata.Visible = false;
            }
            else
            {
                pnl_basarili.Visible = false;
                lbl_mesaj.Text = "Makale eklenirken bir hata oluştu";
                pnl_hata.Visible = true;
            }
        }
    }
}