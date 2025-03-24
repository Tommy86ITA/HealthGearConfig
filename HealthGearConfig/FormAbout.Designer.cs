namespace HealthGearConfig
{
    partial class FormAbout
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
            groupBoxSoftwareVers = new GroupBox();
            labelCopy = new Label();
            labelBuild = new Label();
            labelBuildDate = new Label();
            pictureLogo = new PictureBox();
            labelPartOf = new Label();
            labelSwVersion = new Label();
            labelSwName = new Label();
            groupBoxLicense = new GroupBox();
            richTextBoxLicense = new RichTextBox();
            labelSardinia = new Label();
            labelSupport = new Label();
            linkLabelSupportMail = new LinkLabel();
            groupBoxContacts = new GroupBox();
            linkLabel1 = new LinkLabel();
            labelHome = new Label();
            timerCopied = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            groupBoxSoftwareVers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            groupBoxLicense.SuspendLayout();
            groupBoxContacts.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxSoftwareVers
            // 
            groupBoxSoftwareVers.Controls.Add(labelCopy);
            groupBoxSoftwareVers.Controls.Add(labelBuild);
            groupBoxSoftwareVers.Controls.Add(labelBuildDate);
            groupBoxSoftwareVers.Controls.Add(pictureLogo);
            groupBoxSoftwareVers.Controls.Add(labelPartOf);
            groupBoxSoftwareVers.Controls.Add(labelSwVersion);
            groupBoxSoftwareVers.Controls.Add(labelSwName);
            groupBoxSoftwareVers.Location = new Point(2, 9);
            groupBoxSoftwareVers.Margin = new Padding(6);
            groupBoxSoftwareVers.Name = "groupBoxSoftwareVers";
            groupBoxSoftwareVers.Padding = new Padding(6);
            groupBoxSoftwareVers.Size = new Size(569, 868);
            groupBoxSoftwareVers.TabIndex = 0;
            groupBoxSoftwareVers.TabStop = false;
            groupBoxSoftwareVers.Text = "Informazioni";
            // 
            // labelCopy
            // 
            labelCopy.AutoSize = true;
            labelCopy.Font = new Font("Segoe UI", 7.875F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelCopy.ForeColor = SystemColors.HotTrack;
            labelCopy.Location = new Point(190, 817);
            labelCopy.Margin = new Padding(6, 0, 6, 0);
            labelCopy.Name = "labelCopy";
            labelCopy.Size = new Size(188, 30);
            labelCopy.TabIndex = 9;
            labelCopy.Text = "Copia informazioni";
            labelCopy.TextAlign = ContentAlignment.MiddleCenter;
            labelCopy.Click += labelCopy_Click;
            // 
            // labelBuild
            // 
            labelBuild.AutoSize = true;
            labelBuild.Font = new Font("Segoe UI", 10.875F);
            labelBuild.Location = new Point(129, 673);
            labelBuild.Margin = new Padding(6, 0, 6, 0);
            labelBuild.Name = "labelBuild";
            labelBuild.Size = new Size(178, 40);
            labelBuild.TabIndex = 8;
            labelBuild.Text = "Build: 1204A";
            labelBuild.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelBuildDate
            // 
            labelBuildDate.AutoSize = true;
            labelBuildDate.Font = new Font("Segoe UI", 10.875F);
            labelBuildDate.Location = new Point(129, 737);
            labelBuildDate.Margin = new Padding(6, 0, 6, 0);
            labelBuildDate.Name = "labelBuildDate";
            labelBuildDate.Size = new Size(310, 40);
            labelBuildDate.TabIndex = 7;
            labelBuildDate.Text = "build date: 01/01/2025";
            labelBuildDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureLogo
            // 
            pictureLogo.Image = Properties.Resource.HgLogo_resized;
            pictureLogo.Location = new Point(109, 78);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(350, 350);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 6;
            pictureLogo.TabStop = false;
            // 
            // labelPartOf
            // 
            labelPartOf.AutoSize = true;
            labelPartOf.Font = new Font("Segoe UI", 10.125F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelPartOf.ForeColor = Color.DodgerBlue;
            labelPartOf.Location = new Point(73, 542);
            labelPartOf.Margin = new Padding(6, 0, 6, 0);
            labelPartOf.Name = "labelPartOf";
            labelPartOf.Size = new Size(408, 37);
            labelPartOf.TabIndex = 5;
            labelPartOf.Text = "part of the HealthGear™ Package";
            labelPartOf.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSwVersion
            // 
            labelSwVersion.AutoSize = true;
            labelSwVersion.Font = new Font("Segoe UI", 10.875F);
            labelSwVersion.Location = new Point(129, 615);
            labelSwVersion.Margin = new Padding(6, 0, 6, 0);
            labelSwVersion.Name = "labelSwVersion";
            labelSwVersion.Size = new Size(204, 40);
            labelSwVersion.TabIndex = 3;
            labelSwVersion.Text = "version: 1.2.3.4";
            labelSwVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSwName
            // 
            labelSwName.AutoSize = true;
            labelSwName.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSwName.ForeColor = Color.DodgerBlue;
            labelSwName.Location = new Point(37, 459);
            labelSwName.Margin = new Padding(6, 0, 6, 0);
            labelSwName.Name = "labelSwName";
            labelSwName.Size = new Size(535, 71);
            labelSwName.TabIndex = 2;
            labelSwName.Text = "HealthGear™ Config";
            labelSwName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxLicense
            // 
            groupBoxLicense.Controls.Add(richTextBoxLicense);
            groupBoxLicense.Location = new Point(594, 9);
            groupBoxLicense.Margin = new Padding(6);
            groupBoxLicense.Name = "groupBoxLicense";
            groupBoxLicense.Padding = new Padding(6);
            groupBoxLicense.Size = new Size(1042, 1140);
            groupBoxLicense.TabIndex = 2;
            groupBoxLicense.TabStop = false;
            groupBoxLicense.Text = "Licenza";
            // 
            // richTextBoxLicense
            // 
            richTextBoxLicense.Anchor = AnchorStyles.Top;
            richTextBoxLicense.BackColor = SystemColors.Control;
            richTextBoxLicense.BorderStyle = BorderStyle.None;
            richTextBoxLicense.Location = new Point(11, 44);
            richTextBoxLicense.Margin = new Padding(6);
            richTextBoxLicense.Name = "richTextBoxLicense";
            richTextBoxLicense.ReadOnly = true;
            richTextBoxLicense.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxLicense.Size = new Size(1020, 1053);
            richTextBoxLicense.TabIndex = 0;
            richTextBoxLicense.Text = "";
            // 
            // labelSardinia
            // 
            labelSardinia.AutoSize = true;
            labelSardinia.ForeColor = Color.DodgerBlue;
            labelSardinia.Location = new Point(91, 212);
            labelSardinia.Name = "labelSardinia";
            labelSardinia.Size = new Size(390, 32);
            labelSardinia.TabIndex = 1;
            labelSardinia.Text = "Designed and produced in Sardinia";
            labelSardinia.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelSupport
            // 
            labelSupport.AutoSize = true;
            labelSupport.Location = new Point(72, 134);
            labelSupport.Name = "labelSupport";
            labelSupport.Size = new Size(135, 32);
            labelSupport.TabIndex = 4;
            labelSupport.Text = "Assistenza: ";
            // 
            // linkLabelSupportMail
            // 
            linkLabelSupportMail.AutoSize = true;
            linkLabelSupportMail.Location = new Point(213, 134);
            linkLabelSupportMail.Name = "linkLabelSupportMail";
            linkLabelSupportMail.Size = new Size(284, 32);
            linkLabelSupportMail.TabIndex = 1;
            linkLabelSupportMail.TabStop = true;
            linkLabelSupportMail.Text = "support@healthgear.com";
            // 
            // groupBoxContacts
            // 
            groupBoxContacts.Controls.Add(labelSardinia);
            groupBoxContacts.Controls.Add(labelSupport);
            groupBoxContacts.Controls.Add(linkLabelSupportMail);
            groupBoxContacts.Controls.Add(linkLabel1);
            groupBoxContacts.Controls.Add(labelHome);
            groupBoxContacts.Location = new Point(2, 886);
            groupBoxContacts.Name = "groupBoxContacts";
            groupBoxContacts.Size = new Size(569, 263);
            groupBoxContacts.TabIndex = 4;
            groupBoxContacts.TabStop = false;
            groupBoxContacts.Text = "Contatti";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(213, 60);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(235, 32);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "www.healthgear.com";
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Location = new Point(123, 60);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(84, 32);
            labelHome.TabIndex = 4;
            labelHome.Text = "Home:";
            // 
            // timerCopied
            // 
            timerCopied.Interval = 5000;
            timerCopied.Tick += timerCopied_Tick;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1651, 1164);
            panel1.TabIndex = 5;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1651, 1164);
            Controls.Add(groupBoxLicense);
            Controls.Add(groupBoxContacts);
            Controls.Add(groupBoxSoftwareVers);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About...";
            groupBoxSoftwareVers.ResumeLayout(false);
            groupBoxSoftwareVers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            groupBoxLicense.ResumeLayout(false);
            groupBoxContacts.ResumeLayout(false);
            groupBoxContacts.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxSoftwareVers;
        private Label labelSwVersion;
        private Label labelSwName;
        private GroupBox groupBoxLicense;
        private RichTextBox richTextBoxLicense;
        private Label labelPartOf;
        private PictureBox pictureLogo;
        private Label labelBuildDate;
        private Label labelBuild;
        private Label labelSupport;
        private LinkLabel linkLabelSupportMail;
        private GroupBox groupBoxContacts;
        private LinkLabel linkLabel1;
        private Label labelHome;
        private Label labelSardinia;
        private Label labelCopy;
        private System.Windows.Forms.Timer timerCopied;
        private Panel panel1;
    }
}