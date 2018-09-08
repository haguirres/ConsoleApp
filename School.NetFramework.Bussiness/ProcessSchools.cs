using AutoMapper;
using School.Entities.DTOs;
using School.Entities.EF6;
using School.NetFramework.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace School.NetFramework.Bussiness
{
    public class ProcessSchools
    {
        private IMapper mapper;

        public ProcessSchools()
        {
            mapper = new AutoMapperConfig().CreateMapperConfiguration();
        }

        public IEnumerable<SchoolDto> GetSchools()
        {
            List<SchoolDto> savedSchoolsDto = new List<SchoolDto>();
            using (var dataAccess = new SQLDataAccessSchool())
            {
                var savedSchools = dataAccess.GetSchools();

                savedSchoolsDto = this.mapper.Map<List<SchoolDto>>(savedSchools);
            }
            return savedSchoolsDto;
        }
    }
}
