using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatterCentral.Models;

namespace MatterCentral.Data
{
    public class DbInitializer
    {
        public static void Initialize(ALCContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            // commented out are Keys

            var countries = new Country[]
            {
                new Country{Name="United States"},
                new Country{Name="Alaska"}
            };
            context.Countries.AddRange(countries);
            context.SaveChanges();

            var states = new State[]
            {
                new State{Name="Oregon", CountryId=1},
                new State{Name="Oasis", CountryId=1},
                new State{Name="Alaska", CountryId=1},
                new State{Name="Really Cold", CountryId=2},
                new State{Name="Really Cold2", CountryId=2}
            };
            context.States.AddRange(states);
            context.SaveChanges();

            var cities = new City[]
            {
                new City{Name="Portland", StateId=1},
                new City{Name="Highland", StateId=1},
                new City{Name="Unassuming Docks", StateId=2},
                new City{Name="Hayter's Folly", StateId=2},
                new City{Name="Area 52", StateId=3},
                new City{Name="Way Below Zero", StateId=4},
            };
            context.Cities.AddRange(cities);
            context.SaveChanges();

            var paymentTerms = new PaymentTerm[]
            {
                new PaymentTerm{Name="Net 30 Days"},
                new PaymentTerm{Name="Net 20 Days"},
                new PaymentTerm{Name="Net 7 Days"}
            };
            context.PaymentTerms.AddRange(paymentTerms);
            context.SaveChanges();

            var accountTypes = new AccountType[]
            {
                new AccountType{IsActive=true, Description="First AccounType", Title="Account Type 1", ShowOnAuthorization = true},
                new AccountType{IsActive=true, Description="Second AccounType", Title="Account Type 2", ShowOnAuthorization = false},
                new AccountType{IsActive=true, Description="Third AccounType", Title="Account Type 3", ShowOnAuthorization = true}
            };
            context.AccountTypes.AddRange(accountTypes);
            context.SaveChanges();

            var accounts = new Account[]
            {
                new Account{Name="Account1", TypeId=1},
                new Account{Name="Account2", TypeId=2},
                new Account{Name="Account3", TypeId=3}
            };
            context.Accounts.AddRange(accounts);
            context.SaveChanges();
            
        }
    }
}
