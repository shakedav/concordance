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
            this.button1 = new System.Windows.Forms.Button();
            this.SearchedWord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search By Line Number";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SearchedWord
            // 
            this.SearchedWord.AutoSize = true;
            this.SearchedWord.Location = new System.Drawing.Point(13, 13);
            this.SearchedWord.Name = "SearchedWord";
            this.SearchedWord.Size = new System.Drawing.Size(85, 13);
            this.SearchedWord.TabIndex = 1;
            this.SearchedWord.Text = "Searched Word:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TheWord";
            this.label1.Visible = false;
            // 
            // AdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchedWord);
            this.Controls.Add(this.button1);
            this.Name = "AdvancedSearch";
            this.Text = "AdvancedSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SearchedWord;
        private System.Windows.Forms.Label label1;
    }
}