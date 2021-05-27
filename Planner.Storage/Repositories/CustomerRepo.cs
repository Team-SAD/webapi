using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Planner.Domain.Interfaces;
using Planner.Domain.Models;

namespace Planner.Storage.Repositories
{
  public class CustomerRepo : IRepository<Customer>
  {
    private readonly CPContext _context;
    public CustomerRepo(CPContext context)
    {
      _context = context;
    }

    public async void Create(Customer entry)
    {
      await _context.Customers.AddAsync(entry);

    }

    public bool Delete()
    {
      throw new NotImplementedException();
    }
    public async Task<IEnumerable<Customer>> SelectCustomersAsync()
    {
      return await _context.Customers.ToListAsync();
    }

    public async Task<Customer> GetCustomerByName(string name)
    {
      return await _context.Customers.SingleOrDefaultAsync(x => x.Name == name);
    }
    public IEnumerable<Customer> Read(Func<Customer, bool> filter)
    {
      return _context.Customers.Where(filter).ToList();
    }

    public Customer Update()
    {
      throw new NotImplementedException();
    }
  }
}