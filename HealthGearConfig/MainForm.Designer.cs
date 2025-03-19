// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace HealthGearConfig
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxServiceStatus = new GroupBox();
            panelServiceStatus = new Panel();
            labelServiceStatus = new Label();
            buttonStopService = new Button();
            buttonStartService = new Button();
            tabServerSettings = new TabControl();
            tabPage1 = new TabPage();
            buttonBrowseUploadPath = new Button();
            textBoxFileUploadPath = new TextBox();
            labelUploadFolderPath = new Label();
            buttonBrowseDBFolderPath = new Button();
            textBoxDatabasePath = new TextBox();
            numericUpDownServerPort = new NumericUpDown();
            labelDBFilepath = new Label();
            labelServerPort = new Label();
            tabPageLogging = new TabPage();
            buttonBrowseLoggingPath = new Button();
            textBoxLogPath = new TextBox();
            labelLoggingPath = new Label();
            tabPageManageSettings = new TabPage();
            groupBoxReset = new GroupBox();
            labelResetSettings = new Label();
            buttonResetSettings = new Button();
            groupBoxImportSettings = new GroupBox();
            buttonDiscardImportedSettings = new Button();
            buttonApplyImportedSettings = new Button();
            labelSettingsPreview = new Label();
            textBoxPreview = new TextBox();
            labelImportSettings = new Label();
            buttonImportSettings = new Button();
            groupBoxExportSettings = new GroupBox();
            labelExportSettings = new Label();
            buttonExportSettings = new Button();
            tabPageAbout = new TabPage();
            groupBoxAbout = new GroupBox();
            labelHealthGearVersion = new Label();
            labelSoftwareVersion = new Label();
            labelSoftwareName = new Label();
            richTextBoxLicense = new RichTextBox();
            buttonExit = new Button();
            buttonSave = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            groupBoxServiceStatus.SuspendLayout();
            tabServerSettings.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownServerPort).BeginInit();
            tabPageLogging.SuspendLayout();
            tabPageManageSettings.SuspendLayout();
            groupBoxReset.SuspendLayout();
            groupBoxImportSettings.SuspendLayout();
            groupBoxExportSettings.SuspendLayout();
            tabPageAbout.SuspendLayout();
            groupBoxAbout.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxServiceStatus
            // 
            groupBoxServiceStatus.Controls.Add(panelServiceStatus);
            groupBoxServiceStatus.Controls.Add(labelServiceStatus);
            groupBoxServiceStatus.Controls.Add(buttonStopService);
            groupBoxServiceStatus.Controls.Add(buttonStartService);
            groupBoxServiceStatus.Location = new Point(19, 15);
            groupBoxServiceStatus.Name = "groupBoxServiceStatus";
            groupBoxServiceStatus.Size = new Size(847, 144);
            groupBoxServiceStatus.TabIndex = 0;
            groupBoxServiceStatus.TabStop = false;
            groupBoxServiceStatus.Text = "Stato servizio";
            // 
            // panelServiceStatus
            // 
            panelServiceStatus.BackColor = Color.Red;
            panelServiceStatus.BorderStyle = BorderStyle.FixedSingle;
            panelServiceStatus.Location = new Point(460, 54);
            panelServiceStatus.Name = "panelServiceStatus";
            panelServiceStatus.Size = new Size(53, 59);
            panelServiceStatus.TabIndex = 3;
            // 
            // labelServiceStatus
            // 
            labelServiceStatus.AutoSize = true;
            labelServiceStatus.Location = new Point(537, 72);
            labelServiceStatus.Name = "labelServiceStatus";
            labelServiceStatus.Size = new Size(135, 30);
            labelServiceStatus.TabIndex = 2;
            labelServiceStatus.Text = "Stato servizio";
            // 
            // buttonStopService
            // 
            buttonStopService.Location = new Point(236, 52);
            buttonStopService.Name = "buttonStopService";
            buttonStopService.Size = new Size(207, 68);
            buttonStopService.TabIndex = 1;
            buttonStopService.Text = "Arresta servizio";
            buttonStopService.UseVisualStyleBackColor = true;
            buttonStopService.Click += buttonStopService_Click;
            // 
            // buttonStartService
            // 
            buttonStartService.Location = new Point(21, 52);
            buttonStartService.Name = "buttonStartService";
            buttonStartService.Size = new Size(207, 68);
            buttonStartService.TabIndex = 0;
            buttonStartService.Text = "Avvia servizio";
            buttonStartService.UseVisualStyleBackColor = true;
            buttonStartService.Click += buttonStartService_Click;
            // 
            // tabServerSettings
            // 
            tabServerSettings.Controls.Add(tabPage1);
            tabServerSettings.Controls.Add(tabPageLogging);
            tabServerSettings.Controls.Add(tabPageManageSettings);
            tabServerSettings.Controls.Add(tabPageAbout);
            tabServerSettings.Location = new Point(15, 166);
            tabServerSettings.Multiline = true;
            tabServerSettings.Name = "tabServerSettings";
            tabServerSettings.SelectedIndex = 0;
            tabServerSettings.Size = new Size(845, 1149);
            tabServerSettings.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonBrowseUploadPath);
            tabPage1.Controls.Add(textBoxFileUploadPath);
            tabPage1.Controls.Add(labelUploadFolderPath);
            tabPage1.Controls.Add(buttonBrowseDBFolderPath);
            tabPage1.Controls.Add(textBoxDatabasePath);
            tabPage1.Controls.Add(numericUpDownServerPort);
            tabPage1.Controls.Add(labelDBFilepath);
            tabPage1.Controls.Add(labelServerPort);
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(837, 1106);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Server";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonBrowseUploadPath
            // 
            buttonBrowseUploadPath.Location = new Point(621, 406);
            buttonBrowseUploadPath.Name = "buttonBrowseUploadPath";
            buttonBrowseUploadPath.Size = new Size(131, 45);
            buttonBrowseUploadPath.TabIndex = 8;
            buttonBrowseUploadPath.Text = "Sfoglia...";
            buttonBrowseUploadPath.UseVisualStyleBackColor = true;
            buttonBrowseUploadPath.Click += buttonBrowseUploadPath_Click;
            // 
            // textBoxFileUploadPath
            // 
            textBoxFileUploadPath.Location = new Point(93, 410);
            textBoxFileUploadPath.Name = "textBoxFileUploadPath";
            textBoxFileUploadPath.Size = new Size(487, 35);
            textBoxFileUploadPath.TabIndex = 7;
            // 
            // labelUploadFolderPath
            // 
            labelUploadFolderPath.AutoSize = true;
            labelUploadFolderPath.Location = new Point(87, 366);
            labelUploadFolderPath.Name = "labelUploadFolderPath";
            labelUploadFolderPath.Size = new Size(222, 30);
            labelUploadFolderPath.TabIndex = 6;
            labelUploadFolderPath.Text = "Percorso File Database";
            // 
            // buttonBrowseDBFolderPath
            // 
            buttonBrowseDBFolderPath.Location = new Point(621, 220);
            buttonBrowseDBFolderPath.Name = "buttonBrowseDBFolderPath";
            buttonBrowseDBFolderPath.Size = new Size(131, 45);
            buttonBrowseDBFolderPath.TabIndex = 5;
            buttonBrowseDBFolderPath.Text = "Sfoglia...";
            buttonBrowseDBFolderPath.UseVisualStyleBackColor = true;
            buttonBrowseDBFolderPath.Click += buttonBrowseDBFolderPath_Click;
            // 
            // textBoxDatabasePath
            // 
            textBoxDatabasePath.Location = new Point(93, 224);
            textBoxDatabasePath.Name = "textBoxDatabasePath";
            textBoxDatabasePath.Size = new Size(487, 35);
            textBoxDatabasePath.TabIndex = 4;
            // 
            // numericUpDownServerPort
            // 
            numericUpDownServerPort.Location = new Point(621, 62);
            numericUpDownServerPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDownServerPort.Minimum = new decimal(new int[] { 1024, 0, 0, 0 });
            numericUpDownServerPort.Name = "numericUpDownServerPort";
            numericUpDownServerPort.Size = new Size(131, 35);
            numericUpDownServerPort.TabIndex = 3;
            numericUpDownServerPort.Value = new decimal(new int[] { 5051, 0, 0, 0 });
            // 
            // labelDBFilepath
            // 
            labelDBFilepath.AutoSize = true;
            labelDBFilepath.Location = new Point(87, 189);
            labelDBFilepath.Name = "labelDBFilepath";
            labelDBFilepath.Size = new Size(222, 30);
            labelDBFilepath.TabIndex = 1;
            labelDBFilepath.Text = "Percorso File Database";
            // 
            // labelServerPort
            // 
            labelServerPort.AutoSize = true;
            labelServerPort.Location = new Point(87, 62);
            labelServerPort.Name = "labelServerPort";
            labelServerPort.Size = new Size(124, 30);
            labelServerPort.TabIndex = 0;
            labelServerPort.Text = "Porta Server";
            // 
            // tabPageLogging
            // 
            tabPageLogging.Controls.Add(buttonBrowseLoggingPath);
            tabPageLogging.Controls.Add(textBoxLogPath);
            tabPageLogging.Controls.Add(labelLoggingPath);
            tabPageLogging.Location = new Point(4, 39);
            tabPageLogging.Name = "tabPageLogging";
            tabPageLogging.Padding = new Padding(3);
            tabPageLogging.Size = new Size(837, 1106);
            tabPageLogging.TabIndex = 2;
            tabPageLogging.Text = "Logging";
            tabPageLogging.UseVisualStyleBackColor = true;
            // 
            // buttonBrowseLoggingPath
            // 
            buttonBrowseLoggingPath.Location = new Point(619, 132);
            buttonBrowseLoggingPath.Name = "buttonBrowseLoggingPath";
            buttonBrowseLoggingPath.Size = new Size(131, 45);
            buttonBrowseLoggingPath.TabIndex = 8;
            buttonBrowseLoggingPath.Text = "Sfoglia...";
            buttonBrowseLoggingPath.UseVisualStyleBackColor = true;
            buttonBrowseLoggingPath.Click += buttonBrowseLoggingPath_Click;
            // 
            // textBoxLogPath
            // 
            textBoxLogPath.Location = new Point(91, 135);
            textBoxLogPath.Name = "textBoxLogPath";
            textBoxLogPath.Size = new Size(487, 35);
            textBoxLogPath.TabIndex = 7;
            // 
            // labelLoggingPath
            // 
            labelLoggingPath.AutoSize = true;
            labelLoggingPath.Location = new Point(86, 100);
            labelLoggingPath.Name = "labelLoggingPath";
            labelLoggingPath.Size = new Size(192, 30);
            labelLoggingPath.TabIndex = 6;
            labelLoggingPath.Text = "Percorso File di Log";
            // 
            // tabPageManageSettings
            // 
            tabPageManageSettings.Controls.Add(groupBoxReset);
            tabPageManageSettings.Controls.Add(groupBoxImportSettings);
            tabPageManageSettings.Controls.Add(groupBoxExportSettings);
            tabPageManageSettings.Location = new Point(4, 39);
            tabPageManageSettings.Name = "tabPageManageSettings";
            tabPageManageSettings.Padding = new Padding(3);
            tabPageManageSettings.Size = new Size(837, 1106);
            tabPageManageSettings.TabIndex = 3;
            tabPageManageSettings.Text = "Gestione Impostazioni";
            tabPageManageSettings.UseVisualStyleBackColor = true;
            // 
            // groupBoxReset
            // 
            groupBoxReset.Controls.Add(labelResetSettings);
            groupBoxReset.Controls.Add(buttonResetSettings);
            groupBoxReset.Location = new Point(21, 932);
            groupBoxReset.Name = "groupBoxReset";
            groupBoxReset.Size = new Size(792, 162);
            groupBoxReset.TabIndex = 2;
            groupBoxReset.TabStop = false;
            groupBoxReset.Text = "Reset";
            // 
            // labelResetSettings
            // 
            labelResetSettings.AutoSize = true;
            labelResetSettings.Location = new Point(7, 74);
            labelResetSettings.Name = "labelResetSettings";
            labelResetSettings.Size = new Size(339, 30);
            labelResetSettings.TabIndex = 2;
            labelResetSettings.Text = "Ripristina le impostazioni di default";
            // 
            // buttonResetSettings
            // 
            buttonResetSettings.BackColor = Color.Red;
            buttonResetSettings.ForeColor = Color.White;
            buttonResetSettings.Location = new Point(579, 56);
            buttonResetSettings.Name = "buttonResetSettings";
            buttonResetSettings.Size = new Size(207, 68);
            buttonResetSettings.TabIndex = 1;
            buttonResetSettings.Text = "Ripristina";
            buttonResetSettings.UseVisualStyleBackColor = false;
            buttonResetSettings.Click += buttonResetSettings_Click;
            // 
            // groupBoxImportSettings
            // 
            groupBoxImportSettings.Controls.Add(buttonDiscardImportedSettings);
            groupBoxImportSettings.Controls.Add(buttonApplyImportedSettings);
            groupBoxImportSettings.Controls.Add(labelSettingsPreview);
            groupBoxImportSettings.Controls.Add(textBoxPreview);
            groupBoxImportSettings.Controls.Add(labelImportSettings);
            groupBoxImportSettings.Controls.Add(buttonImportSettings);
            groupBoxImportSettings.Location = new Point(21, 207);
            groupBoxImportSettings.Name = "groupBoxImportSettings";
            groupBoxImportSettings.Size = new Size(792, 718);
            groupBoxImportSettings.TabIndex = 1;
            groupBoxImportSettings.TabStop = false;
            groupBoxImportSettings.Text = "Importa";
            // 
            // buttonDiscardImportedSettings
            // 
            buttonDiscardImportedSettings.Enabled = false;
            buttonDiscardImportedSettings.Location = new Point(421, 632);
            buttonDiscardImportedSettings.Name = "buttonDiscardImportedSettings";
            buttonDiscardImportedSettings.Size = new Size(207, 68);
            buttonDiscardImportedSettings.TabIndex = 6;
            buttonDiscardImportedSettings.Text = "Scarta";
            buttonDiscardImportedSettings.UseVisualStyleBackColor = true;
            buttonDiscardImportedSettings.Click += buttonDiscardImportedSettings_Click;
            // 
            // buttonApplyImportedSettings
            // 
            buttonApplyImportedSettings.Enabled = false;
            buttonApplyImportedSettings.Location = new Point(163, 632);
            buttonApplyImportedSettings.Name = "buttonApplyImportedSettings";
            buttonApplyImportedSettings.Size = new Size(207, 68);
            buttonApplyImportedSettings.TabIndex = 5;
            buttonApplyImportedSettings.Text = "Applica";
            buttonApplyImportedSettings.UseVisualStyleBackColor = true;
            buttonApplyImportedSettings.Click += buttonApplyImportedSettings_Click;
            // 
            // labelSettingsPreview
            // 
            labelSettingsPreview.AutoSize = true;
            labelSettingsPreview.Location = new Point(7, 153);
            labelSettingsPreview.Name = "labelSettingsPreview";
            labelSettingsPreview.Size = new Size(234, 30);
            labelSettingsPreview.TabIndex = 4;
            labelSettingsPreview.Text = "Anteprima impostazioni";
            // 
            // textBoxPreview
            // 
            textBoxPreview.Location = new Point(12, 207);
            textBoxPreview.Multiline = true;
            textBoxPreview.Name = "textBoxPreview";
            textBoxPreview.ReadOnly = true;
            textBoxPreview.Size = new Size(773, 416);
            textBoxPreview.TabIndex = 3;
            // 
            // labelImportSettings
            // 
            labelImportSettings.AutoSize = true;
            labelImportSettings.Location = new Point(7, 74);
            labelImportSettings.Name = "labelImportSettings";
            labelImportSettings.Size = new Size(382, 30);
            labelImportSettings.TabIndex = 2;
            labelImportSettings.Text = "Importa le impostazioni da un file JSON";
            // 
            // buttonImportSettings
            // 
            buttonImportSettings.Location = new Point(579, 56);
            buttonImportSettings.Name = "buttonImportSettings";
            buttonImportSettings.Size = new Size(207, 68);
            buttonImportSettings.TabIndex = 1;
            buttonImportSettings.Text = "Importa";
            buttonImportSettings.UseVisualStyleBackColor = true;
            buttonImportSettings.Click += buttonImportSettings_Click;
            // 
            // groupBoxExportSettings
            // 
            groupBoxExportSettings.Controls.Add(labelExportSettings);
            groupBoxExportSettings.Controls.Add(buttonExportSettings);
            groupBoxExportSettings.Location = new Point(21, 39);
            groupBoxExportSettings.Name = "groupBoxExportSettings";
            groupBoxExportSettings.Size = new Size(792, 162);
            groupBoxExportSettings.TabIndex = 0;
            groupBoxExportSettings.TabStop = false;
            groupBoxExportSettings.Text = "Esporta";
            // 
            // labelExportSettings
            // 
            labelExportSettings.AutoSize = true;
            labelExportSettings.Location = new Point(7, 74);
            labelExportSettings.Name = "labelExportSettings";
            labelExportSettings.Size = new Size(436, 30);
            labelExportSettings.TabIndex = 2;
            labelExportSettings.Text = "Esporte le impostazioni attuali in un file JSON";
            // 
            // buttonExportSettings
            // 
            buttonExportSettings.Location = new Point(579, 56);
            buttonExportSettings.Name = "buttonExportSettings";
            buttonExportSettings.Size = new Size(207, 68);
            buttonExportSettings.TabIndex = 1;
            buttonExportSettings.Text = "Esporta";
            buttonExportSettings.UseVisualStyleBackColor = true;
            buttonExportSettings.Click += buttonExportSettings_Click;
            // 
            // tabPageAbout
            // 
            tabPageAbout.Controls.Add(groupBoxAbout);
            tabPageAbout.Controls.Add(richTextBoxLicense);
            tabPageAbout.Location = new Point(4, 39);
            tabPageAbout.Name = "tabPageAbout";
            tabPageAbout.Padding = new Padding(3);
            tabPageAbout.Size = new Size(837, 1106);
            tabPageAbout.TabIndex = 4;
            tabPageAbout.Text = "About";
            tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // groupBoxAbout
            // 
            groupBoxAbout.Controls.Add(labelHealthGearVersion);
            groupBoxAbout.Controls.Add(labelSoftwareVersion);
            groupBoxAbout.Controls.Add(labelSoftwareName);
            groupBoxAbout.Location = new Point(20, 0);
            groupBoxAbout.Margin = new Padding(4);
            groupBoxAbout.Name = "groupBoxAbout";
            groupBoxAbout.Padding = new Padding(4);
            groupBoxAbout.Size = new Size(791, 242);
            groupBoxAbout.TabIndex = 3;
            groupBoxAbout.TabStop = false;
            // 
            // labelHealthGearVersion
            // 
            labelHealthGearVersion.AutoSize = true;
            labelHealthGearVersion.Location = new Point(12, 162);
            labelHealthGearVersion.Margin = new Padding(4, 0, 4, 0);
            labelHealthGearVersion.Name = "labelHealthGearVersion";
            labelHealthGearVersion.Size = new Size(185, 30);
            labelHealthGearVersion.TabIndex = 6;
            labelHealthGearVersion.Text = "HealthGearVersion";
            labelHealthGearVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSoftwareVersion
            // 
            labelSoftwareVersion.AutoSize = true;
            labelSoftwareVersion.Location = new Point(12, 117);
            labelSoftwareVersion.Margin = new Padding(4, 0, 4, 0);
            labelSoftwareVersion.Name = "labelSoftwareVersion";
            labelSoftwareVersion.Size = new Size(162, 30);
            labelSoftwareVersion.TabIndex = 5;
            labelSoftwareVersion.Text = "SoftwareVersion";
            labelSoftwareVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSoftwareName
            // 
            labelSoftwareName.AutoSize = true;
            labelSoftwareName.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSoftwareName.ForeColor = Color.DodgerBlue;
            labelSoftwareName.Location = new Point(8, 33);
            labelSoftwareName.Margin = new Padding(4, 0, 4, 0);
            labelSoftwareName.Name = "labelSoftwareName";
            labelSoftwareName.Size = new Size(383, 48);
            labelSoftwareName.TabIndex = 4;
            labelSoftwareName.Text = "HealthGear Config";
            labelSoftwareName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBoxLicense
            // 
            richTextBoxLicense.BackColor = SystemColors.ControlLightLight;
            richTextBoxLicense.BorderStyle = BorderStyle.None;
            richTextBoxLicense.Cursor = Cursors.IBeam;
            richTextBoxLicense.Location = new Point(20, 250);
            richTextBoxLicense.Margin = new Padding(4);
            richTextBoxLicense.Name = "richTextBoxLicense";
            richTextBoxLicense.ReadOnly = true;
            richTextBoxLicense.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxLicense.Size = new Size(791, 808);
            richTextBoxLicense.TabIndex = 2;
            richTextBoxLicense.Text = "";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(463, 1322);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(207, 68);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Esci";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(204, 1322);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(207, 68);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Salva";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(873, 1406);
            Controls.Add(buttonExit);
            Controls.Add(buttonSave);
            Controls.Add(tabServerSettings);
            Controls.Add(groupBoxServiceStatus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBoxServiceStatus.ResumeLayout(false);
            groupBoxServiceStatus.PerformLayout();
            tabServerSettings.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownServerPort).EndInit();
            tabPageLogging.ResumeLayout(false);
            tabPageLogging.PerformLayout();
            tabPageManageSettings.ResumeLayout(false);
            groupBoxReset.ResumeLayout(false);
            groupBoxReset.PerformLayout();
            groupBoxImportSettings.ResumeLayout(false);
            groupBoxImportSettings.PerformLayout();
            groupBoxExportSettings.ResumeLayout(false);
            groupBoxExportSettings.PerformLayout();
            tabPageAbout.ResumeLayout(false);
            groupBoxAbout.ResumeLayout(false);
            groupBoxAbout.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxServiceStatus;
        private System.Windows.Forms.Label labelServiceStatus;
        private System.Windows.Forms.Button buttonStopService;
        private System.Windows.Forms.Button buttonStartService;
        private System.Windows.Forms.Panel panelServiceStatus;
        private System.Windows.Forms.TabControl tabServerSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.NumericUpDown numericUpDownServerPort;
        private System.Windows.Forms.Label labelDBFilepath;
        private System.Windows.Forms.Label labelServerPort;
        private System.Windows.Forms.Button buttonBrowseUploadPath;
        private System.Windows.Forms.TextBox textBoxFileUploadPath;
        private System.Windows.Forms.Label labelUploadFolderPath;
        private System.Windows.Forms.Button buttonBrowseDBFolderPath;
        private System.Windows.Forms.TextBox textBoxDatabasePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TabPage tabPageLogging;
        private System.Windows.Forms.TabPage tabPageManageSettings;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.Button buttonBrowseLoggingPath;
        private System.Windows.Forms.TextBox textBoxLogPath;
        private System.Windows.Forms.Label labelLoggingPath;
        private System.Windows.Forms.GroupBox groupBoxExportSettings;
        private System.Windows.Forms.Button buttonExportSettings;
        private System.Windows.Forms.GroupBox groupBoxImportSettings;
        private System.Windows.Forms.TextBox textBoxPreview;
        private System.Windows.Forms.Label labelImportSettings;
        private System.Windows.Forms.Label labelExportSettings;
        private System.Windows.Forms.GroupBox groupBoxReset;
        private System.Windows.Forms.Label labelResetSettings;
        private System.Windows.Forms.Button buttonResetSettings;
        private System.Windows.Forms.Label labelSettingsPreview;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonImportSettings;
        private System.Windows.Forms.Button buttonDiscardImportedSettings;
        private System.Windows.Forms.Button buttonApplyImportedSettings;
        private System.Windows.Forms.GroupBox groupBoxAbout;
        private System.Windows.Forms.Label labelHealthGearVersion;
        private System.Windows.Forms.Label labelSoftwareVersion;
        private System.Windows.Forms.Label labelSoftwareName;
        private System.Windows.Forms.RichTextBox richTextBoxLicense;
    }
}

