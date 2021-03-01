using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages //static verilince newlenmesine gerek yok
    {
        public static string CarAdded = "Araba eklendi."; //publicler büyük yazılır
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarNameInvalid = "Araba ismi geçersiz.";
        public static string CarsListed = "Arabalar listelendi";
        public static string ColorAdded="Renk eklendi.";
        public static string ColorDeleted="Renk silindi.";
        public static string ColorUpdated="Renk güncellendi.";
        public static string ColorSelected="Renk seçildi.";
        public static string BrandUpdated="Marka güncellendi.";
        public static string BrandDeleted="Marka silindi";
        public static string BrandAdded="Marka eklendi";
        public static string UserAdded="Kullanıcı eklendi.";
        public static string UserDeleted="Kullanıcı silindi.";
        public static string UserUpdated="Kullanıcı güncellendi.";
        public static string UsersListed="Kullanıcılar listelendi.";
        public static string UserSelected="Kullanıcı seçildi.";
        public static string CustomerAdded="Müşteri eklendi.";
        public static string CustomerDeleted= "Müşteri silindi.";
        public static string CustomersListed= "Müşteriler listelendi.";
        public static string CustomerSelected= "Müşteri seçildi.";
        public static string CustomerUpdated= "Müşteri güncellendi.";
        public static string RentalAdded="Kiralama eklendi.";
        public static string RentalDeleted="Kiralama silindi.";
        public static string RentalUpdated="Kiralama güncellendi.";
        public static string RentalsListed="Kiralamalar listelendi.";
        public static string RentalSelected="Kiralama seçildi";
        public static string ErrorAdded="Hata eklendi";
        public static string CarInRent="Araba kiralık durumda. Kiralanamaz.";
    }
}
