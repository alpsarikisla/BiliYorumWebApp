<%@ Page Title="" Language="C#" MasterPageFile="~/YoneticiPanel/YoneticiMaster.Master" AutoEventWireup="true" CodeBehind="MakaleEkle.aspx.cs" Inherits="BiliYorumWebApp.YoneticiPanel.MakaleEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Plugins/ckeditor/ckeditor.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="formTasiyici">
        <div class="formBaslik">
            <h3>Makale Ekle</h3>
        </div>
        <div class="formIcerik">
            <asp:Panel ID="pnl_hata" runat="server" CssClass="hatapanel" Visible="false">
                <asp:Label ID="lbl_mesaj" runat="server"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnl_basarili" runat="server" CssClass="basarilipanel" Visible="false">
                Kategori başarı ile eklenmiştir
            </asp:Panel>
            <div class="icerikSol">
                <div class="satir">
                    <label>Makale Başlık</label><br />
                    <asp:TextBox ID="tb_isim" runat="server" CssClass="metinKutu"></asp:TextBox>
                </div>
                <div class="satir satirbosluk">
                    <label>Kategori Seçiniz</label><br />
                    <asp:DropDownList ID="ddl_kategoriler" runat="server" CssClass="metinKutu" DataTextField="Isim" DataValueField="ID" Style="width: 97%"></asp:DropDownList>
                </div>
                <div class="satir satirbosluk">
                    <label>Makale Kapak Resmi</label><br />
                    <asp:FileUpload ID="fu_resim" runat="server" CssClass="metinKutu" />
                </div>
                <div class="satir satirbosluk">
                    <label>Özet</label><br />
                    <asp:TextBox ID="tb_ozet" runat="server" CssClass="metinKutu" TextMode="MultiLine"></asp:TextBox>
                </div>
                <div class="satir satirbosluk">
                    <label>Durum</label><br />
                    <asp:CheckBox ID="cb_aktif" runat="server" Text="Aktif " TextAlign="Left" />
                </div>
            </div>
            <div class="icerikSag">
                <div class="satir">
                    <label>İçerik</label><br />
                    <asp:TextBox ID="tb_icerik" runat="server" TextMode="MultiLine" CssClass="metinKutu"></asp:TextBox>
                    <script>
                        CKEDITOR.replace('ContentPlaceHolder1_tb_icerik');
                    </script>
                </div>
                <div class="satir satirbosluk">
                    <asp:LinkButton ID="lbtn_kaydet" runat="server" CssClass="islemButon" OnClick="lbtn_kaydet_Click">Makale Ekle</asp:LinkButton>
                </div>
            </div>
            <div style="clear: both">
            </div>
        </div>
    </div>
</asp:Content>
