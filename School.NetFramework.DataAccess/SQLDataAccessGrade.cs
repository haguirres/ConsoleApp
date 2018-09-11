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

        public Grade GetGrade(int id)
        {
            Grade grade = new Grade();

            using (var context = new SchoolDatabaseEntities())
            {
                var selectedGrade = context.Grade.Find(id);
                grade = selectedGrade;
            }
            return grade;
        }

        public int InsertGrade(Grade grade)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                context.Grade.Add(grade);
                context.SaveChanges();
                return grade.StudentId;
            }
        }

        public void UpdateGrade(Grade updatedGrade)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedGrade = context.Grade.FirstOrDefault(s => s.StudentId == updatedGrade.StudentId);
                if (savedGrade != null)
                {
                    savedGrade.CourseId = updatedGrade.CourseId;
                    savedGrade.StudentId = updatedGrade.StudentId;
                    savedGrade.Grade1 = updatedGrade.Grade1;
                    context.SaveChanges();
                }
            }
        }

        public void DeleteGrade(int idGrade)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedGrade = context.Grade.FirstOrDefault(s => s.StudentId == idGrade);
                if (savedGrade != null)
                {
                    context.SaveChanges();
                }
            }
        }

        public void Dispose()
        {
        }

    }
}
