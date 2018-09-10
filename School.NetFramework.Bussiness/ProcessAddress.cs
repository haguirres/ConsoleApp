using AutoMapper;
using School.Entities.DTOs;
using School.Entities.EF6;
using School.NetFramework.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace School.NetFramework.Bussiness
{
    public class ProcessAddress
    {
        private IMapper mapper;

        public ProcessAddress()
        {
            mapper = new AutoMapperConfig().CreateMapperConfiguration();
        }
        private Address MapDtoToEntity(AddressDto addressDto)
        {
            return new Address
            {
                AddressId = addressDto.AddressId,
                Address1 = addressDto.Address1,
                Neighborhood = addressDto.Neighborhood,
                ExtNum = addressDto.ExtNum,
                IntNum = addressDto.IntNum

            };
        }

        private AddressDto MapEntityToDto(Address address)
        {
            return new AddressDto
            {
                AddressId = address.AddressId,
                Address1 = address.Address1,
                Neighborhood = address.Neighborhood,
                ExtNum = address.ExtNum,
                IntNum = address.IntNum
            };
        }


        public IEnumerable<AddressDto> GetAddress()
        {
            List<AddressDto> savedAddressDto = new List<AddressDto>();

            using (var dataAccess = new SQLDataAccessAddress())
            {
                var savedAddress = dataAccess.GetAddress();

                savedAddressDto = this.mapper.Map<List<AddressDto>>(savedAddress);
            }
            return savedAddressDto;
        }

        public AddressDto GetAddress(int id)
        {
            AddressDto savedAddressDto = new AddressDto();
            using (var dataAccess = new SQLDataAccessAddress())
            {
                var savedAddress = dataAccess.GetAddress(id);

                savedAddressDto = this.mapper.Map<AddressDto>(savedAddress);
            }
            return savedAddressDto;
        }

        public int InsertAddress(AddressDto addressDto)
        {

            int newAddressId = 0;
            using (var dataAccess = new SQLDataAccessAddress())
            {
                Address newAddress = this.mapper.Map<Address>(addressDto);
                newAddressId = dataAccess.InsertAddress(newAddress);
            }
            return newAddressId;
        }

        public void UpdateAddress(AddressDto addressDto)
        {
            using (var dataAccess = new SQLDataAccessAddress())
            {
                Address newAddress = this.MapDtoToEntity(addressDto);

                dataAccess.UpdateAddress(newAddress);
            }
        }

        public void DeleteAddress(int id)
        {
            using (var dataAccess = new SQLDataAccessAddress())
            {
                var savedAddress = dataAccess.GetAddress(id);

                dataAccess.DeleteAddress(savedAddress.AddressId);
            }
           
        }



    }
}