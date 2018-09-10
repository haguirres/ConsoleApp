using AutoMapper;
using School.Entities.DTOs;
using School.Entities.EF6;
using School.NetFramework.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace School.NetFramework.Bussiness
{
    public class ProcessStudent
    {
        private IMapper mapper;

        public ProcessStudent()
        {
            mapper = new AutoMapperConfig().CreateMapperConfiguration();
        }

        public IEnumerable<StudentDto> GetStudents()
        {
            List<StudentDto> savedStudentsDto = new List<StudentDto>();
            using (var dataAccess = new SQLDataAccessStudent())
            {
                var savedStudents = dataAccess.GetStudents();

                foreach (var item in savedStudents)
                {
                    savedStudentsDto.Add(MapEntityToDto(item));
                }

                savedStudents.ToList().ForEach(item =>
                {
                    savedStudentsDto.Add(MapEntityToDto(item));
                });

                savedStudentsDto = this.mapper.Map<List<StudentDto>>(savedStudents);
            }
            return savedStudentsDto;
        }

        
        public int InsertNewStudent(StudentDto studentDto)
        {
            int newStudentId = 0;
            using (var dataAccess = new SQLDataAccessStudent())
            {
                Student newStudent = this.mapper.Map<Student>(studentDto);
                newStudentId = dataAccess.InsertStudent(newStudent);
            }
            return newStudentId;
        }
        
        public void UpdateStudent(StudentDto studentDto)
        {
            using (var dataAccess = new SQLDataAccessStudent())
            {
                Student newStudent = this.mapper.Map<Student>(studentDto);

                dataAccess.UpdateStudent(newStudent);
            }
        }


        private Student MapDtoToEntity(StudentDto studentDto)
        {
            return new Student
            {
                PersonId = studentDto.PersonId,
                StudentId = studentDto.StudentId,
                Account = studentDto.Account,
                IsActive = studentDto.IsActive
            };
        }
        

        private StudentDto MapEntityToDto(Student student)
        {
            return new StudentDto
            {
                PersonId = student.PersonId,
                StudentId = student.StudentId,
                Account = student.Account,
                IsActive = student.IsActive
            };
        }
    }
}
