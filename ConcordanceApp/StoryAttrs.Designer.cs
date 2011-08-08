namespace concordanceapConcordationDataSetTableAdaptersp
{
    partial class StoryAttrs
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
            this.Publishdatelbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PublishDatetxt = new System.Windows.Forms.TextBox();
            this.Publishertxt = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Publishdatelbl
            // 
            this.Publishdatelbl.AutoSize = true;
            this.Publishdatelbl.Location = new System.Drawing.Point(12, 9);
            this.Publishdatelbl.Name = "Publishdatelbl";
            this.Publishdatelbl.Size = new System.Drawing.Size(70, 13);
            this.Publishdatelbl.TabIndex = 2;
            this.Publishdatelbl.Text = "Publish Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Publisher:";
            // 
            // PublishDatetxt
            // 
            this.PublishDatetxt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PublishDatetxt.Location = new System.Drawing.Point(89, 9);
            this.PublishDatetxt.Name = "PublishDatetxt";
            this.PublishDatetxt.Size = new System.Drawing.Size(100, 21);
            this.PublishDatetxt.TabIndex = 4;
            // 
            // Publishertxt
            // 
            this.Publishertxt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Publishertxt.Location = new System.Drawing.Point(89, 32);
            this.Publishertxt.Name = "Publishertxt";
            this.Publishertxt.Size = new System.Drawing.Size(100, 21);
            this.Publishertxt.TabIndex = 5;
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(105, 59);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(84, 23);
            this.Savebtn.TabIndex = 6;
            this.Savebtn.Text = "Add Attributes";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // StoryAttrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 107);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Publishertxt);
            this.Controls.Add(this.PublishDatetxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Publishdatelbl);
            this.Name = "StoryAttrs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StoryAttrs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Publishdatelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PublishDatetxt;
        private System.Windows.Forms.TextBox Publishertxt;
        private System.Windows.Forms.Button Savebtn;
    }
}