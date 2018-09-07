using School.Entities.EF6;
using System;
using System.Collections.Generic;
using System.Linq;

namespace School.NetFramework.DataAccess
{
    public class SQLDataAccess : IDisposable
    {
        public SQLDataAccess()
        {
        }

        public int InsertRol(Roles rol)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                context.Roles.Add(rol);
                context.SaveChanges();
                return rol.RolId;
            }
        }

        public void UpdateRol(Roles updatedRol)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedRol = context.Roles.FirstOrDefault(s => s.RolId == updatedRol.RolId);
                if (savedRol != null)
                {
                    savedRol.RolName = updatedRol.RolName;
                    savedRol.IsActive = updatedRol.IsActive;
                    context.SaveChanges();
                }
            }
        }

        public IEnumerable<Roles> GetRoles()
        {
            List<Roles> rolesList = new List<Roles>();
            using (var context = new SchoolDatabaseEntities())
            {
                var list = context.Roles.ToList();
                rolesList = list;
            }
            return rolesList;
        }

        public Roles GetRoles(int idRole)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedRol = context.Roles.SingleOrDefault(s => s.RolId == idRole);
                return savedRol;
            }
        }

        public void DeleteRol(int idRol)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedRol = context.Roles.FirstOrDefault(s => s.RolId == idRol);
                if (savedRol != null)
                {
                    savedRol.IsActive = false;
                    context.SaveChanges();
                }
            }
        }

        #region IDisposable

        public void Dispose()
        {
        }

        #endregion IDisposable
    }
}