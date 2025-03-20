using HealthGearConfig.Models;
using Newtonsoft.Json;

namespace HealthGearConfig.Services
{
    public class ConfigFileManager
    {
        private const string ConfigFilePath = "C:\\ProgramData\\HealthGear\\healthgear.config.json";
        public ConfigData Settings { get; private set; }

        public ConfigFileManager()
        {
            // Inizializza con i valori di default per soddisfare il compilatore
            Settings = ConfigData.CreateDefault();
            LoadConfig();
        }

        public void LoadConfig()
        {
            try
            {
                if (File.Exists(ConfigFilePath))
                {
                    string json = File.ReadAllText(ConfigFilePath);
                    Settings = JsonConvert.DeserializeObject<ConfigData>(json) ?? ConfigData.CreateDefault();
                }
                else
                {
                    Settings = ConfigData.CreateDefault();
                    SaveConfig();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore nel caricamento della configurazione del server: {ex.Message}");
                Settings = ConfigData.CreateDefault();
                SaveConfig();
            }
        }

        public void SaveConfig()
        {
            try
            {
                string json = JsonConvert.SerializeObject(Settings, Formatting.Indented);
                File.WriteAllText(ConfigFilePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore nel salvataggio della configurazione del server: {ex.Message}");
            }
        }

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
