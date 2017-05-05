using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TokoTelevisiOnline.model
{
    public class ProdukContext : DbContext

    {
        public ProdukContext()  : base("TokoTelevisiOnline")
        { 
        
        }
        public DbSet<Kategori> DataKategori { get; set; }
        public DbSet<Produk> DataProduk { get; set; }
        public DbSet<CartItem> DataShoppingCart { get; set; }
    }
}