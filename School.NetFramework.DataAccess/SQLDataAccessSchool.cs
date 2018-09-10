using School.Entities.EF6;
using System;
using System.Collections.Generic;
using System.Linq;

namespace School.NetFramework.DataAccess
{
    public class SQLDataAccessSchool : IDisposable
    {
        public SQLDataAccessSchool()
        {

        }

        public IEnumerable<Entities.EF6.School> GetSchools()
        {
            List<Entities.EF6.School> schoolList = new List<Entities.EF6.School>();
            using (var context = new SchoolDatabaseEntities())
            {
                var list = context.School.ToList();
                schoolList = list;
            }
            return schoolList;

        }

        public Entities.EF6.School GetSchool(string id)
        {
            Entities.EF6.School school = new Entities.EF6.School();

            using (var context = new SchoolDatabaseEntities())
            {
                var selectedSchool = context.School.Find(id);
                school = selectedSchool;
            }

            return school;
        }

        public string InsertSchool(Entities.EF6.School school)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                context.School.Add(school);
                context.SaveChanges();
                return school.SchoolId;
            }
        }


        #region IDisposable

        public void Dispose()
        {
        }

        #endregion IDisposable
    }
}
