namespace HealthGearConfig
{
    public partial class FormMigrationWizard : Form
    {
        private static bool IsValidPath(string path) =>
            !string.IsNullOrWhiteSpace(path) && Path.IsPathRooted(path);

        private static long GetFolderSize(string folderPath)
        {
            try
            {
                return Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories)
                                .Sum(file => new FileInfo(file).Length);
            }
            catch { return 0; }
        }

        private static long GetAvailableDiskSpace(string path)
        {
            try
            {
                if (!IsValidPath(path) || !Directory.Exists(path)) return 0;
                string root = Path.GetPathRoot(path) ?? "";
                DriveInfo drive = new(root);
                return drive.AvailableFreeSpace;
            }
            catch { return 0; }
        }

        private static string FormatBytes(long bytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = bytes;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len /= 1024;
            }

            return $"{len:0.##} {sizes[order]}";
        }

        /// <summary>
        /// Aggiorna lo stato del pulsante Avanti nella pagina di selezione cartelle.
        /// </summary>
        private void UpdateNextButtonForFolderSelection()
        {
            if (currentPageIndex == 1)
                buttonNext.Enabled = checkBoxDb.Checked || checkBoxUploads.Checked;
        }

        /// <summary>
        /// Aggiorna la pagina di selezione destinazione con convalida dei percorsi, verifica spazio e tooltip.
        /// </summary>
        private void UpdateNextButtonForDestination()
        {
            if (currentPageIndex != 2) return;

            bool dbValid = true, uploadsValid = true;

            labelRequiredSpaceDb.Text = string.Empty;
            labelReuiredSpaceUploads.Text = string.Empty;

            // ----------------------------------------
            // DATABASE
            // ----------------------------------------
            if (checkBoxDb.Checked)
            {
                string dbDest = textBoxDb.Text;
                string dbFolder = Path.GetDirectoryName(dbPath) ?? "";

                bool hasValidPath = IsValidPath(dbDest) && !dbDest.Equals(dbPath, StringComparison.OrdinalIgnoreCase);
                long requiredDb = hasValidPath ? GetFolderSize(dbFolder) : 0;
                long availableDb = hasValidPath ? GetAvailableDiskSpace(dbDest) : 0;

                dbValid = hasValidPath && availableDb > requiredDb;

                textBoxDb.BackColor = dbValid ? SystemColors.Window : Color.MistyRose;

                labelRequiredSpaceDb.Text = $"Destinazione cartella Database. Spazio richiesto: {FormatBytes(requiredDb)}";

                toolTipProvider.SetToolTip(textBoxDb, dbValid
                    ? ""
                    : "Percorso non valido, uguale a quello attuale o spazio insufficiente.");

                if (dbValid)
                    _state.DestinationDatabasePath = dbDest;
            }

            // ----------------------------------------
            // UPLOADS
            // ----------------------------------------
            if (checkBoxUploads.Checked)
            {
                string uploadsDest = textBoxUploads.Text;

                bool hasValidPath = IsValidPath(uploadsDest) && !uploadsDest.Equals(uploadsPath, StringComparison.OrdinalIgnoreCase);
                long requiredUploads = hasValidPath ? GetFolderSize(uploadsPath) : 0;
                long availableUploads = hasValidPath ? GetAvailableDiskSpace(uploadsDest) : 0;

                uploadsValid = hasValidPath && availableUploads > requiredUploads;

                textBoxUploads.BackColor = uploadsValid ? SystemColors.Window : Color.MistyRose;

                labelReuiredSpaceUploads.Text = $"Destinazione cartella Upload. Spazio richiesto: {FormatBytes(requiredUploads)}";

                toolTipProvider.SetToolTip(textBoxUploads, uploadsValid
                    ? ""
                    : "Percorso non valido, uguale a quello attuale o spazio insufficiente.");

                if (uploadsValid)
                    _state.DestinationUploadsPath = uploadsDest;
            }

            buttonNext.Enabled = dbValid && uploadsValid;
        }

        /// <summary>
        /// Aggiorna la pagina di conferma con le informazioni selezionate e gestisce visibilità e pulsanti.
        /// </summary>
        private void UpdateConfirmPage()
        {
            bool showDb = _state.MigrateDatabase;
            bool showUploads = _state.MigrateUploads;

            // Mostra/nasconde i controlli relativi al DB
            pictureBoxDbConfirm.Visible = showDb;
            labelDbConfirm.Visible = showDb;

            if (showDb)
            {
                labelDbConfirm.Text = $"Cartella Database:\n{_state.CurrentDatabasePath}\n{_state.DestinationDatabasePath}";
            }

            // Mostra/nasconde i controlli relativi agli Upload
            pictureBoxUploadsConfirm.Visible = showUploads;
            labelUploadsConfirm.Visible = showUploads;

            if (showUploads)
            {
                labelUploadsConfirm.Text = $"Cartella Upload:\n{_state.CurrentUploadsPath}\n{_state.DestinationUploadsPath}";
            }

            checkBoxDeleteSource.Checked = false;

            // Disabilita il pulsante Avanti finché non viene confermata l'operazione
            checkBoxConfirm.Checked = false;
            buttonNext.Enabled = false;
        }

        /// <summary>
        /// Abilita il pulsante Avanti solo se l’utente ha confermato le informazioni.
        /// </summary>
        private void UpdateNextButtonForConfirm()
        {
            if (currentPageIndex == 3)
                buttonNext.Enabled = checkBoxConfirm.Checked;
        }


        private void checkBoxDb_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNextButtonForFolderSelection();
        }

        private void checkBoxUploads_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNextButtonForFolderSelection();
        }

        private void textBoxDb_TextChanged(object sender, EventArgs e) => UpdateNextButtonForDestination();
        private void textBoxUploads_TextChanged(object sender, EventArgs e) => UpdateNextButtonForDestination();

        private void checkBoxConfirm_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNextButtonForConfirm();
        }
    }
}
