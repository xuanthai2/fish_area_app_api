using FishAreaApp.Models;

namespace FishAreaApp.Interfaces
{
    public interface IBao
    {
        ICollection<Bao> GetBaos();
    }
}
