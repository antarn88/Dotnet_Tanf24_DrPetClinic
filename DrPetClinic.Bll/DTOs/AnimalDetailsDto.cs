using System;

namespace DrPetClinic.Bll.DTOs;

public class AnimalDetailsDto
{
  public Guid Id { get; set; }
  public string Name { get; set; }
  public string Species { get; set; }
  public string Status { get; set; }
  public List<string> OwnerNames { get; set; } = new List<string>();
  public List<string> Treatments { get; set; } = new List<string>();
}
