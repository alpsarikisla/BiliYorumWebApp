<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YoneticiGiris.aspx.cs" Inherits="BiliYorumWebApp.YoneticiPanel.YoneticiGiris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Yönetici Giriş</title>
    <link href="css/YoneticiGirisStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <%-- Tüm aspx kontrolleri form etiketi içerisinde olmak zorundadır. --%>
        <div class="girisPanel">
            <div class="sol">
                <img src="SiteResimleri/slidebanklogin.gif" />
            </div>
            <div class="sag">
                <div class="satir">
                    <asp:Panel ID="pnl_hata" runat="server" CssClass="hatapanel" Visible="false">
                        <asp:Label ID="lbl_mesaj" runat="server"></asp:Label>
                    </asp:Panel>
                </div>
                <div class="satir">
                    <h2>Yönetici Giriş</h2>
                </div>
                <div class="satir">
                    <label>Kullanıcı Adı:</label><br />
                    <asp:TextBox ID="tb_kullaniciAdi" runat="server" CssClass="metinKutu" placeholder="Kullanıcı Adınız"></asp:TextBox>
                </div>
                <div class="satir">
                    <label>Şifre</label><br />
                    <asp:TextBox ID="tb_sifre" runat="server" CssClass="metinKutu" placeholder="Şifreniz" TextMode="Password"></asp:TextBox>
                </div>
                <div class="satir">
                    <asp:Button ID="btn_giris" runat="server" OnClick="btn_giris_Click" Text="Giriş Yap" CssClass="girisButon"/>
                </div>
            </div>
            <div style="clear:both"></div>
        </div>
    </form>
</body>
</html>
