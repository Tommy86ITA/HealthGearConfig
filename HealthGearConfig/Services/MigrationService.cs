using HealthGearConfig.Models;

namespace HealthGearConfig.Services
{
    public class MigrationService(ConfigFileManager config)
    {
        private readonly ConfigFileManager _config = config;
        public static bool IsRunning { get; private set; }

        /// <summary>
        /// Avvia la migrazione delle cartelle selezionate, aggiornando lo stato e notificando la progressione.
        /// </summary>
        /// <param name="state">Lo stato della migrazione da leggere e aggiornare</param>
        /// <param name="onProgress">Callback opzionale per notificare l'avanzamento (percentuale, messaggio)</param>
        public async Task ExecuteAsync(MigrationState state, Action<int, string>? onProgress = null)
        {
            IsRunning = true;

            int step = 0;
            int totalSteps = (state.MigrateDatabase ? 1 : 0) + (state.MigrateUploads ? 1 : 0);
            int errors = 0;
            int warnings = 0;

            state.MigrationLog = string.Empty;

            try
            {
                if (state.MigrateDatabase)
                {
                    onProgress?.Invoke(GetPercent(++step, totalSteps), "Copia del file del database...");
                    bool result = await CopyDatabaseFileAsync(state);
                    if (!result) warnings++;
                }

                if (state.MigrateUploads)
                {
                    onProgress?.Invoke(GetPercent(++step, totalSteps), "Copia della cartella Upload...");
                    bool result = await CopyDirectoryAsync(
                        state.CurrentUploadsPath,
                        state.DestinationUploadsPath,
                        state,
                        "Uploads");

                    if (!result) warnings++;
                }
            }
            catch (Exception ex)
            {
                errors++;
                state.MigrationLog += $"[ERRORE] {ex.Message}\n";
            }
            finally
            {
                IsRunning = false;
            }

            state.MigrationOutcome = errors > 0 ? "error" : (warnings > 0 ? "warning" : "success");
            onProgress?.Invoke(100, "Migrazione completata.");

            if (state.MigrationOutcome is "success" or "warning")
            {
                if (state.MigrateDatabase)
                    _config.Settings!.DatabasePath = Path.Combine(state.DestinationDatabasePath, Path.GetFileName(state.CurrentDatabasePath));

                if (state.MigrateUploads)
                    _config.Settings!.UploadFolderPath = state.DestinationUploadsPath;

                _config.SaveConfig();

                await CleanSourcePathsAsync(state);
            }
        }

        /// <summary>
        /// Copia ricorsivamente i file da una cartella sorgente a una destinazione, notificando eventuali errori.
        /// </summary>
        /// <param name="sourceDir"></param>
        /// <param name="destDir"></param>
        /// <param name="state"></param>
        /// <param name="label"></param>
        /// <returns></returns>
        private static async Task<bool> CopyDirectoryAsync(string sourceDir, string destDir, MigrationState state, string label)
        {
            bool hasWarnings = false;

            try
            {
                Directory.CreateDirectory(destDir);

                string[] files = Directory.GetFiles(sourceDir, "*.*", SearchOption.AllDirectories);
                int total = files.Length;

                for (int i = 0; i < total; i++)
                {
                    string file = files[i];
                    string relative = Path.GetRelativePath(sourceDir, file);
                    string destination = Path.Combine(destDir, relative);

                    try
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(destination)!);
                        File.Copy(file, destination, true);
                        state.MigrationLog += $"[OK] {label}: {relative}\n";
                    }
                    catch (Exception ex)
                    {
                        hasWarnings = true;
                        state.MigrationLog += $"[WARNING] {label}: {relative} → {ex.Message}\n";
                    }

                    await Task.Delay(1);
                }
            }
            catch (Exception ex)
            {
                state.MigrationLog += $"[ERRORE] {label}: {ex.Message}\n";
                return false;
            }

            return !hasWarnings;
        }

        /// <summary>
        /// Copia il file del database da una cartella sorgente a una destinazione, notificando eventuali errori.
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        private static async Task<bool> CopyDatabaseFileAsync(MigrationState state)
        {
            try
            {
                Directory.CreateDirectory(state.DestinationDatabasePath);

                string fileName = Path.GetFileName(state.CurrentDatabasePath);
                string destFile = Path.Combine(state.DestinationDatabasePath, fileName);

                File.Copy(state.CurrentDatabasePath, destFile, true);
                state.MigrationLog += $"[OK] Database copiato: {fileName}\n";
                await Task.Delay(1);
                return true;
            }
            catch (Exception ex)
            {
                state.MigrationLog += $"[ERRORE] Copia database: {ex.Message}\n";
                return false;
            }
        }

        /// <summary>
        /// Elimina i file di origine dopo la migrazione, se l'opzione è abilitata.
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        private static async Task CleanSourcePathsAsync(MigrationState state)
        {
            if (!state.DeleteSourceAfterMigration)
                return;

            try
            {
                if (state.MigrateDatabase)
                {
                    string originalDbFile = state.CurrentDatabasePath;
                    if (File.Exists(originalDbFile))
                    {
                        File.Delete(originalDbFile);
                        state.MigrationLog += "[INFO] File del database originale eliminato.\n";
                    }
                }

                if (state.MigrateUploads)
                {
                    if (Directory.Exists(state.CurrentUploadsPath))
                    {
                        Directory.Delete(state.CurrentUploadsPath, recursive: true);
                        state.MigrationLog += "[INFO] Cartella Upload originale eliminata.\n";
                    }
                }
            }
            catch (Exception ex)
            {
                state.MigrationLog += $"[WARNING] Impossibile eliminare le cartelle originali: {ex.Message}\n";
                if (state.MigrationOutcome == "success")
                    state.MigrationOutcome = "warning";
            }

            await Task.CompletedTask;
        }

        /// <summary>
        /// Calcola la percentuale di avanzamento in base allo stato corrente e totale.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        private static int GetPercent(int current, int total)
        {
            return total == 0 ? 0 : (int)(current / (double)total * 100);
        }
    }
}
