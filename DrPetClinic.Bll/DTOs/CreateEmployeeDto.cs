using DrPetClinic.Data.Enums;

namespace DrPetClinic.Bll.DTOs
{
    public class CreateEmployeeDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public EmployeeType Type { get; set; }
    }
}
