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
    public class TeacherABC
    {
        private IMapper mapper;

        public TeacherABC()
        {
            mapper = new AutoMapperConfig().CreateMapperConfiguration();
        }

        public int InsertNewTeacher(TeacherDto teacherDto)
        {
            int newTeacherId = 0;
            using (var dataAccess = new SQLDataAccessTeacher())
            {
                Teacher newTeacher = this.MapDtoToEntity(teacherDto);
                //Teacher newTeacher = this.mapper.Map<Teacher>(teacherDto);
                newTeacherId = dataAccess.InsertTeacher(newTeacher);
            }
            return newTeacherId;
        }

        public void UpdateTeacher(TeacherDto teacherDto)
        {
            using (var dataAccess = new SQLDataAccessTeacher())
            {

                Teacher newTeacher = this.MapDtoToEntity(teacherDto);
                //Teacher newTeacher = this.mapper.Map<Teacher>(teacherDto);

                dataAccess.UpdateTeacher(newTeacher);
            }
        }

        public void DeleteTeacher(TeacherDto teacherDto)
        {
            using (var dataAccess = new SQLDataAccessTeacher())
            {

                Teacher newTeacher = this.MapDtoToEntity(teacherDto);
                //Teacher newTeacher = this.mapper.Map<Teacher>(teacherDto);

                dataAccess.DeleteTeacher(newTeacher.TeacherId);
            }
        }


        public IEnumerable<TeacherDto> GetTeachers()
        {
            List<TeacherDto> savedTeachersDto = new List<TeacherDto>();
            using (var dataAccess = new SQLDataAccessTeacher())
            {
                var savedTeachers = dataAccess.GetTeachers();

                foreach (var item in savedTeachers)
                {
                    savedTeachersDto.Add(MapEntityToDto(item));
                }

                savedTeachers.ToList().ForEach(item =>
                {
                    savedTeachersDto.Add(MapEntityToDto(item));
                });

                savedTeachersDto = this.mapper.Map<List<TeacherDto>>(savedTeachers);
            }
            return savedTeachersDto;
        }

        public TeacherDto GetTeacher(int id)
        {
            TeacherDto savedTeacherDto = new TeacherDto();
            using (var dataAccess = new SQLDataAccessTeacher())
            {
                var savedTeacher = dataAccess.GetTeachers(id);

                savedTeacherDto = this.mapper.Map<TeacherDto>(savedTeacher);
            }
            return savedTeacherDto;
        }


        private Teacher MapDtoToEntity(TeacherDto teacherDto)
        {
            return new Teacher
            {
                TeacherId = teacherDto.TeacherId,
                PersonId = teacherDto.PersonId,
                
                RFC = teacherDto.RFC,
                IsActive = teacherDto.IsActive
            };
        }

        private TeacherDto MapEntityToDto(Teacher teacher)
        {
            return new TeacherDto
            {
                TeacherId = teacher.TeacherId,
                PersonId = teacher.PersonId,
                RFC = teacher.RFC,
                IsActive = teacher.IsActive
            };
        }
    }
}

