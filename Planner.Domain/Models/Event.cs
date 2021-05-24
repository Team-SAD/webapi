using System;
using Planner.Domain.Abstracts;

namespace Planner.Domain.Models
{
    public class Event : Entity
    {
        public string Discription { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        // public Location Location { get; set; }
        // public long LocationId { get; set; }
        
        
        
        
    }
}