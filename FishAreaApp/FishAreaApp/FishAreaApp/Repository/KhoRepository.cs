using FishAreaApp.Data;
using FishAreaApp.Interfaces;
using FishAreaApp.Models;

namespace FishAreaApp.Repository
{
    public class KhoRepository : IKho
    {
        private readonly DataContext dataContext;

        public KhoRepository(DataContext dataContext) 
        {
            this.dataContext = dataContext;
        }
        public ICollection<Kho> GetKhos()
        {
            return dataContext.Kho.OrderBy(x => x.Id).ToList();
        }
    }
}
