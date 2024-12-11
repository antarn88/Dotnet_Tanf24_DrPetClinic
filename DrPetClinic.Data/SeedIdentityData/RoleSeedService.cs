using System;
using Microsoft.AspNetCore.Identity;

namespace DrPetClinic.Data.SeedIdentityData;

public class RoleSeedService : IRoleSeedService
{
  private readonly RoleManager<IdentityRole<Guid>> roleManager;

  public RoleSeedService(RoleManager<IdentityRole<Guid>> roleManager)
  {
    this.roleManager = roleManager;
  }

  public async Task SeedRoleAsync()
  {
    if (!await roleManager.RoleExistsAsync("Doctors"))
    {
      await roleManager.CreateAsync(new IdentityRole<Guid> { Name = "Doctors" });
    }
  }
}
