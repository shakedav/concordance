namespace concordanceapConcordationDataSetTableAdaptersp
{
    partial class Bacup_Restore
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
            this.Backupbtn = new System.Windows.Forms.Button();
            this.Restorebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Backupbtn
            // 
            this.Backupbtn.Location = new System.Drawing.Point(12, 12);
            this.Backupbtn.Name = "Backupbtn";
            this.Backupbtn.Size = new System.Drawing.Size(75, 23);
            this.Backupbtn.TabIndex = 0;
            this.Backupbtn.Text = "Backup";
            this.Backupbtn.UseVisualStyleBackColor = true;
            this.Backupbtn.Click += new System.EventHandler(this.Backupbtn_Click);
            // 
            // Restorebtn
            // 
            this.Restorebtn.Location = new System.Drawing.Point(120, 12);
            this.Restorebtn.Name = "Restorebtn";
            this.Restorebtn.Size = new System.Drawing.Size(75, 23);
            this.Restorebtn.TabIndex = 1;
            this.Restorebtn.Text = "Restore";
            this.Restorebtn.UseVisualStyleBackColor = true;
            this.Restorebtn.Click += new System.EventHandler(this.Restorebtn_Click);
            // 
            // Bacup_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 47);
            this.Controls.Add(this.Restorebtn);
            this.Controls.Add(this.Backupbtn);
            this.Name = "Bacup_Restore";
            this.Text = "Maintenance";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Backupbtn;
        private System.Windows.Forms.Button Restorebtn;
    }
}