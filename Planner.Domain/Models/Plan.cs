using System.Collections.Generic;
using Planner.Domain.Abstracts;

namespace Planner.Domain.Models
{
  public class Plan : Entity
  {
    public Customer customer { get; set; }
    public int Month { get; set; }
    public List<Event> Events { get; set; }


  }
}