<%@ Page Title="" Language="C#" MasterPageFile="~/YoneticiPanel/YoneticiMaster.Master" AutoEventWireup="true" CodeBehind="KategoriListele.aspx.cs" Inherits="BiliYorumWebApp.YoneticiPanel.KategoriListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/ListeStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="listetasiyici">
        <div class="listebaslik">
            <h3>Kategoriler</h3>
        </div>
        <div class="listeicerik">
            <asp:ListView ID="lv_kategoriler" runat="server" OnItemCommand="lv_kategoriler_ItemCommand">
                <LayoutTemplate>
                    <table cellpadding="0" cellspacing="0">
                        <tr>
                            <th>ID</th>
                            <th>Isim</th>
                            <th>Durum</th>
                            <th width="20%">Seçenekler</th>
                        </tr>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("ID") %></td>
                        <td><%# Eval("Isim") %></td>
                        <td><%# Eval("Durum") %></td>
                        <td>
                            <a href="#" title="Düzenle">
                                <img src="SiteResimleri/pen.png" /></a>
                            <asp:LinkButton ID="lbtn_durum" runat="server" title="Durum Değiştir" CommandName="durum" CommandArgument='<%# Eval("ID") %>'><img src="SiteResimleri/recycle.png" /></asp:LinkButton>
                            <asp:LinkButton ID="lbtn_sil" runat="server" title="sil" CommandName="sil"  CommandArgument='<%# Eval("ID") %>'><img src="SiteResimleri/trash-bin.png" /></asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>
</asp:Content>
