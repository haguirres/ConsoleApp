using School.Entities.EF6;
using System;
using System.Collections.Generic;
using System.Linq;

namespace School.NetFramework.DataAccess
{
    public class SQLDataAccessAddress : IDisposable
    {
        public SQLDataAccessAddress()
        {
        }

        public IEnumerable<Address> GetAddress()
        {
            List<Address> addressList = new List<Address>();
            using (var context = new SchoolDatabaseEntities())
            {
                var list = context.Address.ToList();
                addressList = list;
            }
            return addressList;

        }
        public Address GetAddress(int id)
        {
            Address address = new Address();
            using (var context = new SchoolDatabaseEntities())
            {
                var selectedAddress = context.Address.Find(id);
                address = selectedAddress;
            }
            return address;
        }


        public int InsertAddress(Address address)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                context.Address.Add(address);
                context.SaveChanges();
                return address.AddressId;
            }
        }

     

        public void UpdateAddress(Address updateAddress)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedAddress = context.Address.FirstOrDefault(s => s.AddressId == updateAddress.AddressId);
                if (savedAddress != null)
                {
                    savedAddress.AddressId = updateAddress.AddressId;
                    savedAddress.Address1 = updateAddress.Address1;
                    savedAddress.Neighborhood = updateAddress.Neighborhood;
                    savedAddress.ExtNum = updateAddress.ExtNum;
                    savedAddress.IntNum = updateAddress.IntNum;                   
                   
                    context.SaveChanges();
                }
            }
        }
        public void DeleteAddress(int id)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedAddress = context.Address.FirstOrDefault(s => s.AddressId == id);
                if (savedAddress != null)
                {
                    context.Address.Remove(savedAddress);
                    context.SaveChanges();
                }
            }
        }



        #region IDisposable

        public void Dispose()
        {
        }

        #endregion IDisposable
    }
}