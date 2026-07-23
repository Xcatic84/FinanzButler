using FinanzButler.Core.Entities;
using FinanzButler.Application.Interfaces;

namespace FinanzButler.Application.Services
{
    public class BuchungService
    {
        private readonly IBuchungRepository _buchungRepository;

        public BuchungService(IBuchungRepository buchungRepository)
        {
            _buchungRepository = buchungRepository;
        }

        public void BuchungAnlegen(Buchung buchung)
        {
            if (buchung.Betrag <= 0)
            {
                throw new ArgumentException("Der Betrag muss größer als 0 sein.");
            }

            if (string.IsNullOrWhiteSpace(buchung.Bezeichnung))
            {
                throw new ArgumentException("Die Bezeichnung darf nicht leer sein.");
            }

            _buchungRepository.Add(buchung);
        }

        public List<Buchung> AlleBuchungenAbrufen()
        {
            return _buchungRepository.GetAlle();
        }

        public void BuchungLoeschen(Guid id)
        {
            _buchungRepository.Delete(id);
        }
    }
}