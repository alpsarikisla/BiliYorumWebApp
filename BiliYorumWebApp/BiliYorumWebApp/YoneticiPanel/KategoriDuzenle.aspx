<%@ Page Title="" Language="C#" MasterPageFile="~/YoneticiPanel/YoneticiMaster.Master" AutoEventWireup="true" CodeBehind="KategoriDuzenle.aspx.cs" Inherits="BiliYorumWebApp.YoneticiPanel.KategoriDuzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="formTasiyici">
      <div class="formBaslik">
          <h3>Kategori Düzenle</h3>
      </div>
      <div class="formIcerik">
          <asp:Panel ID="pnl_hata" runat="server" CssClass="hatapanel" Visible="false">
              <asp:Label ID="lbl_mesaj" runat="server"></asp:Label>
          </asp:Panel>
          <asp:Panel ID="pnl_basarili" runat="server" CssClass="basarilipanel" Visible="false">
              Kategori başarı ile düzenlenmiştir
          </asp:Panel>
          <div class="satir">
              <label>Kategori Adı</label><br />
              <asp:TextBox ID="tb_isim" runat="server" CssClass="metinKutu"></asp:TextBox>
          </div>
          <div class="satir">
             <asp:CheckBox ID="cb_durum" runat="server" /> Aktif Kategori
          </div>
          <div class="satir satirbosluk">
              <asp:LinkButton ID="lbtn_duzenle" runat="server" CssClass="islemButon" OnClick="lbtn_duzenle_Click">Kategori Düzenle</asp:LinkButton>
          </div>
      </div>
  </div>
</asp:Content>
