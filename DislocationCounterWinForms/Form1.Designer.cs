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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ThresholdSelector = new System.Windows.Forms.NumericUpDown();
            this.ThresholdLabel = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.FileDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportPictureButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.CountDislocationsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcessButton = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countDislocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ResultTextLabel = new System.Windows.Forms.Label();
            this.ResultValueLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdSelector)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 371);
            this.panel1.TabIndex = 1;
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
            // ThresholdSelector
            // 
            this.ThresholdSelector.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ThresholdSelector.Location = new System.Drawing.Point(252, 3);
            this.ThresholdSelector.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.ThresholdSelector.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ThresholdSelector.Name = "ThresholdSelector";
            this.ThresholdSelector.Size = new System.Drawing.Size(60, 23);
            this.ThresholdSelector.TabIndex = 5;
            this.ThresholdSelector.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ThresholdSelector.ValueChanged += new System.EventHandler(this.ThresholdSelector_ValueChanged);
            // 
            // ThresholdLabel
            // 
            this.ThresholdLabel.AutoSize = true;
            this.ThresholdLabel.Location = new System.Drawing.Point(146, 4);
            this.ThresholdLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.ThresholdLabel.Name = "ThresholdLabel";
            this.ThresholdLabel.Size = new System.Drawing.Size(100, 15);
            this.ThresholdLabel.TabIndex = 2;
            this.ThresholdLabel.Text = "Sensitivity (0-255)";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileDropDown,
            this.EditDropDown,
            this.ProcessButton});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(143, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // FileDropDown
            // 
            this.FileDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportPictureButton,
            this.ExitButton});
            this.FileDropDown.Name = "FileDropDown";
            this.FileDropDown.Size = new System.Drawing.Size(37, 20);
            this.FileDropDown.Text = "File";
            // 
            // ImportPictureButton
            // 
            this.ImportPictureButton.Name = "ImportPictureButton";
            this.ImportPictureButton.Size = new System.Drawing.Size(150, 22);
            this.ImportPictureButton.Text = "Import picture";
            this.ImportPictureButton.Click += new System.EventHandler(this.ImportPictureButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(150, 22);
            this.ExitButton.Text = "Exit";
            // 
            // EditDropDown
            // 
            this.EditDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountDislocationsButton});
            this.EditDropDown.Name = "EditDropDown";
            this.EditDropDown.Size = new System.Drawing.Size(39, 20);
            this.EditDropDown.Text = "Edit";
            // 
            // CountDislocationsButton
            // 
            this.CountDislocationsButton.Name = "CountDislocationsButton";
            this.CountDislocationsButton.Size = new System.Drawing.Size(173, 22);
            this.CountDislocationsButton.Text = "Count dislocations";
            this.CountDislocationsButton.Click += new System.EventHandler(this.CountDislocationsButton_Click);
            // 
            // ProcessButton
            // 
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(59, 20);
            this.ProcessButton.Text = "Process";
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.menuStrip2);
            this.flowLayoutPanel1.Controls.Add(this.ThresholdLabel);
            this.flowLayoutPanel1.Controls.Add(this.ThresholdSelector);
            this.flowLayoutPanel1.Controls.Add(this.ResultTextLabel);
            this.flowLayoutPanel1.Controls.Add(this.ResultValueLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(619, 25);
            this.flowLayoutPanel1.TabIndex = 6;
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
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countDislocationsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // countDislocationsToolStripMenuItem
            // 
            this.countDislocationsToolStripMenuItem.Name = "countDislocationsToolStripMenuItem";
            this.countDislocationsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.countDislocationsToolStripMenuItem.Text = "Count dislocations";
            this.countDislocationsToolStripMenuItem.Click += new System.EventHandler(this.countDislocationsToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.processToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(619, 400);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 7;
            // 
            // ResultTextLabel
            // 
            this.ResultTextLabel.AutoSize = true;
            this.ResultTextLabel.Location = new System.Drawing.Point(318, 4);
            this.ResultTextLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.ResultTextLabel.Name = "ResultTextLabel";
            this.ResultTextLabel.Size = new System.Drawing.Size(42, 15);
            this.ResultTextLabel.TabIndex = 6;
            this.ResultTextLabel.Text = "Result:";
            // 
            // ResultValueLabel
            // 
            this.ResultValueLabel.AutoSize = true;
            this.ResultValueLabel.Location = new System.Drawing.Point(366, 4);
            this.ResultValueLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.ResultValueLabel.Name = "ResultValueLabel";
            this.ResultValueLabel.Size = new System.Drawing.Size(13, 15);
            this.ResultValueLabel.TabIndex = 7;
            this.ResultValueLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 424);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdSelector)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label ThresholdLabel;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem FileDropDown;
        private ToolStripMenuItem ImportPictureButton;
        private ToolStripMenuItem ExitButton;
        private ToolStripMenuItem EditDropDown;
        private ToolStripMenuItem CountDislocationsButton;
        private ToolStripMenuItem ProcessButton;
        private NumericUpDown ThresholdSelector;
        private FlowLayoutPanel flowLayoutPanel1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem importPictureToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem countDislocationsToolStripMenuItem;
        private ToolStripMenuItem processToolStripMenuItem;
        private MenuStrip menuStrip1;
        private SplitContainer splitContainer1;
        private Label ResultTextLabel;
        private Label ResultValueLabel;
    }
}