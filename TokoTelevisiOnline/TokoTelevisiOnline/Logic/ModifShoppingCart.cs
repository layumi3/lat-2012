using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoTelevisiOnline.model
{
    public class ModifShoppingCart : IDisposable
    {
        public string ShoppingCartId { get; set; }
        private ProdukContext _db = new ProdukContext();
        public const string CartSessionKey = "CartId";
        public void TambahItem(int id)
        {
            ShoppingCartId = GetCartId();

            var cartItem = _db.DataShoppingCart.SingleOrDefault(
                c => c.CartId == ShoppingCartId && c.ProdukId == id);

            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    ItemId = Guid.NewGuid().ToString(),
                    ProdukId = id,
                    CartId = ShoppingCartId,
                    Produk = _db.DataProduk.SingleOrDefault(
                    p => p.ProdukId == id),
                    Jumlah = 1,
                    Tanggal = DateTime.Now

                };
                _db.DataShoppingCart.Add(cartItem);
            }
            else
            {
                cartItem.Jumlah++;
            }
                _db.SaveChanges();

            }
            public void Dispose()
            {
                if (_db != null)
                {
                    _db.Dispose();
                    _db= null;
                }
            }
        public string GetCartId()
        {
            if (HttpContext.Current.Session[CartSessionKey]==null)
            {
                if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
                {
                    HttpContext.Current.Session[CartSessionKey]=HttpContext.Current.User.Identity.Name;

                }else
                {
                    Guid tempCartId = Guid.NewGuid();
                    HttpContext.Current.Session[CartSessionKey] = 
                        tempCartId.ToString();
                }
            }
            return HttpContext.Current.Session[CartSessionKey].ToString();
        }
        public List<CartItem> GetCartItem()
        {
            ShoppingCartId = GetCartId();
            return _db.DataShoppingCart.Where(c =>c.CartId == ShoppingCartId).ToList();
        }
        public decimal GetTotal()
        {
            ShoppingCartId = GetCartId();
            decimal? total = decimal.Zero;
            total =(decimal?)(from cartItem in _db.DataShoppingCart where cartItem.CartId == ShoppingCartId select (int?) cartItem.Jumlah * cartItem.Produk.Harga).Sum();
            return total ?? decimal.Zero;
        }

        public ModifShoppingCart GetCart(HttpContext context)
        {
            using (var cart = new ModifShoppingCart())
            {
                cart.ShoppingCartId = cart.GetCartId(); 
                return cart;

            }
        }
        public void UbahShoppingCartDatabase(String cartId, UbahShoppingCart[] UbahCartItem)
        {
            using (var db = new TokoTelevisiOnline.model.ProdukContext())
            {
                try 
                {
                    int CartItemCount = UbahCartItem.Count();
                    List<CartItem> myCart = GetCartItem();
                    foreach (var cartItem in myCart)
             {
                        for (int i = 0; i <CartItemCount; i++)
                        {
                            if (cartItem.Produk.ProdukId == UbahCartItem[i]. ProdukId)
                            {
                                if (UbahCartItem[i].JumlahTextBox < 1 || UbahCartItem[i].HapusItem == true)
                                {
                                    HapusItem(cartId, cartItem.ProdukId);
                                }
                                else
                                {
                                    UbahItem(cartId, cartItem.ProdukId, UbahCartItem[i].JumlahTextBox);
                                }
                            }
                    }
            }
        }
                catch (Exception exp)
                {
                    throw new Exception ("Error: Ubah Cart Database tidak berhasil - " + exp.Message.ToString(), exp);

                }
            }

        }
            public void HapusItem(string hapusCartID, int hapusProdukID)
            {
                using (var _db = new TokoTelevisiOnline.model.ProdukContext())
                {
                    try
                    {
                        var myItem = (from c in _db.DataShoppingCart where c.CartId == hapusCartID && c.Produk.ProdukId == hapusProdukID select c).FirstOrDefault();
                        if (myItem != null)
                        {
                            _db.DataShoppingCart.Remove(myItem);
                            _db.SaveChanges();
                        }
                    }
                    catch (Exception exp)
                    {
                        throw new Exception("ERROR: Cart Item tidak berhasil dihapus " + exp.Message.ToString(), exp);

                    }
                }
                }
            public void UbahItem(string ubahCartID, int ubahProdukID, int jumlah)
            {
                using (var _db = new TokoTelevisiOnline.model.ProdukContext())
                {
                    try
                    {
                        var myItem = (from c in _db.DataShoppingCart where c.CartId == ubahCartID && c.Produk.ProdukId == ubahProdukID select c).FirstOrDefault();
                        if (myItem != null)
                        {
                            myItem.Jumlah = jumlah;
                            _db.SaveChanges();
                        }
                    }
                    catch (Exception exp)
                    {
                        throw new Exception("ERROR: Unable to Updte cart Item - " + exp.Message.ToString(), exp);
                    }
                }
            }
                public void HapusSemuaCart()
                {
                    ShoppingCartId = GetCartId();
                    var semuacartItem = _db.DataShoppingCart.Where(
                        c => c.CartId == ShoppingCartId);
                    foreach (var cartItem in semuacartItem)
                    {
                        _db.DataShoppingCart.Remove(cartItem);
                    }
                    //simpan perubahan
                    _db.SaveChanges();
                }
            
    public int GetCount()
    {
    ShoppingCartId = GetCartId();
    int? count = (from cartItem in _db.DataShoppingCart where cartItem.CartId == ShoppingCartId select (int?)cartItem.Jumlah).Sum();
    return count ?? 0;
    }
        public struct UbahShoppingCart
        {
            public int ProdukId;
            public int JumlahTextBox;
            public bool HapusItem;
        }
        }
    }
