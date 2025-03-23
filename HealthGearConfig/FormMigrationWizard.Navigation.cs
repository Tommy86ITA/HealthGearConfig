using HealthGearConfig.Services;

namespace HealthGearConfig
{
    public partial class FormMigrationWizard : Form
    {
        /// <summary>
        /// Gestisce quale pagina del wizard mostrare.
        /// </summary>
        /// <param name="index"></param>
        private void ShowPage(int index)
        {
            if (index < 0 || index >= wizardPages.Count)
                return;

            // Nasconde tutte le pagine e mostra solo quella corrente
            foreach (var panel in wizardPages)
                panel.Visible = false;

            wizardPages[index].Visible = true;
            currentPageIndex = index;

            // Aggiorna intestazione
            var (title, subtitle) = pageHeaders[index];
            SetHeader(title, subtitle);

            // Aggiorna pulsanti di navigazione
            UpdateNavigationButtons();

            // Azioni specifiche per pagina
            switch (currentPageIndex)
            {
                case 1:
                    UpdateNextButtonForFolderSelection();
                    break;

                case 2:
                    _state.MigrateDatabase = checkBoxDb.Checked;
                    _state.MigrateUploads = checkBoxUploads.Checked;

                    UpdateDestinationControls(); // Abilita/disabilita textbox e pulsanti
                    UpdateNextButtonForDestination(); // Convalida i percorsi
                    break;

                case 3:
                    UpdateConfirmPage(); // Mostra riepilogo operazione e gestisce checkbox
                    UpdateNextButtonForConfirm();
                    break;

                case 4:
                    StartMigrationAsync();
                    break;

                case 5:
                    UpdateSummaryPage();
                    break;
            }
        }

        /// <summary>
        /// Aggiorna lo stato dei pulsanti di navigazione in base alla pagina corrente.
        /// </summary>
        private void UpdateNavigationButtons()
        {
            buttonBack.Enabled = currentPageIndex > 0;
            buttonNext.Enabled = currentPageIndex < wizardPages.Count - 1;
            buttonFinish.Visible = currentPageIndex == wizardPages.Count - 1;
        }

        /// <summary>
        /// Avvia la migrazione dei dati in background.
        /// </summary>
        private async void StartMigrationAsync()
        {
            // Disabilita pulsanti durante la migrazione
            buttonNext.Enabled = false;
            buttonBack.Enabled = false;
            buttonCancel.Enabled = false;
            buttonFinish.Visible = false;

            labelProgress.Text = "Inizio migrazione...";
            progressBar.Value = 0;

            MigrationService service = new(_configManager);
            await service.ExecuteAsync(_state, ReportProgress);

            ShowPage(5); // Vai alla pagina di riepilogo
        }

        /// <summary>
        /// Riporta i progressi della migrazione sulla progressbar.
        /// </summary>
        /// <param name="percent"></param>
        /// <param name="message"></param>
        private void ReportProgress(int percent, string message)
        {
            if (InvokeRequired)
            {
                Invoke(() => ReportProgress(percent, message));
                return;
            }

            progressBar.Value = Math.Min(percent, 100);
            labelProgress.Text = message;
        }



        private void buttonNext_Click(object sender, EventArgs e) => ShowPage(currentPageIndex + 1);
        private void buttonBack_Click(object sender, EventArgs e) => ShowPage(currentPageIndex - 1);
        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
