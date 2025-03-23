namespace HealthGearConfig.Models
{
    /// <summary>
    /// Rappresenta lo stato corrente della migrazione, incluse le selezioni effettuate dall'utente
    /// e i percorsi di origine e destinazione.
    /// </summary>
    public class MigrationState
    {
        /// <summary>
        /// Indica se la cartella del database è stata selezionata per la migrazione.
        /// </summary>
        public bool MigrateDatabase { get; set; }

        /// <summary>
        /// Indica se la cartella di upload è stata selezionata per la migrazione.
        /// </summary>
        public bool MigrateUploads { get; set; }

        /// <summary>
        /// Percorso attuale del file di database.
        /// </summary>
        public string CurrentDatabasePath { get; set; } = string.Empty;

        /// <summary>
        /// Percorso attuale della cartella di upload.
        /// </summary>
        public string CurrentUploadsPath { get; set; } = string.Empty;

        /// <summary>
        /// Nuova destinazione selezionata per il database.
        /// </summary>
        public string DestinationDatabasePath { get; set; } = string.Empty;

        /// <summary>
        /// Nuova destinazione selezionata per la cartella di upload.
        /// </summary>
        public string DestinationUploadsPath { get; set; } = string.Empty;

        /// <summary>
        /// Restituisce true se almeno un tipo di dato è stato selezionato per la migrazione.
        /// </summary>
        public bool HasAnySelection => MigrateDatabase || MigrateUploads;

        /// <summary>
        /// Indica se eliminare i file di origine dopo la migrazione.
        /// </summary>
        public bool DeleteSourceAfterMigration { get; set; } = false;

        /// <summary>
        /// Log della migrazione, contenente informazioni sull'esito e dettagli dell'operazione.
        /// </summary>
        public string MigrationLog { get; set; } = string.Empty;

        /// <summary>
        /// Esito della migrazione: "success", "warning" o "error".
        /// </summary>
        public string MigrationOutcome { get; set; } = "success";

        /// <summary>
        /// Resetta completamente lo stato della migrazione.
        /// </summary>
        public void Reset()
        {
            MigrateDatabase = false;
            MigrateUploads = false;
            CurrentDatabasePath = string.Empty;
            CurrentUploadsPath = string.Empty;
            DestinationDatabasePath = string.Empty;
            DestinationUploadsPath = string.Empty;
        }
    }
}
