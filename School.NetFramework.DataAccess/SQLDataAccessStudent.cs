using School.Entities.EF6;
using System;
using System.Collections.Generic;
using System.Linq;

namespace School.NetFramework.DataAccess
{
    public class SQLDataAccessStudent : IDisposable
    {
        public SQLDataAccessStudent()
        {

        }

        public IEnumerable<Student> GetStudents()
        {
            List<Student> StudentList = new List<Student>();
            using (var context = new SchoolDatabaseEntities())
            {
                var list = context.Student.ToList();
                StudentList = list;
            }
            return StudentList;
        }

        public Student GetStudent (int id)
        {
            Student student = new Student();

            using (var context = new SchoolDatabaseEntities())
            {
                var selectedStudent = context.Student.Find(id);
                student = selectedStudent;
            }
            return student;
        }

        public Student InsertStudent(Student student)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                context.Student.Add(student);
                context.SaveChanges();
                return student;
            }
        }

        public void UpdateStudent(Student updatedStudent)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedStudent = context.Student.FirstOrDefault(s => s.StudentId == updatedStudent.StudentId);
                if (savedStudent != null)
                {
                    savedStudent.PersonId = updatedStudent.PersonId;
                    savedStudent.StudentId = updatedStudent.StudentId;
                    savedStudent.Account = updatedStudent.Account;
                    savedStudent.IsActive = updatedStudent.IsActive;
                    context.SaveChanges();
                }
            }
        }

        public void DeleteStudent(int idStudent)
        {
            using (var context = new SchoolDatabaseEntities())
            {
                var savedStudent = context.Student.FirstOrDefault(s => s.StudentId == idStudent);
                if (savedStudent != null)
                {
                    savedStudent.IsActive = false;
                    context.SaveChanges();
                }
            }
        }

        public void Dispose()
        {
        }
    }
}
