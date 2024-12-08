using System;
using System.ComponentModel;
using System.Reflection;
using DrPetClinic.Data.Enums;

namespace DrPetClinic.Bll.Helpers;

public class Utils
{
  public static string GetEnumDescription(EmployeeType value)
  {
    var field = value.GetType().GetField(value.ToString());

    if (field == null)
    {
      throw new ArgumentException($"Az '{value}' enum érték nem található az {value.GetType().Name} típusban.");
    }

    var attribute = field.GetCustomAttributes(typeof(DescriptionAttribute), false)
                          .Cast<DescriptionAttribute>()
                          .FirstOrDefault();

    return attribute?.Description ?? value.ToString();
  }


  public static EmployeeType GetEmployeeTypeFromEmployeeTypeDescription(string description)
  {
    foreach (var field in typeof(EmployeeType).GetFields(BindingFlags.Public | BindingFlags.Static))
    {
      var attribute = field
                      .GetCustomAttributes(typeof(DescriptionAttribute), false)
                      .Cast<DescriptionAttribute>()
                      .FirstOrDefault();

      if (attribute != null && attribute.Description == description)
      {
        return (EmployeeType)field.GetValue(null)!;
      }
    }

    throw new ArgumentException($"Nem található az enum leírás: {description}");
  }

}
