using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Voronoi
{
    public sealed partial class BaseWindow : Form
    {
        Sampler sampler;
        Voronoi voronoi;

        public BaseWindow()
        {
            InitializeComponent();

            AcceptButton = voronoiButton;
            tabControl1.SelectedIndex = 1;
            this.FormClosing += new FormClosingEventHandler(BaseWindow_FormClosing);
        }

        void BaseWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void MenuOpenFile(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog1.FileName);

                int min = Math.Min(image.Width, image.Height);
                clusterSize.Maximum = Convert.ToDecimal(min * 0.25f);

                originalImageBox.Image = image;

                if (sampler != null)
                    sampler.Dispose();

                sampler = new Sampler(image);

                AutoSample(e);
            }
        }

        private void Sample(object sender, EventArgs e)
        {
            if (sampler == null)
            {
                MessageBox.Show("You must load a original picture", "Original picture is missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            int value = (uniformCheckBox.Checked)? 1 : 0;
            value += (normalCheckBox.Checked)? 2 : 0;

            if (value == 0)
            {
                MessageBox.Show("You must check distribution type", "Distribution type isn't selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sampler.ClusterSize = Convert.ToDouble(this.clusterSize.Value);
            sampler.Variance = Convert.ToDouble(this.variance.Value);
            sampler.ClusterCount = Convert.ToInt32(this.clusterCountUpDown.Value);

            int percent = percentSampled.Value;

            if (timesCheckBox.Checked)
                percent *= 100;


            sampledImageBox.Image = sampler.Sample((Sampler.Distribution)value, percent);

        }

        private void GaussCheckedChanged(object sender, EventArgs e)
        {
            settings.Enabled = normalCheckBox.Checked;

            bool allEnabled = normalCheckBox.Checked && uniformCheckBox.Checked;
            clusterSizeLabel.Enabled = clusterSize.Enabled = clusterCountUpDown.Enabled = clusterCountLabel.Enabled = allEnabled;

            AutoSample(e);
        }

        private void UniformChecked(object sender, EventArgs e)
        {
            bool allEnabled = normalCheckBox.Checked && uniformCheckBox.Checked;
            clusterSizeLabel.Enabled = clusterSize.Enabled = clusterCountUpDown.Enabled = clusterCountLabel.Enabled = allEnabled;

            AutoSample(e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sampledImageBox.Image == null)
            {
                MessageBox.Show("Before save, you must generate sampled picture", "Sampled picture is missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sampledImageBox.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void percentPointsBarValueChenged(object sender, EventArgs e)
        {
            AutoSample(e);
        }

        private void AutoSample(EventArgs e)
        {
            if (autoSample.Checked && tabControl1.SelectedTab.Name == "samplerTab" || (tabControl1.SelectedTab.Name == "voronoiTab" && resample.Checked))
            {
                if (sampler == null)
                    return;

                if (!uniformCheckBox.Checked && !normalCheckBox.Checked)
                    return;

                Sample(null, e);
            }
        }

        private void autoSampleCheckedChanged(object sender, EventArgs e)
        {
            sampleButton.Enabled = !autoSample.Checked;
        }

        private void clusterSizeChanged(object sender, EventArgs e)
        {
            AutoSample(e);
        }

        private void varianceChanged(object sender, EventArgs e)
        {
            AutoSample(e);
        }

        private void voronoiButton_Click(object sender, EventArgs e)
        {
            if (sampler == null)
            {
                MessageBox.Show("You must load a original picture", "Original picture is missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (timesCheckBox.Checked && MessageBox.Show("Are you sure, that interval 0-100% is right? Solving Voronoi diagram on this interval can be very slowly (tens of minutes, hours, ...).", "Is interval 0-100% right?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            voronoiButton.Enabled = false;

            AutoSample(e);

            BenTools.Data.HashSet<BenTools.Mathematics.Vector> data = sampler.GetSampledData();

            if (data == null && !resample.Checked)
            {
                MessageBox.Show("You must sample original picture", "Original picture isn't sampled.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            voronoi = new Voronoi(data);

            Thread t = new Thread(ComputeVoronoiMap);
            t.Start();

            while (t.ThreadState == ThreadState.Running)
            {
                Application.DoEvents();
                Thread.Sleep(200);
                voronoiProgress.Value = voronoi.GetProgressOfComputing();
            }

            voronoiButton.Enabled = true;
        }

        private void ComputeVoronoiMap()
        {
            Image img = voronoi.ComputeVoronoiMap(originalImageBox.Image, showEdges.Checked);

            if (voronoiPictureBox.Image != null)
            {
                lock (voronoiPictureBox.Image)
                {
                    voronoiPictureBox.Image = img;
                }
            }
            else
                voronoiPictureBox.Image = img;

        }

        private void TabChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "samplerTab":
                    AcceptButton = sampleButton;
                    break;

                case "voronoiTab":
                    AcceptButton = voronoiButton;
                    break;
            }
        }

        private void saveVoronoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (voronoiPictureBox.Image == null)
            {
                MessageBox.Show("Before save, you must generate Voronoi picture", "Voronoi picture is missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                voronoiPictureBox.Image.Save(saveFileDialog1.FileName);
            }

        }

        private void samplerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void voronoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void ClusterCountChanged(object sender, EventArgs e)
        {
            AutoSample(e);
        }

        private void ShowEdgesChanges(object sender, EventArgs e)
        {
            if (voronoi.GetVoronoiMap() == null)
                return;

            if (showEdges.Checked)
            {
                Image img = (Image)voronoi.GetVoronoiMap().Clone();
                voronoi.DrawEdges(img);
                voronoiPictureBox.Image = img;
            }
            else
            {
                voronoiPictureBox.Image = voronoi.GetVoronoiMap();
            }
        }
    }
}
