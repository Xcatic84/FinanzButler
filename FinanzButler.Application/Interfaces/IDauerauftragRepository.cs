using FinanzButler.Core.Entities;

namespace FinanzButler.Application.Interfaces
{
    public interface IDauerauftragRepository
    {
        List<Dauerauftrag> GetAlle();
        Dauerauftrag? GetById(Guid id);
        void Add(Dauerauftrag dauerauftrag);
        void Update(Dauerauftrag dauerauftrag);
        void Delete(Guid id);
    }
}