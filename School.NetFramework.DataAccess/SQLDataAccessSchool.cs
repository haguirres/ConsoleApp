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

        public void UpdateSchool(Entities.EF6.School updateSchool)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedSchool = context.School.FirstOrDefault(s => s.SchoolId == updateSchool.SchoolId);
                if(savedSchool != null)
                {
                    savedSchool.SchoolId = updateSchool.SchoolId;
                    savedSchool.AddressId = updateSchool.AddressId;
                    savedSchool.SchoolName = updateSchool.SchoolName;
                    savedSchool.SchoolType = updateSchool.SchoolType;
                    savedSchool.MinToPass = updateSchool.MinToPass;
                    savedSchool.IsActive = updateSchool.IsActive;
                    context.SaveChanges();
                }

            }

        }

        public void DeleteSchool(string id)
        {
            using ( var context = new SchoolDatabaseEntities())
            {
                var selectedSchool = context.School.Find(id);
                context.Entry(selectedSchool).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }


        #region IDisposable

        public void Dispose()
        {
        }

        #endregion IDisposable
    }
}
