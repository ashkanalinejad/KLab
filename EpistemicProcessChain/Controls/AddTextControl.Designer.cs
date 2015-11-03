namespace KLab.Controls
{
    partial class AddTextControl
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
            this.Text_TB = new System.Windows.Forms.TextBox();
            this.ADD_BT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_TB
            // 
            this.Text_TB.BackColor = System.Drawing.SystemColors.Window;
            this.Text_TB.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_TB.Location = new System.Drawing.Point(3, 3);
            this.Text_TB.Name = "Text_TB";
            this.Text_TB.Size = new System.Drawing.Size(140, 22);
            this.Text_TB.TabIndex = 3;
            // 
            // ADD_BT
            // 
            this.ADD_BT.BackgroundImage = global::EpistemicProcessChain.Properties.Resources.Add;
            this.ADD_BT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ADD_BT.Location = new System.Drawing.Point(149, 4);
            this.ADD_BT.Margin = new System.Windows.Forms.Padding(0);
            this.ADD_BT.Name = "ADD_BT";
            this.ADD_BT.Size = new System.Drawing.Size(20, 20);
            this.ADD_BT.TabIndex = 4;
            this.ADD_BT.UseVisualStyleBackColor = true;
            this.ADD_BT.Click += new System.EventHandler(this.Add_PB_Click);
            // 
            // AddTextControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ADD_BT);
            this.Controls.Add(this.Text_TB);
            this.Name = "AddTextControl";
            this.Size = new System.Drawing.Size(174, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_TB;
        private System.Windows.Forms.Button ADD_BT;
    }
}
