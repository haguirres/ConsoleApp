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


        #region IDisposable

        public void Dispose()
        {
        }

        #endregion IDisposable
    }
}
