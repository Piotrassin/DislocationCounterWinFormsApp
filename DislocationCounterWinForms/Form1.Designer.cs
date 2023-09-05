namespace DysklokacjowoWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureViewportPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.thresholdSelector = new System.Windows.Forms.NumericUpDown();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.resetSettingButton = new System.Windows.Forms.Button();
            this.minimumViableAreaSelector = new System.Windows.Forms.NumericUpDown();
            this.minimumViableAreaLabel = new System.Windows.Forms.Label();
            this.resultValueLabel = new System.Windows.Forms.Label();
            this.resultTextLabel = new System.Windows.Forms.Label();
            this.maxErrorSelector = new System.Windows.Forms.NumericUpDown();
            this.maxErrorLabel = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.countDislocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureViewportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdSelector)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimumViableAreaSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxErrorSelector)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureViewportPanel
            // 
            this.pictureViewportPanel.AutoScroll = true;
            this.pictureViewportPanel.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.pictureViewportPanel.AutoSize = true;
            this.pictureViewportPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureViewportPanel.Controls.Add(this.pictureBox1);
            this.pictureViewportPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureViewportPanel.Location = new System.Drawing.Point(0, 0);
            this.pictureViewportPanel.Name = "pictureViewportPanel";
            this.pictureViewportPanel.Size = new System.Drawing.Size(946, 546);
            this.pictureViewportPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // thresholdSelector
            // 
            this.thresholdSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.thresholdSelector.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.thresholdSelector.Location = new System.Drawing.Point(129, 5);
            this.thresholdSelector.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.thresholdSelector.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.thresholdSelector.Name = "thresholdSelector";
            this.thresholdSelector.Size = new System.Drawing.Size(60, 23);
            this.thresholdSelector.TabIndex = 5;
            this.thresholdSelector.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.thresholdSelector.ValueChanged += new System.EventHandler(this.ThresholdSelector_ValueChanged);
            // 
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Location = new System.Drawing.Point(6, 7);
            this.thresholdLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(100, 15);
            this.thresholdLabel.TabIndex = 2;
            this.thresholdLabel.Text = "Sensitivity (0-255)";
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.Control;
            this.controlPanel.Controls.Add(this.resetSettingButton);
            this.controlPanel.Controls.Add(this.minimumViableAreaSelector);
            this.controlPanel.Controls.Add(this.minimumViableAreaLabel);
            this.controlPanel.Controls.Add(this.resultValueLabel);
            this.controlPanel.Controls.Add(this.resultTextLabel);
            this.controlPanel.Controls.Add(this.maxErrorSelector);
            this.controlPanel.Controls.Add(this.maxErrorLabel);
            this.controlPanel.Controls.Add(this.thresholdSelector);
            this.controlPanel.Controls.Add(this.thresholdLabel);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Padding = new System.Windows.Forms.Padding(3);
            this.controlPanel.Size = new System.Drawing.Size(195, 546);
            this.controlPanel.TabIndex = 10;
            // 
            // resetSettingButton
            // 
            this.resetSettingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetSettingButton.Location = new System.Drawing.Point(9, 511);
            this.resetSettingButton.Name = "resetSettingButton";
            this.resetSettingButton.Size = new System.Drawing.Size(101, 26);
            this.resetSettingButton.TabIndex = 1;
            this.resetSettingButton.Text = "Restore default";
            this.resetSettingButton.UseVisualStyleBackColor = true;
            // 
            // minimumViableAreaSelector
            // 
            this.minimumViableAreaSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimumViableAreaSelector.DecimalPlaces = 2;
            this.minimumViableAreaSelector.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.minimumViableAreaSelector.Location = new System.Drawing.Point(129, 62);
            this.minimumViableAreaSelector.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.minimumViableAreaSelector.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.minimumViableAreaSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.minimumViableAreaSelector.Name = "minimumViableAreaSelector";
            this.minimumViableAreaSelector.Size = new System.Drawing.Size(60, 23);
            this.minimumViableAreaSelector.TabIndex = 11;
            this.toolTip1.SetToolTip(this.minimumViableAreaSelector, "Sets the minimum area of a shape being taken into account.\r\nHelpful if there are " +
        "many small features that shouldn\'t be taken into account.\r\nDefault = 0,05");
            this.minimumViableAreaSelector.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // minimumViableAreaLabel
            // 
            this.minimumViableAreaLabel.AutoSize = true;
            this.minimumViableAreaLabel.Location = new System.Drawing.Point(6, 64);
            this.minimumViableAreaLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.minimumViableAreaLabel.Name = "minimumViableAreaLabel";
            this.minimumViableAreaLabel.Size = new System.Drawing.Size(85, 15);
            this.minimumViableAreaLabel.TabIndex = 10;
            this.minimumViableAreaLabel.Text = "Minimum area";
            this.toolTip1.SetToolTip(this.minimumViableAreaLabel, "Sets the minimum area of a shape being taken into account.\r\nHelpful if there are " +
        "many small features that shouldn\'t be taken into account.\r\nDefault = 0,05");
            // 
            // resultValueLabel
            // 
            this.resultValueLabel.AutoSize = true;
            this.resultValueLabel.Location = new System.Drawing.Point(54, 88);
            this.resultValueLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.resultValueLabel.Name = "resultValueLabel";
            this.resultValueLabel.Size = new System.Drawing.Size(13, 15);
            this.resultValueLabel.TabIndex = 7;
            this.resultValueLabel.Text = "0";
            // 
            // resultTextLabel
            // 
            this.resultTextLabel.AutoSize = true;
            this.resultTextLabel.Location = new System.Drawing.Point(6, 88);
            this.resultTextLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.resultTextLabel.Name = "resultTextLabel";
            this.resultTextLabel.Size = new System.Drawing.Size(42, 15);
            this.resultTextLabel.TabIndex = 6;
            this.resultTextLabel.Text = "Result:";
            // 
            // maxErrorSelector
            // 
            this.maxErrorSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxErrorSelector.DecimalPlaces = 2;
            this.maxErrorSelector.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.maxErrorSelector.Location = new System.Drawing.Point(129, 33);
            this.maxErrorSelector.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.maxErrorSelector.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.maxErrorSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.maxErrorSelector.Name = "maxErrorSelector";
            this.maxErrorSelector.Size = new System.Drawing.Size(60, 23);
            this.maxErrorSelector.TabIndex = 9;
            this.toolTip1.SetToolTip(this.maxErrorSelector, "Higher value = more shapes with less distinct shapes are taken into account\r\nLowe" +
        "r value = only distinct shapes will be taken into account.\r\nDefault = 0,05\r\n");
            this.maxErrorSelector.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // maxErrorLabel
            // 
            this.maxErrorLabel.AutoSize = true;
            this.maxErrorLabel.Location = new System.Drawing.Point(6, 35);
            this.maxErrorLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.maxErrorLabel.Name = "maxErrorLabel";
            this.maxErrorLabel.Size = new System.Drawing.Size(104, 15);
            this.maxErrorLabel.TabIndex = 8;
            this.maxErrorLabel.Text = "Max. Error (0,01-1)";
            this.toolTip1.SetToolTip(this.maxErrorLabel, "Higher value = more shapes with less distinct shapes are taken into account\r\nLowe" +
        "r value = only distinct shapes will be taken into account.\r\nDefault = 0,05\r\n");
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importPictureToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importPictureToolStripMenuItem
            // 
            this.importPictureToolStripMenuItem.Name = "importPictureToolStripMenuItem";
            this.importPictureToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.importPictureToolStripMenuItem.Text = "Import picture";
            this.importPictureToolStripMenuItem.Click += new System.EventHandler(this.importPictureToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.processToolStripMenuItem.Text = "Filter";
            this.processToolStripMenuItem.Click += new System.EventHandler(this.processToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.processToolStripMenuItem,
            this.countDislocationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // countDislocationsToolStripMenuItem
            // 
            this.countDislocationsToolStripMenuItem.Name = "countDislocationsToolStripMenuItem";
            this.countDislocationsToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.countDislocationsToolStripMenuItem.Text = "Count dislocations";
            this.countDislocationsToolStripMenuItem.Click += new System.EventHandler(this.countDislocationsToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 999999;
            this.toolTip1.InitialDelay = 550;
            this.toolTip1.ReshowDelay = 110;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.controlPanel);
            this.panel3.Controls.Add(this.pictureViewportPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(946, 546);
            this.panel3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 570);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pictureViewportPanel.ResumeLayout(false);
            this.pictureViewportPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdSelector)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimumViableAreaSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxErrorSelector)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel pictureViewportPanel;
        private PictureBox pictureBox1;
        private Label thresholdLabel;
        private NumericUpDown thresholdSelector;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem importPictureToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem processToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Label resultTextLabel;
        private Label resultValueLabel;
        private Label maxErrorLabel;
        private NumericUpDown maxErrorSelector;
        private ToolTip toolTip1;
        private Panel controlPanel;
        private NumericUpDown minimumViableAreaSelector;
        private Label minimumViableAreaLabel;
        private Panel panel3;
        private ToolStripMenuItem countDislocationsToolStripMenuItem;
        private Button resetSettingButton;
    }
}