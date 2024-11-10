using DrPetClinic.Data.Enums;

namespace DrPetClinic.Bll.DTOs
{
    public class EmployeeSummaryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public EmployeeType Type { get; set; }
        public string? Description { get; set; }
    }
}
