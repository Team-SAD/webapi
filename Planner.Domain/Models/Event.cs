using System;
using Planner.Domain.Abstracts;

namespace Planner.Domain.Models
{
  public class Event : Entity
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    // public Location Location { get; set; }
    // public long LocationId { get; set; }
    public override string ToString()
    {
      return $"{Title}";
    }
  }
}