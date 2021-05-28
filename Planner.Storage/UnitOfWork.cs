using System.Threading.Tasks;
using Planner.Storage.Repositories;

namespace Planner.Storage
{
    public class UnitOfWork
    {
         private readonly CPContext _context;
        public AppUserRepo AppUsers { get; set; }
        public EventRepo Events { get; set; }
        public LocationRepo Locations { get; set; }
        
        

        public UnitOfWork(CPContext context)
        {
            _context = context;

            AppUsers = new AppUserRepo(_context);
            Events = new EventRepo(_context);
            Locations = new LocationRepo(_context);
        }
        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }
    }
}