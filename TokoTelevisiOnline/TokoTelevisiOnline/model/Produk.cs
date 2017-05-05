using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TokoTelevisiOnline.model
{
    public class Produk
    {
        [ScaffoldColumn(false)]
        public int ProdukId { get; set; }

        [Required, StringLength(100), Display(Name = "Nama")]
        public string NamaProduk { get; set; }

        [Required, StringLength(1000), Display(Name = "Diskripsi Produk"),DataType(DataType.MultilineText)]
        public string Deskripsi { get; set; }

        public string Gambar { get; set; }

        [Display(Name = "Harda")]
        public double? Harga { get; set; }

        public int? KategoriID { get; set; }
        public virtual Kategori Kategori { get; set; }
    }
}