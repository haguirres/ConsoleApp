using AutoMapper;
using School.Entities.DTOs;
using School.Entities.EF6;

namespace School.NetFramework.Bussiness
{
    public class AutoMapperConfig
    {
        public IMapper CreateMapperConfiguration()
        {
            var mapper = new AutoMapper.MapperConfiguration(config =>
            {
                config.CreateMap<Roles, RolDto>();

                config.CreateMap<Roles, RolDto>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(src => src.RolId))
                .ForMember(dto => dto.Name, opt => opt.MapFrom(src => src.RolName))
                .ForMember(dto => dto.IdName, opt=> opt.MapFrom(src => string.Join(" ", src.RolId,src.RolName)));

                config.CreateMap<Entities.EF6.School, SchoolDto>();
                config.CreateMap<SchoolDto, Entities.EF6.School>();

                config.CreateMap<Address, AddressDto>();
                config.CreateMap<AddressDto, Address>();


            });



            return mapper.CreateMapper();
        }
    }
}