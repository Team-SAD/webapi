using System.ComponentModel.DataAnnotations;

namespace Planner.Domain.DTO
{
  public class RegisterDto
  {
    [Required]
    public string Name { get; set; }


  }
}