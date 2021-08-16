using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "ürün eklendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz";
        public static string MaintenanceTime = "sistem bakımda";
        public static string ProductListed = "ürünler listelendi";
        public static string ProductCountOfError = "kategoriye ait ürün sayısı 10dan büyük olamaz";
        public static string ProductNameAlreadyExists = "bu isimde başka bir ürün zaten var";
        public static string CategoryLimitExists = "kategori limiti aşıldı.. yeni ürün eklenemiyor";
    }
}
