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
  public class LocationRepo : IRepository<Location>
  {
    private readonly CPContext _context;
    public LocationRepo(CPContext context)
    {
      _context = context;
    }

    public void Create(Location entry)
    {
      throw new NotImplementedException();
    }
    public async Task<IEnumerable<Location>> SelectLocationsAsync()
    {
      return await _context.Locations.ToListAsync();
    }
    public bool Delete()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Location> Read(Func<Location, bool> filter)
    {
      return _context.Locations.Where(filter).ToList();
    }

    public Location Update()
    {
      throw new NotImplementedException();
    }
  }
}