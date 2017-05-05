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
    public partial class ProdukList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Produk> GetProduk([QueryString("id")] int? kategoriId)
        {
            var _db = new TokoTelevisiOnline.model.ProdukContext();
            IQueryable<Produk> query = _db.DataProduk;
            if (kategoriId.HasValue && kategoriId > 0)
            {
                query = query.Where(p=>p.KategoriID == kategoriId);
            }
            return query;
        }
    }
}