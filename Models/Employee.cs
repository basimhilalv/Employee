using System.ComponentModel.DataAnnotations;
namespace EmployeeSpace.Models;

public class Employee
{
    public long Id {get; set;}

    [Required(ErrorMessage = "Employee name is required")]
    [StringLength(50, ErrorMessage = "Employee name cannot exceed 50 characters.")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Department name is required")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
    public string? Department { get; set; }
    public int Salary { get; set; }
}