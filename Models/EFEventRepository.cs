using System.Linq;

namespace Modas.Models
{
    public class EFEventRepository : IEventRepository
    {
        private ApplicationDbContext context;

        public EFEventRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Event> Events => context.Events;
        public IQueryable<Location> Locations => context.Locations;

        public Event AddEvent(Event evt)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteEvent(int eventId)
        {
            throw new System.NotImplementedException();
        }

        public Event UpdateEvent(Event evt)
        {
            throw new System.NotImplementedException();
        }
    }
}
