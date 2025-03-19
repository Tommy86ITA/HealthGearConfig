using System;
using HealthGearConfig.Settings;
using System.IO;

namespace HealthGearConfig.Services
{
    /// <summary>
    /// Classe responsabile della configurazione iniziale dell'applicazione.
    /// Si occupa di verificare e creare le cartelle necessarie all'avvio.
    /// </summary>
    public static class StartManager
    {
        /// <summary>
        /// Inizializza l'ambiente di HealthGearConfig assicurando che tutte le cartelle richieste esistano.
        /// </summary>
        public static void EnsureDirectoriesExist()
        {
            try
            {
                Console.WriteLine("🔄 Verifica e creazione delle cartelle richieste...");

                // Creiamo un'istanza di ServerSettings per ottenere i percorsi configurabili
                var serverSettings = new ServerSettings();
                serverSettings.EnsureDirectoriesExist();

                // Creiamo anche la cartella per i log
                Directory.CreateDirectory(LoggingSettings.DefaultLogPath);

                Console.WriteLine("✅ Tutte le cartelle sono state verificate e, se necessario, create.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Errore durante la creazione delle cartelle: {ex.Message}");
            }
        }
    }
}
