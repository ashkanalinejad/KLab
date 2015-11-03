namespace KLab.Controls
{
    partial class AddRemoveMemSpecifiedList
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
            this.AddNew_BT = new System.Windows.Forms.Button();
            this.List_TL = new System.Windows.Forms.TableLayoutPanel();
            this.NewContent_CB = new System.Windows.Forms.ComboBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // AddNew_BT
            // 
            this.AddNew_BT.Location = new System.Drawing.Point(144, 4);
            this.AddNew_BT.Name = "AddNew_BT";
            this.AddNew_BT.Size = new System.Drawing.Size(36, 23);
            this.AddNew_BT.TabIndex = 0;
            this.AddNew_BT.Text = "Add";
            this.AddNew_BT.UseVisualStyleBackColor = true;
            this.AddNew_BT.Click += new System.EventHandler(this.AddNew_BT_Click);
            // 
            // List_TL
            // 
            this.List_TL.AutoSize = true;
            this.List_TL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.List_TL.BackColor = System.Drawing.Color.Transparent;
            this.List_TL.ColumnCount = 1;
            this.List_TL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.List_TL.Location = new System.Drawing.Point(4, 48);
            this.List_TL.Name = "List_TL";
            this.List_TL.RowCount = 1;
            this.List_TL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.List_TL.Size = new System.Drawing.Size(0, 0);
            this.List_TL.TabIndex = 1;
            // 
            // NewContent_CB
            // 
            this.NewContent_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NewContent_CB.FormattingEnabled = true;
            this.NewContent_CB.Location = new System.Drawing.Point(4, 5);
            this.NewContent_CB.Name = "NewContent_CB";
            this.NewContent_CB.Size = new System.Drawing.Size(134, 21);
            this.NewContent_CB.TabIndex = 2;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(207, 299);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 4;
            this.lineShape1.X2 = 200;
            this.lineShape1.Y1 = 34;
            this.lineShape1.Y2 = 34;
            // 
            // AddRemoveMemSpecifiedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.NewContent_CB);
            this.Controls.Add(this.List_TL);
            this.Controls.Add(this.AddNew_BT);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "AddRemoveMemSpecifiedList";
            this.Size = new System.Drawing.Size(207, 299);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNew_BT;
        private System.Windows.Forms.TableLayoutPanel List_TL;
        private System.Windows.Forms.ComboBox NewContent_CB;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}
