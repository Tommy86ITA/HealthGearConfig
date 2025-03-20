// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using HealthGearConfig.Services;

namespace HealthGearConfig
{
    public partial class MainForm : Form
    {
        private readonly StartupManager _startupManager;
        /// <summary>
        /// Costruttore della finestra principale.
        /// Inizializza i componenti e aggiorna lo stato del servizio all'avvio.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _startupManager = new StartupManager();
            UpdateServiceStatus();
        }

        ///--------------------------------------------------------------------------------
        /// Metodi per la gestione dell'avvio e arresto del servizio
        ///--------------------------------------------------------------------------------
        /// <summary>
        /// Gestisce il click sul pulsante "Avvia Servizio".
        /// Avvia il servizio e aggiorna la UI in base al nuovo stato.
        /// </summary>
        private void buttonStartService_Click(object? sender, EventArgs e)
        {
            if (ServiceManager.StartService())
            {
                UpdateServiceStatus(); // ✅ Aggiorna UI dopo l'avvio
            }
            else
            {
                _ = MessageBox.Show("Errore durante l'avvio del servizio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gestisce il click sul pulsante "Ferma Servizio".
        /// Arresta il servizio e aggiorna la UI in base al nuovo stato.
        /// </summary>
        private void buttonStopService_Click(object? sender, EventArgs e)
        {
            if (ServiceManager.StopService())
            {
                UpdateServiceStatus(); // ✅ Aggiorna UI dopo lo stop
            }
            else
            {
                _ = MessageBox.Show("Errore durante l'arresto del servizio.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///--------------------------------------------------------------------------------
        /// Metodi helper per la gestione dell'interfaccia grafica
        ///--------------------------------------------------------------------------------
        /// <summary>
        /// Aggiorna l'interfaccia utente in base allo stato attuale del servizio.
        /// - Cambia il colore del pannello di stato.
        /// - Aggiorna il testo dello stato del servizio.
        /// - Abilita/disabilita i pulsanti e i controlli in base allo stato del servizio.
        /// </summary>
        private void UpdateServiceStatus()
        {
            try
            {
                bool isRunning = ServiceManager.IsServiceRunning();

                // Stato del servizio
                if (isRunning)
                {
                    labelServiceStatus.Text = "Servizo in esecuzione";
                    panelServiceStatus.BackColor = Color.Green;
                }
                else
                {
                    labelServiceStatus.Text = "Servizio arrestato";
                    panelServiceStatus.BackColor = Color.Red;
                }

                // Abilita/disabilita i pulsanti in base allo stato del servizio
                buttonStartService.Enabled = !isRunning;
                // Disabilita il pulsante di arresto se il servizio è già fermo
                buttonStopService.Enabled = isRunning;

                // Disabilita la tab delle impostazioni del server se il servizio è attivo
                groupBoxServer.Enabled = !isRunning;

                // Disabilita i controlli di migrazione cartelle se il servizio è attivo
                groupBoxFolders.Enabled = !isRunning;
            }
            catch (Exception)
            {
                // Se il servizio non è installato, gestiamo lo stato specifico
                labelServiceStatus.Text = "Servizio non installato";
                panelServiceStatus.BackColor = Color.Gray;

                // Disabilitiamo i pulsanti di avvio e arresto
                buttonStartService.Enabled = false;
                buttonStopService.Enabled = false;

                // Mostriamo l'avviso solo se non è già stato mostrato
                _ = MessageBox.Show(
                    "Il servizio HealthGear non è installato su questo sistema.\n" +
                    "Contatta l'Amministratore di sistema.",
                    "Servizio non installato",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        ///--------------------------------------------------------------------------------
        /// <summary>
        /// Gestione degli eventi di chiusura dell'applicazione
        /// </summary>
        ///--------------------------------------------------------------------------------
        ///
        /// <summary>
        /// Gestisce la chiusura dell'applicazione quando l'utente clicca sulla "X" o preme ALT+F4.
        /// </summary>
        private void Form1_OnFormClosing(object? sender, FormClosingEventArgs e)

        {
            ExitApplication();
        }

        /// <summary>
        /// Gestisce l'uscita dall'applicazione, mostrando avvisi se necessario.
        /// </summary>
        private static void ExitApplication()
        {
            ExitManager.ConfirmExit();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void buttonServer_Click(object sender, EventArgs e)
        {
            using FormServerSettings settingsForm = new();
            settingsForm.ShowDialog();
        }
    }
}
