namespace KLab
{
    partial class KLabMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KLabMainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.File_TSDDB = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ActionModels_ARL = new KLab.Controls.AddRemoveEditListControl();
            this.atomics_ARL = new KLab.Controls.AddRemoveListControl();
            this.agents_ARL = new KLab.Controls.AddRemoveListControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.agents_ARL);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(24, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agents";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.atomics_ARL);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(267, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 325);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atomics Clauses";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_TSDDB,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(765, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // File_TSDDB
            // 
            this.File_TSDDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.File_TSDDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.File_TSDDB.Image = ((System.Drawing.Image)(resources.GetObject("File_TSDDB.Image")));
            this.File_TSDDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.File_TSDDB.Name = "File_TSDDB";
            this.File_TSDDB.Size = new System.Drawing.Size(38, 22);
            this.File_TSDDB.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New ";
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ActionModels_ARL);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(511, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 325);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Action Models";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "emd";
            this.saveFileDialog1.Filter = "Epistemic Model Description|*.emd";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "emd";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ActionModels_ARL
            // 
            this.ActionModels_ARL.AutoScroll = true;
            this.ActionModels_ARL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ActionModels_ARL.Location = new System.Drawing.Point(8, 19);
            this.ActionModels_ARL.Name = "ActionModels_ARL";
            this.ActionModels_ARL.Size = new System.Drawing.Size(207, 194);
            this.ActionModels_ARL.TabIndex = 0;
            // 
            // atomics_ARL
            // 
            this.atomics_ARL.AutoScroll = true;
            this.atomics_ARL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.atomics_ARL.Location = new System.Drawing.Point(8, 20);
            this.atomics_ARL.Name = "atomics_ARL";
            this.atomics_ARL.Size = new System.Drawing.Size(207, 285);
            this.atomics_ARL.TabIndex = 0;
            // 
            // agents_ARL
            // 
            this.agents_ARL.AutoScroll = true;
            this.agents_ARL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.agents_ARL.Location = new System.Drawing.Point(7, 20);
            this.agents_ARL.Name = "agents_ARL";
            this.agents_ARL.Size = new System.Drawing.Size(207, 285);
            this.agents_ARL.TabIndex = 0;
            // 
            // KLabMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(765, 406);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KLabMainForm";
            this.Text = "KLab";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton File_TSDDB;
        private KLab.Controls.AddRemoveListControl agents_ARL;
        private KLab.Controls.AddRemoveListControl atomics_ARL;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private KLab.Controls.AddRemoveEditListControl ActionModels_ARL;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

