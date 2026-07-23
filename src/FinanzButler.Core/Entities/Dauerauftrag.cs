namespace FinanzButler.Core.Entities
{
    public enum Intervall
    {
        Woechentlich,
        Monatlich,
        Vierteljaehrlich,
        Jaehrlich
    }

    public class Dauerauftrag
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public decimal Betrag { get; set; }
        public BuchungsTyp Typ { get; set; }
        public string Bezeichnung { get; set; } = string.Empty;
        public Guid KategorieId { get; set; }
        public Guid KontoId { get; set; }
        public Intervall Intervall { get; set; }
        public DateTime Startdatum { get; set; }
        public DateTime? Enddatum { get; set; }
    }
}