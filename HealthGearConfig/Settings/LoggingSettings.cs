using System;
using System.IO;

namespace HealthGearConfig.Settings
{
    /// <summary>
    /// Classe che rappresenta le impostazioni di logging.
    /// </summary>
    public class LoggingSettings
    {
        /// <summary>
        /// Percorso della cartella in cui vengono salvati i file di log.
        /// </summary>
        public string LogPath { get; set; } = DefaultLogPath;

        /// <summary>
        /// Percorso predefinito dei log in `C:\ProgramData\HealthGear\Logs\`
        /// </summary>
        public static string DefaultLogPath =>
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "HealthGear", "Logs");
    }
}
