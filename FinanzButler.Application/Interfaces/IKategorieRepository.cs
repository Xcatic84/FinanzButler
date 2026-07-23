using FinanzButler.Core.Entities;

namespace FinanzButler.Application.Interfaces
{
    public interface IKategorieRepository
    {
        List<Kategorie> GetAlle();
        Kategorie? GetById(Guid id);
        void Add(Kategorie kategorie);
        void Update(Kategorie kategorie);
        void Delete(Guid id);
    }
}