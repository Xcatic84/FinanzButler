namespace FinanzButler.Core.Entities
{
    public enum KontoTyp
    {
        Girokonto,
        Bargeld,
        Kreditkarte,
        Sparkonto
    }

    public class Konto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public KontoTyp Typ { get; set; }
        public decimal Startsaldo { get; set; }
    }
}