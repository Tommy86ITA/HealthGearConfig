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
            groupBoxSoftwareVers = new GroupBox();
            label1 = new Label();
            labelSwVersion = new Label();
            labelSwName = new Label();
            pictureBox1 = new PictureBox();
            buttonClose = new Button();
            groupBoxLicense = new GroupBox();
            richTextBoxLicense = new RichTextBox();
            groupBoxSoftwareVers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxLicense.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxSoftwareVers
            // 
            groupBoxSoftwareVers.Controls.Add(label1);
            groupBoxSoftwareVers.Controls.Add(labelSwVersion);
            groupBoxSoftwareVers.Controls.Add(labelSwName);
            groupBoxSoftwareVers.Controls.Add(pictureBox1);
            groupBoxSoftwareVers.Location = new Point(1, 4);
            groupBoxSoftwareVers.Name = "groupBoxSoftwareVers";
            groupBoxSoftwareVers.Size = new Size(562, 133);
            groupBoxSoftwareVers.TabIndex = 0;
            groupBoxSoftwareVers.TabStop = false;
            groupBoxSoftwareVers.Text = "Informazioni";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(166, 54);
            label1.Name = "label1";
            label1.Size = new Size(230, 21);
            label1.TabIndex = 5;
            label1.Text = "part of the HealthGear Package";
            // 
            // labelSwVersion
            // 
            labelSwVersion.AutoSize = true;
            labelSwVersion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSwVersion.Location = new Point(166, 97);
            labelSwVersion.Name = "labelSwVersion";
            labelSwVersion.Size = new Size(113, 21);
            labelSwVersion.TabIndex = 3;
            labelSwVersion.Text = "version: 1.2.3.4";
            labelSwVersion.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelSwName
            // 
            labelSwName.AutoSize = true;
            labelSwName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSwName.ForeColor = Color.DodgerBlue;
            labelSwName.Location = new Point(166, 22);
            labelSwName.Name = "labelSwName";
            labelSwName.Size = new Size(224, 32);
            labelSwName.TabIndex = 2;
            labelSwName.Text = "HealthGear Config";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 96);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(245, 669);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Chiudi";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // groupBoxLicense
            // 
            groupBoxLicense.Controls.Add(richTextBoxLicense);
            groupBoxLicense.Location = new Point(2, 143);
            groupBoxLicense.Name = "groupBoxLicense";
            groupBoxLicense.Size = new Size(561, 520);
            groupBoxLicense.TabIndex = 2;
            groupBoxLicense.TabStop = false;
            groupBoxLicense.Text = "Licenza";
            // 
            // richTextBoxLicense
            // 
            richTextBoxLicense.BackColor = SystemColors.Window;
            richTextBoxLicense.BorderStyle = BorderStyle.None;
            richTextBoxLicense.Location = new Point(6, 18);
            richTextBoxLicense.Name = "richTextBoxLicense";
            richTextBoxLicense.ReadOnly = true;
            richTextBoxLicense.ScrollBars = RichTextBoxScrollBars.None;
            richTextBoxLicense.Size = new Size(549, 496);
            richTextBoxLicense.TabIndex = 0;
            richTextBoxLicense.Text = "";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 704);
            Controls.Add(groupBoxLicense);
            Controls.Add(buttonClose);
            Controls.Add(groupBoxSoftwareVers);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "About...";
            groupBoxSoftwareVers.ResumeLayout(false);
            groupBoxSoftwareVers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxLicense.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxSoftwareVers;
        private PictureBox pictureBox1;
        private Label labelSwVersion;
        private Label labelSwName;
        private Button buttonClose;
        private GroupBox groupBoxLicense;
        private RichTextBox richTextBoxLicense;
        private Label label1;
    }
}