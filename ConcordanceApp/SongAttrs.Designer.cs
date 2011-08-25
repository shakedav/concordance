namespace concordanceapConcordationDataSetTableAdaptersp
{
    partial class SongAttrs
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
            this.Savebtn = new System.Windows.Forms.Button();
            this.PublishDatetxt = new System.Windows.Forms.TextBox();
            this.Composertxt = new System.Windows.Forms.TextBox();
            this.PublishDatelbl = new System.Windows.Forms.Label();
            this.Composerlbl = new System.Windows.Forms.Label();
            this.Publishertxt = new System.Windows.Forms.TextBox();
            this.Publisherlbl = new System.Windows.Forms.Label();
            this.Performertxt = new System.Windows.Forms.TextBox();
            this.Performerlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(142, 117);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(98, 23);
            this.Savebtn.TabIndex = 11;
            this.Savebtn.Text = "Add Attributes";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // PublishDatetxt
            // 
            this.PublishDatetxt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PublishDatetxt.Location = new System.Drawing.Point(124, 36);
            this.PublishDatetxt.Name = "PublishDatetxt";
            this.PublishDatetxt.Size = new System.Drawing.Size(116, 21);
            this.PublishDatetxt.TabIndex = 10;
            // 
            // Composertxt
            // 
            this.Composertxt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Composertxt.Location = new System.Drawing.Point(124, 9);
            this.Composertxt.Name = "Composertxt";
            this.Composertxt.Size = new System.Drawing.Size(116, 21);
            this.Composertxt.TabIndex = 9;
            // 
            // PublishDatelbl
            // 
            this.PublishDatelbl.AutoSize = true;
            this.PublishDatelbl.Location = new System.Drawing.Point(14, 39);
            this.PublishDatelbl.Name = "PublishDatelbl";
            this.PublishDatelbl.Size = new System.Drawing.Size(83, 13);
            this.PublishDatelbl.TabIndex = 8;
            this.PublishDatelbl.Text = "Publish Date:";
            // 
            // Composerlbl
            // 
            this.Composerlbl.AutoSize = true;
            this.Composerlbl.Location = new System.Drawing.Point(14, 12);
            this.Composerlbl.Name = "Composerlbl";
            this.Composerlbl.Size = new System.Drawing.Size(71, 13);
            this.Composerlbl.TabIndex = 7;
            this.Composerlbl.Text = "Composer:";
            // 
            // Publishertxt
            // 
            this.Publishertxt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Publishertxt.Location = new System.Drawing.Point(124, 63);
            this.Publishertxt.Name = "Publishertxt";
            this.Publishertxt.Size = new System.Drawing.Size(116, 21);
            this.Publishertxt.TabIndex = 13;
            // 
            // Publisherlbl
            // 
            this.Publisherlbl.AutoSize = true;
            this.Publisherlbl.Location = new System.Drawing.Point(14, 66);
            this.Publisherlbl.Name = "Publisherlbl";
            this.Publisherlbl.Size = new System.Drawing.Size(64, 13);
            this.Publisherlbl.TabIndex = 12;
            this.Publisherlbl.Text = "Publisher:";
            // 
            // Performertxt
            // 
            this.Performertxt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Performertxt.Location = new System.Drawing.Point(124, 90);
            this.Performertxt.Name = "Performertxt";
            this.Performertxt.Size = new System.Drawing.Size(116, 21);
            this.Performertxt.TabIndex = 15;
            // 
            // Performerlbl
            // 
            this.Performerlbl.AutoSize = true;
            this.Performerlbl.Location = new System.Drawing.Point(14, 93);
            this.Performerlbl.Name = "Performerlbl";
            this.Performerlbl.Size = new System.Drawing.Size(70, 13);
            this.Performerlbl.TabIndex = 14;
            this.Performerlbl.Text = "Performer:";
            // 
            // SongAttrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 155);
            this.Controls.Add(this.Performertxt);
            this.Controls.Add(this.Performerlbl);
            this.Controls.Add(this.Publishertxt);
            this.Controls.Add(this.Publisherlbl);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.PublishDatetxt);
            this.Controls.Add(this.Composertxt);
            this.Controls.Add(this.PublishDatelbl);
            this.Controls.Add(this.Composerlbl);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "SongAttrs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Song Attributes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.TextBox PublishDatetxt;
        private System.Windows.Forms.TextBox Composertxt;
        private System.Windows.Forms.Label PublishDatelbl;
        private System.Windows.Forms.Label Composerlbl;
        private System.Windows.Forms.TextBox Publishertxt;
        private System.Windows.Forms.Label Publisherlbl;
        private System.Windows.Forms.TextBox Performertxt;
        private System.Windows.Forms.Label Performerlbl;
    }
}