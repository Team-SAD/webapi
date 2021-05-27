using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Planner.Domain.Interfaces;
using Planner.Domain.Models;
using Planner.Storage;

namespace Planner.Storage.Repositories
{
  public class EventRepo : IRepository<Event>
  {
    private readonly CPContext _context;
    public EventRepo(CPContext context)
    {
      _context = context;
    }

    public void Create(Event entry)
    {
      throw new NotImplementedException();
    }
    public async Task<IEnumerable<Event>> SelectEventsAsync()
    {
      return await _context.Events.ToListAsync();
    }
    public bool Delete()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Event> Read(Func<Event, bool> filter)
    {
      return _context.Events.Where(filter).ToList();
    }

    public Event Update()
    {
      throw new NotImplementedException();
    }
  }
}