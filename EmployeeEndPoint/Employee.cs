using System.ComponentModel.DataAnnotations;

namespace EmployeeEndPointProject;
public record Employee(string FirstName, [Required] string LastName);