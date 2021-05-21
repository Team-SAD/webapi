using Planner.Storage.Repositories;

namespace Planner.Storage
{
    public class UnitOfWork
    {
         private readonly CPContext _context;
        public CustomerRepo Customers { get; set; }
        public EventRepo Events { get; set; }
        public LocationRepo Locations { get; set; }
        
        

        public UnitOfWork(CPContext context)
        {
            _context = context;

            Customers = new CustomerRepo(_context);
            Events = new EventRepo(_context);
            Locations = new LocationRepo(_context);
        }
        public void Save()
        {
        _context.SaveChanges();
        }
    }
}