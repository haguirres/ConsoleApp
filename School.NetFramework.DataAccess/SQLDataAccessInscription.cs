using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Entities.EF6;

namespace School.NetFramework.DataAccess
{
    class SQLDataAccessInscription:IDisposable
    {
        public SQLDataAccessInscription()
        {
        }

        public int InsertInscription(Inscription inscription)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                context.Inscription.Add(inscription);
                context.SaveChanges();
                return inscription.StudentId;
            }
        }

        public void UpdateInscription(Inscription inscription)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedInscription = context.Inscription.FirstOrDefault(
                    s => s.StudentId == inscription.StudentId &&
                    s.SchoolId == inscription.SchoolId);
                if(savedInscription != null)
                {
                    savedInscription.InscriptionDate = inscription.InscriptionDate;
                    context.SaveChanges();
                }
            }
        }
        public IEnumerable<Inscription> GetInscriptions()
        {
            List<Inscription> InscriptionList = new List<Inscription>();
            using(var context= new SchoolDatabaseEntities())
            {
                var list = context.Inscription.ToList();
                InscriptionList = list;
                return InscriptionList;
            }
        }
        
        public Inscription GetInscription(int StudentId, string SchoolId)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedInscription = context.Inscription.SingleOrDefault(
                    s => s.SchoolId == SchoolId &&
                    s.StudentId == StudentId);
                return savedInscription;
            }   
        }
        public void DeleteInscription(int StudentId, string SchoolId)
        {
            using(var context = new SchoolDatabaseEntities())
            {
                var savedInscription = context.Inscription.SingleOrDefault(
                    s => s.SchoolId == SchoolId &&
                    s.StudentId == StudentId);
                if(savedInscription != null)
                {
                    //savedInscription.IsActive = false;
                    context.SaveChanges();
                }
            }
        }

        public void Dispose()
        {

        }
    }
}
