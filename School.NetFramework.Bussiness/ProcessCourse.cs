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
        public IEnumerable<CourseDto> GetCourses()
        {
            List<CourseDto> list = new List<CourseDto>();
            using (var access = new SQLDataAccessCourse())
            {
                var saverCourse = access.GetCourses();
                saverCourse.Where(item => item.IsActive==true).ToList().ForEach(item =>
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

        public string InsertCourse(CourseDto Course)
        {
            string CourseId;
            using (var access = new SQLDataAccessCourse())
            {
                CourseId = access.InsertCourse(MapDtoToEntity(Course));
            }
            return CourseId;
        }

        public void UpdateCourse(CourseDto Course)
        {
            using (var access = new SQLDataAccessCourse())
            {
                access.UpdateCourse(MapDtoToEntity(Course));
            }
        }

        public void DeleteCourse(string courseId)
        {
            using (var access = new SQLDataAccessCourse())
            {
                access.DeleteCourse(courseId);
            }
        }

        private Course MapDtoToEntity(CourseDto CourseDto)
        {
            return new Course
            {
            CourseId    = CourseDto.CourseId,
            SignaturesId= CourseDto.SignaturesId,
            SchoolId    = CourseDto.SchoolId,
            TeacherId   = CourseDto.TeacherId,
            MinToPass   = CourseDto.MinToPass,
            Year        = CourseDto.Year,
            Credits     = CourseDto.Credits,
            StartDate   = CourseDto.StartDate,
            EndDate     = CourseDto.EndDate,
            IsActive    = CourseDto.IsActive,
            ScheduleId  = CourseDto.ScheduleId
            };
        }

        private CourseDto MapEntityToDto(Course Course)
        {
            return new CourseDto
            {
                CourseId=       Course.CourseId,
                SignaturesId =  Course.SignaturesId,
                SchoolId =      Course.SchoolId,
                TeacherId =     Course.TeacherId,
                MinToPass =     Course.MinToPass,
                Year =          Course.Year,
                Credits =       Course.Credits,
                StartDate =     Course.StartDate,
                EndDate =       Course.EndDate,
                IsActive =      Course.IsActive,
                ScheduleId =    Course.ScheduleId
            };
        }
    }
}

