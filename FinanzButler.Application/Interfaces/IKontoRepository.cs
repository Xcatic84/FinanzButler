using FinanzButler.Core.Entities;

namespace FinanzButler.Application.Interfaces
{
    public interface IKontoRepository
    {
        List<Konto> GetAlle();
        Konto? GetById(Guid id);
        void Add(Konto konto);
        void Update(Konto konto);
        void Delete(Guid id);
    }
}