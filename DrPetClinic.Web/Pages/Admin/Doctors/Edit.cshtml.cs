using AutoMapper;
using DrPetClinic.Bll.DTOs;
using DrPetClinic.Bll.Helpers;
using DrPetClinic.Bll.Interfaces;
using DrPetClinic.Bll.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrPetClinic.Web.Pages.Admin.Doctors
{
    public class EditModel : PageModel
    {
        private readonly IEmployeeService _employeeService;
        private readonly IConsultationTimeService _consultationTimeService;
        private readonly IMapper _mapper;

        [BindProperty]
        public EmployeeDetailsDto Doctor { get; set; }



        public EditModel(IEmployeeService employeeService, IConsultationTimeService consultationTimeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _consultationTimeService = consultationTimeService;
            _mapper = mapper;
        }

        public async Task OnGetAsync(Guid doktorId)
        {
            Doctor = await _employeeService.GetEmployeeByIdAsync(doktorId);

            if (Doctor != null)
            {
                // Töltse be az orvos rendelési időit
                Doctor.ConsultationTimes = await _consultationTimeService.GetConsultationTimesByDoctorIdAsync(doktorId);
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // if (!ModelState.IsValid)
            // {
            //     return Page();
            // }

            foreach (var consultation in Doctor.ConsultationTimes)
            {
                System.Console.WriteLine(consultation.IsAvailable);
                // Kényszerített alapértelmezett értékek
                // consultation.IsAvailable = consultation.IsAvailable || false;
                // consultation.DayOfWeek = Enum.TryParse<DayOfWeek>(consultation.DayOfWeek.ToString(), out var day) ? day : DayOfWeek.Monday;
            }

            var createConsultationTimeDtos = Doctor.ConsultationTimes
                .Select(ct => new CreateConsultationTimeDto
                {
                    Id = ct.Id,
                    Year = ct.Year,
                    Month = ct.Month,
                    Week = ct.Week,
                    DayOfWeek = ct.DayOfWeek,
                    StartTime = ct.StartTime,
                    EndTime = ct.EndTime,
                    IsAvailable = ct.IsAvailable,
                    Description = ct.Description,
                    EmployeeId = Doctor.Id
                })
                .ToList();



            await _consultationTimeService.UpdateConsultationTimesAsync(Doctor.Id, createConsultationTimeDtos);
            await _employeeService.UpdateEmployeeAsync(Doctor.Id, _mapper.Map<CreateEmployeeDto>(Doctor));

            return RedirectToPage("/Admin/Doctors/Index");
        }
    }
}
