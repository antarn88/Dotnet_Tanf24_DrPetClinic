using System;
using DrPetClinic.Data.Entities;
using DrPetClinic.Data.Enums;
using Microsoft.AspNetCore.Identity;

namespace DrPetClinic.Data.SeedIdentityData;

public class UserSeedService : IUserSeedService
{
  private readonly UserManager<Employee> userManager;

  public UserSeedService(UserManager<Employee> userManager)
  {
    this.userManager = userManager;
  }

  public async Task SeedUserAsync()
  {

    if (!(await userManager.GetUsersInRoleAsync("Doctors")).Any())
    {
      var user = new Employee
      {
        UserName = "admin@drpetclinic.hu",
        Email = "admin@drpetclinic.hu",
        EmailConfirmed = true,
        Name = "Admin Doktor",
        Type = EmployeeType.Doctor,
        Description = "Admin doki",
        SecurityStamp = Guid.NewGuid().ToString()
      };

      var createResult = await userManager.CreateAsync(user, "P@ssword1");

      if (userManager.Options.SignIn.RequireConfirmedAccount)
      {
        // Regisztrációt meg kell erősíteni.
        var code = await userManager.GenerateEmailConfirmationTokenAsync(user);
        var result = await userManager.ConfirmEmailAsync(user, code);
      }

      var addToRoleResult = await userManager.AddToRoleAsync(user, "Doctors");

      if (!createResult.Succeeded || !addToRoleResult.Succeeded)
      {
        throw new ApplicationException("Nem sikerült létrehozni az adminisztrátor felhasználót: " +
          string.Join(", ", createResult.Errors.Concat(addToRoleResult.Errors).Select(x => x.Description)));
      }
    }

  }
}
