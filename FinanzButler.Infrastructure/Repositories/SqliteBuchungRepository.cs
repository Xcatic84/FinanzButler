using Microsoft.Data.Sqlite;
using FinanzButler.Core.Entities;
using FinanzButler.Application.Interfaces;
using FinanzButler.Infrastructure.Data;

namespace FinanzButler.Infrastructure.Repositories
{
    public class SqliteBuchungRepository : IBuchungRepository
    {
        public List<Buchung> GetAlle()
        {
            var ergebnis = new List<Buchung>();

            using var connection = new SqliteConnection(DatabaseInitializer.ConnectionString);
            connection.Open();

            var befehl = connection.CreateCommand();
            befehl.CommandText = "SELECT Id, Datum, Betrag, Typ, Bezeichnung, KategorieId, KontoId FROM Buchung";

            using var reader = befehl.ExecuteReader();
            while (reader.Read())
            {
                ergebnis.Add(new Buchung
                {
                    Id = Guid.Parse(reader.GetString(0)),
                    Datum = DateTime.Parse(reader.GetString(1)),
                    Betrag = reader.GetDecimal(2),
                    Typ = (BuchungsTyp)reader.GetInt32(3),
                    Bezeichnung = reader.GetString(4),
                    KategorieId = Guid.Parse(reader.GetString(5)),
                    KontoId = Guid.Parse(reader.GetString(6))
                });
            }

            return ergebnis;
        }

        public Buchung? GetById(Guid id)
        {
            return GetAlle().FirstOrDefault(b => b.Id == id);
        }

        public void Add(Buchung buchung)
        {
            using var connection = new SqliteConnection(DatabaseInitializer.ConnectionString);
            connection.Open();

            var befehl = connection.CreateCommand();
            befehl.CommandText =
            @"INSERT INTO Buchung (Id, Datum, Betrag, Typ, Bezeichnung, KategorieId, KontoId)
              VALUES ($id, $datum, $betrag, $typ, $bezeichnung, $kategorieId, $kontoId)";

            befehl.Parameters.AddWithValue("$id", buchung.Id.ToString());
            befehl.Parameters.AddWithValue("$datum", buchung.Datum.ToString("o"));
            befehl.Parameters.AddWithValue("$betrag", buchung.Betrag);
            befehl.Parameters.AddWithValue("$typ", (int)buchung.Typ);
            befehl.Parameters.AddWithValue("$bezeichnung", buchung.Bezeichnung);
            befehl.Parameters.AddWithValue("$kategorieId", buchung.KategorieId.ToString());
            befehl.Parameters.AddWithValue("$kontoId", buchung.KontoId.ToString());

            befehl.ExecuteNonQuery();
        }

        public void Update(Buchung buchung)
        {
            using var connection = new SqliteConnection(DatabaseInitializer.ConnectionString);
            connection.Open();

            var befehl = connection.CreateCommand();
            befehl.CommandText =
            @"UPDATE Buchung SET Datum = $datum, Betrag = $betrag, Typ = $typ,
              Bezeichnung = $bezeichnung, KategorieId = $kategorieId, KontoId = $kontoId
              WHERE Id = $id";

            befehl.Parameters.AddWithValue("$id", buchung.Id.ToString());
            befehl.Parameters.AddWithValue("$datum", buchung.Datum.ToString("o"));
            befehl.Parameters.AddWithValue("$betrag", buchung.Betrag);
            befehl.Parameters.AddWithValue("$typ", (int)buchung.Typ);
            befehl.Parameters.AddWithValue("$bezeichnung", buchung.Bezeichnung);
            befehl.Parameters.AddWithValue("$kategorieId", buchung.KategorieId.ToString());
            befehl.Parameters.AddWithValue("$kontoId", buchung.KontoId.ToString());

            befehl.ExecuteNonQuery();
        }

        public void Delete(Guid id)
        {
            using var connection = new SqliteConnection(DatabaseInitializer.ConnectionString);
            connection.Open();

            var befehl = connection.CreateCommand();
            befehl.CommandText = "DELETE FROM Buchung WHERE Id = $id";
            befehl.Parameters.AddWithValue("$id", id.ToString());

            befehl.ExecuteNonQuery();
        }
    }
}