using FinanzButler.Core.Entities;

namespace FinanzButler.Application.Interfaces
{
    public interface IBuchungRepository
    {
        List<Buchung> GetAlle();
        Buchung? GetById(Guid id);
        void Add(Buchung buchung);
        void Update(Buchung buchung);
        void Delete(Guid id);
    }
}