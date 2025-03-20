// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace HealthGearConfig
{
    partial class FormServerSettings
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
            listBoxHosts = new ListBox();
            groupBoxPort = new GroupBox();
            labelServerPort = new Label();
            numericUpDownPort = new NumericUpDown();
            groupBoxHosts = new GroupBox();
            tableLayoutPanelHosts = new TableLayoutPanel();
            buttonAdd = new Button();
            buttonRemove = new Button();
            textBoxHosts = new TextBox();
            buttonSaveSettings = new Button();
            buttonCancel = new Button();
            groupBoxPort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPort).BeginInit();
            groupBoxHosts.SuspendLayout();
            tableLayoutPanelHosts.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxHosts
            // 
            listBoxHosts.FormattingEnabled = true;
            listBoxHosts.Location = new Point(9, 49);
            listBoxHosts.Name = "listBoxHosts";
            listBoxHosts.Size = new Size(578, 292);
            listBoxHosts.TabIndex = 2;
            // 
            // groupBoxPort
            // 
            groupBoxPort.Controls.Add(labelServerPort);
            groupBoxPort.Controls.Add(numericUpDownPort);
            groupBoxPort.Location = new Point(17, 16);
            groupBoxPort.Name = "groupBoxPort";
            groupBoxPort.Size = new Size(596, 154);
            groupBoxPort.TabIndex = 10;
            groupBoxPort.TabStop = false;
            groupBoxPort.Text = "Porta Server";
            // 
            // labelServerPort
            // 
            labelServerPort.Anchor = AnchorStyles.None;
            labelServerPort.AutoSize = true;
            labelServerPort.Location = new Point(12, 60);
            labelServerPort.Name = "labelServerPort";
            labelServerPort.Size = new Size(164, 32);
            labelServerPort.TabIndex = 4;
            labelServerPort.Text = "Listening Port:";
            // 
            // numericUpDownPort
            // 
            numericUpDownPort.Anchor = AnchorStyles.Right;
            numericUpDownPort.Location = new Point(399, 58);
            numericUpDownPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDownPort.Minimum = new decimal(new int[] { 1024, 0, 0, 0 });
            numericUpDownPort.Name = "numericUpDownPort";
            numericUpDownPort.Size = new Size(188, 39);
            numericUpDownPort.TabIndex = 5;
            numericUpDownPort.TextAlign = HorizontalAlignment.Right;
            numericUpDownPort.Value = new decimal(new int[] { 1024, 0, 0, 0 });
            // 
            // groupBoxHosts
            // 
            groupBoxHosts.Controls.Add(tableLayoutPanelHosts);
            groupBoxHosts.Controls.Add(listBoxHosts);
            groupBoxHosts.Location = new Point(20, 176);
            groupBoxHosts.Name = "groupBoxHosts";
            groupBoxHosts.Size = new Size(593, 420);
            groupBoxHosts.TabIndex = 11;
            groupBoxHosts.TabStop = false;
            groupBoxHosts.Text = "Allowed Hosts";
            // 
            // tableLayoutPanelHosts
            // 
            tableLayoutPanelHosts.ColumnCount = 3;
            tableLayoutPanelHosts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 99.99999F));
            tableLayoutPanelHosts.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanelHosts.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanelHosts.Controls.Add(buttonAdd, 1, 0);
            tableLayoutPanelHosts.Controls.Add(buttonRemove, 2, 0);
            tableLayoutPanelHosts.Controls.Add(textBoxHosts, 0, 0);
            tableLayoutPanelHosts.Location = new Point(9, 347);
            tableLayoutPanelHosts.Name = "tableLayoutPanelHosts";
            tableLayoutPanelHosts.RowCount = 1;
            tableLayoutPanelHosts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelHosts.Size = new Size(578, 67);
            tableLayoutPanelHosts.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.None;
            buttonAdd.AutoSize = true;
            buttonAdd.ImageAlign = ContentAlignment.TopCenter;
            buttonAdd.Location = new Point(421, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(74, 42);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Anchor = AnchorStyles.None;
            buttonRemove.AutoSize = true;
            buttonRemove.Location = new Point(501, 12);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(74, 42);
            buttonRemove.TabIndex = 2;
            buttonRemove.Text = "-";
            buttonRemove.TextAlign = ContentAlignment.TopCenter;
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // textBoxHosts
            // 
            textBoxHosts.Anchor = AnchorStyles.None;
            textBoxHosts.Location = new Point(5, 14);
            textBoxHosts.Name = "textBoxHosts";
            textBoxHosts.Size = new Size(407, 39);
            textBoxHosts.TabIndex = 3;
            // 
            // buttonSaveSettings
            // 
            buttonSaveSettings.Anchor = AnchorStyles.None;
            buttonSaveSettings.FlatAppearance.BorderSize = 2;
            buttonSaveSettings.Location = new Point(22, 611);
            buttonSaveSettings.Name = "buttonSaveSettings";
            buttonSaveSettings.Size = new Size(200, 48);
            buttonSaveSettings.TabIndex = 14;
            buttonSaveSettings.Text = "Salva";
            buttonSaveSettings.UseVisualStyleBackColor = true;
            buttonSaveSettings.Click += buttonSaveSettings_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.None;
            buttonCancel.FlatAppearance.BorderSize = 2;
            buttonCancel.Location = new Point(409, 611);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(200, 48);
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "Annulla";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormServerSettings
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(626, 680);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSaveSettings);
            Controls.Add(groupBoxHosts);
            Controls.Add(groupBoxPort);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormServerSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Impostazioni Server";
            groupBoxPort.ResumeLayout(false);
            groupBoxPort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPort).EndInit();
            groupBoxHosts.ResumeLayout(false);
            tableLayoutPanelHosts.ResumeLayout(false);
            tableLayoutPanelHosts.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBoxHosts;
        private GroupBox groupBoxPort;
        private GroupBox groupBoxHosts;
        private TableLayoutPanel tableLayoutPanelHosts;
        private Button buttonAdd;
        private Button buttonRemove;
        private Button buttonSaveSettings;
        private Label labelServerPort;
        private NumericUpDown numericUpDownPort;
        private TextBox textBoxHosts;
        private Button buttonCancel;
    }
}