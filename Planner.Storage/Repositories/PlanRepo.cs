using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Planner.Domain.Interfaces;
using Planner.Domain.Models;

namespace Planner.Storage.Repositories
{
  public class PlanRepo : IRepository<Plan>
  {
    private readonly CPContext _context;
    public PlanRepo(CPContext context)
    {
      _context = context;
    }

    public void Create(Plan entry)
    {
      throw new NotImplementedException();
    }
    public async Task<IEnumerable<Plan>> SelectPlannersAsync()
    {
      return await _context.Planners.ToListAsync();
    }
    public bool Delete()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Plan> Read(Func<Plan, bool> filter)
    {
      return _context.Planners.Where(filter).ToList();
    }

    public Plan Update()
    {
      throw new NotImplementedException();
    }
  }
}