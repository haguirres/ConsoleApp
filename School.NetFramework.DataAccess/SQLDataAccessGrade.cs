using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using School.Entities.EF6;

namespace School.NetFramework.DataAccess
{
    public class SQLDataAccessGrade:IDisposable
    {
        public SQLDataAccessGrade()
        {

        }

        public IEnumerable<Grade> GetGrades()
        {
            List<Grade> GradeList = new List<Grade>();
            using (var context = new SchoolDatabaseEntities())
            {
                var list = context.Grade.ToList();
                GradeList = list;
            }
            return GradeList;
        }

        public Grade GetGrade(string courseId, int studentId)
        {
            Grade grade = new Grade();

            using (var context = new SchoolDatabaseEntities())
            {
                var selectedGrade = context.Grade.Where(s => s.CourseId == courseId && s.StudentId == studentId).FirstOrDefault();
                grade = selectedGrade;
            }
            return grade;
        }

        public Grade InsertGrade(Grade grade)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                context.Grade.Add(grade);
                context.SaveChanges();
                return grade;
            }
        }

        public void UpdateGrade(Grade updatedGrade)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedGrade = context.Grade.FirstOrDefault(s => s.StudentId == updatedGrade.StudentId && s.CourseId == updatedGrade.CourseId);
                if (savedGrade != null)
                {
                    savedGrade.CourseId = updatedGrade.CourseId;
                    savedGrade.StudentId = updatedGrade.StudentId;
                    savedGrade.IsActive = updatedGrade.IsActive;
                    savedGrade.Grade1 = updatedGrade.Grade1;
                    context.SaveChanges();
                }
            }
        }

        public void DeleteGrade(string courseId, int studentId)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedGrade = context.Grade.FirstOrDefault(s => s.StudentId == studentId && s.CourseId == courseId);
                if (savedGrade != null && savedGrade.IsActive)
                {
                    savedGrade.IsActive = false;
                    context.SaveChanges();
                }
            }
        }

        public void Dispose()
        {
        }

    }
}
