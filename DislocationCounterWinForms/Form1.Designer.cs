using DislocationCounterWinForms;
using System.Windows.Forms;

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.thresholdSelector = new System.Windows.Forms.NumericUpDown();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.countShapesButton = new System.Windows.Forms.Button();
            this.previewFilteredShapesButton = new System.Windows.Forms.Button();
            this.resultControlPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.resultValueLabel = new System.Windows.Forms.Label();
            this.resultTextLabel = new System.Windows.Forms.Label();
            this.maxAreaControlPanel = new System.Windows.Forms.Panel();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.maximumViableAreaSelector = new System.Windows.Forms.NumericUpDown();
            this.maximumViableAreaLabel = new System.Windows.Forms.Label();
            this.minAreaControlPanel = new System.Windows.Forms.Panel();
            this.minimumViableAreaSelector = new System.Windows.Forms.NumericUpDown();
            this.minimumViableAreaLabel = new System.Windows.Forms.Label();
            this.resetSettingButton = new System.Windows.Forms.Button();
            this.maxErrorControlPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.maxErrorSelector = new System.Windows.Forms.NumericUpDown();
            this.maxErrorLabel = new System.Windows.Forms.Label();
            this.sensitivityControlPanel = new System.Windows.Forms.Panel();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdSelector)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.resultControlPanel.SuspendLayout();
            this.maxAreaControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumViableAreaSelector)).BeginInit();
            this.minAreaControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimumViableAreaSelector)).BeginInit();
            this.maxErrorControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxErrorSelector)).BeginInit();
            this.sensitivityControlPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(205, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(808, 605);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // thresholdSelector
            // 
            this.thresholdSelector.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.thresholdSelector.Location = new System.Drawing.Point(115, 3);
            this.thresholdSelector.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.thresholdSelector.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.thresholdSelector.Name = "thresholdSelector";
            this.thresholdSelector.Size = new System.Drawing.Size(80, 23);
            this.thresholdSelector.TabIndex = 5;
            this.toolTip1.SetToolTip(this.thresholdSelector, "Sets the brightness threshold for pixels to be used in later steps (white). The r" +
        "est is ignored (black).\r\nHigher value = more brigther pixels are used\r\nLower val" +
        "ue = only the darker pixels are used");
            // 
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Location = new System.Drawing.Point(0, 3);
            this.thresholdLabel.Margin = new System.Windows.Forms.Padding(5);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Padding = new System.Windows.Forms.Padding(2);
            this.thresholdLabel.Size = new System.Drawing.Size(104, 19);
            this.thresholdLabel.TabIndex = 2;
            this.thresholdLabel.Text = "Sensitivity (0-255)";
            this.toolTip1.SetToolTip(this.thresholdLabel, "Sets the brightness threshold for pixels to be used in later steps (white). The r" +
        "est is ignored (black).\r\nHigher value = more brigther pixels are used\r\nLower val" +
        "ue = only the darker pixels are used");
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.Control;
            this.controlPanel.Controls.Add(this.countShapesButton);
            this.controlPanel.Controls.Add(this.previewFilteredShapesButton);
            this.controlPanel.Controls.Add(this.resultControlPanel);
            this.controlPanel.Controls.Add(this.maxAreaControlPanel);
            this.controlPanel.Controls.Add(this.minAreaControlPanel);
            this.controlPanel.Controls.Add(this.resetSettingButton);
            this.controlPanel.Controls.Add(this.maxErrorControlPanel);
            this.controlPanel.Controls.Add(this.sensitivityControlPanel);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Padding = new System.Windows.Forms.Padding(5);
            this.controlPanel.Size = new System.Drawing.Size(205, 605);
            this.controlPanel.TabIndex = 10;
            // 
            // countShapesButton
            // 
            this.countShapesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.countShapesButton.Location = new System.Drawing.Point(5, 173);
            this.countShapesButton.Name = "countShapesButton";
            this.countShapesButton.Size = new System.Drawing.Size(195, 23);
            this.countShapesButton.TabIndex = 22;
            this.countShapesButton.Text = "Count Shapes";
            this.toolTip1.SetToolTip(this.countShapesButton, "Filters and counts the shapes in one step.");
            this.countShapesButton.UseVisualStyleBackColor = true;
            this.countShapesButton.Click += new System.EventHandler(this.countShapesButton_Click);
            // 
            // previewFilteredShapesButton
            // 
            this.previewFilteredShapesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.previewFilteredShapesButton.Location = new System.Drawing.Point(5, 150);
            this.previewFilteredShapesButton.Name = "previewFilteredShapesButton";
            this.previewFilteredShapesButton.Size = new System.Drawing.Size(195, 23);
            this.previewFilteredShapesButton.TabIndex = 21;
            this.previewFilteredShapesButton.Text = "Preview Filtered Shapes";
            this.toolTip1.SetToolTip(this.previewFilteredShapesButton, "Displays the preview of filtered shapes based on their brightness. Shapes coloute" +
        "d in white are used in further steps. Black pixels are ignored.");
            this.previewFilteredShapesButton.UseVisualStyleBackColor = true;
            this.previewFilteredShapesButton.Click += new System.EventHandler(this.previewFilteredShapesButton_Click);
            // 
            // resultControlPanel
            // 
            this.resultControlPanel.Controls.Add(this.label4);
            this.resultControlPanel.Controls.Add(this.resultValueLabel);
            this.resultControlPanel.Controls.Add(this.resultTextLabel);
            this.resultControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultControlPanel.Location = new System.Drawing.Point(5, 121);
            this.resultControlPanel.Name = "resultControlPanel";
            this.resultControlPanel.Size = new System.Drawing.Size(195, 29);
            this.resultControlPanel.TabIndex = 20;
            this.toolTip1.SetToolTip(this.resultControlPanel, "Displays the number of shapes counted based on above criteria.");
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, -141);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2);
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sensitivity (0-255)";
            // 
            // resultValueLabel
            // 
            this.resultValueLabel.AutoSize = true;
            this.resultValueLabel.Location = new System.Drawing.Point(53, 4);
            this.resultValueLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.resultValueLabel.Name = "resultValueLabel";
            this.resultValueLabel.Size = new System.Drawing.Size(13, 15);
            this.resultValueLabel.TabIndex = 7;
            this.resultValueLabel.Text = "0";
            // 
            // resultTextLabel
            // 
            this.resultTextLabel.AutoSize = true;
            this.resultTextLabel.Location = new System.Drawing.Point(5, 4);
            this.resultTextLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.resultTextLabel.Name = "resultTextLabel";
            this.resultTextLabel.Size = new System.Drawing.Size(42, 15);
            this.resultTextLabel.TabIndex = 6;
            this.resultTextLabel.Text = "Result:";
            // 
            // maxAreaControlPanel
            // 
            this.maxAreaControlPanel.Controls.Add(this.numericUpDown3);
            this.maxAreaControlPanel.Controls.Add(this.label3);
            this.maxAreaControlPanel.Controls.Add(this.maximumViableAreaSelector);
            this.maxAreaControlPanel.Controls.Add(this.maximumViableAreaLabel);
            this.maxAreaControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.maxAreaControlPanel.Location = new System.Drawing.Point(5, 92);
            this.maxAreaControlPanel.Name = "maxAreaControlPanel";
            this.maxAreaControlPanel.Size = new System.Drawing.Size(195, 29);
            this.maxAreaControlPanel.TabIndex = 19;
            this.toolTip1.SetToolTip(this.maxAreaControlPanel, "Sets the maximum area of a counted shape.");
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown3.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(109, -105);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(80, 23);
            this.numericUpDown3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, -105);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sensitivity (0-255)";
            // 
            // maximumViableAreaSelector
            // 
            this.maximumViableAreaSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximumViableAreaSelector.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.maximumViableAreaSelector.Location = new System.Drawing.Point(115, 3);
            this.maximumViableAreaSelector.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.maximumViableAreaSelector.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.maximumViableAreaSelector.Name = "maximumViableAreaSelector";
            this.maximumViableAreaSelector.Size = new System.Drawing.Size(80, 23);
            this.maximumViableAreaSelector.TabIndex = 13;
            this.toolTip1.SetToolTip(this.maximumViableAreaSelector, "Sets the maximum area of a counted shape.\r\nHelpful if there are large features wh" +
        "ich shouldn\'t be counted.");
            this.maximumViableAreaSelector.Value = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.maximumViableAreaSelector.ValueChanged += new System.EventHandler(this.maximumViableAreaSelector_ValueChanged);
            // 
            // maximumViableAreaLabel
            // 
            this.maximumViableAreaLabel.AutoSize = true;
            this.maximumViableAreaLabel.Location = new System.Drawing.Point(3, 5);
            this.maximumViableAreaLabel.Margin = new System.Windows.Forms.Padding(0);
            this.maximumViableAreaLabel.Name = "maximumViableAreaLabel";
            this.maximumViableAreaLabel.Size = new System.Drawing.Size(87, 15);
            this.maximumViableAreaLabel.TabIndex = 12;
            this.maximumViableAreaLabel.Text = "Maximum area";
            this.toolTip1.SetToolTip(this.maximumViableAreaLabel, "Sets the maximum area of a counted shape.\r\nHelpful if there are large features wh" +
        "ich shouldn\'t be counted.");
            // 
            // minAreaControlPanel
            // 
            this.minAreaControlPanel.Controls.Add(this.minimumViableAreaSelector);
            this.minAreaControlPanel.Controls.Add(this.minimumViableAreaLabel);
            this.minAreaControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.minAreaControlPanel.Location = new System.Drawing.Point(5, 63);
            this.minAreaControlPanel.Name = "minAreaControlPanel";
            this.minAreaControlPanel.Size = new System.Drawing.Size(195, 29);
            this.minAreaControlPanel.TabIndex = 18;
            this.toolTip1.SetToolTip(this.minAreaControlPanel, "Sets the minimum area of counted shapes.");
            // 
            // minimumViableAreaSelector
            // 
            this.minimumViableAreaSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimumViableAreaSelector.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.minimumViableAreaSelector.Location = new System.Drawing.Point(115, 3);
            this.minimumViableAreaSelector.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.minimumViableAreaSelector.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.minimumViableAreaSelector.Name = "minimumViableAreaSelector";
            this.minimumViableAreaSelector.Size = new System.Drawing.Size(80, 23);
            this.minimumViableAreaSelector.TabIndex = 11;
            this.toolTip1.SetToolTip(this.minimumViableAreaSelector, "Sets the minimum area of counted shapes.\r\nHelpful if there are many small feature" +
        "s that should be ignored.");
            this.minimumViableAreaSelector.ValueChanged += new System.EventHandler(this.minimumViableAreaSelector_ValueChanged);
            // 
            // minimumViableAreaLabel
            // 
            this.minimumViableAreaLabel.AutoSize = true;
            this.minimumViableAreaLabel.Location = new System.Drawing.Point(3, 5);
            this.minimumViableAreaLabel.Margin = new System.Windows.Forms.Padding(0);
            this.minimumViableAreaLabel.Name = "minimumViableAreaLabel";
            this.minimumViableAreaLabel.Size = new System.Drawing.Size(85, 15);
            this.minimumViableAreaLabel.TabIndex = 10;
            this.minimumViableAreaLabel.Text = "Minimum area";
            this.toolTip1.SetToolTip(this.minimumViableAreaLabel, "Sets the minimum area of counted shapes.\r\nHelpful if there are many small feature" +
        "s that should be ignored.");
            // 
            // resetSettingButton
            // 
            this.resetSettingButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resetSettingButton.Location = new System.Drawing.Point(5, 574);
            this.resetSettingButton.Name = "resetSettingButton";
            this.resetSettingButton.Size = new System.Drawing.Size(195, 26);
            this.resetSettingButton.TabIndex = 1;
            this.resetSettingButton.Text = "Restore default";
            this.toolTip1.SetToolTip(this.resetSettingButton, "Restores the settings to their default values.");
            this.resetSettingButton.UseVisualStyleBackColor = true;
            this.resetSettingButton.Click += new System.EventHandler(this.resetSettingButton_Click);
            // 
            // maxErrorControlPanel
            // 
            this.maxErrorControlPanel.Controls.Add(this.label1);
            this.maxErrorControlPanel.Controls.Add(this.maxErrorSelector);
            this.maxErrorControlPanel.Controls.Add(this.maxErrorLabel);
            this.maxErrorControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.maxErrorControlPanel.Location = new System.Drawing.Point(5, 34);
            this.maxErrorControlPanel.Name = "maxErrorControlPanel";
            this.maxErrorControlPanel.Size = new System.Drawing.Size(195, 29);
            this.maxErrorControlPanel.TabIndex = 17;
            this.toolTip1.SetToolTip(this.maxErrorControlPanel, "Higher value = less pronounced and more blurry shapes are used.");
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, -33);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sensitivity (0-255)";
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
            this.maxErrorSelector.Location = new System.Drawing.Point(115, 2);
            this.maxErrorSelector.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.maxErrorSelector.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxErrorSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.maxErrorSelector.Name = "maxErrorSelector";
            this.maxErrorSelector.Size = new System.Drawing.Size(80, 23);
            this.maxErrorSelector.TabIndex = 9;
            this.toolTip1.SetToolTip(this.maxErrorSelector, "Higher value = less pronounced and more blurry shapes are used.\r\nLower value = on" +
        "ly distinct and clear shapes are be used.\r\n");
            this.maxErrorSelector.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            // 
            // maxErrorLabel
            // 
            this.maxErrorLabel.AutoSize = true;
            this.maxErrorLabel.Location = new System.Drawing.Point(3, 5);
            this.maxErrorLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.maxErrorLabel.Name = "maxErrorLabel";
            this.maxErrorLabel.Size = new System.Drawing.Size(104, 15);
            this.maxErrorLabel.TabIndex = 8;
            this.maxErrorLabel.Text = "Max. Error (0,01-1)";
            this.toolTip1.SetToolTip(this.maxErrorLabel, "Higher value = less pronounced and more blurry shapes are used.\r\nLower value = on" +
        "ly distinct and clear shapes are be used.\r\n");
            // 
            // sensitivityControlPanel
            // 
            this.sensitivityControlPanel.Controls.Add(this.thresholdSelector);
            this.sensitivityControlPanel.Controls.Add(this.thresholdLabel);
            this.sensitivityControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sensitivityControlPanel.Location = new System.Drawing.Point(5, 5);
            this.sensitivityControlPanel.Name = "sensitivityControlPanel";
            this.sensitivityControlPanel.Size = new System.Drawing.Size(195, 29);
            this.sensitivityControlPanel.TabIndex = 16;
            this.toolTip1.SetToolTip(this.sensitivityControlPanel, "Sets the brightness threshold for pixels to be used in later steps (white). The r" +
        "est is ignored (black).");
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.fileToolStripMenuItem.Text = "Import Picture";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.controlPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1013, 605);
            this.panel3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 629);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(480, 300);
            this.Name = "Form1";
            this.Text = "Dyslokacjowo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdSelector)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.resultControlPanel.ResumeLayout(false);
            this.resultControlPanel.PerformLayout();
            this.maxAreaControlPanel.ResumeLayout(false);
            this.maxAreaControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumViableAreaSelector)).EndInit();
            this.minAreaControlPanel.ResumeLayout(false);
            this.minAreaControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimumViableAreaSelector)).EndInit();
            this.maxErrorControlPanel.ResumeLayout(false);
            this.maxErrorControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxErrorSelector)).EndInit();
            this.sensitivityControlPanel.ResumeLayout(false);
            this.sensitivityControlPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Label thresholdLabel;
        private NumericUpDown thresholdSelector;
        private ToolStripMenuItem fileToolStripMenuItem;
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
        private Button resetSettingButton;
        private NumericUpDown maximumViableAreaSelector;
        private Label maximumViableAreaLabel;
        private Panel sensitivityControlPanel;
        private Panel maxAreaControlPanel;
        private NumericUpDown numericUpDown3;
        private Label label3;
        private Panel minAreaControlPanel;
        private Panel maxErrorControlPanel;
        private Label label1;
        private Button countShapesButton;
        private Button previewFilteredShapesButton;
        private Panel resultControlPanel;
        private Label label4;
    }
}