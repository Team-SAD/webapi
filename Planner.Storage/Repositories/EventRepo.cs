using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Planner.Domain.Interfaces;
using Planner.Domain.Models;

namespace Planner.Storage.Repositories
{
    public class EventRepo : IRepository<Event>
    {
        private readonly CPContext _context;
        public EventRepo(CPContext context)
        {
            _context = context;
        }

        
        public async void Create(Event entry)
        {
           
            await _context.Events.AddAsync(entry);
        }
        public async Task<IEnumerable<Event>> SelectEventsAsync()
        {
            return await _context.Events.ToListAsync();
        }

        public async Task<Event> SelectEventAsync(long? id)
        {
            
                return await _context.Events.FindAsync(id);
        }
        public async Task<bool> DeleteAsync(long id)
        {
            var ev = await _context.Events.FindAsync(id);
            if (ev == null)
            {
                return false;
            }

            _context.Events.Remove(ev);
            return true;
        }

        public async Task<Event> Update(Event ev)
        {
            var eventToUpdate = await _context.Events.FirstOrDefaultAsync(e => e.EntityId == ev.EntityId);

            if (eventToUpdate != null) 
            {
                eventToUpdate.Description = ev.Description;
                eventToUpdate.StartDate = ev.StartDate;
                eventToUpdate.EndDate = ev.EndDate;
                eventToUpdate.Location = ev.Location;
                eventToUpdate.Title = ev.Title;
                eventToUpdate.AppUser = ev.AppUser;
            }
            else
            {
                return ev;
            }

            return eventToUpdate;

        }

        public IEnumerable<Event> Read(Func<Event, bool> filter)
        {
            return _context.Events.Where(filter).ToList();
        }

        public Event Update()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }
    }
}