using School.Entities.EF6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.NetFramework.DataAccess
{
    public class SQLDataAccessSchoolUser : IDisposable
    {
        public SQLDataAccessSchoolUser()
        {

        }
        public int InsertUser(SchoolUser schoolUser)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                context.SchoolUser.Add(schoolUser);
                context.SaveChanges();
                return schoolUser.SchoolUserId;
            }
        }

        public void UpdateUser(SchoolUser updatedUser)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedUser= context.SchoolUser.FirstOrDefault(s => s.SchoolUserId == updatedUser.SchoolUserId);
                if (savedUser != null)
                {
                    savedUser.UserName = updatedUser.UserName;
                    savedUser.Password = updatedUser.Password;
                    savedUser.RolId = updatedUser.RolId;
                    savedUser.IsActive = updatedUser.IsActive;
                    context.SaveChanges();
                }
            }

        }

        public IEnumerable<SchoolUser> GetUsers()
            {
                List<SchoolUser> userList = new List<SchoolUser>();
                using (var context = new SchoolDatabaseEntities())
                {
                    var list = context.SchoolUser.Where(s => s.IsActive == true).ToList();
                    userList = list;
                }
                return userList;
            }

            public SchoolUser GetUser(int schoolUserId)
            {
                using (var context = new SchoolDatabaseEntities())
                {
                    var savedUser = context.SchoolUser.SingleOrDefault(s => s.SchoolUserId == schoolUserId);
                    return savedUser;
                }
            }

        public void DeleteUser(int userId)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedUser = context.SchoolUser.FirstOrDefault(s => s.SchoolUserId == userId);
                if (savedUser != null)
                {
                    savedUser.IsActive = false;
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
