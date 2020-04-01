namespace Voronoi
{
    partial class BaseWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveVoronoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.samplerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voronoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.originalImageBox = new System.Windows.Forms.PictureBox();
            this.sampledImageBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.percentSampled = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.sampleButton = new System.Windows.Forms.Button();
            this.uniformCheckBox = new System.Windows.Forms.CheckBox();
            this.normalCheckBox = new System.Windows.Forms.CheckBox();
            this.clusterSize = new System.Windows.Forms.NumericUpDown();
            this.settings = new System.Windows.Forms.GroupBox();
            this.clusterCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.clusterCountLabel = new System.Windows.Forms.Label();
            this.variance = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.clusterSizeLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.autoSample = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.samplerTab = new System.Windows.Forms.TabPage();
            this.voronoiTab = new System.Windows.Forms.TabPage();
            this.voronoiProgress = new System.Windows.Forms.ProgressBar();
            this.showEdges = new System.Windows.Forms.CheckBox();
            this.voronoiButton = new System.Windows.Forms.Button();
            this.voronoiPictureBox = new System.Windows.Forms.PictureBox();
            this.timesCheckBox = new System.Windows.Forms.CheckBox();
            this.resample = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampledImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentSampled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clusterSize)).BeginInit();
            this.settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clusterCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variance)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.samplerTab.SuspendLayout();
            this.voronoiTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voronoiPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tabsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveVoronoiToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.MenuOpenFile);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.saveToolStripMenuItem.Text = "Save samples";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveVoronoiToolStripMenuItem
            // 
            this.saveVoronoiToolStripMenuItem.Name = "saveVoronoiToolStripMenuItem";
            this.saveVoronoiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.saveVoronoiToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.saveVoronoiToolStripMenuItem.Text = "Save Voronoi";
            this.saveVoronoiToolStripMenuItem.Click += new System.EventHandler(this.saveVoronoiToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabsToolStripMenuItem
            // 
            this.tabsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.samplerToolStripMenuItem,
            this.voronoiToolStripMenuItem});
            this.tabsToolStripMenuItem.Name = "tabsToolStripMenuItem";
            this.tabsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.tabsToolStripMenuItem.Text = "Tabs";
            // 
            // samplerToolStripMenuItem
            // 
            this.samplerToolStripMenuItem.Name = "samplerToolStripMenuItem";
            this.samplerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.samplerToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.samplerToolStripMenuItem.Text = "Sampler";
            this.samplerToolStripMenuItem.Click += new System.EventHandler(this.samplerToolStripMenuItem_Click);
            // 
            // voronoiToolStripMenuItem
            // 
            this.voronoiToolStripMenuItem.Name = "voronoiToolStripMenuItem";
            this.voronoiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.voronoiToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.voronoiToolStripMenuItem.Text = "Voronoi";
            this.voronoiToolStripMenuItem.Click += new System.EventHandler(this.voronoiToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All files|*.*|JPEG files|*.jpg|BMP files|*.bmp|PNG files|*.png";
            // 
            // originalImageBox
            // 
            this.originalImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalImageBox.Location = new System.Drawing.Point(12, 47);
            this.originalImageBox.MaximumSize = new System.Drawing.Size(310, 200);
            this.originalImageBox.MinimumSize = new System.Drawing.Size(310, 200);
            this.originalImageBox.Name = "originalImageBox";
            this.originalImageBox.Size = new System.Drawing.Size(310, 200);
            this.originalImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalImageBox.TabIndex = 1;
            this.originalImageBox.TabStop = false;
            // 
            // sampledImageBox
            // 
            this.sampledImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sampledImageBox.Location = new System.Drawing.Point(4, 3);
            this.sampledImageBox.MaximumSize = new System.Drawing.Size(310, 200);
            this.sampledImageBox.MinimumSize = new System.Drawing.Size(310, 200);
            this.sampledImageBox.Name = "sampledImageBox";
            this.sampledImageBox.Size = new System.Drawing.Size(310, 200);
            this.sampledImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sampledImageBox.TabIndex = 2;
            this.sampledImageBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(109, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(37, -108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sampled image";
            // 
            // percentSampled
            // 
            this.percentSampled.LargeChange = 20;
            this.percentSampled.Location = new System.Drawing.Point(12, 253);
            this.percentSampled.Maximum = 200;
            this.percentSampled.Name = "percentSampled";
            this.percentSampled.Size = new System.Drawing.Size(310, 45);
            this.percentSampled.TabIndex = 4;
            this.percentSampled.TickFrequency = 5;
            this.percentSampled.Value = 50;
            this.percentSampled.ValueChanged += new System.EventHandler(this.percentPointsBarValueChenged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Percent of points, which will be sampled (0-1%)";
            // 
            // sampleButton
            // 
            this.sampleButton.Location = new System.Drawing.Point(240, 253);
            this.sampleButton.Name = "sampleButton";
            this.sampleButton.Size = new System.Drawing.Size(75, 23);
            this.sampleButton.TabIndex = 6;
            this.sampleButton.Text = "Sample";
            this.sampleButton.UseVisualStyleBackColor = true;
            this.sampleButton.Click += new System.EventHandler(this.Sample);
            // 
            // uniformCheckBox
            // 
            this.uniformCheckBox.AutoSize = true;
            this.uniformCheckBox.Checked = true;
            this.uniformCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uniformCheckBox.Location = new System.Drawing.Point(6, 209);
            this.uniformCheckBox.Name = "uniformCheckBox";
            this.uniformCheckBox.Size = new System.Drawing.Size(119, 17);
            this.uniformCheckBox.TabIndex = 7;
            this.uniformCheckBox.Text = "Uniform distrubution";
            this.uniformCheckBox.UseVisualStyleBackColor = true;
            this.uniformCheckBox.CheckedChanged += new System.EventHandler(this.UniformChecked);
            // 
            // normalCheckBox
            // 
            this.normalCheckBox.AutoSize = true;
            this.normalCheckBox.Location = new System.Drawing.Point(125, 209);
            this.normalCheckBox.Name = "normalCheckBox";
            this.normalCheckBox.Size = new System.Drawing.Size(116, 17);
            this.normalCheckBox.TabIndex = 7;
            this.normalCheckBox.Text = "Normal distrubution";
            this.normalCheckBox.UseVisualStyleBackColor = true;
            this.normalCheckBox.CheckedChanged += new System.EventHandler(this.GaussCheckedChanged);
            // 
            // clusterSize
            // 
            this.clusterSize.Location = new System.Drawing.Point(102, 19);
            this.clusterSize.Name = "clusterSize";
            this.clusterSize.Size = new System.Drawing.Size(37, 20);
            this.clusterSize.TabIndex = 8;
            this.clusterSize.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.clusterSize.ValueChanged += new System.EventHandler(this.clusterSizeChanged);
            // 
            // settings
            // 
            this.settings.Controls.Add(this.clusterSize);
            this.settings.Controls.Add(this.clusterCountUpDown);
            this.settings.Controls.Add(this.clusterCountLabel);
            this.settings.Controls.Add(this.variance);
            this.settings.Controls.Add(this.label5);
            this.settings.Controls.Add(this.clusterSizeLabel);
            this.settings.Enabled = false;
            this.settings.Location = new System.Drawing.Point(6, 232);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(228, 47);
            this.settings.TabIndex = 9;
            this.settings.TabStop = false;
            this.settings.Text = "Settings";
            // 
            // clusterCountUpDown
            // 
            this.clusterCountUpDown.Location = new System.Drawing.Point(34, 19);
            this.clusterCountUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.clusterCountUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clusterCountUpDown.Name = "clusterCountUpDown";
            this.clusterCountUpDown.Size = new System.Drawing.Size(41, 20);
            this.clusterCountUpDown.TabIndex = 13;
            this.clusterCountUpDown.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.clusterCountUpDown.ValueChanged += new System.EventHandler(this.ClusterCountChanged);
            // 
            // clusterCountLabel
            // 
            this.clusterCountLabel.AutoSize = true;
            this.clusterCountLabel.Location = new System.Drawing.Point(0, 21);
            this.clusterCountLabel.Name = "clusterCountLabel";
            this.clusterCountLabel.Size = new System.Drawing.Size(35, 13);
            this.clusterCountLabel.TabIndex = 12;
            this.clusterCountLabel.Text = "Count";
            // 
            // variance
            // 
            this.variance.DecimalPlaces = 1;
            this.variance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.variance.Location = new System.Drawing.Point(186, 19);
            this.variance.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.variance.Name = "variance";
            this.variance.Size = new System.Drawing.Size(37, 20);
            this.variance.TabIndex = 11;
            this.variance.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.variance.ValueChanged += new System.EventHandler(this.varianceChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Variance";
            // 
            // clusterSizeLabel
            // 
            this.clusterSizeLabel.AutoSize = true;
            this.clusterSizeLabel.Location = new System.Drawing.Point(76, 21);
            this.clusterSizeLabel.Name = "clusterSizeLabel";
            this.clusterSizeLabel.Size = new System.Drawing.Size(27, 13);
            this.clusterSizeLabel.TabIndex = 9;
            this.clusterSizeLabel.Text = "Size";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPEG files|*.jpg|BMP files|*.bmp|PNG files|*.png|All files|*.*";
            // 
            // autoSample
            // 
            this.autoSample.AutoSize = true;
            this.autoSample.Location = new System.Drawing.Point(240, 230);
            this.autoSample.Name = "autoSample";
            this.autoSample.Size = new System.Drawing.Size(84, 17);
            this.autoSample.TabIndex = 10;
            this.autoSample.Text = "Auto sample";
            this.autoSample.UseVisualStyleBackColor = true;
            this.autoSample.CheckedChanged += new System.EventHandler(this.autoSampleCheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.samplerTab);
            this.tabControl1.Controls.Add(this.voronoiTab);
            this.tabControl1.Location = new System.Drawing.Point(331, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(328, 314);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabChanged);
            // 
            // samplerTab
            // 
            this.samplerTab.Controls.Add(this.sampleButton);
            this.samplerTab.Controls.Add(this.autoSample);
            this.samplerTab.Controls.Add(this.sampledImageBox);
            this.samplerTab.Controls.Add(this.settings);
            this.samplerTab.Controls.Add(this.label2);
            this.samplerTab.Controls.Add(this.normalCheckBox);
            this.samplerTab.Controls.Add(this.uniformCheckBox);
            this.samplerTab.Location = new System.Drawing.Point(4, 22);
            this.samplerTab.Name = "samplerTab";
            this.samplerTab.Padding = new System.Windows.Forms.Padding(3);
            this.samplerTab.Size = new System.Drawing.Size(320, 288);
            this.samplerTab.TabIndex = 0;
            this.samplerTab.Text = "Sampler";
            this.samplerTab.UseVisualStyleBackColor = true;
            // 
            // voronoiTab
            // 
            this.voronoiTab.Controls.Add(this.voronoiProgress);
            this.voronoiTab.Controls.Add(this.resample);
            this.voronoiTab.Controls.Add(this.showEdges);
            this.voronoiTab.Controls.Add(this.voronoiButton);
            this.voronoiTab.Controls.Add(this.voronoiPictureBox);
            this.voronoiTab.Location = new System.Drawing.Point(4, 22);
            this.voronoiTab.Name = "voronoiTab";
            this.voronoiTab.Padding = new System.Windows.Forms.Padding(3);
            this.voronoiTab.Size = new System.Drawing.Size(320, 288);
            this.voronoiTab.TabIndex = 1;
            this.voronoiTab.Text = "Voronoi";
            this.voronoiTab.UseVisualStyleBackColor = true;
            // 
            // voronoiProgress
            // 
            this.voronoiProgress.Location = new System.Drawing.Point(6, 253);
            this.voronoiProgress.Name = "voronoiProgress";
            this.voronoiProgress.Size = new System.Drawing.Size(228, 23);
            this.voronoiProgress.TabIndex = 6;
            // 
            // showEdges
            // 
            this.showEdges.AutoSize = true;
            this.showEdges.Location = new System.Drawing.Point(6, 218);
            this.showEdges.Name = "showEdges";
            this.showEdges.Size = new System.Drawing.Size(85, 17);
            this.showEdges.TabIndex = 5;
            this.showEdges.Text = "Show edges";
            this.showEdges.UseVisualStyleBackColor = true;
            this.showEdges.CheckedChanged += new System.EventHandler(this.ShowEdgesChanges);
            // 
            // voronoiButton
            // 
            this.voronoiButton.Location = new System.Drawing.Point(240, 253);
            this.voronoiButton.Name = "voronoiButton";
            this.voronoiButton.Size = new System.Drawing.Size(75, 23);
            this.voronoiButton.TabIndex = 4;
            this.voronoiButton.Text = "Compute";
            this.voronoiButton.UseVisualStyleBackColor = true;
            this.voronoiButton.Click += new System.EventHandler(this.voronoiButton_Click);
            // 
            // voronoiPictureBox
            // 
            this.voronoiPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voronoiPictureBox.Location = new System.Drawing.Point(4, 3);
            this.voronoiPictureBox.MaximumSize = new System.Drawing.Size(310, 200);
            this.voronoiPictureBox.MinimumSize = new System.Drawing.Size(310, 200);
            this.voronoiPictureBox.Name = "voronoiPictureBox";
            this.voronoiPictureBox.Size = new System.Drawing.Size(310, 200);
            this.voronoiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.voronoiPictureBox.TabIndex = 3;
            this.voronoiPictureBox.TabStop = false;
            // 
            // timesCheckBox
            // 
            this.timesCheckBox.AutoSize = true;
            this.timesCheckBox.Location = new System.Drawing.Point(12, 320);
            this.timesCheckBox.Name = "timesCheckBox";
            this.timesCheckBox.Size = new System.Drawing.Size(151, 17);
            this.timesCheckBox.TabIndex = 12;
            this.timesCheckBox.Text = "Switch to interval 0 - 100%";
            this.timesCheckBox.UseVisualStyleBackColor = true;
            // 
            // resample
            // 
            this.resample.AutoSize = true;
            this.resample.Checked = true;
            this.resample.CheckState = System.Windows.Forms.CheckState.Checked;
            this.resample.Location = new System.Drawing.Point(240, 230);
            this.resample.Name = "resample";
            this.resample.Size = new System.Drawing.Size(76, 17);
            this.resample.TabIndex = 10;
            this.resample.Text = "Re-sample";
            this.resample.UseVisualStyleBackColor = true;
            this.resample.CheckedChanged += new System.EventHandler(this.autoSampleCheckedChanged);
            // 
            // BaseWindow
            // 
            this.AcceptButton = this.sampleButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 344);
            this.Controls.Add(this.timesCheckBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.percentSampled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.originalImageBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(687, 380);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(687, 380);
            this.Name = "BaseWindow";
            this.Text = "Sampler/Voronoi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampledImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentSampled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clusterSize)).EndInit();
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clusterCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variance)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.samplerTab.ResumeLayout(false);
            this.samplerTab.PerformLayout();
            this.voronoiTab.ResumeLayout(false);
            this.voronoiTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voronoiPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox originalImageBox;
        private System.Windows.Forms.PictureBox sampledImageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar percentSampled;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sampleButton;
        private System.Windows.Forms.CheckBox uniformCheckBox;
        private System.Windows.Forms.CheckBox normalCheckBox;
        private System.Windows.Forms.NumericUpDown clusterSize;
        private System.Windows.Forms.GroupBox settings;
        private System.Windows.Forms.Label clusterSizeLabel;
        private System.Windows.Forms.NumericUpDown variance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox autoSample;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage samplerTab;
        private System.Windows.Forms.TabPage voronoiTab;
        private System.Windows.Forms.PictureBox voronoiPictureBox;
        private System.Windows.Forms.Button voronoiButton;
        private System.Windows.Forms.CheckBox showEdges;
        private System.Windows.Forms.ToolStripMenuItem saveVoronoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem samplerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voronoiToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown clusterCountUpDown;
        private System.Windows.Forms.Label clusterCountLabel;
        private System.Windows.Forms.CheckBox timesCheckBox;
        private System.Windows.Forms.ProgressBar voronoiProgress;
        private System.Windows.Forms.CheckBox resample;
    }
}

