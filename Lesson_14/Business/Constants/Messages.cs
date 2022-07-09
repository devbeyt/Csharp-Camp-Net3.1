using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Mehsul elve edildi";
        public static string ProductNameInvalid = "Mehsul adi en az 2 herfden ibaret olmalidir";
        public static string MaintenanceTime = "Sistem baximdadir";
        public static string ProductListed = "Mehsullar listelendi";
        public static string ProductCoutOfCategoryError = "Bir kategoride en cox 10 mehsul olmalidir";
        public static string ProductNameAllreadyExists = "Bu adda mehsul zaten var";
        public static string CategoryLimitExceded = "Kategory limit kecildiyi ucun mehsul elve edilmir";
        public static string AuthorizationDenied = "Icazeniz yoxdur";
    }
}
