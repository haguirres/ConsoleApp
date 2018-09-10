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

        public SchoolDto GetSchool(string id)
        {
            SchoolDto savedSchoolDto = new SchoolDto();
            using (var dataAccess = new SQLDataAccessSchool())
            {
                var savedSchool = dataAccess.GetSchool(id);

                savedSchoolDto = this.mapper.Map<SchoolDto>(savedSchool);
            }
            return savedSchoolDto;
        }

        public string InsertNewSchool(SchoolDto schoolDto)
        {
            string newSchoolId = "0";
            using (var dataAccess = new SQLDataAccessSchool())
            {
                Entities.EF6.School newSchool = this.mapper.Map<Entities.EF6.School>(schoolDto);
                newSchoolId = dataAccess.InsertSchool(newSchool);
            }
            return newSchoolId;

        }

        public void UpdateSchool(SchoolDto schoolDto)
        {
            using (var dataAccess = new SQLDataAccessSchool())
            {
                Entities.EF6.School updateSchool = this.mapper.Map<Entities.EF6.School>(schoolDto);
                dataAccess.UpdateSchool(updateSchool);
            }
        }

        public void DeleteSchool(string id)
        {
            using (var dataAccess = new SQLDataAccessSchool())
            {
                dataAccess.DeleteSchool(id);
            }
        }

    }
}
