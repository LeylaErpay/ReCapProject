using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {

        public static string CarAdded = "ürün eklendi";
        public static string CarNameInvalid = "ürün adı geçersiz";
        public static string MaintenanceTime = "sistem bakımda";
        public static string CarsListed = "ürünler listelendi";
        public static string CarNotRented = "kiralanamadı";
        public static string CarRented = "kiralandı";
        public static string UserAdded = "kullanıcı eklendi";
        public static string UserDeleted = "kullanıcı silindi";
        public static string UserUpdated = "kullanıcı güncellendi";

        public static string RentalAddedError { get; internal set; }
        public static string RentalAdded { get; internal set; }
        public static string Updated { get; internal set; }
        public static string Deleted { get; internal set; }
    }
}
