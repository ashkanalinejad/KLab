namespace EpistemicProcessChain
{
    partial class EpistemicProcessChainEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EpistemicProcessChainEditor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EpisModels_AR = new KLab.Controls.AddRemoveListControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EpisProcess_ARE = new KLab.Controls.AddRemoveEditListControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Generator_BT = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.EpisProcEditPanel = new KLab.Controls.ProcessEditPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EpisModels_AR);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 328);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Epistemic Models";
            // 
            // EpisModels_AR
            // 
            this.EpisModels_AR.AutoScroll = true;
            this.EpisModels_AR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EpisModels_AR.Location = new System.Drawing.Point(6, 19);
            this.EpisModels_AR.Name = "EpisModels_AR";
            this.EpisModels_AR.Size = new System.Drawing.Size(207, 299);
            this.EpisModels_AR.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EpisProcess_ARE);
            this.groupBox2.Location = new System.Drawing.Point(256, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 328);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Epistemic Processes";
            // 
            // EpisProcess_ARE
            // 
            this.EpisProcess_ARE.AutoScroll = true;
            this.EpisProcess_ARE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EpisProcess_ARE.Location = new System.Drawing.Point(7, 20);
            this.EpisProcess_ARE.Name = "EpisProcess_ARE";
            this.EpisProcess_ARE.Size = new System.Drawing.Size(207, 299);
            this.EpisProcess_ARE.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.Generator_BT});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(742, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Generator_BT
            // 
            this.Generator_BT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Generator_BT.Image = global::EpistemicProcessChain.Properties.Resources.Play;
            this.Generator_BT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Generator_BT.Name = "Generator_BT";
            this.Generator_BT.Size = new System.Drawing.Size(23, 22);
            this.Generator_BT.Text = "toolStripButton1";
            this.Generator_BT.ToolTipText = "Process Epistemic Chain of Actions";
            this.Generator_BT.Click += new System.EventHandler(this.Generator_BT_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "epc";
            this.saveFileDialog1.Filter = "Epistemic Process Chain|*epc";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "epc";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "*.epc|";
            // 
            // EpisProcEditPanel
            // 
            this.EpisProcEditPanel.BackColor = System.Drawing.Color.DimGray;
            this.EpisProcEditPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EpisProcEditPanel.Location = new System.Drawing.Point(500, 47);
            this.EpisProcEditPanel.Name = "EpisProcEditPanel";
            this.EpisProcEditPanel.ProcName = null;
            this.EpisProcEditPanel.Size = new System.Drawing.Size(226, 323);
            this.EpisProcEditPanel.TabIndex = 3;
            this.EpisProcEditPanel.Visible = false;
            // 
            // EpistemicProcessChainEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(742, 386);
            this.Controls.Add(this.EpisProcEditPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EpistemicProcessChainEditor";
            this.Text = "Epistemic Process Chain Editor";
            this.Load += new System.EventHandler(this.EpistemicProcessChainEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KLab.Controls.AddRemoveListControl EpisModels_AR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private KLab.Controls.AddRemoveEditListControl EpisProcess_ARE;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Generator_BT;
        private KLab.Controls.ProcessEditPanel EpisProcEditPanel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}