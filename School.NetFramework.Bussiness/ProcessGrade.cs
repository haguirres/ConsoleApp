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

        public GradeDto GetGrade(int id)
        {
            GradeDto savedGradeDto = new GradeDto();
            using (var dataAcces = new SQLDataAccessGrade())
            {
                var savedGrade = dataAcces.GetGrade(id);
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

        public int InsertNewGrade(GradeDto gradeDto)
        {
            int newStudentId = 0;
            using (var dataAccess = new SQLDataAccessGrade())
            {
                Grade newGrade = this.mapper.Map<Grade>(gradeDto);
                newStudentId = dataAccess.InsertGrade(newGrade);
            }
            return newStudentId;
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
                dataAcces.DeleteGrade(newGrade.StudentId);
            }
        }


        private Grade MapDtoToEntity(GradeDto gradeDto)
        {
            return new Grade
            {
                CourseId = gradeDto.CourseId,
                StudentId = gradeDto.StudentId,
                Grade1 = gradeDto.Grade1
            };
        }


        private GradeDto MapEntityToDto(Grade student)
        {
            return new GradeDto
            {
                CourseId = student.CourseId,
                StudentId = student.StudentId,
                Grade1 = student.Grade1
            };
        }
    }
}
