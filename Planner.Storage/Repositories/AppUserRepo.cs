using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Planner.Domain.Interfaces;
using Planner.Domain.Models;

namespace Planner.Storage.Repositories
{
    public class AppUserRepo : IRepository<AppUser>
    {
        private readonly CPContext _context;
        public AppUserRepo(CPContext context)
        {
            _context = context;
        }

        public async void Create(AppUser entry)
        {
            await _context.AppUsers.AddAsync(entry);
           
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<AppUser>> SelectCustomersAsync()
        {
            return await _context.AppUsers.ToListAsync();
        }

        public async Task<AppUser> GetCustomerByName(string name)
        {
            return await _context.AppUsers.FirstOrDefaultAsync(x => x.Name == name);
        }
        public  IEnumerable<AppUser>  Read(Func<AppUser, bool> filter)
        {
            return  _context.AppUsers.Where(filter).ToList();
        }

        public AppUser Update()
        {
            throw new NotImplementedException();
        }
    }
}