using DrPetClinic.Bll.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace DrPetClinic.Web.Pages.ViewComponents;

public class DoctorCardViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(EmployeeDto doctor, int index)
    {
        ViewData["Index"] = index;
        return View(doctor);
    }
}
