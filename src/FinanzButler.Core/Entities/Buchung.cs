namespace FinanzButler.Core.Entities
{
    public enum BuchungsTyp
    {
        Einnahme,
        Ausgabe
    }

    public class Buchung
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Datum { get; set; }
        public decimal Betrag { get; set; }
        public BuchungsTyp Typ { get; set; }
        public string Bezeichnung { get; set; } = string.Empty;
        public Guid KategorieId { get; set; }
        public Guid KontoId { get; set; }
    }
}