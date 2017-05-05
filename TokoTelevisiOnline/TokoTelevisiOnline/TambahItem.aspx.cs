using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoTelevisiOnline.model;

namespace TokoTelevisiOnline
{
    public partial class TambahItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rawId = Request.QueryString["ProdukID"];
            int produkId;
            if (!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out produkId))
            {
                using (ModifShoppingCart usersShoppingCart = new ModifShoppingCart())
                {
                    usersShoppingCart.TambahItem(Convert.ToInt16(rawId));
                }

            }
            else {
                Debug.Fail("ERROR : Penambahan produk yang akan dibeli pada halaman TambahItem.aspx tidak dapat dilakukan tanpa ProdukId.");

                throw new Exception("ERROR: Tidak diizinkan memanggil halaman TambahItem.aspx tanpa menentukan PRodukId telebih dahulu.");

            }
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}