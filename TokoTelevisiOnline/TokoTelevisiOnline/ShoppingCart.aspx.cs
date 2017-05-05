using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoTelevisiOnline.model;

namespace TokoTelevisiOnline
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (ModifShoppingCart usersShoppingCart = new ModifShoppingCart())
            {
                decimal cartTotal = 0;
                cartTotal = usersShoppingCart.GetTotal();
                if (cartTotal > 0)
                {
                    lblTotal.Text = String.Format("{0:c}", cartTotal);
                }
                else
                {
                    LabelTotalText.Text = "";
                    lblTotal.Text = "";
                    ShoppingCartTitle.InnerText = "Tidak ada produk yang dipesan pada troli";
                    BtnUbah.Visible = false;
                }
            }
        }

        public List<CartItem> GetShoppingCartItem()
        {
            ModifShoppingCart modifikasi = new ModifShoppingCart();
            return modifikasi.GetCartItem();

        }

        public List<CartItem> UbahCartItem()
        {
            using (ModifShoppingCart usersShoppingCart = new ModifShoppingCart())
            {
                String cartId = usersShoppingCart.GetCartId();

                ModifShoppingCart.UbahShoppingCart[] ubahCart = new ModifShoppingCart.UbahShoppingCart[GridView1.Rows.Count];
                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    IOrderedDictionary rowValues = new OrderedDictionary();
                    rowValues = GetValue(GridView1.Rows[i]);
                    ubahCart[i].ProdukId = Convert.ToInt32(rowValues["ProdukID"]);

                    CheckBox cbHapus = new CheckBox();
                    cbHapus = (CheckBox)GridView1.Rows[i].FindControl("HapusCheckBox");
                    ubahCart[i].HapusItem = cbHapus.Checked;

                    TextBox UbahJumlahTextBox = new TextBox();
                    UbahJumlahTextBox = (TextBox)GridView1.Rows[i].FindControl("JumlahTextBox");
                    ubahCart[i].JumlahTextBox = Convert.ToInt16(UbahJumlahTextBox.Text.ToString());

                }
                usersShoppingCart.UbahShoppingCartDatabase(cartId, ubahCart);
                GridView1.DataBind();
                lblTotal.Text = String.Format("{0:c}", usersShoppingCart.GetTotal());
                return usersShoppingCart.GetCartItem();
            }
        }
        public static IOrderedDictionary GetValue(GridViewRow row)
        {
            IOrderedDictionary values = new OrderedDictionary();
            foreach (DataControlFieldCell cell in row.Cells)
            {
                if (cell.Visible)
                {
                    cell.ContainingField.ExtractValuesFromCell(values, cell, row.RowState, true);
                }
            }
            return values;
        }
        protected void BtnUbah_Click(object sender, EventArgs e)
        {
            UbahCartItem();
        }
    }
}
