using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using School.Entities.DTOs;
using School.Entities.EF6;
using School.NetFramework.DataAccess;

namespace School.NetFramework.Bussiness
{
    public class ProcessGrade
    {
        private IMapper mapper;

        public ProcessGrade()
        {
            mapper = new AutoMapperConfig().CreateMapperConfiguration();
        }

        public GradeDto GetGrade(string courseId, int studentId)
        {
            GradeDto savedGradeDto = new GradeDto();
            using (var dataAcces = new SQLDataAccessGrade())
            {
                var savedGrade = dataAcces.GetGrade(courseId, studentId);
                savedGradeDto = this.mapper.Map<GradeDto>(savedGrade);
            }
            return savedGradeDto;
        }

        public IEnumerable<GradeDto> GetGrades()
        {
            List<GradeDto> savedGradesDto = new List<GradeDto>();
            using (var dataAccess = new SQLDataAccessGrade())
            {
                var savedGrades = dataAccess.GetGrades();

                foreach (var item in savedGrades)
                {
                    savedGradesDto.Add(MapEntityToDto(item));
                }

                savedGrades.ToList().ForEach(item =>
                {
                    savedGradesDto.Add(MapEntityToDto(item));
                });

                savedGradesDto = this.mapper.Map<List<GradeDto>>(savedGrades);
            }
            return savedGradesDto;
        }

        public Grade InsertNewGrade(GradeDto gradeDto)
        {
            Grade newStudent = new Grade();
            using (var dataAccess = new SQLDataAccessGrade())
            {
                Grade newGrade = this.mapper.Map<Grade>(gradeDto);
                newStudent = dataAccess.InsertGrade(newGrade);
            }
            return newStudent;
        }

        public void UpdateGrade(GradeDto gradeDto)
        {
            using (var dataAccess = new SQLDataAccessGrade())
            {
                Grade newGrade = this.mapper.Map<Grade>(gradeDto);

                dataAccess.UpdateGrade(newGrade);
            }
        }

        public void DeleteGrade(GradeDto gradeDto)
        {
            using (var dataAcces = new SQLDataAccessGrade())
            {
                Grade newGrade = this.MapDtoToEntity(gradeDto);
                dataAcces.DeleteGrade(newGrade);
            }
        }


        private Grade MapDtoToEntity(GradeDto gradeDto)
        {
            return new Grade
            {
                CourseId = gradeDto.CourseId,
                StudentId = gradeDto.StudentId,
                IsActive = gradeDto.IsActive,
                Grade1 = gradeDto.Grade1
            };
        }


        private GradeDto MapEntityToDto(Grade grade)
        {
            return new GradeDto
            {
                CourseId = grade.CourseId,
                StudentId = grade.StudentId,
                IsActive = grade.IsActive,
                Grade1 = grade.Grade1
            };
        }
    }
}
