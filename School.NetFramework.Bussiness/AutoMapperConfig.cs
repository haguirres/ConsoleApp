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
                //config.CreateMap<Roles, RolDto>();
                config.CreateMap<RolDto, Roles>()
                .ForMember(src=> src.RolId, opt => opt.MapFrom(dto=> dto.Id))
                .ForMember(src => src.RolName, opt => opt.MapFrom(dto => dto.Name))
                .ForMember(src => src.IsActive, opt => opt.MapFrom(dto => dto.IsActive));
                config.CreateMap<Teacher, TeacherDto>();

                config.CreateMap<Roles, RolDto>()
                .ForMember(dto => dto.Id, opt => opt.MapFrom(src => src.RolId))
                .ForMember(dto => dto.Name, opt => opt.MapFrom(src => src.RolName))
                .ForMember(dto => dto.IdName, opt=> opt.MapFrom(src => string.Join(" ", src.RolId,src.RolName)));

                config.CreateMap<Entities.EF6.School, SchoolDto>();
                config.CreateMap<SchoolDto, Entities.EF6.School>();

                config.CreateMap<Address, AddressDto>();
                config.CreateMap<AddressDto, Address>();

                config.CreateMap<Person, PersonDto>();
                config.CreateMap<PersonDto, Person>();

                config.CreateMap<Grade, GradeDto>();
                config.CreateMap<GradeDto, Grade>();

                config.CreateMap<Student, StudentDto>();
                config.CreateMap<StudentDto, Student>();
            });



            return mapper.CreateMapper();
        }
    }
}