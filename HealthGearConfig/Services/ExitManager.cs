// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace HealthGearConfig.Services
{
    public static class ExitManager
    {
        /// <summary>
        /// Gestisce l'uscita dall'applicazione, mostrando avvisi se necessario.
        /// </summary>
        public static bool ConfirmExit()
        {
            // Se il wizard di migrazione è ancora aperto, impediamo la chiusura
            if (MigrationWizard.IsRunning)
            {
                MessageBox.Show(
                    "Il wizard di migrazione è ancora in esecuzione. Attendere il completamento prima di chiudere l'applicazione.",
                    "Migrazione in corso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false; // ❌ Blocca la chiusura dell'app
            }

            // Se il servizio è installato ma non in esecuzione, chiediamo se avviarlo prima di chiudere
            if (ServiceManager.IsServiceInstalled() && !ServiceManager.IsServiceRunning())
            {
                DialogResult serviceResult = MessageBox.Show(
                    "Stai per chiudere l'applicazione, ma il servizio non è in esecuzione.\n\nVuoi avviare il servizio prima di uscire?",
                    "Servizio non attivo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (serviceResult == DialogResult.Cancel)
                {
                    return false; // ❌ L'utente ha annullato l'uscita
                }
                else if (serviceResult == DialogResult.Yes)
                {
                    ServiceManager.StartService(); // ✅ Avvia il servizio prima di chiudere
                }
            }

            return true; // ✅ L'utente ha confermato l'uscita
        }
    }
}