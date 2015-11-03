namespace KLab.Controls
{
    partial class ProcessEditPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EpisProcName_LB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Source_CB = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Resault_CB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ActionList_ARDDL = new KLab.Controls.AddRemoveMemSpecifiedList();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // EpisProcName_LB
            // 
            this.EpisProcName_LB.AutoSize = true;
            this.EpisProcName_LB.Dock = System.Windows.Forms.DockStyle.Top;
            this.EpisProcName_LB.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.EpisProcName_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.EpisProcName_LB.Location = new System.Drawing.Point(0, 0);
            this.EpisProcName_LB.Name = "EpisProcName_LB";
            this.EpisProcName_LB.Size = new System.Drawing.Size(128, 18);
            this.EpisProcName_LB.TabIndex = 0;
            this.EpisProcName_LB.Text = "EpisProcName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // Source_CB
            // 
            this.Source_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Source_CB.FormattingEnabled = true;
            this.Source_CB.Location = new System.Drawing.Point(75, 4);
            this.Source_CB.Name = "Source_CB";
            this.Source_CB.Size = new System.Drawing.Size(135, 21);
            this.Source_CB.Sorted = true;
            this.Source_CB.TabIndex = 1;
            this.Source_CB.SelectedIndexChanged += new System.EventHandler(this.Source_CB_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Source_CB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 30);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Resault_CB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 30);
            this.panel2.TabIndex = 2;
            // 
            // Resault_CB
            // 
            this.Resault_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Resault_CB.FormattingEnabled = true;
            this.Resault_CB.Location = new System.Drawing.Point(75, 4);
            this.Resault_CB.Name = "Resault_CB";
            this.Resault_CB.Size = new System.Drawing.Size(135, 21);
            this.Resault_CB.Sorted = true;
            this.Resault_CB.TabIndex = 1;
            this.Resault_CB.SelectedIndexChanged += new System.EventHandler(this.Resault_CB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Resault";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ActionList_ARDDL);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 215);
            this.panel3.TabIndex = 3;
            // 
            // ActionList_ARDDL
            // 
            this.ActionList_ARDDL.AutoScroll = true;
            this.ActionList_ARDDL.BackColor = System.Drawing.SystemColors.Control;
            this.ActionList_ARDDL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActionList_ARDDL.Location = new System.Drawing.Point(3, 30);
            this.ActionList_ARDDL.Name = "ActionList_ARDDL";
            this.ActionList_ARDDL.Size = new System.Drawing.Size(207, 175);
            this.ActionList_ARDDL.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chain of Actions";
            // 
            // ProcessEditPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EpisProcName_LB);
            this.Name = "ProcessEditPanel";
            this.Size = new System.Drawing.Size(226, 323);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EpisProcName_LB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Source_CB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox Resault_CB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private AddRemoveMemSpecifiedList ActionList_ARDDL;
        private System.Windows.Forms.Label label2;
    }
}
