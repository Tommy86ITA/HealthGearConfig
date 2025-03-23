using HealthGearConfig.Properties;
namespace HealthGearConfig
{
    partial class FormMigrationWizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMigrationWizard));
            panelHeader = new Panel();
            labelPageSubtitle = new Label();
            labelPageTitle = new Label();
            pictureBoxHeader = new PictureBox();
            panelWelcome = new Panel();
            groupBoxWelcome = new GroupBox();
            labelIntroduction = new Label();
            flowLayoutPanelNavigation = new FlowLayoutPanel();
            buttonFinish = new Button();
            buttonNext = new Button();
            buttonBack = new Button();
            buttonCancel = new Button();
            panelSelectFolders = new Panel();
            groupBoxSelectFolders = new GroupBox();
            labelUploadsCurrentPath = new Label();
            labelDbCurrentPath = new Label();
            checkBoxUploads = new CheckBox();
            checkBoxDb = new CheckBox();
            pictureBoxUploadFolder = new PictureBox();
            pictureBoxDb = new PictureBox();
            labelSelectFolder = new Label();
            panelDestination = new Panel();
            groupBoxDestination = new GroupBox();
            labelReuiredSpaceUploads = new Label();
            labelRequiredSpaceDb = new Label();
            buttonBrowseDb = new Button();
            textBoxDb = new TextBox();
            buttonBrowseUploads = new Button();
            textBoxUploads = new TextBox();
            pictureBoxUploadsDestination = new PictureBox();
            pictureBoxDbDestination = new PictureBox();
            labelSelectDestination = new Label();
            toolTipProvider = new ToolTip(components);
            panelConfirm = new Panel();
            groupBoxConfirm = new GroupBox();
            checkBoxDeleteSource = new CheckBox();
            checkBoxConfirm = new CheckBox();
            labelUploadsConfirm = new Label();
            labelDbConfirm = new Label();
            pictureBoxUploadsConfirm = new PictureBox();
            pictureBoxDbConfirm = new PictureBox();
            labelConfirm = new Label();
            panelProgress = new Panel();
            groupBoxProgress = new GroupBox();
            labelDetails = new Label();
            textBoxDetails = new TextBox();
            labelDontClose = new Label();
            progressBar = new ProgressBar();
            labelProgress = new Label();
            panelSummary = new Panel();
            groupBoxSummary = new GroupBox();
            pictureBoxSummary = new PictureBox();
            buttonSaveLog = new Button();
            labelLog = new Label();
            textBoxLog = new TextBox();
            labelSummaryMessage = new Label();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHeader).BeginInit();
            panelWelcome.SuspendLayout();
            groupBoxWelcome.SuspendLayout();
            flowLayoutPanelNavigation.SuspendLayout();
            panelSelectFolders.SuspendLayout();
            groupBoxSelectFolders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUploadFolder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDb).BeginInit();
            panelDestination.SuspendLayout();
            groupBoxDestination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUploadsDestination).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDbDestination).BeginInit();
            panelConfirm.SuspendLayout();
            groupBoxConfirm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUploadsConfirm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDbConfirm).BeginInit();
            panelProgress.SuspendLayout();
            groupBoxProgress.SuspendLayout();
            panelSummary.SuspendLayout();
            groupBoxSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSummary).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.AutoScroll = true;
            panelHeader.Controls.Add(labelPageSubtitle);
            panelHeader.Controls.Add(labelPageTitle);
            panelHeader.Controls.Add(pictureBoxHeader);
            panelHeader.Location = new Point(1, 2);
            panelHeader.Margin = new Padding(4, 5, 4, 5);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(836, 100);
            panelHeader.TabIndex = 0;
            // 
            // labelPageSubtitle
            // 
            labelPageSubtitle.AutoSize = true;
            labelPageSubtitle.Location = new Point(111, 51);
            labelPageSubtitle.Margin = new Padding(4, 0, 4, 0);
            labelPageSubtitle.Name = "labelPageSubtitle";
            labelPageSubtitle.Size = new Size(214, 25);
            labelPageSubtitle.TabIndex = 2;
            labelPageSubtitle.Text = "Prepariamo la migrazione";
            // 
            // labelPageTitle
            // 
            labelPageTitle.AutoSize = true;
            labelPageTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPageTitle.Location = new Point(111, 7);
            labelPageTitle.Margin = new Padding(4, 0, 4, 0);
            labelPageTitle.Name = "labelPageTitle";
            labelPageTitle.Size = new Size(137, 32);
            labelPageTitle.TabIndex = 1;
            labelPageTitle.Text = "Benvenuto";
            // 
            // pictureBoxHeader
            // 
            pictureBoxHeader.Anchor = AnchorStyles.Left;
            pictureBoxHeader.Image = Resource.foldermigrlogo;
            pictureBoxHeader.Location = new Point(12, 4);
            pictureBoxHeader.Margin = new Padding(4, 5, 4, 5);
            pictureBoxHeader.Name = "pictureBoxHeader";
            pictureBoxHeader.Size = new Size(92, 92);
            pictureBoxHeader.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHeader.TabIndex = 0;
            pictureBoxHeader.TabStop = false;
            // 
            // panelWelcome
            // 
            panelWelcome.Controls.Add(groupBoxWelcome);
            panelWelcome.Location = new Point(1, 103);
            panelWelcome.Margin = new Padding(4, 5, 4, 5);
            panelWelcome.Name = "panelWelcome";
            panelWelcome.Size = new Size(836, 525);
            panelWelcome.TabIndex = 2;
            // 
            // groupBoxWelcome
            // 
            groupBoxWelcome.Controls.Add(labelIntroduction);
            groupBoxWelcome.Location = new Point(4, 8);
            groupBoxWelcome.Margin = new Padding(4, 5, 4, 5);
            groupBoxWelcome.Name = "groupBoxWelcome";
            groupBoxWelcome.Padding = new Padding(4, 5, 4, 5);
            groupBoxWelcome.Size = new Size(821, 500);
            groupBoxWelcome.TabIndex = 0;
            groupBoxWelcome.TabStop = false;
            // 
            // labelIntroduction
            // 
            labelIntroduction.Location = new Point(9, 32);
            labelIntroduction.Margin = new Padding(4, 0, 4, 0);
            labelIntroduction.Name = "labelIntroduction";
            labelIntroduction.Size = new Size(803, 445);
            labelIntroduction.TabIndex = 0;
            labelIntroduction.Text = resources.GetString("labelIntroduction.Text");
            // 
            // flowLayoutPanelNavigation
            // 
            flowLayoutPanelNavigation.Controls.Add(buttonFinish);
            flowLayoutPanelNavigation.Controls.Add(buttonNext);
            flowLayoutPanelNavigation.Controls.Add(buttonBack);
            flowLayoutPanelNavigation.Controls.Add(buttonCancel);
            flowLayoutPanelNavigation.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelNavigation.Location = new Point(0, 635);
            flowLayoutPanelNavigation.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanelNavigation.Name = "flowLayoutPanelNavigation";
            flowLayoutPanelNavigation.Size = new Size(827, 73);
            flowLayoutPanelNavigation.TabIndex = 3;
            flowLayoutPanelNavigation.WrapContents = false;
            // 
            // buttonFinish
            // 
            buttonFinish.Anchor = AnchorStyles.Right;
            flowLayoutPanelNavigation.SetFlowBreak(buttonFinish, true);
            buttonFinish.Location = new Point(716, 5);
            buttonFinish.Margin = new Padding(4, 5, 4, 5);
            buttonFinish.Name = "buttonFinish";
            buttonFinish.Size = new Size(107, 38);
            buttonFinish.TabIndex = 4;
            buttonFinish.Text = "Chiudi";
            buttonFinish.UseVisualStyleBackColor = true;
            buttonFinish.Click += buttonFinish_Click;
            // 
            // buttonNext
            // 
            buttonNext.Anchor = AnchorStyles.Right;
            buttonNext.Location = new Point(601, 5);
            buttonNext.Margin = new Padding(4, 5, 4, 5);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(107, 38);
            buttonNext.TabIndex = 5;
            buttonNext.Text = "Avanti";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Right;
            buttonBack.Location = new Point(486, 5);
            buttonBack.Margin = new Padding(4, 5, 4, 5);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(107, 38);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "Indietro";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Right;
            buttonCancel.Location = new Point(371, 5);
            buttonCancel.Margin = new Padding(4, 5, 4, 5);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(107, 38);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Annulla";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // panelSelectFolders
            // 
            panelSelectFolders.Controls.Add(groupBoxSelectFolders);
            panelSelectFolders.Location = new Point(1, 103);
            panelSelectFolders.Margin = new Padding(4, 5, 4, 5);
            panelSelectFolders.Name = "panelSelectFolders";
            panelSelectFolders.Size = new Size(836, 525);
            panelSelectFolders.TabIndex = 4;
            // 
            // groupBoxSelectFolders
            // 
            groupBoxSelectFolders.Controls.Add(labelUploadsCurrentPath);
            groupBoxSelectFolders.Controls.Add(labelDbCurrentPath);
            groupBoxSelectFolders.Controls.Add(checkBoxUploads);
            groupBoxSelectFolders.Controls.Add(checkBoxDb);
            groupBoxSelectFolders.Controls.Add(pictureBoxUploadFolder);
            groupBoxSelectFolders.Controls.Add(pictureBoxDb);
            groupBoxSelectFolders.Controls.Add(labelSelectFolder);
            groupBoxSelectFolders.Location = new Point(4, 8);
            groupBoxSelectFolders.Margin = new Padding(4, 5, 4, 5);
            groupBoxSelectFolders.Name = "groupBoxSelectFolders";
            groupBoxSelectFolders.Padding = new Padding(4, 5, 4, 5);
            groupBoxSelectFolders.Size = new Size(821, 500);
            groupBoxSelectFolders.TabIndex = 0;
            groupBoxSelectFolders.TabStop = false;
            // 
            // labelUploadsCurrentPath
            // 
            labelUploadsCurrentPath.AutoSize = true;
            labelUploadsCurrentPath.Location = new Point(276, 335);
            labelUploadsCurrentPath.Name = "labelUploadsCurrentPath";
            labelUploadsCurrentPath.Size = new Size(142, 50);
            labelUploadsCurrentPath.TabIndex = 6;
            labelUploadsCurrentPath.Text = "Percorso attuale:\r\nC:\\....";
            // 
            // labelDbCurrentPath
            // 
            labelDbCurrentPath.AutoSize = true;
            labelDbCurrentPath.Location = new Point(276, 177);
            labelDbCurrentPath.Name = "labelDbCurrentPath";
            labelDbCurrentPath.Size = new Size(142, 50);
            labelDbCurrentPath.TabIndex = 5;
            labelDbCurrentPath.Text = "Percorso attuale:\r\nC:\\....";
            // 
            // checkBoxUploads
            // 
            checkBoxUploads.AutoSize = true;
            checkBoxUploads.Location = new Point(276, 293);
            checkBoxUploads.Name = "checkBoxUploads";
            checkBoxUploads.Size = new Size(201, 29);
            checkBoxUploads.TabIndex = 4;
            checkBoxUploads.Text = "Cartella degli upload";
            checkBoxUploads.UseVisualStyleBackColor = true;
            checkBoxUploads.CheckedChanged += checkBoxUploads_CheckedChanged;
            // 
            // checkBoxDb
            // 
            checkBoxDb.AutoSize = true;
            checkBoxDb.Location = new Point(276, 135);
            checkBoxDb.Name = "checkBoxDb";
            checkBoxDb.Size = new Size(204, 29);
            checkBoxDb.TabIndex = 3;
            checkBoxDb.Text = "Cartella del Database";
            checkBoxDb.UseVisualStyleBackColor = true;
            checkBoxDb.CheckedChanged += checkBoxDb_CheckedChanged;
            // 
            // pictureBoxUploadFolder
            // 
            pictureBoxUploadFolder.Image = Resource.uploadfolder;
            pictureBoxUploadFolder.Location = new Point(141, 293);
            pictureBoxUploadFolder.Name = "pictureBoxUploadFolder";
            pictureBoxUploadFolder.Size = new Size(92, 92);
            pictureBoxUploadFolder.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUploadFolder.TabIndex = 2;
            pictureBoxUploadFolder.TabStop = false;
            // 
            // pictureBoxDb
            // 
            pictureBoxDb.Image = Resource.databasefolder;
            pictureBoxDb.Location = new Point(141, 135);
            pictureBoxDb.Name = "pictureBoxDb";
            pictureBoxDb.Size = new Size(92, 92);
            pictureBoxDb.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDb.TabIndex = 1;
            pictureBoxDb.TabStop = false;
            // 
            // labelSelectFolder
            // 
            labelSelectFolder.Location = new Point(34, 32);
            labelSelectFolder.Name = "labelSelectFolder";
            labelSelectFolder.Size = new Size(752, 72);
            labelSelectFolder.TabIndex = 0;
            labelSelectFolder.Text = "In questa fase dovrai selezionare quali cartelle spostare. Puoi selezionare solo la cartella di residenza del DB, quella dei file di upload oppure entrambe.";
            // 
            // panelDestination
            // 
            panelDestination.Controls.Add(groupBoxDestination);
            panelDestination.Location = new Point(1, 103);
            panelDestination.Margin = new Padding(4, 5, 4, 5);
            panelDestination.Name = "panelDestination";
            panelDestination.Size = new Size(836, 525);
            panelDestination.TabIndex = 5;
            // 
            // groupBoxDestination
            // 
            groupBoxDestination.Controls.Add(labelReuiredSpaceUploads);
            groupBoxDestination.Controls.Add(labelRequiredSpaceDb);
            groupBoxDestination.Controls.Add(buttonBrowseDb);
            groupBoxDestination.Controls.Add(textBoxDb);
            groupBoxDestination.Controls.Add(buttonBrowseUploads);
            groupBoxDestination.Controls.Add(textBoxUploads);
            groupBoxDestination.Controls.Add(pictureBoxUploadsDestination);
            groupBoxDestination.Controls.Add(pictureBoxDbDestination);
            groupBoxDestination.Controls.Add(labelSelectDestination);
            groupBoxDestination.Location = new Point(4, 8);
            groupBoxDestination.Margin = new Padding(4, 5, 4, 5);
            groupBoxDestination.Name = "groupBoxDestination";
            groupBoxDestination.Padding = new Padding(4, 5, 4, 5);
            groupBoxDestination.Size = new Size(821, 500);
            groupBoxDestination.TabIndex = 0;
            groupBoxDestination.TabStop = false;
            // 
            // labelReuiredSpaceUploads
            // 
            labelReuiredSpaceUploads.AutoSize = true;
            labelReuiredSpaceUploads.Location = new Point(268, 293);
            labelReuiredSpaceUploads.Name = "labelReuiredSpaceUploads";
            labelReuiredSpaceUploads.Size = new Size(321, 25);
            labelReuiredSpaceUploads.TabIndex = 12;
            labelReuiredSpaceUploads.Text = "Seleziona destinazione cartella Uploads";
            // 
            // labelRequiredSpaceDb
            // 
            labelRequiredSpaceDb.AutoSize = true;
            labelRequiredSpaceDb.Location = new Point(268, 135);
            labelRequiredSpaceDb.Name = "labelRequiredSpaceDb";
            labelRequiredSpaceDb.Size = new Size(278, 25);
            labelRequiredSpaceDb.TabIndex = 11;
            labelRequiredSpaceDb.Text = "Seleziona destinazione cartella DB";
            // 
            // buttonBrowseDb
            // 
            buttonBrowseDb.Anchor = AnchorStyles.Right;
            buttonBrowseDb.Location = new Point(596, 192);
            buttonBrowseDb.Margin = new Padding(4, 5, 4, 5);
            buttonBrowseDb.Name = "buttonBrowseDb";
            buttonBrowseDb.Size = new Size(107, 38);
            buttonBrowseDb.TabIndex = 10;
            buttonBrowseDb.Text = "Sfoglia...";
            toolTipProvider.SetToolTip(buttonBrowseDb, "Seleziona la nuova destinazione per il database");
            buttonBrowseDb.UseVisualStyleBackColor = true;
            buttonBrowseDb.Click += buttonBrowseDb_Click;
            // 
            // textBoxDb
            // 
            textBoxDb.BackColor = SystemColors.Window;
            textBoxDb.Location = new Point(268, 196);
            textBoxDb.Name = "textBoxDb";
            textBoxDb.ReadOnly = true;
            textBoxDb.Size = new Size(320, 31);
            textBoxDb.TabIndex = 9;
            textBoxDb.TextChanged += textBoxDb_TextChanged;
            // 
            // buttonBrowseUploads
            // 
            buttonBrowseUploads.Anchor = AnchorStyles.Right;
            buttonBrowseUploads.Location = new Point(596, 350);
            buttonBrowseUploads.Margin = new Padding(4, 5, 4, 5);
            buttonBrowseUploads.Name = "buttonBrowseUploads";
            buttonBrowseUploads.Size = new Size(107, 38);
            buttonBrowseUploads.TabIndex = 8;
            buttonBrowseUploads.Text = "Sfoglia...";
            toolTipProvider.SetToolTip(buttonBrowseUploads, "Seleziona la nuova destinazione per i file di upload");
            buttonBrowseUploads.UseVisualStyleBackColor = true;
            buttonBrowseUploads.Click += buttonBrowseUploads_Click;
            // 
            // textBoxUploads
            // 
            textBoxUploads.BackColor = SystemColors.Window;
            textBoxUploads.Location = new Point(268, 354);
            textBoxUploads.Name = "textBoxUploads";
            textBoxUploads.ReadOnly = true;
            textBoxUploads.Size = new Size(320, 31);
            textBoxUploads.TabIndex = 4;
            textBoxUploads.TextChanged += textBoxUploads_TextChanged;
            // 
            // pictureBoxUploadsDestination
            // 
            pictureBoxUploadsDestination.Image = Resource.uploadfolder;
            pictureBoxUploadsDestination.Location = new Point(141, 293);
            pictureBoxUploadsDestination.Name = "pictureBoxUploadsDestination";
            pictureBoxUploadsDestination.Size = new Size(92, 92);
            pictureBoxUploadsDestination.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUploadsDestination.TabIndex = 2;
            pictureBoxUploadsDestination.TabStop = false;
            // 
            // pictureBoxDbDestination
            // 
            pictureBoxDbDestination.Image = Resource.databasefolder;
            pictureBoxDbDestination.Location = new Point(141, 135);
            pictureBoxDbDestination.Name = "pictureBoxDbDestination";
            pictureBoxDbDestination.Size = new Size(92, 92);
            pictureBoxDbDestination.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDbDestination.TabIndex = 1;
            pictureBoxDbDestination.TabStop = false;
            // 
            // labelSelectDestination
            // 
            labelSelectDestination.Location = new Point(34, 32);
            labelSelectDestination.Name = "labelSelectDestination";
            labelSelectDestination.Size = new Size(752, 85);
            labelSelectDestination.TabIndex = 0;
            labelSelectDestination.Text = resources.GetString("labelSelectDestination.Text");
            // 
            // panelConfirm
            // 
            panelConfirm.Controls.Add(groupBoxConfirm);
            panelConfirm.Location = new Point(1, 103);
            panelConfirm.Margin = new Padding(4, 5, 4, 5);
            panelConfirm.Name = "panelConfirm";
            panelConfirm.Size = new Size(836, 525);
            panelConfirm.TabIndex = 6;
            // 
            // groupBoxConfirm
            // 
            groupBoxConfirm.Controls.Add(checkBoxDeleteSource);
            groupBoxConfirm.Controls.Add(checkBoxConfirm);
            groupBoxConfirm.Controls.Add(labelUploadsConfirm);
            groupBoxConfirm.Controls.Add(labelDbConfirm);
            groupBoxConfirm.Controls.Add(pictureBoxUploadsConfirm);
            groupBoxConfirm.Controls.Add(pictureBoxDbConfirm);
            groupBoxConfirm.Controls.Add(labelConfirm);
            groupBoxConfirm.Location = new Point(4, 8);
            groupBoxConfirm.Margin = new Padding(4, 5, 4, 5);
            groupBoxConfirm.Name = "groupBoxConfirm";
            groupBoxConfirm.Padding = new Padding(4, 5, 4, 5);
            groupBoxConfirm.Size = new Size(821, 500);
            groupBoxConfirm.TabIndex = 0;
            groupBoxConfirm.TabStop = false;
            // 
            // checkBoxDeleteSource
            // 
            checkBoxDeleteSource.AutoSize = true;
            checkBoxDeleteSource.Location = new Point(143, 402);
            checkBoxDeleteSource.Name = "checkBoxDeleteSource";
            checkBoxDeleteSource.Size = new Size(671, 29);
            checkBoxDeleteSource.TabIndex = 14;
            checkBoxDeleteSource.Text = "Elimina le cartelle originali dopo la migrazione (solo se l'operazione ha successo)";
            checkBoxDeleteSource.UseVisualStyleBackColor = true;
            checkBoxDeleteSource.CheckedChanged += checkBoxDeleteSource_CheckedChanged;
            // 
            // checkBoxConfirm
            // 
            checkBoxConfirm.AutoSize = true;
            checkBoxConfirm.Location = new Point(193, 448);
            checkBoxConfirm.Name = "checkBoxConfirm";
            checkBoxConfirm.Size = new Size(438, 29);
            checkBoxConfirm.TabIndex = 13;
            checkBoxConfirm.Text = "Ho verificato le informazioni e desidero procedere.";
            checkBoxConfirm.UseVisualStyleBackColor = true;
            checkBoxConfirm.CheckedChanged += checkBoxConfirm_CheckedChanged;
            // 
            // labelUploadsConfirm
            // 
            labelUploadsConfirm.AutoEllipsis = true;
            labelUploadsConfirm.Location = new Point(269, 295);
            labelUploadsConfirm.Name = "labelUploadsConfirm";
            labelUploadsConfirm.Size = new Size(533, 113);
            labelUploadsConfirm.TabIndex = 12;
            labelUploadsConfirm.Text = "Cartella Upload";
            // 
            // labelDbConfirm
            // 
            labelDbConfirm.AutoEllipsis = true;
            labelDbConfirm.Location = new Point(269, 137);
            labelDbConfirm.Name = "labelDbConfirm";
            labelDbConfirm.Size = new Size(533, 113);
            labelDbConfirm.TabIndex = 11;
            labelDbConfirm.Text = "Cartella Database";
            // 
            // pictureBoxUploadsConfirm
            // 
            pictureBoxUploadsConfirm.Image = Resource.uploadfolder;
            pictureBoxUploadsConfirm.Location = new Point(141, 293);
            pictureBoxUploadsConfirm.Name = "pictureBoxUploadsConfirm";
            pictureBoxUploadsConfirm.Size = new Size(92, 92);
            pictureBoxUploadsConfirm.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUploadsConfirm.TabIndex = 2;
            pictureBoxUploadsConfirm.TabStop = false;
            // 
            // pictureBoxDbConfirm
            // 
            pictureBoxDbConfirm.Image = Resource.databasefolder;
            pictureBoxDbConfirm.Location = new Point(141, 135);
            pictureBoxDbConfirm.Name = "pictureBoxDbConfirm";
            pictureBoxDbConfirm.Size = new Size(92, 92);
            pictureBoxDbConfirm.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDbConfirm.TabIndex = 1;
            pictureBoxDbConfirm.TabStop = false;
            // 
            // labelConfirm
            // 
            labelConfirm.Location = new Point(34, 32);
            labelConfirm.Name = "labelConfirm";
            labelConfirm.Size = new Size(752, 85);
            labelConfirm.TabIndex = 0;
            labelConfirm.Text = "Prima di procedere, ecco il riepilogo della migrazione da eseguire:";
            // 
            // panelProgress
            // 
            panelProgress.Controls.Add(groupBoxProgress);
            panelProgress.Location = new Point(1, 103);
            panelProgress.Margin = new Padding(4, 5, 4, 5);
            panelProgress.Name = "panelProgress";
            panelProgress.Size = new Size(836, 525);
            panelProgress.TabIndex = 7;
            // 
            // groupBoxProgress
            // 
            groupBoxProgress.Controls.Add(labelDetails);
            groupBoxProgress.Controls.Add(textBoxDetails);
            groupBoxProgress.Controls.Add(labelDontClose);
            groupBoxProgress.Controls.Add(progressBar);
            groupBoxProgress.Controls.Add(labelProgress);
            groupBoxProgress.Location = new Point(4, 8);
            groupBoxProgress.Margin = new Padding(4, 5, 4, 5);
            groupBoxProgress.Name = "groupBoxProgress";
            groupBoxProgress.Padding = new Padding(4, 5, 4, 5);
            groupBoxProgress.Size = new Size(821, 500);
            groupBoxProgress.TabIndex = 0;
            groupBoxProgress.TabStop = false;
            // 
            // labelDetails
            // 
            labelDetails.AutoSize = true;
            labelDetails.Location = new Point(40, 258);
            labelDetails.Name = "labelDetails";
            labelDetails.Size = new Size(78, 25);
            labelDetails.TabIndex = 4;
            labelDetails.Text = "Dettagli:";
            // 
            // textBoxDetails
            // 
            textBoxDetails.BackColor = SystemColors.Window;
            textBoxDetails.Location = new Point(40, 295);
            textBoxDetails.Multiline = true;
            textBoxDetails.Name = "textBoxDetails";
            textBoxDetails.ReadOnly = true;
            textBoxDetails.ScrollBars = ScrollBars.Both;
            textBoxDetails.Size = new Size(741, 197);
            textBoxDetails.TabIndex = 3;
            // 
            // labelDontClose
            // 
            labelDontClose.AutoSize = true;
            labelDontClose.ForeColor = Color.Red;
            labelDontClose.Location = new Point(161, 139);
            labelDontClose.Name = "labelDontClose";
            labelDontClose.Size = new Size(500, 25);
            labelDontClose.TabIndex = 2;
            labelDontClose.Text = "NON CHIUDERE IL PROGRAMMA DURANTE LA MIGRAZIONE";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(40, 198);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(741, 34);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 1;
            // 
            // labelProgress
            // 
            labelProgress.Location = new Point(34, 32);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(752, 85);
            labelProgress.TabIndex = 0;
            labelProgress.Text = resources.GetString("labelProgress.Text");
            // 
            // panelSummary
            // 
            panelSummary.Controls.Add(groupBoxSummary);
            panelSummary.Location = new Point(1, 103);
            panelSummary.Margin = new Padding(4, 5, 4, 5);
            panelSummary.Name = "panelSummary";
            panelSummary.Size = new Size(836, 525);
            panelSummary.TabIndex = 8;
            // 
            // groupBoxSummary
            // 
            groupBoxSummary.Controls.Add(pictureBoxSummary);
            groupBoxSummary.Controls.Add(buttonSaveLog);
            groupBoxSummary.Controls.Add(labelLog);
            groupBoxSummary.Controls.Add(textBoxLog);
            groupBoxSummary.Controls.Add(labelSummaryMessage);
            groupBoxSummary.Location = new Point(4, 8);
            groupBoxSummary.Margin = new Padding(4, 5, 4, 5);
            groupBoxSummary.Name = "groupBoxSummary";
            groupBoxSummary.Padding = new Padding(4, 5, 4, 5);
            groupBoxSummary.Size = new Size(821, 500);
            groupBoxSummary.TabIndex = 0;
            groupBoxSummary.TabStop = false;
            // 
            // pictureBoxSummary
            // 
            pictureBoxSummary.Location = new Point(689, 22);
            pictureBoxSummary.Name = "pictureBoxSummary";
            pictureBoxSummary.Size = new Size(92, 92);
            pictureBoxSummary.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSummary.TabIndex = 6;
            pictureBoxSummary.TabStop = false;
            // 
            // buttonSaveLog
            // 
            buttonSaveLog.Anchor = AnchorStyles.Right;
            buttonSaveLog.Location = new Point(679, 439);
            buttonSaveLog.Margin = new Padding(4, 5, 4, 5);
            buttonSaveLog.Name = "buttonSaveLog";
            buttonSaveLog.Size = new Size(107, 38);
            buttonSaveLog.TabIndex = 5;
            buttonSaveLog.Text = "Salva log...";
            buttonSaveLog.UseVisualStyleBackColor = true;
            buttonSaveLog.Click += buttonSaveLog_Click;
            // 
            // labelLog
            // 
            labelLog.AutoSize = true;
            labelLog.Location = new Point(34, 79);
            labelLog.Name = "labelLog";
            labelLog.Size = new Size(312, 25);
            labelLog.TabIndex = 4;
            labelLog.Text = "Di seguito trovi il log delle operazioni:";
            // 
            // textBoxLog
            // 
            textBoxLog.BackColor = SystemColors.Window;
            textBoxLog.Location = new Point(34, 120);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.ReadOnly = true;
            textBoxLog.ScrollBars = ScrollBars.Both;
            textBoxLog.Size = new Size(752, 300);
            textBoxLog.TabIndex = 3;
            // 
            // labelSummaryMessage
            // 
            labelSummaryMessage.Location = new Point(40, 22);
            labelSummaryMessage.Name = "labelSummaryMessage";
            labelSummaryMessage.Size = new Size(627, 25);
            labelSummaryMessage.TabIndex = 0;
            labelSummaryMessage.Text = "L'operazione è stata completata";
            // 
            // FormMigrationWizard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(839, 708);
            ControlBox = false;
            Controls.Add(panelSummary);
            Controls.Add(panelSelectFolders);
            Controls.Add(panelConfirm);
            Controls.Add(panelProgress);
            Controls.Add(panelDestination);
            Controls.Add(flowLayoutPanelNavigation);
            Controls.Add(panelWelcome);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormMigrationWizard";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Migrazione guidata cartelle";
            Load += FormMigrationWizard_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHeader).EndInit();
            panelWelcome.ResumeLayout(false);
            groupBoxWelcome.ResumeLayout(false);
            flowLayoutPanelNavigation.ResumeLayout(false);
            panelSelectFolders.ResumeLayout(false);
            groupBoxSelectFolders.ResumeLayout(false);
            groupBoxSelectFolders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUploadFolder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDb).EndInit();
            panelDestination.ResumeLayout(false);
            groupBoxDestination.ResumeLayout(false);
            groupBoxDestination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUploadsDestination).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDbDestination).EndInit();
            panelConfirm.ResumeLayout(false);
            groupBoxConfirm.ResumeLayout(false);
            groupBoxConfirm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUploadsConfirm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDbConfirm).EndInit();
            panelProgress.ResumeLayout(false);
            groupBoxProgress.ResumeLayout(false);
            groupBoxProgress.PerformLayout();
            panelSummary.ResumeLayout(false);
            groupBoxSummary.ResumeLayout(false);
            groupBoxSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSummary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox pictureBoxHeader;
        private Label labelPageTitle;
        private Label labelPageSubtitle;
        private Panel panelWelcome;
        private GroupBox groupBoxWelcome;
        private Label labelIntroduction;
        private FlowLayoutPanel flowLayoutPanelNavigation;
        private Button buttonNext;
        private Button buttonCancel;
        private Button buttonBack;
        private Button buttonFinish;
        private Panel panelSelectFolders;
        private GroupBox groupBoxSelectFolders;
        private Label labelSelectFolder;
        private PictureBox pictureBoxUploadFolder;
        private PictureBox pictureBoxDb;
        private CheckBox checkBoxUploads;
        private CheckBox checkBoxDb;
        private Label labelUploadsCurrentPath;
        private Label labelDbCurrentPath;
        private Panel panelDestination;
        private GroupBox groupBoxDestination;
        private PictureBox pictureBoxUploadsDestination;
        private PictureBox pictureBoxDbDestination;
        private Label labelSelectDestination;
        private Button buttonBrowseDb;
        private TextBox textBoxDb;
        private Button buttonBrowseUploads;
        private TextBox textBoxUploads;
        private ToolTip toolTipProvider;
        private Label labelRequiredSpaceDb;
        private Label labelReuiredSpaceUploads;
        private Panel panelConfirm;
        private GroupBox groupBoxConfirm;
        private Label labelUploadsConfirm;
        private Label labelDbConfirm;
        private PictureBox pictureBoxUploadsConfirm;
        private PictureBox pictureBoxDbConfirm;
        private Label labelConfirm;
        private CheckBox checkBoxConfirm;
        private Panel panelProgress;
        private GroupBox groupBoxProgress;
        private ProgressBar progressBar;
        private Label labelProgress;
        private Label labelDontClose;
        private TextBox textBoxDetails;
        private Label labelDetails;
        private Panel panelSummary;
        private GroupBox groupBoxSummary;
        private TextBox textBoxLog;
        private Label labelSummaryMessage;
        private Label labelLog;
        private Button buttonSaveLog;
        private PictureBox pictureBoxSummary;
        private CheckBox checkBoxDeleteSource;
    }
}