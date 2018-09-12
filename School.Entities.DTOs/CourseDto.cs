using System;

namespace School.Entities.DTOs
{
   public class CourseDto
    {
        public string CourseId { get; set; }
        public int SignaturesId { get; set; }
        public string SchoolId { get; set; }
        public int TeacherId { get; set; }
        public int? MinToPass { get; set; }
        public int Year { get; set; }
        public int? Credits { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public int ScheduleId { get; set; }
    }
}
