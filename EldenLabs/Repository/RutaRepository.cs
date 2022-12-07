using EldenLabs.Data;
using EldenLabs.Interfaces;
using EldenLabs.Models;

namespace EldenLabs.Repository
{
    public class RutaRepository : IRutaRepository
    {
        private readonly DataContext _context;

        public RutaRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Ruta> GetRutas()
        {
            return _context.Rutas.OrderBy(p => p.Id).ToList();
        }
    }
}
