namespace concordanceapConcordationDataSetTableAdaptersp
{
    partial class AdvancedSearch
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
            this.Linelbl = new System.Windows.Forms.Label();
            this.WordNumlbl = new System.Windows.Forms.Label();
            this.LineNumtxt = new System.Windows.Forms.TextBox();
            this.WordNumtxt = new System.Windows.Forms.TextBox();
            this.SearchLinebtn = new System.Windows.Forms.Button();
            this.Taglbl = new System.Windows.Forms.Label();
            this.Tagtxt = new System.Windows.Forms.TextBox();
            this.TagSearchbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Linelbl
            // 
            this.Linelbl.AutoSize = true;
            this.Linelbl.Location = new System.Drawing.Point(13, 37);
            this.Linelbl.Name = "Linelbl";
            this.Linelbl.Size = new System.Drawing.Size(30, 13);
            this.Linelbl.TabIndex = 0;
            this.Linelbl.Text = "Line:";
            // 
            // WordNumlbl
            // 
            this.WordNumlbl.AutoSize = true;
            this.WordNumlbl.Location = new System.Drawing.Point(147, 37);
            this.WordNumlbl.Name = "WordNumlbl";
            this.WordNumlbl.Size = new System.Drawing.Size(76, 13);
            this.WordNumlbl.TabIndex = 1;
            this.WordNumlbl.Text = "Word Number:";
            // 
            // LineNumtxt
            // 
            this.LineNumtxt.Location = new System.Drawing.Point(82, 35);
            this.LineNumtxt.Name = "LineNumtxt";
            this.LineNumtxt.Size = new System.Drawing.Size(59, 20);
            this.LineNumtxt.TabIndex = 2;
            // 
            // WordNumtxt
            // 
            this.WordNumtxt.Location = new System.Drawing.Point(229, 34);
            this.WordNumtxt.Name = "WordNumtxt";
            this.WordNumtxt.Size = new System.Drawing.Size(59, 20);
            this.WordNumtxt.TabIndex = 3;
            // 
            // SearchLinebtn
            // 
            this.SearchLinebtn.Location = new System.Drawing.Point(294, 32);
            this.SearchLinebtn.Name = "SearchLinebtn";
            this.SearchLinebtn.Size = new System.Drawing.Size(75, 23);
            this.SearchLinebtn.TabIndex = 4;
            this.SearchLinebtn.Text = "Search";
            this.SearchLinebtn.UseVisualStyleBackColor = true;
            this.SearchLinebtn.Click += new System.EventHandler(this.SearchLinebtn_Click);
            // 
            // Taglbl
            // 
            this.Taglbl.AutoSize = true;
            this.Taglbl.Location = new System.Drawing.Point(13, 100);
            this.Taglbl.Name = "Taglbl";
            this.Taglbl.Size = new System.Drawing.Size(60, 13);
            this.Taglbl.TabIndex = 5;
            this.Taglbl.Text = "Tag Name:";
            // 
            // Tagtxt
            // 
            this.Tagtxt.Location = new System.Drawing.Point(82, 97);
            this.Tagtxt.Name = "Tagtxt";
            this.Tagtxt.Size = new System.Drawing.Size(59, 20);
            this.Tagtxt.TabIndex = 6;
            // 
            // TagSearchbtn
            // 
            this.TagSearchbtn.Location = new System.Drawing.Point(147, 95);
            this.TagSearchbtn.Name = "TagSearchbtn";
            this.TagSearchbtn.Size = new System.Drawing.Size(75, 23);
            this.TagSearchbtn.TabIndex = 7;
            this.TagSearchbtn.Text = "Search";
            this.TagSearchbtn.UseVisualStyleBackColor = true;
            this.TagSearchbtn.Click += new System.EventHandler(this.TagSearchbtn_Click);
            // 
            // AdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 141);
            this.Controls.Add(this.TagSearchbtn);
            this.Controls.Add(this.Tagtxt);
            this.Controls.Add(this.Taglbl);
            this.Controls.Add(this.SearchLinebtn);
            this.Controls.Add(this.WordNumtxt);
            this.Controls.Add(this.LineNumtxt);
            this.Controls.Add(this.WordNumlbl);
            this.Controls.Add(this.Linelbl);
            this.Name = "AdvancedSearch";
            this.Text = "Advanced Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Linelbl;
        private System.Windows.Forms.Label WordNumlbl;
        private System.Windows.Forms.TextBox LineNumtxt;
        private System.Windows.Forms.TextBox WordNumtxt;
        private System.Windows.Forms.Button SearchLinebtn;
        private System.Windows.Forms.Label Taglbl;
        private System.Windows.Forms.TextBox Tagtxt;
        private System.Windows.Forms.Button TagSearchbtn;

    }
}