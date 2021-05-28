using System;
using Planner.Domain.Models;

namespace Planner.Domain.DTO
{
    public class EventDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
        public Location Location { get; set; }
    }
}