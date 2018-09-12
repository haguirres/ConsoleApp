using School.Entities.EF6;
using System;
using System.Collections.Generic;
using System.Linq;


namespace School.NetFramework.DataAccess
{
    public class SQLDataAccessCourse : IDisposable
    {
        public SQLDataAccessCourse()
        {

        }

        public string InsertCourse(Course course)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                context.Course.Add(course);
                context.SaveChanges();
                return course.CourseId;
            }
        }

        public void UpdateCourse(Course course)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedCourse = context.Course.FirstOrDefault(
                    s => s.CourseId == course.CourseId);
                if (savedCourse != null)
                {
                    savedCourse.Signatures = course.Signatures;
                    savedCourse.SchoolId = course.SchoolId;
                    savedCourse.TeacherId = course.TeacherId;
                    savedCourse.MinToPass = course.MinToPass;
                    savedCourse.Year = course.Year;
                    savedCourse.Credits = course.Credits;
                    savedCourse.EndDate = course.EndDate;
                    savedCourse.IsActive = course.IsActive;
                    savedCourse.ScheduleId = course.ScheduleId;
                    context.SaveChanges();
                }
            }
        }

        public Course GetCourse(string CourseId)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedInscription = context.Course.SingleOrDefault(
                    s => s.CourseId == CourseId && s.IsActive == true);
                return savedInscription;
            }
        }

        public IEnumerable<Course> GetCourses()
        {
            List<Course> CourseList = new List<Course>();
            using (var context = new SchoolDatabaseEntities())
            {
                var list = context.Course.Where(s=> s.IsActive==true).ToList();
                CourseList = list;
            }
            return CourseList;
        }



        public void DeleteCourse(String CourseId)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var saverCourse = context.Course.SingleOrDefault(
                    s => s.CourseId == CourseId && s.IsActive == true);
                if (saverCourse != null)
                {
                    saverCourse.IsActive = false;
                    context.SaveChanges();
                }
            }

        }

        public void Dispose()
        {
        }
    }
}
