using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoTelevisiOnline.model;

namespace TokoTelevisiOnline
{
    public partial class ProdukDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Produk> GetProduk([QueryString("ProdukID")] int? produkId)
        {
            var _db = new TokoTelevisiOnline.model.ProdukContext();
            IQueryable<Produk> query = _db.DataProduk;
            if (produkId.HasValue && produkId > 0)
            {
                query = query.Where(p => p.ProdukId == produkId);
            }
            else {
                query = null;
            }
            return query;
        }
    }
}