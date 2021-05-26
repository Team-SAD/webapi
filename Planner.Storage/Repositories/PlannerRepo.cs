using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Planner.Domain.Interfaces;
using Planner.Domain.Models;

namespace Planner.Storage.Repositories
{
  public class PlannerRepo : IRepository<Planner>
  {
    private readonly CPContext _context;
    public PlannerRepo(CPContext context)
    {
      _context = context;
    }

    public void Create(Planner entry)
    {
      throw new NotImplementedException();
    }
    public async Task<IEnumerable<Planner>> SelectPlannersAsync()
    {
      return await _context.Planners.ToListAsync();
    }
    public bool Delete()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Planner> Read(Func<Planner, bool> filter)
    {
      return _context.Planners.Where(filter).ToList();
    }

    public Planner Update()
    {
      throw new NotImplementedException();
    }
  }
}