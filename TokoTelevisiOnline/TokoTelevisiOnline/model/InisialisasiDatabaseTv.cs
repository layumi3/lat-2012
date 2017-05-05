using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TokoTelevisiOnline.model
{
    public class InisialisasiDatabaseTv :
        DropCreateDatabaseIfModelChanges<ProdukContext>
    {
        protected override void Seed(ProdukContext context)
        {
            GetDataKategori().ForEach(c => context.DataKategori.Add(c));
            GetDataProduk().ForEach(p => context.DataProduk.Add(p));
        }
        private static List<Kategori> GetDataKategori()
        {
            var Kategori = new List<Kategori>{
                new Kategori
                {
                    KategoriID=1,
                    NamaKategori="Tabung"
                },
               
                new Kategori
                {
                    KategoriID=2,
                    NamaKategori="Plasma"
                },
             
                new Kategori
                {
                    KategoriID=3,
                    NamaKategori="LED"
                },
               
                new Kategori
                {
                    KategoriID=4,
                    NamaKategori="LCD"
                },
               
                new Kategori
                {
                    KategoriID=5,
                    NamaKategori="Aksesoris"
                }
        };
            return Kategori;
        }
        private static List<Produk> GetDataProduk()
        {
            var produk = new List<Produk>{
                new Produk{
                    ProdukId=1,
                    NamaProduk="LCD LG 42 inch",
                    Deskripsi="Sebuah Televisi layar datar yang di tujukan bagi Anda dengan design stylis",
                    Gambar="Images/tv/lcd/Akira CT-14HS9_400rb.gif",
                    Harga=500000,
                    KategoriID=1

                },
                                new Produk{
                    ProdukId=2,
                    NamaProduk="Plasma Sharp ",
                    Deskripsi="Sebuah Televisi layar datar yang di tujukan bagi Anda dengan design stylis dan serasi untuk ruangan anda",
                    Gambar="Images/tv/lcd/lg1.jpg",
                    Harga=500000,
                    KategoriID=2

                },
                                new Produk{
                    ProdukId=3,
                    NamaProduk="LED LG 42 inch",
                    Deskripsi="Sebuah Televisi layar datar yang di tujukan bagi Anda dengan design stylis",
                    Gambar="Images/tv/lcd/lg1.jpg",
                    Harga=500000,
                    KategoriID=3

                },
                              new Produk{
                    ProdukId=4,
                    NamaProduk="LED LG 42 inch",
                    Deskripsi="Sebuah Televisi layar datar yang di tujukan bagi Anda dengan design stylis",
                    Gambar="Images/tv/lcd/lg1.jpg",
                    Harga=500000,
                    KategoriID=3

                },              new Produk{
                    ProdukId=5,
                    NamaProduk="LED LG 42 inch",
                    Deskripsi="Sebuah Televisi layar datar yang di tujukan bagi Anda dengan design stylis",
                    Gambar="Images/tv/lcd/depopelita_polytron_PLD20D302_blk-20.jpg",
                    Harga=500000,
                    KategoriID=3

                },
                                new Produk{
                    ProdukId=6,
                    NamaProduk="Panasonic 14 Inch",
                    Deskripsi="Sebuah Televisi layar datar yang di tujukan bagi Anda dengan design stylis",
                    Gambar="Images/tv/lcd/lg1.jpg",
                    Harga=200000,
                    KategoriID=1

                }

            };
            return produk;
        }
    }
}