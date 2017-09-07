using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_Core_1_0.Models
{
    public static class Repository
    {
        public static List<Account> Accounts = new List<Account>();
        public static List<Authorization> Authorizations = new List<Authorization>();
        public static List<Commodity> Commodities = new List<Commodity>();
        public static List<Location> Locations = new List<Location>();

        static Repository()
        {
            //Authorizations.Add(new Authorization(1, "1212121", "Shipper1", "Receiver1", "ReceiverContact1", "Alabama", "Tucson", "999", "9991", "SupplierName1", "ReclocID1", "ReclocName1"));
            //Authorizations.Add(new Authorization(2, "1212121", "Shipper1", "Receiver1", "ReceiverContact1", "Alabama", "Tucson", "999", "9991", "SupplierName1", "ReclocID1", "ReclocName1"));
            //Authorizations.Add(new Authorization(3, "1212121", "Shipper1", "Receiver1", "ReceiverContact1", "Alabama", "Tucson", "999", "9991", "SupplierName1", "ReclocID1", "ReclocName1"));
            //Authorizations.Add(new Authorization(4, "1212121", "Shipper1", "Receiver1", "ReceiverContact1", "Alabama", "Tucson", "999", "9991", "SupplierName1", "ReclocID1", "ReclocName1"));
            //Authorizations.Add(new Authorization(5, "1212121", "Shipper1", "Receiver1", "ReceiverContact1", "Alabama", "Tucson", "999", "9991", "SupplierName1", "ReclocID1", "ReclocName1"));
        }
    }
}