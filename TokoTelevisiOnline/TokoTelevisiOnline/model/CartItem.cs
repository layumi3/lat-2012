using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TokoTelevisiOnline.model
{
    public class CartItem
    {
        [Key]
        public string ItemId { get; set; }

        public string CartId { get; set; }

        public int Jumlah { get; set; }

        public System.DateTime Tanggal { get; set; }

        public int ProdukId { get; set; } //dari inisialisasi database

        public virtual Produk Produk { get; set; }
    }
}