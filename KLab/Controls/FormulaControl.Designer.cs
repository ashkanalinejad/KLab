namespace KLab.Controls
{
    partial class FormulaControl
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
            this.Formula_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Formula_TB
            // 
            this.Formula_TB.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formula_TB.Location = new System.Drawing.Point(4, 4);
            this.Formula_TB.Name = "Formula_TB";
            this.Formula_TB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Formula_TB.Size = new System.Drawing.Size(193, 24);
            this.Formula_TB.TabIndex = 0;
            this.Formula_TB.Leave += new System.EventHandler(this.Formula_TB_Leave);
            this.Formula_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Formula_TB_KeyPress);
            // 
            // FormulaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Formula_TB);
            this.Name = "FormulaControl";
            this.Size = new System.Drawing.Size(200, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Formula_TB;
    }
}
