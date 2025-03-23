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
            folderBrowserDialog = new FolderBrowserDialog();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            tableLayoutPanelMain = new TableLayoutPanel();
            groupBoxLog = new GroupBox();
            tableLayoutPanelLog = new TableLayoutPanel();
            buttonLog = new Button();
            labelLog = new Label();
            groupBoxFolders = new GroupBox();
            tableLayoutPanelFolders = new TableLayoutPanel();
            buttonFolderWizard = new Button();
            labelFolders = new Label();
            groupBoxServer = new GroupBox();
            tableLayoutPanelServer = new TableLayoutPanel();
            buttonServer = new Button();
            labelServer = new Label();
            groupBoxServiceStatus = new GroupBox();
            tableLayoutPanelService = new TableLayoutPanel();
            buttonStartService = new Button();
            labelServiceStatus = new Label();
            panelServiceStatus = new Panel();
            buttonStopService = new Button();
            buttonQuit = new Button();
            buttonInfo = new Button();
            tableLayoutPanelMain.SuspendLayout();
            groupBoxLog.SuspendLayout();
            tableLayoutPanelLog.SuspendLayout();
            groupBoxFolders.SuspendLayout();
            tableLayoutPanelFolders.SuspendLayout();
            groupBoxServer.SuspendLayout();
            tableLayoutPanelServer.SuspendLayout();
            groupBoxServiceStatus.SuspendLayout();
            tableLayoutPanelService.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(groupBoxLog, 0, 3);
            tableLayoutPanelMain.Controls.Add(groupBoxFolders, 0, 2);
            tableLayoutPanelMain.Controls.Add(groupBoxServer, 0, 1);
            tableLayoutPanelMain.Controls.Add(groupBoxServiceStatus, 0, 0);
            tableLayoutPanelMain.Location = new Point(6, 1);
            tableLayoutPanelMain.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 4;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9992046F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9992F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9992F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9992F));
            tableLayoutPanelMain.Size = new Size(496, 422);
            tableLayoutPanelMain.TabIndex = 8;
            // 
            // groupBoxLog
            // 
            groupBoxLog.Anchor = AnchorStyles.None;
            groupBoxLog.Controls.Add(tableLayoutPanelLog);
            groupBoxLog.Location = new Point(2, 317);
            groupBoxLog.Margin = new Padding(2, 1, 2, 1);
            groupBoxLog.Name = "groupBoxLog";
            groupBoxLog.Padding = new Padding(2, 1, 2, 1);
            groupBoxLog.Size = new Size(492, 103);
            groupBoxLog.TabIndex = 7;
            groupBoxLog.TabStop = false;
            groupBoxLog.Text = "Visualizza Log";
            // 
            // tableLayoutPanelLog
            // 
            tableLayoutPanelLog.ColumnCount = 2;
            tableLayoutPanelLog.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.7362633F));
            tableLayoutPanelLog.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.2637367F));
            tableLayoutPanelLog.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11F));
            tableLayoutPanelLog.Controls.Add(buttonLog, 1, 0);
            tableLayoutPanelLog.Controls.Add(labelLog, 0, 0);
            tableLayoutPanelLog.Dock = DockStyle.Fill;
            tableLayoutPanelLog.Location = new Point(2, 17);
            tableLayoutPanelLog.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanelLog.Name = "tableLayoutPanelLog";
            tableLayoutPanelLog.RowCount = 1;
            tableLayoutPanelLog.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelLog.Size = new Size(488, 85);
            tableLayoutPanelLog.TabIndex = 0;
            // 
            // buttonLog
            // 
            buttonLog.Anchor = AnchorStyles.None;
            buttonLog.FlatAppearance.BorderSize = 2;
            buttonLog.Location = new Point(345, 31);
            buttonLog.Margin = new Padding(2, 1, 2, 1);
            buttonLog.Name = "buttonLog";
            buttonLog.Size = new Size(108, 22);
            buttonLog.TabIndex = 4;
            buttonLog.Text = "Apri Log...";
            buttonLog.UseVisualStyleBackColor = true;
            // 
            // labelLog
            // 
            labelLog.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelLog.AutoSize = true;
            labelLog.Location = new Point(2, 35);
            labelLog.Margin = new Padding(2, 0, 2, 0);
            labelLog.Name = "labelLog";
            labelLog.Size = new Size(307, 15);
            labelLog.TabIndex = 7;
            labelLog.Text = "Apri la cartella con i Log di HealthGear.";
            // 
            // groupBoxFolders
            // 
            groupBoxFolders.Anchor = AnchorStyles.None;
            groupBoxFolders.Controls.Add(tableLayoutPanelFolders);
            groupBoxFolders.Location = new Point(2, 211);
            groupBoxFolders.Margin = new Padding(2, 1, 2, 1);
            groupBoxFolders.Name = "groupBoxFolders";
            groupBoxFolders.Padding = new Padding(2, 1, 2, 1);
            groupBoxFolders.Size = new Size(492, 103);
            groupBoxFolders.TabIndex = 6;
            groupBoxFolders.TabStop = false;
            groupBoxFolders.Text = "Spostamento Cartelle";
            // 
            // tableLayoutPanelFolders
            // 
            tableLayoutPanelFolders.ColumnCount = 2;
            tableLayoutPanelFolders.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.6263733F));
            tableLayoutPanelFolders.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.3736267F));
            tableLayoutPanelFolders.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11F));
            tableLayoutPanelFolders.Controls.Add(buttonFolderWizard, 1, 0);
            tableLayoutPanelFolders.Controls.Add(labelFolders, 0, 0);
            tableLayoutPanelFolders.Dock = DockStyle.Fill;
            tableLayoutPanelFolders.Location = new Point(2, 17);
            tableLayoutPanelFolders.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanelFolders.Name = "tableLayoutPanelFolders";
            tableLayoutPanelFolders.RowCount = 1;
            tableLayoutPanelFolders.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelFolders.Size = new Size(488, 85);
            tableLayoutPanelFolders.TabIndex = 0;
            // 
            // buttonFolderWizard
            // 
            buttonFolderWizard.Anchor = AnchorStyles.None;
            buttonFolderWizard.FlatAppearance.BorderSize = 2;
            buttonFolderWizard.Location = new Point(345, 31);
            buttonFolderWizard.Margin = new Padding(2, 1, 2, 1);
            buttonFolderWizard.Name = "buttonFolderWizard";
            buttonFolderWizard.Size = new Size(108, 22);
            buttonFolderWizard.TabIndex = 4;
            buttonFolderWizard.Text = "Wizard...";
            buttonFolderWizard.UseVisualStyleBackColor = true;
            buttonFolderWizard.Click += buttonFolderWizard_Click;
            // 
            // labelFolders
            // 
            labelFolders.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelFolders.AutoSize = true;
            labelFolders.Location = new Point(2, 27);
            labelFolders.Margin = new Padding(2, 0, 2, 0);
            labelFolders.Name = "labelFolders";
            labelFolders.Size = new Size(306, 30);
            labelFolders.TabIndex = 7;
            labelFolders.Text = "Avvia il wizard di spostamento sicuro della cartella di residenza del DB e quella per l'upload dei documenti.";
            // 
            // groupBoxServer
            // 
            groupBoxServer.Anchor = AnchorStyles.None;
            groupBoxServer.Controls.Add(tableLayoutPanelServer);
            groupBoxServer.Location = new Point(2, 106);
            groupBoxServer.Margin = new Padding(2, 1, 2, 1);
            groupBoxServer.Name = "groupBoxServer";
            groupBoxServer.Padding = new Padding(2, 1, 2, 1);
            groupBoxServer.Size = new Size(492, 103);
            groupBoxServer.TabIndex = 5;
            groupBoxServer.TabStop = false;
            groupBoxServer.Text = "Impostazioni Server";
            // 
            // tableLayoutPanelServer
            // 
            tableLayoutPanelServer.ColumnCount = 2;
            tableLayoutPanelServer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.5164833F));
            tableLayoutPanelServer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.4835167F));
            tableLayoutPanelServer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11F));
            tableLayoutPanelServer.Controls.Add(buttonServer, 1, 0);
            tableLayoutPanelServer.Controls.Add(labelServer, 0, 0);
            tableLayoutPanelServer.Dock = DockStyle.Fill;
            tableLayoutPanelServer.Location = new Point(2, 17);
            tableLayoutPanelServer.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanelServer.Name = "tableLayoutPanelServer";
            tableLayoutPanelServer.RowCount = 1;
            tableLayoutPanelServer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelServer.Size = new Size(488, 85);
            tableLayoutPanelServer.TabIndex = 0;
            // 
            // buttonServer
            // 
            buttonServer.Anchor = AnchorStyles.None;
            buttonServer.FlatAppearance.BorderSize = 2;
            buttonServer.Location = new Point(344, 31);
            buttonServer.Margin = new Padding(2, 1, 2, 1);
            buttonServer.Name = "buttonServer";
            buttonServer.Size = new Size(108, 22);
            buttonServer.TabIndex = 4;
            buttonServer.Text = "Modifica...";
            buttonServer.UseVisualStyleBackColor = true;
            buttonServer.Click += buttonServer_Click;
            // 
            // labelServer
            // 
            labelServer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelServer.AutoSize = true;
            labelServer.Location = new Point(2, 27);
            labelServer.Margin = new Padding(2, 0, 2, 0);
            labelServer.Name = "labelServer";
            labelServer.Size = new Size(305, 30);
            labelServer.TabIndex = 7;
            labelServer.Text = "Clicca per modificare le impostazioni del server (porta, allowed hosts...).";
            // 
            // groupBoxServiceStatus
            // 
            groupBoxServiceStatus.Anchor = AnchorStyles.None;
            groupBoxServiceStatus.Controls.Add(tableLayoutPanelService);
            groupBoxServiceStatus.Location = new Point(2, 1);
            groupBoxServiceStatus.Margin = new Padding(2, 1, 2, 1);
            groupBoxServiceStatus.Name = "groupBoxServiceStatus";
            groupBoxServiceStatus.Padding = new Padding(2, 1, 2, 1);
            groupBoxServiceStatus.Size = new Size(492, 103);
            groupBoxServiceStatus.TabIndex = 3;
            groupBoxServiceStatus.TabStop = false;
            groupBoxServiceStatus.Text = "Stato servizio";
            // 
            // tableLayoutPanelService
            // 
            tableLayoutPanelService.ColumnCount = 4;
            tableLayoutPanelService.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.40224F));
            tableLayoutPanelService.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.40224F));
            tableLayoutPanelService.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.934066F));
            tableLayoutPanelService.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.4065933F));
            tableLayoutPanelService.Controls.Add(buttonStartService, 0, 0);
            tableLayoutPanelService.Controls.Add(labelServiceStatus, 3, 0);
            tableLayoutPanelService.Controls.Add(panelServiceStatus, 2, 0);
            tableLayoutPanelService.Controls.Add(buttonStopService, 1, 0);
            tableLayoutPanelService.Dock = DockStyle.Fill;
            tableLayoutPanelService.Location = new Point(2, 17);
            tableLayoutPanelService.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanelService.Name = "tableLayoutPanelService";
            tableLayoutPanelService.RowCount = 1;
            tableLayoutPanelService.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelService.Size = new Size(488, 85);
            tableLayoutPanelService.TabIndex = 0;
            // 
            // buttonStartService
            // 
            buttonStartService.Anchor = AnchorStyles.None;
            buttonStartService.FlatAppearance.BorderSize = 2;
            buttonStartService.Location = new Point(20, 31);
            buttonStartService.Margin = new Padding(2, 1, 2, 1);
            buttonStartService.Name = "buttonStartService";
            buttonStartService.Size = new Size(108, 22);
            buttonStartService.TabIndex = 4;
            buttonStartService.Text = "Avvia servizio";
            buttonStartService.UseVisualStyleBackColor = true;
            // 
            // labelServiceStatus
            // 
            labelServiceStatus.Anchor = AnchorStyles.None;
            labelServiceStatus.AutoSize = true;
            labelServiceStatus.Location = new Point(368, 35);
            labelServiceStatus.Margin = new Padding(2, 0, 2, 0);
            labelServiceStatus.Name = "labelServiceStatus";
            labelServiceStatus.Size = new Size(76, 15);
            labelServiceStatus.TabIndex = 6;
            labelServiceStatus.Text = "Stato servizio";
            // 
            // panelServiceStatus
            // 
            panelServiceStatus.Anchor = AnchorStyles.None;
            panelServiceStatus.BackColor = Color.Red;
            panelServiceStatus.BorderStyle = BorderStyle.FixedSingle;
            panelServiceStatus.Location = new Point(298, 27);
            panelServiceStatus.Margin = new Padding(2, 1, 2, 1);
            panelServiceStatus.Name = "panelServiceStatus";
            panelServiceStatus.Size = new Size(24, 31);
            panelServiceStatus.TabIndex = 8;
            // 
            // buttonStopService
            // 
            buttonStopService.Anchor = AnchorStyles.None;
            buttonStopService.FlatAppearance.BorderSize = 2;
            buttonStopService.Location = new Point(168, 31);
            buttonStopService.Margin = new Padding(2, 1, 2, 1);
            buttonStopService.Name = "buttonStopService";
            buttonStopService.Size = new Size(108, 22);
            buttonStopService.TabIndex = 5;
            buttonStopService.Text = "Arresta servizio";
            buttonStopService.UseVisualStyleBackColor = true;
            // 
            // buttonQuit
            // 
            buttonQuit.Anchor = AnchorStyles.None;
            buttonQuit.FlatAppearance.BorderSize = 2;
            buttonQuit.Location = new Point(139, 436);
            buttonQuit.Margin = new Padding(2, 1, 2, 1);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(108, 22);
            buttonQuit.TabIndex = 10;
            buttonQuit.Text = "Esci";
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Anchor = AnchorStyles.None;
            buttonInfo.FlatAppearance.BorderSize = 2;
            buttonInfo.Location = new Point(262, 436);
            buttonInfo.Margin = new Padding(2, 1, 2, 1);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(108, 22);
            buttonInfo.TabIndex = 11;
            buttonInfo.Text = "Info...";
            buttonInfo.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(509, 471);
            Controls.Add(buttonInfo);
            Controls.Add(buttonQuit);
            Controls.Add(tableLayoutPanelMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HealthGearConfig";
            tableLayoutPanelMain.ResumeLayout(false);
            groupBoxLog.ResumeLayout(false);
            tableLayoutPanelLog.ResumeLayout(false);
            tableLayoutPanelLog.PerformLayout();
            groupBoxFolders.ResumeLayout(false);
            tableLayoutPanelFolders.ResumeLayout(false);
            tableLayoutPanelFolders.PerformLayout();
            groupBoxServer.ResumeLayout(false);
            tableLayoutPanelServer.ResumeLayout(false);
            tableLayoutPanelServer.PerformLayout();
            groupBoxServiceStatus.ResumeLayout(false);
            tableLayoutPanelService.ResumeLayout(false);
            tableLayoutPanelService.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private TableLayoutPanel tableLayoutPanelMain;
        private GroupBox groupBoxServiceStatus;
        private TableLayoutPanel tableLayoutPanelService;
        private Button buttonStartService;
        private Label labelServiceStatus;
        private Panel panelServiceStatus;
        private Button buttonStopService;
        private GroupBox groupBoxServer;
        private TableLayoutPanel tableLayoutPanelServer;
        private Button buttonServer;
        private Label labelServer;
        private GroupBox groupBoxFolders;
        private TableLayoutPanel tableLayoutPanelFolders;
        private Button buttonFolderWizard;
        private Label labelFolders;
        private GroupBox groupBoxLog;
        private TableLayoutPanel tableLayoutPanelLog;
        private Button buttonLog;
        private Label labelLog;
        private Button buttonQuit;
        private Button buttonInfo;
    }
}

