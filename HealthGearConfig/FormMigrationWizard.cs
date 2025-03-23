using HealthGearConfig.Models;
using HealthGearConfig.Services;

namespace HealthGearConfig
{
    public partial class FormMigrationWizard : Form
    {
        private readonly ConfigFileManager _configManager = new();

        private readonly List<Panel> wizardPages;
        private int currentPageIndex = 0;
        private readonly MigrationState _state = new();

        /// <summary>
        /// Intestazioni delle pagine del wizard.
        /// </summary>

        private readonly List<(string Title, string Subtitle)> pageHeaders =
        [
            ("Benvenuto", "Prepariamo la migrazione"),
            ("Cosa vuoi spostare?", "Seleziona le cartelle da migrare"),
            ("Dove vuoi spostarle?", "Scegli la nuova destinazione"),
            ("Conferma le operazioni", "Verifica che tutto sia corretto"),
            ("In corso...", "Attendere il completamento della procedura"),
            ("Completato", "Riepilogo dell'operazione")
        ];

        private string dbPath = string.Empty;
        private string uploadsPath = string.Empty;

        public FormMigrationWizard()
        {
            InitializeComponent();

            /// Inizializza le pagine del wizard

            wizardPages =
            [
                panelWelcome,
                panelSelectFolders,
                panelDestination,
                panelConfirm,
                panelProgress,
                panelSummary
            ];

            /// Nasconde tutte le pagine tranne la prima
            for (int i = 0; i < wizardPages.Count; i++)
                wizardPages[i].Visible = i == 0;

            currentPageIndex = 0;
            SetHeader(pageHeaders[0].Title, pageHeaders[0].Subtitle);
        }

        /// <summary>
        /// Aggiorna lo stato dei pulsanti di navigazione in base alla pagina corrente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMigrationWizard_Load(object sender, EventArgs e)
        {
            dbPath = _configManager.Settings?.DatabasePath ?? "Percorso non disponibile";
            uploadsPath = _configManager.Settings?.UploadFolderPath ?? "Percorso non disponibile";
            _state.CurrentDatabasePath = dbPath;
            _state.CurrentUploadsPath = uploadsPath;


            labelDbCurrentPath.Text = $"Percorso attuale:\n{dbPath}";
            labelUploadsCurrentPath.Text = $"Percorso attuale:\n{uploadsPath}";
            UpdateNavigationButtons();
        }

        /// <summary>
        /// Aggiorna l'intestazione della pagina corrente.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="subtitle"></param>
        private void SetHeader(string title, string subtitle)
        {
            labelPageTitle.Text = title;
            labelPageSubtitle.Text = subtitle;
        }

        /// <summary>
        /// Aggiorna lo stato del flag che richiede o meno la cancellazione dei file di origine.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxDeleteSource_CheckedChanged(object sender, EventArgs e)
        {
            _state.DeleteSourceAfterMigration = checkBoxDeleteSource.Checked;
        }

        private void SaveMigrationLogToFile()
        {
            using SaveFileDialog dialog = new()
            {
                Title = "Salva il log della migrazione",
                Filter = "File di testo|*.txt",
                FileName = "Migration.log",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(dialog.FileName, _state.MigrationLog);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Impossibile salvare il file: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSaveLog_Click(object sender, EventArgs e)
        {
            SaveMigrationLogToFile();
        }
    }
}
