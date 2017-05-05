using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TokoTelevisiOnline.model
{
    public class Kategori
    {
        [ScaffoldColumn(false)]
        public int KategoriID { get; set; }
        
        [Required, StringLength(100), Display(Name = "Nama")]
        public string NamaKategori { get; set; }

        [Display(Name = "Deskripsi Produk")]
        public string Deskripsi { get; set; }

        public virtual ICollection<Produk> DataProduk { get; set; }
    }
}