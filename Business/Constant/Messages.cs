using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constant
{
    public static class Messages
    {
        public static string CarAdded = "Araba ekleme başarılı.";
        public static string CarDeleted = "Araba silme başarılı.";
        public static string CarUpdated = "Araba güncelleme başarılı.";
        public static string CarListed = "Arabalar listelendi.";
        public static string CarGetById = "Verilen id ile uyuşan araba getirildi.";       
        public static string CarGetByIdBrand = "Marka id ile uyuşan arabalar getirildi.";
        public static string CarGetByIdColor = "Renk id ile uyuşan arabalar getirildi.";

        public static string ColorAdded = "Renk ekleme başarılı.";
        public static string ColorDeleted = "Renk silme başarılı.";
        public static string ColorUpdated = "Renk güncelleme başarılı.";
        public static string ColorListed = "Renkler listelendi.";
        public static string ColorGetById = "Verilen id ile uyuşan renk getirildi.";

        public static string BrandAdded = "Marka ekleme başarılı.";
        public static string BrandDeleted = "Marka silme başarılı.";
        public static string BrandUpdated = "Marka güncelleme başarılı.";
        public static string BrandListed = "Markalar listelendi.";
        public static string BrandGetById = "Verilen id ile uyuşan marka getirildi.";

        public static string RentalAdded = "Kiralama işlemi başarılı.";

        public static string SuccessListed = "Listeleme işlemi başarılı.";

        public static string AddedError = "Ekleme işlemi gerçekleştirilirken bir hata ile karşılaşıldı. Lütfen bilgileri kontrol ediniz.";
        public static string DeletedError = "Silme işlemi gerçekleştirilirken bir hata ile karşılaşıldı. Lütfen bilgileri kontrol ediniz.";
        public static string UpdatedError = "Güncelleme işlemi gerçekleştirilirken bir hata ile karşılaşıldı. Lütfen bilgileri kontrol ediniz.";
        public static string ListedError = "Listeleme gerçekleştirilemedi.";
        public static string CarValidateError = "Araç açıklaması 15 karakterden fazla olmalı veya aracın kirası 0'dan fazla olmalı.";
        public static string RequirementError = "Aranan gereksinime uygun eleman bulunamadı.";
        public static string IdError = "Id'ler uyuşmuyor.";
    }
}
