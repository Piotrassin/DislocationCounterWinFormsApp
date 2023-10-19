using DislocationCounterWinForms;
using System.Windows.Forms;

namespace DysklokacjowoWinForms
{
    partial class MainWindow
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            originalPictureBox = new PictureBox();
            thresholdSelector = new NumericUpDown();
            thresholdLabel = new Label();
            controlPanel = new Panel();
            countShapesButton = new Button();
            previewFilteredShapesButton = new Button();
            resultControlPanel = new Panel();
            label4 = new Label();
            resultValueLabel = new Label();
            resultTextLabel = new Label();
            checkBoxControlPanel = new Panel();
            label1 = new Label();
            autoPreviewCheckBox = new CheckBox();
            maxAreaControlPanel = new Panel();
            numericUpDown3 = new NumericUpDown();
            label3 = new Label();
            maximumViableAreaSelector = new NumericUpDown();
            maximumViableAreaLabel = new Label();
            minAreaControlPanel = new Panel();
            minimumViableAreaSelector = new NumericUpDown();
            minimumViableAreaLabel = new Label();
            resetSettingButton = new Button();
            sensitivityControlPanel = new Panel();
            importPictureButton = new Button();
            toolTip1 = new ToolTip(components);
            panel3 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            processedPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)originalPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thresholdSelector).BeginInit();
            controlPanel.SuspendLayout();
            resultControlPanel.SuspendLayout();
            checkBoxControlPanel.SuspendLayout();
            maxAreaControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maximumViableAreaSelector).BeginInit();
            minAreaControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minimumViableAreaSelector).BeginInit();
            sensitivityControlPanel.SuspendLayout();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)processedPictureBox).BeginInit();
            SuspendLayout();
            // 
            // originalPictureBox
            // 
            originalPictureBox.Dock = DockStyle.Fill;
            originalPictureBox.Location = new Point(3, 3);
            originalPictureBox.Name = "originalPictureBox";
            originalPictureBox.Size = new Size(794, 595);
            originalPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            originalPictureBox.TabIndex = 0;
            originalPictureBox.TabStop = false;
            // 
            // thresholdSelector
            // 
            thresholdSelector.Anchor = AnchorStyles.Right;
            thresholdSelector.Location = new Point(115, 3);
            thresholdSelector.Margin = new Padding(3, 3, 3, 2);
            thresholdSelector.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            thresholdSelector.Name = "thresholdSelector";
            thresholdSelector.Size = new Size(80, 23);
            thresholdSelector.TabIndex = 5;
            toolTip1.SetToolTip(thresholdSelector, resources.GetString("thresholdSelector.ToolTip"));
            thresholdSelector.ValueChanged += thresholdSelector_ValueChanged;
            // 
            // thresholdLabel
            // 
            thresholdLabel.AutoSize = true;
            thresholdLabel.Location = new Point(0, 3);
            thresholdLabel.Margin = new Padding(5);
            thresholdLabel.Name = "thresholdLabel";
            thresholdLabel.Padding = new Padding(2);
            thresholdLabel.Size = new Size(104, 19);
            thresholdLabel.TabIndex = 2;
            thresholdLabel.Text = "Sensitivity (0-255)";
            toolTip1.SetToolTip(thresholdLabel, resources.GetString("thresholdLabel.ToolTip"));
            // 
            // controlPanel
            // 
            controlPanel.BackColor = SystemColors.Control;
            controlPanel.Controls.Add(countShapesButton);
            controlPanel.Controls.Add(previewFilteredShapesButton);
            controlPanel.Controls.Add(resultControlPanel);
            controlPanel.Controls.Add(checkBoxControlPanel);
            controlPanel.Controls.Add(maxAreaControlPanel);
            controlPanel.Controls.Add(minAreaControlPanel);
            controlPanel.Controls.Add(resetSettingButton);
            controlPanel.Controls.Add(sensitivityControlPanel);
            controlPanel.Controls.Add(importPictureButton);
            controlPanel.Dock = DockStyle.Left;
            controlPanel.Location = new Point(0, 0);
            controlPanel.Margin = new Padding(0);
            controlPanel.Name = "controlPanel";
            controlPanel.Padding = new Padding(5);
            controlPanel.Size = new Size(205, 629);
            controlPanel.TabIndex = 10;
            // 
            // countShapesButton
            // 
            countShapesButton.Dock = DockStyle.Top;
            countShapesButton.Location = new Point(5, 196);
            countShapesButton.Name = "countShapesButton";
            countShapesButton.Size = new Size(195, 23);
            countShapesButton.TabIndex = 22;
            countShapesButton.Text = "Count Shapes";
            toolTip1.SetToolTip(countShapesButton, "Filters and counts the shapes in one step.");
            countShapesButton.UseVisualStyleBackColor = true;
            countShapesButton.Click += countShapesButton_Click;
            // 
            // previewFilteredShapesButton
            // 
            previewFilteredShapesButton.Dock = DockStyle.Top;
            previewFilteredShapesButton.Location = new Point(5, 173);
            previewFilteredShapesButton.Name = "previewFilteredShapesButton";
            previewFilteredShapesButton.Size = new Size(195, 23);
            previewFilteredShapesButton.TabIndex = 21;
            previewFilteredShapesButton.Text = "Preview Filtered Shapes";
            toolTip1.SetToolTip(previewFilteredShapesButton, "Displays the preview of filtered shapes based on their brightness. \r\nShapes coloured in white are used in further steps. Black pixels are ignored.");
            previewFilteredShapesButton.UseVisualStyleBackColor = true;
            previewFilteredShapesButton.Click += previewFilteredShapesButton_Click;
            // 
            // resultControlPanel
            // 
            resultControlPanel.Controls.Add(label4);
            resultControlPanel.Controls.Add(resultValueLabel);
            resultControlPanel.Controls.Add(resultTextLabel);
            resultControlPanel.Dock = DockStyle.Top;
            resultControlPanel.Location = new Point(5, 144);
            resultControlPanel.Name = "resultControlPanel";
            resultControlPanel.Size = new Size(195, 29);
            resultControlPanel.TabIndex = 20;
            toolTip1.SetToolTip(resultControlPanel, "Displays the number of shapes counted based on above criteria.");
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(0, -141);
            label4.Margin = new Padding(5);
            label4.Name = "label4";
            label4.Padding = new Padding(2);
            label4.Size = new Size(104, 19);
            label4.TabIndex = 2;
            label4.Text = "Sensitivity (0-255)";
            // 
            // resultValueLabel
            // 
            resultValueLabel.AutoSize = true;
            resultValueLabel.Location = new Point(53, 4);
            resultValueLabel.Margin = new Padding(3, 4, 3, 0);
            resultValueLabel.Name = "resultValueLabel";
            resultValueLabel.Size = new Size(13, 15);
            resultValueLabel.TabIndex = 7;
            resultValueLabel.Text = "0";
            toolTip1.SetToolTip(resultValueLabel, "Displays the number of shapes counted based on above criteria.");
            // 
            // resultTextLabel
            // 
            resultTextLabel.AutoSize = true;
            resultTextLabel.Location = new Point(5, 4);
            resultTextLabel.Margin = new Padding(3, 4, 3, 0);
            resultTextLabel.Name = "resultTextLabel";
            resultTextLabel.Size = new Size(42, 15);
            resultTextLabel.TabIndex = 6;
            resultTextLabel.Text = "Result:";
            toolTip1.SetToolTip(resultTextLabel, "Displays the number of shapes counted based on above criteria.");
            // 
            // checkBoxControlPanel
            // 
            checkBoxControlPanel.Controls.Add(label1);
            checkBoxControlPanel.Controls.Add(autoPreviewCheckBox);
            checkBoxControlPanel.Dock = DockStyle.Top;
            checkBoxControlPanel.Location = new Point(5, 115);
            checkBoxControlPanel.Name = "checkBoxControlPanel";
            checkBoxControlPanel.Size = new Size(195, 29);
            checkBoxControlPanel.TabIndex = 21;
            toolTip1.SetToolTip(checkBoxControlPanel, "Automatically displays the preview of filtered shapes after each Sensitivity setting change.\r\n");
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(0, -177);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Padding = new Padding(2);
            label1.Size = new Size(104, 19);
            label1.TabIndex = 2;
            label1.Text = "Sensitivity (0-255)";
            // 
            // autoPreviewCheckBox
            // 
            autoPreviewCheckBox.AutoSize = true;
            autoPreviewCheckBox.Location = new Point(3, 3);
            autoPreviewCheckBox.Name = "autoPreviewCheckBox";
            autoPreviewCheckBox.Size = new Size(96, 19);
            autoPreviewCheckBox.TabIndex = 8;
            autoPreviewCheckBox.Text = "Auto Preview";
            toolTip1.SetToolTip(autoPreviewCheckBox, "Automatically displays the preview of filtered shapes after each Sensitivity setting change.\r\n");
            autoPreviewCheckBox.UseVisualStyleBackColor = true;
            // 
            // maxAreaControlPanel
            // 
            maxAreaControlPanel.Controls.Add(numericUpDown3);
            maxAreaControlPanel.Controls.Add(label3);
            maxAreaControlPanel.Controls.Add(maximumViableAreaSelector);
            maxAreaControlPanel.Controls.Add(maximumViableAreaLabel);
            maxAreaControlPanel.Dock = DockStyle.Top;
            maxAreaControlPanel.Location = new Point(5, 86);
            maxAreaControlPanel.Name = "maxAreaControlPanel";
            maxAreaControlPanel.Size = new Size(195, 29);
            maxAreaControlPanel.TabIndex = 19;
            toolTip1.SetToolTip(maxAreaControlPanel, "Sets the maximum area of a counted shape.\r\nHelpful if there are large features which shouldn't be counted.\r\n");
            // 
            // numericUpDown3
            // 
            numericUpDown3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown3.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown3.Location = new Point(109, -105);
            numericUpDown3.Margin = new Padding(3, 3, 3, 2);
            numericUpDown3.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(80, 23);
            numericUpDown3.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(0, -105);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Padding = new Padding(2);
            label3.Size = new Size(104, 19);
            label3.TabIndex = 2;
            label3.Text = "Sensitivity (0-255)";
            // 
            // maximumViableAreaSelector
            // 
            maximumViableAreaSelector.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maximumViableAreaSelector.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            maximumViableAreaSelector.Location = new Point(115, 3);
            maximumViableAreaSelector.Margin = new Padding(3, 3, 3, 2);
            maximumViableAreaSelector.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            maximumViableAreaSelector.Name = "maximumViableAreaSelector";
            maximumViableAreaSelector.Size = new Size(80, 23);
            maximumViableAreaSelector.TabIndex = 13;
            toolTip1.SetToolTip(maximumViableAreaSelector, "Sets the maximum area of a counted shape.\r\nHelpful if there are large features which shouldn't be counted.\r\n");
            maximumViableAreaSelector.Value = new decimal(new int[] { 999999, 0, 0, 0 });
            maximumViableAreaSelector.ValueChanged += maximumViableAreaSelector_ValueChanged;
            // 
            // maximumViableAreaLabel
            // 
            maximumViableAreaLabel.AutoSize = true;
            maximumViableAreaLabel.Location = new Point(3, 5);
            maximumViableAreaLabel.Margin = new Padding(0);
            maximumViableAreaLabel.Name = "maximumViableAreaLabel";
            maximumViableAreaLabel.Size = new Size(87, 15);
            maximumViableAreaLabel.TabIndex = 12;
            maximumViableAreaLabel.Text = "Maximum area";
            toolTip1.SetToolTip(maximumViableAreaLabel, "Sets the maximum area of a counted shape.\r\nHelpful if there are large features which shouldn't be counted.\r\n");
            // 
            // minAreaControlPanel
            // 
            minAreaControlPanel.Controls.Add(minimumViableAreaSelector);
            minAreaControlPanel.Controls.Add(minimumViableAreaLabel);
            minAreaControlPanel.Dock = DockStyle.Top;
            minAreaControlPanel.Location = new Point(5, 57);
            minAreaControlPanel.Name = "minAreaControlPanel";
            minAreaControlPanel.Size = new Size(195, 29);
            minAreaControlPanel.TabIndex = 18;
            toolTip1.SetToolTip(minAreaControlPanel, "Sets the minimum area of counted shapes.\r\nHelpful if there are many small features that should be ignored.\r\n\r\n");
            // 
            // minimumViableAreaSelector
            // 
            minimumViableAreaSelector.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimumViableAreaSelector.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            minimumViableAreaSelector.Location = new Point(115, 3);
            minimumViableAreaSelector.Margin = new Padding(3, 3, 3, 2);
            minimumViableAreaSelector.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            minimumViableAreaSelector.Name = "minimumViableAreaSelector";
            minimumViableAreaSelector.Size = new Size(80, 23);
            minimumViableAreaSelector.TabIndex = 11;
            toolTip1.SetToolTip(minimumViableAreaSelector, "Sets the minimum area of counted shapes.\r\nHelpful if there are many small features that should be ignored.\r\n\r\n");
            minimumViableAreaSelector.ValueChanged += minimumViableAreaSelector_ValueChanged;
            // 
            // minimumViableAreaLabel
            // 
            minimumViableAreaLabel.AutoSize = true;
            minimumViableAreaLabel.Location = new Point(3, 5);
            minimumViableAreaLabel.Margin = new Padding(0);
            minimumViableAreaLabel.Name = "minimumViableAreaLabel";
            minimumViableAreaLabel.Size = new Size(85, 15);
            minimumViableAreaLabel.TabIndex = 10;
            minimumViableAreaLabel.Text = "Minimum area";
            toolTip1.SetToolTip(minimumViableAreaLabel, "Sets the minimum area of counted shapes.\r\nHelpful if there are many small features that should be ignored.\r\n\r\n");
            // 
            // resetSettingButton
            // 
            resetSettingButton.Dock = DockStyle.Bottom;
            resetSettingButton.Location = new Point(5, 598);
            resetSettingButton.Name = "resetSettingButton";
            resetSettingButton.Size = new Size(195, 26);
            resetSettingButton.TabIndex = 1;
            resetSettingButton.Text = "Restore default";
            toolTip1.SetToolTip(resetSettingButton, "Restores the settings to their default values.");
            resetSettingButton.UseVisualStyleBackColor = true;
            resetSettingButton.Click += resetSettingButton_Click;
            // 
            // sensitivityControlPanel
            // 
            sensitivityControlPanel.Controls.Add(thresholdSelector);
            sensitivityControlPanel.Controls.Add(thresholdLabel);
            sensitivityControlPanel.Dock = DockStyle.Top;
            sensitivityControlPanel.Location = new Point(5, 28);
            sensitivityControlPanel.Name = "sensitivityControlPanel";
            sensitivityControlPanel.Size = new Size(195, 29);
            sensitivityControlPanel.TabIndex = 16;
            toolTip1.SetToolTip(sensitivityControlPanel, resources.GetString("sensitivityControlPanel.ToolTip"));
            // 
            // importPictureButton
            // 
            importPictureButton.Dock = DockStyle.Top;
            importPictureButton.Location = new Point(5, 5);
            importPictureButton.Name = "importPictureButton";
            importPictureButton.Size = new Size(195, 23);
            importPictureButton.TabIndex = 23;
            importPictureButton.Text = "Import Picture";
            importPictureButton.UseVisualStyleBackColor = true;
            importPictureButton.Click += importPictureButton_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 999999;
            toolTip1.InitialDelay = 550;
            toolTip1.ReshowDelay = 110;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // panel3
            // 
            panel3.Controls.Add(tabControl1);
            panel3.Controls.Add(controlPanel);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1013, 629);
            panel3.TabIndex = 8;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(205, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(808, 629);
            tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(originalPictureBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(800, 601);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Original Image";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(processedPictureBox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(800, 601);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Processed Image";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // processedPictureBox
            // 
            processedPictureBox.Dock = DockStyle.Fill;
            processedPictureBox.Location = new Point(3, 3);
            processedPictureBox.Name = "processedPictureBox";
            processedPictureBox.Size = new Size(794, 595);
            processedPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            processedPictureBox.TabIndex = 0;
            processedPictureBox.TabStop = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 629);
            Controls.Add(panel3);
            MinimumSize = new Size(480, 300);
            Name = "MainWindow";
            Text = "Dyslokacjowo";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)originalPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)thresholdSelector).EndInit();
            controlPanel.ResumeLayout(false);
            resultControlPanel.ResumeLayout(false);
            resultControlPanel.PerformLayout();
            checkBoxControlPanel.ResumeLayout(false);
            checkBoxControlPanel.PerformLayout();
            maxAreaControlPanel.ResumeLayout(false);
            maxAreaControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)maximumViableAreaSelector).EndInit();
            minAreaControlPanel.ResumeLayout(false);
            minAreaControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minimumViableAreaSelector).EndInit();
            sensitivityControlPanel.ResumeLayout(false);
            sensitivityControlPanel.PerformLayout();
            panel3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)processedPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox originalPictureBox;
        private Label thresholdLabel;
        private NumericUpDown thresholdSelector;
        private Label resultTextLabel;
        private Label resultValueLabel;
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
        private Label label1;
        private Button countShapesButton;
        private Button previewFilteredShapesButton;
        private Panel resultControlPanel;
        private Label label4;
        private Button importPictureButton;
        private Panel checkBoxControlPanel;
        private CheckBox autoPreviewCheckBox;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox processedPictureBox;
    }
}