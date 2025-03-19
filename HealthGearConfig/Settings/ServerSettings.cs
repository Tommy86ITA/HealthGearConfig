using System;
using System.IO;

namespace HealthGearConfig.Settings
{
    /// <summary>
    /// Classe che rappresenta le impostazioni del server.
    /// Contiene le configurazioni per la porta del server, il database e il percorso di upload dei file.
    /// </summary>
    public class ServerSettings
    {
        /// <summary>
        /// Porta su cui il server è in ascolto.
        /// </summary>
        public int Port { get; set; } = 5051;

        /// <summary>
        /// Percorso predefinito del database in `C:\ProgramData\HealthGear\healthgear.db`
        /// </summary>
        public string DatabasePath { get; set; }

        /// <summary>
        /// Percorso della cartella in cui vengono salvati i file caricati dagli utenti.
        /// </summary>
        public string FileUploadPath { get; set; }

        /// <summary>
        /// Costruttore: imposta i valori di default.
        /// </summary>
        public ServerSettings()
        {
            DatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "HealthGear", "healthgear.db");
            FileUploadPath = @"C:\HealthGear\Uploads";
        }

        /// <summary>
        /// Assicura che tutte le cartelle necessarie esistano.
        /// </summary>
        public void EnsureDirectoriesExist()
        {
            try
            {
                Console.WriteLine("🔄 Verifica e creazione cartelle necessarie...");

                Directory.CreateDirectory(Path.GetDirectoryName(DatabasePath) ?? @"C:\ProgramData\HealthGear");
                Directory.CreateDirectory(FileUploadPath);

                Console.WriteLine("✅ Cartelle verificate e pronte all'uso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Errore durante la creazione delle cartelle: {ex.Message}");
            }
        }
    }
}
