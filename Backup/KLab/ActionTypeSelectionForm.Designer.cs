namespace KLab
{
    partial class ActionTypeSelectionForm
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
            this.Ok_BT = new System.Windows.Forms.Button();
            this.Cancel_BT = new System.Windows.Forms.Button();
            this.Actions_List = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Ok_BT
            // 
            this.Ok_BT.Location = new System.Drawing.Point(12, 264);
            this.Ok_BT.Name = "Ok_BT";
            this.Ok_BT.Size = new System.Drawing.Size(113, 37);
            this.Ok_BT.TabIndex = 0;
            this.Ok_BT.Text = "OK";
            this.Ok_BT.UseVisualStyleBackColor = true;
            this.Ok_BT.Click += new System.EventHandler(this.Ok_BT_Click);
            // 
            // Cancel_BT
            // 
            this.Cancel_BT.Location = new System.Drawing.Point(133, 264);
            this.Cancel_BT.Name = "Cancel_BT";
            this.Cancel_BT.Size = new System.Drawing.Size(113, 37);
            this.Cancel_BT.TabIndex = 0;
            this.Cancel_BT.Text = "Cancel";
            this.Cancel_BT.UseVisualStyleBackColor = true;
            this.Cancel_BT.Click += new System.EventHandler(this.Cancel_BT_Click);
            // 
            // Actions_List
            // 
            this.Actions_List.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actions_List.FormattingEnabled = true;
            this.Actions_List.ItemHeight = 16;
            this.Actions_List.Items.AddRange(new object[] {
            "Secret Announcement",
            "Public Announcement"});
            this.Actions_List.Location = new System.Drawing.Point(12, 13);
            this.Actions_List.Name = "Actions_List";
            this.Actions_List.Size = new System.Drawing.Size(234, 228);
            this.Actions_List.TabIndex = 1;
            // 
            // ActionTypeSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 313);
            this.Controls.Add(this.Actions_List);
            this.Controls.Add(this.Cancel_BT);
            this.Controls.Add(this.Ok_BT);
            this.Name = "ActionTypeSelectionForm";
            this.Text = "Action Type Selection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ok_BT;
        private System.Windows.Forms.Button Cancel_BT;
        private System.Windows.Forms.ListBox Actions_List;
    }
}