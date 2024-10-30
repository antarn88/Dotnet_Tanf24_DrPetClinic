using DrPetClinic.Data;

namespace DrPetClinic.Bll
{
    public class ClinicService
    {
        public ClinicService(DrPetClinicDBContext dbContext)
        {
            DBContext = dbContext;
        }

        public DrPetClinicDBContext DBContext { get; }
    }
}
