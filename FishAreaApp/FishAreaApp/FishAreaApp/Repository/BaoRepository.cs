using FishAreaApp.Data;
using FishAreaApp.Interfaces;
using FishAreaApp.Models;

namespace FishAreaApp.Repository
{
    public class BaoRepository : IBao
    {
        private readonly DataContext _context;
        public BaoRepository(DataContext dbContext)
        {
            this._context = dbContext;
        }

        public ICollection<Bao> GetBaos()
        {
            return _context.Baos.OrderBy(b => b.Id).ToList();
        }
    }
}
