<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="TokoTelevisiOnline.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <div id="ShoppingCartTitle" runat="server" class="ContentHead">
        <h1> Shopping Cart</h1>

    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" ShowFooter="true" CellPadding="4" GridLines="Vertical" ItemType="TokoTelevisiOnline.model.CartItem" SelectMethod="GetShoppingCartItem" CssClass="table table-striped table-bordered">
        <Columns>
            <asp:BoundField DataField="ProdukID" HeaderText="Produk ID " SortExpression="ProdukID" />
            <asp:BoundField DataField="Produk.NamaProduk" HeaderText="Nama Produk" />
            <asp:BoundField DataField="Produk.Harga" HeaderText="Harga Satuan" DataFormatString="{0:c}" />
            <asp:TemplateField HeaderText="Jumlah">
                <ItemTemplate>
                <asp:TextBox ID="JumlahTextBox" width="40" runat="server" Text="<%#: Item.Jumlah %>">
                </asp:TextBox>
                    </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Item Total">
                <ItemTemplate>
                    <%#: String.Format("{0:c}",((Convert.ToDouble(Item.Jumlah))*Convert.ToDouble(Item.Produk.Harga))) %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox id="HapusCheckBox" runat="server" />

                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <div>
    <p>

    </p>
    <strong>
        
        
        <asp:Label ID="LabelTotalText" runat="server" Text="Order Total"></asp:Label>
        <asp:Label ID="lblTotal" runat="server" EnableViewState="false"></asp:Label>
    </strong>
        </div>
    <br />
    <table>
        <tr>
            <td>
                <asp:Button ID="BtnUbah" runat="server" Text="Ubah" OnClick="BtnUbah_Click" />
            </td>
        </tr>
    </table>

</asp:Content>

