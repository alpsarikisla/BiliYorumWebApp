﻿using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiliYorumWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            rp_Makale.DataSource = dm.MakaleListele();
            rp_Makale.DataBind();
        }
    }
}