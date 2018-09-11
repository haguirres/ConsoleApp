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
    public class ProcessCourse
    {
        public IEnumerable<CourseDto> GetCourse()
        {
            List<CourseDto> list = new List<CourseDto>();
            using (var access = new SQLDataAccessCourse())
            {
                var saverCourse = access.GetCourses();
                saverCourse.ToList().ForEach(item =>
                {
                    list.Add(MapEntityToDto(item));
                });
            }
            return list;
        }

        public CourseDto GetCourse(string CourseId)
        {
            CourseDto Course = new CourseDto();
            using (var access = new SQLDataAccessCourse())
            {
                Course = MapEntityToDto(access.GetCourse(CourseId));
            }
            return Course;
        }

        public CourseDto InsertCourse(CourseDto Course)
        {
            using (var access = new SQLDataAccessCourse())
            {
                access.InsertCourse(MapDtoToEntity(Course));
            }
            return Course;
        }

        public void UpdateCourse(CourseDto Course)
        {
            using (var access = new SQLDataAccessCourse())
            {
                access.UpdateCourse(MapDtoToEntity(Course));
            }
        }

        //public void DeleteCourse(CourseDto course)
        //{
        //    using (var access = new SQLDataAccessCourse())
        //    {
        //        access.DeleteCourse(MapDtoToEntity(course));
        //    }
        //}

        private Course MapDtoToEntity(CourseDto CourseDto)
        {
            return new Course
            {
                
            };
        }

        private CourseDto MapEntityToDto(Course Course)
        {
            return new CourseDto
            {
               
            };
        }
    }
}

