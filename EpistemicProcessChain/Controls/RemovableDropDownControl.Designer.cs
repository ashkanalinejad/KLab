namespace KLab.Controls
{
    partial class RemovableDropDownControl
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
            this.Content_CB = new System.Windows.Forms.ComboBox();
            this.Remove_BT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Content_CB
            // 
            this.Content_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Content_CB.FormattingEnabled = true;
            this.Content_CB.Location = new System.Drawing.Point(2, 1);
            this.Content_CB.Name = "Content_CB";
            this.Content_CB.Size = new System.Drawing.Size(121, 21);
            this.Content_CB.TabIndex = 0;
            this.Content_CB.SelectedIndexChanged += new System.EventHandler(this.Content_CB_SelectedIndexChanged);
            // 
            // Remove_BT
            // 
            this.Remove_BT.BackgroundImage = global::EpistemicProcessChain.Properties.Resources.Remove;
            this.Remove_BT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Remove_BT.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_BT.Image = global::EpistemicProcessChain.Properties.Resources.Remove;
            this.Remove_BT.Location = new System.Drawing.Point(152, 2);
            this.Remove_BT.Margin = new System.Windows.Forms.Padding(0);
            this.Remove_BT.Name = "Remove_BT";
            this.Remove_BT.Size = new System.Drawing.Size(20, 20);
            this.Remove_BT.TabIndex = 2;
            this.Remove_BT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Remove_BT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Remove_BT.UseVisualStyleBackColor = true;
            this.Remove_BT.Click += new System.EventHandler(this.Remove_BT_Click);
            // 
            // RemovableDropDownControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Remove_BT);
            this.Controls.Add(this.Content_CB);
            this.Name = "RemovableDropDownControl";
            this.Size = new System.Drawing.Size(174, 24);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Content_CB;
        private System.Windows.Forms.Button Remove_BT;
    }
}
