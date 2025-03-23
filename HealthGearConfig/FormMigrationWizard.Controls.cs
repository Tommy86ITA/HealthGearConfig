using HealthGearConfig.Properties;

namespace HealthGearConfig
{
    public partial class FormMigrationWizard : Form
    {
        private void buttonBrowseDb_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog dialog = new();
            dialog.Description = "Seleziona la nuova destinazione per il database";
            dialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxDb.Text = dialog.SelectedPath;
                UpdateNextButtonForDestination();
            }
        }

        private void buttonBrowseUploads_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog dialog = new();
            dialog.Description = "Seleziona la nuova destinazione per la cartella di upload";
            dialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxUploads.Text = dialog.SelectedPath;
                UpdateNextButtonForDestination();
            }
        }
        private void UpdateDestinationControls()
        {
            textBoxDb.Visible = buttonBrowseDb.Visible = pictureBoxDbDestination.Visible = _state.MigrateDatabase;
            textBoxUploads.Visible = buttonBrowseUploads.Visible = pictureBoxUploadsDestination.Visible = _state.MigrateUploads;
        }

        /// <summary>
        /// Aggiorna la pagina di riepilogo dopo la migrazione, inclusi log, immagine e pulsanti.
        /// </summary>
        private void UpdateSummaryPage()
        {
            labelSummaryMessage.Text = _state.MigrationOutcome switch
            {
                "success" => "L'operazione è stata completata con successo. I nuovi percorsi sono stati salvati nel file di configurazione.",
                "warning" => "L'operazione è stata completata con alcuni avvisi. I percorsi validi sono stati salvati nel file di configurazione.",
                "error" => "Si è verificato un errore durante la migrazione. Nessuna modifica è stata applicata.",
                _ => "Esito sconosciuto."
            };


            pictureBoxSummary.Image = _state.MigrationOutcome switch
            {
                "success" => Resource.foldersucces,
                "warning" => Resource.folderwarning,
                "error" => Resource.foldererror,
                _ => null
            };

            textBoxLog.Text = _state.MigrationLog;

            buttonNext.Visible = false;
            buttonBack.Visible = false;
            buttonCancel.Visible = false;
            buttonFinish.Text = "Chiudi";
            buttonFinish.Visible = true;
        }

    }
}
