using System.Collections.Generic;
using Planner.Domain.Abstracts;

namespace Planner.Domain.Models
{
  public class Customer : Entity
  {
    public string Name { get; set; }

    public List<Plan> Planners { get; set; }

    public override string ToString()
    {
      return $"{Name}";
    }
  }
}