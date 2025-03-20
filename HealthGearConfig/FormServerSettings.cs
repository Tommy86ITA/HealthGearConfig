// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using HealthGearConfig.Services;

namespace HealthGearConfig
{
    public partial class FormServerSettings : Form
    {
        private readonly ConfigFileManager _configManager;

        /// <summary>
        /// Costruttore del form.
        /// </summary>
        public FormServerSettings()
        {
            InitializeComponent();
            _configManager = new ConfigFileManager();
            listBoxHosts.DrawMode = DrawMode.OwnerDrawFixed; // Permette colori personalizzati
            listBoxHosts.DrawItem += ListBoxHosts_DrawItem;
            LoadSettings();
        }

        /// <summary>
        /// Carica le impostazioni esistenti nel form.
        /// </summary>
        private void LoadSettings()
        {
            // Controllo e validazione della porta salvata nel file JSON
            if (_configManager.Settings!.ServerPort < 1024 || _configManager.Settings.ServerPort > 65535)
            {
                MessageBox.Show("⚠️ La porta specificata nel file di configurazione non è valida.\n" +
                                "Verrà impostata al valore predefinito (5001).",
                                "Errore Configurazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                _configManager.Settings.ServerPort = 5051; // Valore di default
                _configManager.SaveConfig(); // Salviamo il valore corretto
            }

            // Imposta il valore corretto nel controllo UI
            numericUpDownPort.Value = _configManager.Settings.ServerPort;

            listBoxHosts.Items.Clear();
            bool hasInvalidHosts = false; // Flag per errori

            foreach (var host in _configManager.Settings.AllowedHosts.Split(','))
            {
                string trimmedHost = host.Trim();
                listBoxHosts.Items.Add(trimmedHost);

                if (!IsValidHost(trimmedHost))
                {
                    // 🔴 Evidenzia l'errore in rosso
                    listBoxHosts.Items[^1] = new ListBoxItem(trimmedHost, Color.Red);
                    hasInvalidHosts = true;
                }
            }

            // Mostra un messaggio se ci sono errori
            if (hasInvalidHosts)
            {
                MessageBox.Show("⚠️ Alcuni Allowed Hosts non sono validi. Sono evidenziati in rosso.",
                                "Errore Configurazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Aggiunge un nuovo host alla lista.
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string newHost = textBoxHosts.Text.Trim();

            if (string.IsNullOrWhiteSpace(newHost))
            {
                MessageBox.Show("Inserisci un host valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidHost(newHost))
            {
                MessageBox.Show("L'host inserito non è valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listBoxHosts.Items.Contains(newHost))
            {
                MessageBox.Show("L'host è già presente nella lista.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listBoxHosts.Items.Add(newHost);
            textBoxHosts.Clear();
            UpdateRemoveButtonState();
        }

        /// <summary>
        /// Rimuove l'host selezionato dalla lista.
        /// </summary>
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxHosts.SelectedIndex == -1) return;

            object? selectedItem = listBoxHosts.SelectedItem;

            if (selectedItem is null)
            {
                MessageBox.Show("⚠️ Nessun elemento selezionato.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Contiamo quanti host validi ci sono
            int validHostsCount = listBoxHosts.Items.Cast<object>().Count(item =>
                (item is string host && IsValidHost(host)) ||
                (item is ListBoxItem listItem && IsValidHost(listItem.Text)));

            // Se rimane solo un host valido e si sta tentando di rimuoverlo, impedire la rimozione
            if (selectedItem is string host && IsValidHost(host) && validHostsCount == 1)
            {
                MessageBox.Show("⚠️ Non puoi rimuovere l'ultimo host valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Solo ora possiamo rimuovere l'elemento in sicurezza
            listBoxHosts.Items.Remove(selectedItem);

            // Dopo la rimozione, se rimane solo un host non valido, sostituirlo con 'localhost'
            if (listBoxHosts.Items.Count == 1)
            {
                object lastItem = listBoxHosts.Items[0];
                if (lastItem is ListBoxItem listItem && !IsValidHost(listItem.Text))
                {
                    listBoxHosts.Items[0] = "localhost";
                }
            }

            UpdateRemoveButtonState();
        }

        /// <summary>
        /// Salva le impostazioni e chiude il form.
        /// </summary>
        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            _configManager.Settings!.ServerPort = (int)numericUpDownPort.Value;
            _configManager.Settings!.AllowedHosts = string.Join(",", listBoxHosts.Items.Cast<string>());
            _configManager.SaveConfig();
            MessageBox.Show("Impostazioni salvate con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ///--------------------------------------------------------------------------------
        /// <summary>
        /// Metodi di supporto
        /// </summary>
        ///--------------------------------------------------------------------------------
        ///
        /// <summary>
        /// Verifica se l'host è valido (IP, dominio o wildcard '*').
        /// </summary>
        private static bool IsValidHost(string host)
        {
            if (host == "*" || host.Equals("localhost", StringComparison.OrdinalIgnoreCase) || host == "0.0.0.0" || host == "[::]")
                return true; // `*` per qualsiasi host, `localhost`, `0.0.0.0` e `[::]` sono validi

            // ❌ Se è un IP ma contiene '*', lo consideriamo NON valido
            if (host.Contains('*'))
                return false;

            // Controllo IP standard
            if (System.Net.IPAddress.TryParse(host, out _))
                return true;

            // Controllo dominio con regex
            //return System.Text.RegularExpressions.Regex.IsMatch(host, @"^([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,}$");
            return ValidHostRegex().IsMatch(host);
        }

        /// <summary>
        /// Disabilita il pulsante "Rimuovi" se c'è un solo host rimasto.
        /// </summary>
        private void UpdateRemoveButtonState()
        {
            int validHostsCount = listBoxHosts.Items.Cast<object>().Count(item =>
                (item is string host && IsValidHost(host)) ||
                (item is ListBoxItem listItem && IsValidHost(listItem.Text)));

            // Disabilita il pulsante se c'è solo un host valido rimasto
            buttonRemove.Enabled = listBoxHosts.Items.Count > 1 || validHostsCount > 1;
        }

        /// <summary>
        /// Disegna gli elementi della ListBox con colori personalizzati.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxHosts_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();
            object item = listBoxHosts.Items[e.Index];

            string text = item?.ToString() ?? string.Empty;
            Color color = (item is ListBoxItem listItem) ? listItem.Color : Color.Black;

            using (Brush brush = new SolidBrush(color))
            {
                e.Graphics.DrawString(text, e.Font ?? SystemFonts.DefaultFont, brush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        [System.Text.RegularExpressions.GeneratedRegex(@"^([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,}$")]
        private static partial System.Text.RegularExpressions.Regex ValidHostRegex();
    }

    /// <summary>
    /// Elemento personalizzato per la ListBox con testo e colore.
    /// </summary>
    public class ListBoxItem(string text, Color color)
    {
        public string Text { get; } = text;
        public Color Color { get; } = color;

        public override string ToString() => Text; // Mostra solo il testo nella ListBox
    }
}
