using HealthGearConfig.Models;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace HealthGearConfig.Services
{
    /// <summary>
    /// Classe responsabile della gestione del file di configurazione healthgear.config.json.
    /// Permette di leggere, scrivere e ripristinare le impostazioni di configurazione dell'applicazione.
    /// </summary>
    public class ConfigFileManager
    {
        private const string ConfigFilePath = "C:\\ProgramData\\HealthGear\\healthgear.config.json";

        /// <summary>
        /// Contiene le impostazioni attualmente caricate dalla configurazione.
        /// </summary>
        public ConfigData Settings { get; private set; }

        /// <summary>
        /// Costruttore della classe ConfigFileManager.
        /// Inizializza le impostazioni con valori di default e carica la configurazione dal file JSON.
        /// </summary>
        public ConfigFileManager()
        {
            // Inizializza con i valori di default per soddisfare il compilatore
            Settings = ConfigData.CreateDefault();
            LoadConfig();
        }

        /// <summary>
        /// Carica la configurazione dal file JSON.
        /// Se il file è mancante, corrotto o non valido, viene rigenerato con valori di default.
        /// </summary>
        public void LoadConfig()
        {
            try
            {
                if (File.Exists(ConfigFilePath))
                {
                    string json = File.ReadAllText(ConfigFilePath);
                    var loadedConfig = JsonConvert.DeserializeObject<ConfigData>(json);

                    if (loadedConfig == null)
                    {
                        MessageBox.Show("Il file di configurazione è corrotto. Verrà ripristinato ai valori di default.", "Errore Configurazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ResetToDefault();
                    }
                    else
                    {
                        Settings = loadedConfig;
                    }
                }
                else
                {
                    MessageBox.Show("Il file di configurazione non è stato trovato. Verrà creato uno nuovo con valori di default.", "File Mancante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetToDefault();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nel caricamento della configurazione: {ex.Message}\nIl file verrà ripristinato.", "Errore Configurazione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetToDefault();
            }
        }

        /// <summary>
        /// Ripristina la configurazione ai valori di default e salva le impostazioni nel file JSON.
        /// </summary>
        private void ResetToDefault()
        {
            Settings = ConfigData.CreateDefault();
            SaveConfig();
            MessageBox.Show("La configurazione è stata ripristinata ai valori di default.", "Ripristino Configurazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Salva la configurazione attuale nel file JSON.
        /// </summary>
        public void SaveConfig()
        {
            try
            {
                string json = JsonConvert.SerializeObject(Settings, Formatting.Indented);
                File.WriteAllText(ConfigFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nel salvataggio della configurazione: {ex.Message}", "Errore Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Verifica ed eventualmente crea le directory necessarie per il file di configurazione.
        /// </summary>
        public static void EnsureDirectoriesExist()
        {
            const string basePath = "C:\\ProgramData\\HealthGear";
            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }
        }
    }
}
