using HealthGearConfig.Services;
using System.Diagnostics;
using System.Security.Principal;

namespace HealthGearConfig
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            /*            // 🔍 Controlla se l'app è in esecuzione come amministratore
                        if (!IsRunningAsAdministrator())
                        {
                            try
                            {
                                ProcessStartInfo startInfo = new()
                                {
                                    FileName = Application.ExecutablePath,
                                    Verb = "runas",
                                    UseShellExecute = true // 🛠 Necessario per l'UAC
                                };

                                Process.Start(startInfo);
                            }
                            catch
                            {
                                MessageBox.Show("Devi eseguire questa applicazione come amministratore.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            // 🛑 Esce immediatamente dal processo corrente
                            Environment.Exit(0);
                            return;
                        }*/

            // 🛠 Previeni esecuzioni multiple
            using Mutex mutex = new(true, "HealthGearConfigMutex", out bool createdNew);
            if (!createdNew)
            {
                MessageBox.Show("L'app è già in esecuzione.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inizializza la gestione della configurazione
            // Inizializza la gestione della configurazione
            var configManager = new ConfigFileManager();
            ConfigFileManager.EnsureDirectoriesExist();

            // Test: Stampiamo le impostazioni caricate per verificare se funzionano
            Console.WriteLine("📂 Configurazione caricata:");
            Console.WriteLine($" - Porta Server: {configManager.Settings.ServerPort}");
            Console.WriteLine($" - Percorso Database: {configManager.Settings.DatabasePath}");
            Console.WriteLine($" - Cartella Upload: {configManager.Settings.UploadFolderPath}");
            Console.WriteLine($" - Allowed Hosts: {configManager.Settings.AllowedHosts}");
            configManager.Settings.ServerPort = 9090;
            configManager.SaveConfig();


            Application.Run(new MainForm());
        }

        /// <summary>
        /// Controlla se il programma è in esecuzione con privilegi di amministratore.
        /// </summary>
        private static bool IsRunningAsAdministrator()
        {
            using WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
