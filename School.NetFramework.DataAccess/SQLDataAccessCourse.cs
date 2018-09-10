using School.Entities.EF6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.NetFramework.DataAccess
{
   public class SQLDataAccessCourse : IDisposable
    {
        public SQLDataAccessCourse()
        {

        }

        public string InsertCourse(Course course)
        {
            using(var context = new SchoolDatabaseEntities())
            {
                context.Course.Add(course);
                context.SaveChanges();
                return course.CourseId;
            }
        }

        public void UpdateCourse(Course course)
        {
            using(var context = new SchoolDatabaseEntities())
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

        public Course GetCourse(int StudentId, string SchoolId)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedInscription = context.Course.SingleOrDefault(
                    s => s.SchoolId == SchoolId &&
                    s.StudentId == StudentId);
                return savedInscription;
            }
        }

        public Course GetCourse(string CourseId)
        {
            using(var context = new SchoolDatabaseEntities())
            {
                var saverCourse = context.Course.SingleOrDefault(
                    s => s.CourseId == CourseId);
                return saverCourse;
                
            }
        }


        public void DeleteCourse(string CourseId)
        {
            using(var context = new SchoolDatabaseEntities())
            {
                var saverCourse = context.Course.SingleOrDefault(
                    s => s.CourseId == CourseId);
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
