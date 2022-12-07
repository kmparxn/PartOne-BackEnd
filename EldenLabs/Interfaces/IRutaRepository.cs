using EldenLabs.Models;

namespace EldenLabs.Interfaces
{
    public interface IRutaRepository
    {
        ICollection<Ruta> GetRutas();
    }
}
