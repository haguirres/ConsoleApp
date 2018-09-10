using School.Entities.EF6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.NetFramework.DataAccess
{
    public class TeacherDataAccess:IDisposable
    {
        public TeacherDataAccess()
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int InsertTeacher(Teacher teacher)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                context.Teacher.Add(teacher);
                context.SaveChanges();
                return teacher.TeacherId;
            }
        }




        public void UpdateTeacher(Teacher updatedTeacher)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedTeacher = context.Teacher.FirstOrDefault(s => s.TeacherId == updatedTeacher.TeacherId);
                if (savedTeacher != null)
                {
                    savedTeacher.Person = updatedTeacher.Person;
                    savedTeacher.RFC = updatedTeacher.RFC;
                    savedTeacher.School = updatedTeacher.School;
                    savedTeacher.IsActive = updatedTeacher.IsActive;
                    context.SaveChanges();
                }
            }
        }

        public IEnumerable<Teacher> GetTeachers()
        {
            List<Teacher> teacherList = new List<Teacher>();
            using (var context = new SchoolDatabaseEntities())
            {
                var list = context.Teacher.ToList();
                teacherList = list;
            }
            return teacherList;
        }

        public Teacher GetTeachers(int idTeacher)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedTeacher = context.Teacher.SingleOrDefault(s => s.TeacherId == idTeacher);
                return savedTeacher;
            }
        }

        public void DeleteTeacher(int idTeacher)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedTeacher = context.Teacher.FirstOrDefault(s => s.TeacherId == idTeacher);
                if (savedTeacher != null)
                {
                    savedTeacher.IsActive = false;
                    context.SaveChanges();
                }
            }
        }



    }
}
