using LanchoneteSite.Models;

namespace LanchoneteSite.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
