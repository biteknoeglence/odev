using Odev5gun.Concreate;
using Odev5gun.Entities;
using System;

namespace Odev5gun
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Kayıt olma servisi oluştur
            RegisterManager register = new RegisterManager(new CheckRealPerson());

            //Hesap kimlik servisi oluştur
            AccountManager accountManager = new AccountManager();

            //market sistemi oluştur
            ShopManager shopManager = new ShopManager();

            //ürün kampanya sistemi oluştur
            DiscountManager discountManager = new DiscountManager();

            //kampanya oluştur
            ProductDiscount KisIndirimi = new ProductDiscount()
            {
                DiscountName = "Kış İndirimi",
                DiscountValue = 50,
            };

            ProductDiscount YazIndirimi = new ProductDiscount()
            {
                DiscountName = "Yaz İndirimi",
                DiscountValue = 75,
            };

            // oyun içi ürün oluştur
            Product DolunayKilici = new Product()
            {
                Id = 1,
                Name = "+6 Dolunay kılıcı",
                Price = 50,
            };

            Account uye1 = new Member()
            {
                TcNo = "5416415",
                Id = 5,
                Name = "army",
                Password = "asd",
                FirstName = "Elif",
                LastName = "Yüksel",
                DateBirth = new DateTime(1979, 6, 5)
            };

            //simule edilmiş özellikler
            //kontrol et ve kullanıcıyı sisteme ekle
            register.Save(uye1);

            //kullanıcıyı güncelleştir
            accountManager.Update(uye1);

            //kullanıcı ürünü satın alır
            shopManager.Buy(uye1, DolunayKilici);

            //ürüne kampanya eklenir
            discountManager.Add(DolunayKilici, KisIndirimi);

            //kullanıcı kampanya almış ürünü satın alır
            shopManager.Buy(uye1, DolunayKilici);

            //üründen kampanya silinir
            discountManager.Remove(DolunayKilici, KisIndirimi);

            //ürüne kampanya eklenir
            discountManager.Update(DolunayKilici, YazIndirimi);

            //kullanıcı sil
            accountManager.Delete(uye1);



            //

        }
    }
}
