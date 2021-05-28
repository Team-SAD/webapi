using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Planner.Domain.Interfaces;
using Planner.Domain.Models;

namespace Planner.Storage.Repositories
{
    public class LocationRepo : IRepository<Location>
    {
        private readonly CPContext _context;
        public LocationRepo(CPContext context)
        {
            _context = context;
        }
        public async void CreateAsync(Location location)
        {
            await _context.Locations.AddAsync(location);
        }
        
        public async Task<Location> UpdateAsync(Location location)
        {
            var locationToUpdate = await _context.Locations.FirstOrDefaultAsync(l => l.EntityId == location.EntityId);

            if (locationToUpdate != null)
            {
                locationToUpdate.Street = location.Street;
                locationToUpdate.City = location.City;
                locationToUpdate.State = location.State;
                locationToUpdate.Zipcode = location.Zipcode;
            }
            else
            {
                return location;
            }

            return locationToUpdate;

        }
        
        public async Task<bool> DeleteAsync(long id)
        {
            var location = await _context.Locations.FindAsync(id);
            if (location == null)
            {
                return false;
            }

            _context.Locations.Remove(location);
            return true;
        }

        public  void Create(Location entry)
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