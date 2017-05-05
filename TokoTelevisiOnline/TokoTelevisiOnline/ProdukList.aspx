
<%@ Page Title="ProdukList" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProdukList.aspx.cs" Inherits="TokoTelevisiOnline.ProdukList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <section>
        <div>
            <hgroup>
                <h2>
                    Masuk
                    <%#: Page.Title %>
                </h2>
            </hgroup>
           <asp:ListView ID="ProdukID" runat="server" GroupItemCount="4" ItemType="TokoTelevisiOnline.model.Produk" SelectMethod="GetProduk">
                <EmptyDataTemplate>
                    <table>
                        <tr>
                            <td>
                                Data Tidak tersedia
                            </td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyDataTemplate>
                    <td>

                    </td>
                </EmptyDataTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>

                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="ProdukDetail.aspx?produkID=<%#: Item.ProdukId %>">
                                        <img src="<%#: Item.Gambar %>" width="131" height="217" style="border:solid" />
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="ProdukDetail.aspx?produkID=<%#: Item.ProdukId %>"> 
                                        <span>
                                            <%#:Item.NamaProduk %>
                                        </span>
                                    </a>
                                    <br />
                                    <span>
                                        <b>
                                            Harga : 
                                        </b><%#:String.Format("{0:c}",Item.Harga) %>
                                    </span>
                                    <br />
                                    <a href="/TambahItem.aspx?produkID=<%#: Item.ProdukId %>">
                                        <span class="ProdukListItem">
                                            <b>
                                                Tambah Item
                                            </b>
                                        </span>
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width:100px;">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                        <tr id="groupPlaceholder">

                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>
</asp:Content>
