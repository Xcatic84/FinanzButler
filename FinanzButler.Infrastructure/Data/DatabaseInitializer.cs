using Microsoft.Data.Sqlite;

namespace FinanzButler.Infrastructure.Data
{
    public static class DatabaseInitializer
    {
        public static string ConnectionString = "Data Source=finanzbutler.db";

        public static void Initialisieren()
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var befehl = connection.CreateCommand();
            befehl.CommandText =
            @"
                CREATE TABLE IF NOT EXISTS Konto (
                    Id TEXT PRIMARY KEY,
                    Name TEXT NOT NULL,
                    Typ INTEGER NOT NULL,
                    Startsaldo REAL NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Kategorie (
                    Id TEXT PRIMARY KEY,
                    Name TEXT NOT NULL,
                    FarbeHex TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Buchung (
                    Id TEXT PRIMARY KEY,
                    Datum TEXT NOT NULL,
                    Betrag REAL NOT NULL,
                    Typ INTEGER NOT NULL,
                    Bezeichnung TEXT NOT NULL,
                    KategorieId TEXT NOT NULL,
                    KontoId TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Dauerauftrag (
                    Id TEXT PRIMARY KEY,
                    Betrag REAL NOT NULL,
                    Typ INTEGER NOT NULL,
                    Bezeichnung TEXT NOT NULL,
                    KategorieId TEXT NOT NULL,
                    KontoId TEXT NOT NULL,
                    Intervall INTEGER NOT NULL,
                    Startdatum TEXT NOT NULL,
                    Enddatum TEXT NULL
                );
            ";

            befehl.ExecuteNonQuery();
        }
    }
}