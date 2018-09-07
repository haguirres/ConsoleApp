
namespace School.Entities.DTOs
{
    public class SchoolDto
    {
        public string SchoolId { get; set; }
        public int AddressId { get; set; }
        public string SchoolName { get; set; }
        public int SchoolType { get; set; }
        public int MinToPass { get; set; }
        public bool IsActive { get; set; }
    }
}
