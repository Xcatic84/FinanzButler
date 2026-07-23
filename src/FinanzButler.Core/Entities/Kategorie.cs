namespace FinanzButler.Core.Entities
{
    public class Kategorie
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string FarbeHex { get; set; } = "#CCCCCC";
    }
}