<%@ Page Title="" Language="C#" MasterPageFile="~/YoneticiPanel/YoneticiMaster.Master" AutoEventWireup="true" CodeBehind="MakaleListele.aspx.cs" Inherits="BiliYorumWebApp.YoneticiPanel.MakaleListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/ListeStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="listetasiyici">
        <div class="listebaslik">
            <h3>Makaleler</h3>
        </div>
        <div class="listeicerik">
            <asp:ListView ID="lv_Makaleler" runat="server" OnItemCommand="lv_Makaleler_ItemCommand">
                <LayoutTemplate>
                    <table cellpadding="0" cellspacing="0">
                        <tr>
                            <th>Resim</th>
                            <th>ID</th>
                            <th>Başlık</th>
                            <th>Yazar</th>
                            <th>Kategori</th>
                            <th>Ekleme Tarihi</th>
                            <th>Durum</th>

                            <th width="20%">Seçenekler</th>
                        </tr>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <img src='../MakaleResimleri/<%# Eval("Resim") %>' width="80" /></td>
                        <td><%# Eval("ID") %></td>
                        <td><%# Eval("Baslik") %></td>
                        <td><%# Eval("Yazar") %></td>
                        <td><%# Eval("Kategori") %></td>
                        <td><%# Eval("EklemeTarih") %></td>
                        <td><%# Eval("Durum") %></td>
                        <td>
                            <a href='#' title="Düzenle">
                                <img src="SiteResimleri/pen.png" /></a>
                            <asp:LinkButton ID="lbtn_durum" runat="server" title="Durum Değiştir" CommandName="durum" CommandArgument='<%# Eval("ID") %>'><img src="SiteResimleri/recycle.png" /></asp:LinkButton>
                            <asp:LinkButton ID="lbtn_sil" runat="server" title="sil" CommandName="sil" CommandArgument='<%# Eval("ID") %>'><img src="SiteResimleri/trash-bin.png" /></asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>
</asp:Content>

