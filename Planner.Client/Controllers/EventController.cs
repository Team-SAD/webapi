using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planner.Domain.DTO;
using Planner.Domain.Models;
using Planner.Storage;

namespace Planner.Client.Controllers
{
    
    public class EventController : ApiBaseController
    {
        private readonly UnitOfWork _unitOfWork;
        public EventController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetEvents()
        {
            var events = await _unitOfWork.Events.SelectEventsAsync();
            return Ok(events);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetEventItem(long id)
        {
            var eventItem = await _unitOfWork.Events.SelectEventAsync(id);

            if (eventItem == null)
            {
                return NotFound();
            }

            return eventItem;
        }

        [HttpPost("create")]
        public async Task<ActionResult<Event>> Create(EventDto ev)
        {
            var eventItem = new Event() { 
                Title= ev.Title, 
                Description = ev.Description, 
                StartDate = ev.StartDate, 
                EndDate = ev.EndDate, 
                Location = ev.Location};
            _unitOfWork.Events.Create(eventItem);
            await _unitOfWork.Save();
            return eventItem;

        }

        [HttpPost("edit")]
        
        public async Task<Event> EditEvent(Event ev)
        {
            //var eventToUpdate = await _unitOfWork.Events.SelectEventAsync(id); 
            var updatedEvent = _unitOfWork.Events.Update(ev);
            await _unitOfWork.Save();
        
            return await updatedEvent;
          
        }
       
        
    }
}