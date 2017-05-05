<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProdukDetail.aspx.cs" Inherits="TokoTelevisiOnline.ProdukDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">


<asp:FormView ID="FormView1" runat="server" ItemType="TokoTelevisiOnline.model.Produk" SelectMethod="GetProduk" RenderOuterTable="false">
    <ItemTemplate>
        <div>
            <h1>
                <%#: Item.NamaProduk %>
            </h1>
        </div>
        <br />
        <table>
            <tr>
                <td>
                    <img src="<%#: Item.Gambar %>" style="border:solid;height: 300px" alt="<%#: Item.NamaProduk %>" />

                </td>
                <td>
                    &nbsp;
                </td>
                <td style="vertical-align:top;text-align:left;">
                    <b>
                        Deskripsi:

                    </b><br />
                    <span>
                        <b> Harga : </b> &nbsp;<%#:String.Format("{0:c}", Item.Harga) %>
                    </span>
                    <br />
                    <span>
                        <b>
                            No Produk 
                        </b> &nbsp; <%#:Item.ProdukId %>
                    </span>
                </td>
            </tr>
        </table>
    </ItemTemplate>

</asp:FormView>
    </asp:Content>