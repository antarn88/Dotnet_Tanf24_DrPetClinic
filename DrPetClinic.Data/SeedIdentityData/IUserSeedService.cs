using System;

namespace DrPetClinic.Data.SeedIdentityData;

public interface IUserSeedService
{
  Task SeedUserAsync();
}
