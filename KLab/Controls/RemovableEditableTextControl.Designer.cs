namespace KLab.Controls
{
    partial class RemovableEditableTextControl
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
            this.Text_LB = new System.Windows.Forms.Label();
            this.Edit_BT = new System.Windows.Forms.Button();
            this.Remove_BT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_LB
            // 
            this.Text_LB.AutoSize = true;
            this.Text_LB.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_LB.ForeColor = System.Drawing.Color.White;
            this.Text_LB.Location = new System.Drawing.Point(3, 5);
            this.Text_LB.MaximumSize = new System.Drawing.Size(0, 17);
            this.Text_LB.MinimumSize = new System.Drawing.Size(0, 17);
            this.Text_LB.Name = "Text_LB";
            this.Text_LB.Size = new System.Drawing.Size(62, 17);
            this.Text_LB.TabIndex = 1;
            this.Text_LB.Text = "label1";
            // 
            // Edit_BT
            // 
            this.Edit_BT.BackgroundImage = global::KLab.Properties.Resources.Edit;
            this.Edit_BT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Edit_BT.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_BT.Image = global::KLab.Properties.Resources.Edit;
            this.Edit_BT.Location = new System.Drawing.Point(131, 2);
            this.Edit_BT.Margin = new System.Windows.Forms.Padding(0);
            this.Edit_BT.Name = "Edit_BT";
            this.Edit_BT.Size = new System.Drawing.Size(20, 20);
            this.Edit_BT.TabIndex = 2;
            this.Edit_BT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Edit_BT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Edit_BT.UseVisualStyleBackColor = true;
            this.Edit_BT.Click += new System.EventHandler(this.Edit_BT_Click);
            // 
            // Remove_BT
            // 
            this.Remove_BT.BackgroundImage = global::KLab.Properties.Resources.Remove;
            this.Remove_BT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Remove_BT.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_BT.Image = global::KLab.Properties.Resources.Remove;
            this.Remove_BT.Location = new System.Drawing.Point(151, 2);
            this.Remove_BT.Margin = new System.Windows.Forms.Padding(0);
            this.Remove_BT.Name = "Remove_BT";
            this.Remove_BT.Size = new System.Drawing.Size(20, 20);
            this.Remove_BT.TabIndex = 2;
            this.Remove_BT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Remove_BT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Remove_BT.UseVisualStyleBackColor = true;
            this.Remove_BT.Click += new System.EventHandler(this.Remove_BT_Click);
            // 
            // RemovableEditableTextControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.Edit_BT);
            this.Controls.Add(this.Remove_BT);
            this.Controls.Add(this.Text_LB);
            this.Name = "RemovableEditableTextControl";
            this.Size = new System.Drawing.Size(174, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text_LB;
        private System.Windows.Forms.Button Remove_BT;
        private System.Windows.Forms.Button Edit_BT;
    }
}
