<%@ Page Title="" Language="C#" MasterPageFile="~/YoneticiPanel/YoneticiMaster.Master" AutoEventWireup="true" CodeBehind="KategoriEkle.aspx.cs" Inherits="BiliYorumWebApp.YoneticiPanel.KategoriEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formTasiyici">
        <div class="formBaslik">
            <h3>Kategori Ekle</h3>
        </div>
        <div class="formIcerik">
            <asp:Panel ID="pnl_hata" runat="server" CssClass="hatapanel" Visible="false">
                <asp:Label ID="lbl_mesaj" runat="server"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnl_basarili" runat="server" CssClass="basarilipanel" Visible="false">
                Kategori başarı ile eklenmiştir
            </asp:Panel>
            <div class="satir">
                <label>Kategori Adı</label><br />
                <asp:TextBox ID="tb_isim" runat="server" CssClass="metinKutu"></asp:TextBox>
            </div>
            <div class="satir satirbosluk">
                <asp:LinkButton ID="lbtn_kaydet" runat="server" CssClass="islemButon" OnClick="lbtn_kaydet_Click">Kategori Ekle</asp:LinkButton>
            </div>
        </div>
    </div>
</asp:Content>
