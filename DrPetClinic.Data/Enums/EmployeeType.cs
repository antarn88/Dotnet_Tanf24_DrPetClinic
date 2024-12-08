using System.ComponentModel;

namespace DrPetClinic.Data.Enums
{
    public enum EmployeeType
    {
        [Description("Doktor")]
        Doctor = 1,

        [Description("Asszisztens")]
        Assistant = 2,
    }
}
