using LanchoneteSite.Context;
using LanchoneteSite.Models;
using LanchoneteSite.Repositories.Interfaces;

namespace LanchoneteSite.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
