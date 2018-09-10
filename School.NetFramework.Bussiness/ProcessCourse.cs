using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Entities.DTOs;
using School.Entities.EF6;
using School.NetFramework.DataAccess;

namespace School.NetFramework.Bussiness
{
    class ProcessCourse
    {
        public IEnumerable<CourseDto> GetCourse()
        {
            List<CourseDto> list = new List<CourseDto>();
            using (var access = new SQLDataAccessCourse())
            {
                var saverCourse = access.GetCourse();
                saverCourse.ToList().ForEach(item =>
                {
                    list.Add(MapEntityToDto(item));
                });
            }
            return list;
        }

        public CourseDto GetCourse(int StudentId, string SchoolId)
        {
            CourseDto Course = new CourseDto();
            using (var access = new SQLDataAccessCourse())
            {
                Course = MapEntityToDto(access.GetCourse(StudentId, SchoolId));
            }
            return Course;
        }

        public int InsertCourse(CourseDto Course)
        {
            using (var access = new SQLDataAccessCourse())
            {
                access.InsertCourse(MapDtoToEntity(Course));
            }
            return Course.Credits;
        }

        public void UpdateCourse(CourseDto Course)
        {
            using (var access = new SQLDataAccessCourse())
            {
                access.UpdateCourse(MapDtoToEntity(Course));
            }
        }

        public void DeleteCourse(CourseDto inscription)
        {
            using (var access = new SQLDataAccessCourse())
            {
                access.DeleteInscription(MapDtoToEntity(inscription));
            }
        }

        private Course MapDtoToEntity(CourseDto CourseDto)
        {
            return new Course
            {
                StudentId = inscriptionDto.StudentId,
                SchoolId = inscriptionDto.SchoolId,
                InscriptionDate = inscriptionDto.InscriptionDate
            };
        }

        private CourseDto MapEntityToDto(Course Course)
        {
            return new CourseDto
            {
                StudentId = Course.StudentId,
                SchoolId = Course.SchoolId,
                InscriptionDate = Course.InscriptionDate
            };
        }
    }
}
}
