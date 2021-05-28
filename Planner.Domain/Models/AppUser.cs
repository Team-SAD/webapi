using System.Collections.Generic;
using Planner.Domain.Abstracts;

namespace Planner.Domain.Models
{
    public class AppUser : Entity
    {
        public string Name { get; set; }
        public List<Event> Events { get; set; }
        public long EventId { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}