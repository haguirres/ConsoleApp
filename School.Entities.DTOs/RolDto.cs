namespace School.Entities.DTOs
{
    public class RolDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        /// <summary>
        /// Concatenación de Id y Name
        /// </summary>
        public string IdName { get; set; }
    }
}