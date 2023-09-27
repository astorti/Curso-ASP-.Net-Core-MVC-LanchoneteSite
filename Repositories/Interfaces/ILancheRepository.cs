using LanchoneteSite.Models;

namespace LanchoneteSite.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchePreferidos { get; }
        Lanche GetLancheById(int lancheId);
    }
}
