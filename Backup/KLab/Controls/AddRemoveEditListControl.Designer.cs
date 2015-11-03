namespace KLab.Controls
{
    partial class AddRemoveEditListControl
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
            this.List_TL = new System.Windows.Forms.TableLayoutPanel();
            this.addTextControl1 = new KLab.Controls.AddTextControl();
            this.SuspendLayout();
            // 
            // List_TL
            // 
            this.List_TL.AutoSize = true;
            this.List_TL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.List_TL.ColumnCount = 1;
            this.List_TL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.List_TL.Location = new System.Drawing.Point(3, 61);
            this.List_TL.Name = "List_TL";
            this.List_TL.RowCount = 1;
            this.List_TL.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.List_TL.Size = new System.Drawing.Size(0, 0);
            this.List_TL.TabIndex = 0;
            // 
            // addTextControl1
            // 
            this.addTextControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addTextControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addTextControl1.Location = new System.Drawing.Point(6, 13);
            this.addTextControl1.Name = "addTextControl1";
            this.addTextControl1.Size = new System.Drawing.Size(174, 30);
            this.addTextControl1.TabIndex = 0;
            // 
            // AddRemoveListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.addTextControl1);
            this.Controls.Add(this.List_TL);
            this.Name = "AddRemoveListControl";
            this.Size = new System.Drawing.Size(207, 299);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AddTextControl addTextControl1;
        private System.Windows.Forms.TableLayoutPanel List_TL;

    }
}
