namespace KLab
{
    partial class SecretAnnouncementEditor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OK_BT = new System.Windows.Forms.Button();
            this.Cancel_BT = new System.Windows.Forms.Button();
            this.Announcement_FC = new KLab.Controls.FormulaControl();
            this.Aaud_ARL = new KLab.Controls.AddRemoveListControl();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Aaud_ARL);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(242, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 325);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Audience";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Announcement_FC);
            this.groupBox3.Location = new System.Drawing.Point(12, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 59);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Announcement";
            // 
            // OK_BT
            // 
            this.OK_BT.Location = new System.Drawing.Point(12, 257);
            this.OK_BT.Name = "OK_BT";
            this.OK_BT.Size = new System.Drawing.Size(211, 42);
            this.OK_BT.TabIndex = 4;
            this.OK_BT.Text = "OK";
            this.OK_BT.UseVisualStyleBackColor = true;
            this.OK_BT.Click += new System.EventHandler(this.OK_BT_Click);
            // 
            // Cancel_BT
            // 
            this.Cancel_BT.Location = new System.Drawing.Point(12, 305);
            this.Cancel_BT.Name = "Cancel_BT";
            this.Cancel_BT.Size = new System.Drawing.Size(211, 42);
            this.Cancel_BT.TabIndex = 4;
            this.Cancel_BT.Text = "Cancel";
            this.Cancel_BT.UseVisualStyleBackColor = true;
            this.Cancel_BT.Click += new System.EventHandler(this.Cancel_BT_Click);
            // 
            // Announcement_FC
            // 
            this.Announcement_FC.Location = new System.Drawing.Point(6, 19);
            this.Announcement_FC.Name = "Announcement_FC";
            this.Announcement_FC.Size = new System.Drawing.Size(200, 32);
            this.Announcement_FC.TabIndex = 2;
            // 
            // Aaud_ARL
            // 
            this.Aaud_ARL.AutoScroll = true;
            this.Aaud_ARL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Aaud_ARL.Location = new System.Drawing.Point(7, 20);
            this.Aaud_ARL.Name = "Aaud_ARL";
            this.Aaud_ARL.Size = new System.Drawing.Size(207, 285);
            this.Aaud_ARL.TabIndex = 0;
            // 
            // SecretAnnouncementEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(481, 362);
            this.Controls.Add(this.Cancel_BT);
            this.Controls.Add(this.OK_BT);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "SecretAnnouncementEditor";
            this.Text = "Secret Announce Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private KLab.Controls.AddRemoveListControl Aaud_ARL;
        private KLab.Controls.FormulaControl Announcement_FC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button OK_BT;
        private System.Windows.Forms.Button Cancel_BT;

    }
}