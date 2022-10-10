using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string BrandListed = "Ürünler Listelendi!";
        public static string BrandAdded = "Ürünler Eklendi!";
        public static string BrandDeleted = "Ürünler Silindi!";
        public static string BrandUpdated = "Ürünler Güncellendi";

        public static string CategoryListed = "Kategori Listelendi!";
        public static string CategoryAdded = "Kategori Eklendi!";
        public static string CategoryDeleted = "Kategori Silindi!";
        public static string CategoryUpdated = "Kategori Güncellendi";

        public static string ColourListed = "Renk Listelendi!";
        public static string ColourAdded = "Renk Eklendi!";
        public static string ColourDeleted = "Renk Silindi!";
        public static string ColourUpdated = "Renk Güncellendi";

        public static string CommentListed = "Yorum Listelendi!";
        public static string CommentAdded = "Yorum Eklendi!";
        public static string CommentDeleted = "Yorum Silindi!";
        public static string CommentUpdated = "Yorum Güncellendi";

        public static string OperationClaimsListed = "Operasyon Talepleri Listelendi!";
        public static string OperationClaimsAdded = "Operasyon Talepleri Eklendi!";
        public static string OperationClaimsDeleted = "Operasyon Talepleri Silindi!";
        public static string OperationClaimsUpdated = "Operasyon Talepleri Güncellendi";

        public static string OrdersListed = "Siparişler Listelendi!";
        public static string OrdersListedByUserId = "Kullanıcı Id için Siparişler Listelendi!";
        public static string OrdersListedByProduct = "Ürünler için Siparişler Listelendi";
        public static string OrdersAdded = "Siparişler Eklendi!";
        public static string OrdersDeleted = "Siparişler Silindi!";
        public static string OrdersUpdated = "Siparişler Güncellendi";

        public static string ProductListed = "Ürünler Listelendi!";
        public static string ProductListedById = "Id'ye Göre Listelenen Ürün";
        public static string ProductListedByName = "İsme Göre Listelenen Ürün";
        public static string ProductsListedByCategory = " Kategoriye Göre Listelenen Ürün";
        public static string ProductsListedByBrand = "Markaya Göre Listelenen Ürün";
        public static string ProductsListedByColour = "Renge göre listelenen Ürün";
        public static string ProductAdded = "Ürün Eklendi!";
        public static string ProductDeleted = "Ürün Silindi!";
        public static string ProductUpdated = "Ürün Güncellendi";

        public static string SizeListed = "Boyut Listelendi!";
        public static string SizeAdded = "Boyut Eklendi!";
        public static string SizeDeleted = "Boyut Silindi!";
        public static string SizeUpdated = "Boyut Güncellendi";

        public static string SaleListed = "Satış Listelendi!";
        public static string SaleListedByProduct = "Ürüne göre Listelenen Satış";
        public static string SaleListedByBrand = "Markaya Göre Listelenen Satış";
        public static string SaleListedByCategory = "Kategoriye Göre Listenen Satış";
        public static string SaleAdded = "Satış Eklendi!";
        public static string SaleDeleted = "Satış Silindi!";
        public static string SaleUpdated = "Satış Güncellendi";

        public static string UserListed = "Kullanıcı Listelendi!";
        public static string UserAdded = "Kullanıcı Eklendi!";
        public static string UserDeleted = "Kullanıcı Silindi!";
        public static string UserUpdated = "Kullanıcı Güncellendi";

        public static string AuthorizationDenied = "AuthorizationDenied";
        public static string UserFound = "Kullanıcı Bulundu";
        public static string UserCouldNotFound = "Kullanıcı Bulunamadı";
        public static string UserAlreadyExist = "Kullanıcı Zaten Var";
        public static string UserIsNotExist = "Kullanıcı Mevcut Değil";
        public static string UserRegistered = "Kullanıcı Kayıtlı";
        public static string IncorrectPasswordOrUsername = "Yanlış Parola veya Kullanıcı Adı";
        public static string Welcome = "Hoş geldiniz !";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Yanlış Parola";
        public static string SuccessfulLogin = "Başarılı Giriş, Hoş Geldiniz";
        public static string AccessTokenCreated = "Token Oluşturuldu!";
    }
}
