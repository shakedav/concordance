namespace concordanceapConcordationDataSetTableAdaptersp
{
    partial class AttributesForm
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
            this.components = new System.ComponentModel.Container();
            this.Authorlbl = new System.Windows.Forms.Label();
            this.Composerlbl = new System.Windows.Forms.Label();
            this.SongNametxt = new System.Windows.Forms.TextBox();
            this.Composertxt = new System.Windows.Forms.TextBox();
            this.Authortxt = new System.Windows.Forms.TextBox();
            this.SongNamelbl = new System.Windows.Forms.Label();
            this.Nextbtn = new System.Windows.Forms.Button();
            this.NameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ComposerError = new System.Windows.Forms.ErrorProvider(this.components);
            this.AuthorError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComposerError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorError)).BeginInit();
            this.SuspendLayout();
            // 
            // Authorlbl
            // 
            this.Authorlbl.AutoSize = true;
            this.Authorlbl.Location = new System.Drawing.Point(12, 61);
            this.Authorlbl.Name = "Authorlbl";
            this.Authorlbl.Size = new System.Drawing.Size(41, 13);
            this.Authorlbl.TabIndex = 0;
            this.Authorlbl.Text = "Author:";
            // 
            // Composerlbl
            // 
            this.Composerlbl.AutoSize = true;
            this.Composerlbl.Location = new System.Drawing.Point(12, 35);
            this.Composerlbl.Name = "Composerlbl";
            this.Composerlbl.Size = new System.Drawing.Size(57, 13);
            this.Composerlbl.TabIndex = 1;
            this.Composerlbl.Text = "Composer:";
            // 
            // SongNametxt
            // 
            this.NameError.SetError(this.SongNametxt, "Document name is mandatory");
            this.SongNametxt.Location = new System.Drawing.Point(75, 9);
            this.SongNametxt.Name = "SongNametxt";
            this.SongNametxt.Size = new System.Drawing.Size(100, 20);
            this.SongNametxt.TabIndex = 2;
            this.SongNametxt.Leave += new System.EventHandler(this.SongNametxt_Leave);
            // 
            // Composertxt
            // 
            this.ComposerError.SetError(this.Composertxt, "Composer is mandatory");
            this.Composertxt.Location = new System.Drawing.Point(75, 35);
            this.Composertxt.Name = "Composertxt";
            this.Composertxt.Size = new System.Drawing.Size(100, 20);
            this.Composertxt.TabIndex = 3;
            this.Composertxt.Leave += new System.EventHandler(this.Composertxt_Leave);
            // 
            // Authortxt
            // 
            this.AuthorError.SetError(this.Authortxt, "Author name is mandatory");
            this.Authortxt.Location = new System.Drawing.Point(75, 61);
            this.Authortxt.Name = "Authortxt";
            this.Authortxt.Size = new System.Drawing.Size(100, 20);
            this.Authortxt.TabIndex = 5;
            this.Authortxt.Leave += new System.EventHandler(this.Authortxt_Leave);
            // 
            // SongNamelbl
            // 
            this.SongNamelbl.AutoSize = true;
            this.SongNamelbl.Location = new System.Drawing.Point(12, 9);
            this.SongNamelbl.Name = "SongNamelbl";
            this.SongNamelbl.Size = new System.Drawing.Size(60, 13);
            this.SongNamelbl.TabIndex = 4;
            this.SongNamelbl.Text = "SongName";
            // 
            // Nextbtn
            // 
            this.Nextbtn.Location = new System.Drawing.Point(85, 87);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(75, 23);
            this.Nextbtn.TabIndex = 6;
            this.Nextbtn.Text = "Next";
            this.Nextbtn.UseVisualStyleBackColor = true;
            this.Nextbtn.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // NameError
            // 
            this.NameError.ContainerControl = this;
            // 
            // ComposerError
            // 
            this.ComposerError.ContainerControl = this;
            // 
            // AuthorError
            // 
            this.AuthorError.ContainerControl = this;
            // 
            // AttributesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 134);
            this.Controls.Add(this.Nextbtn);
            this.Controls.Add(this.Authortxt);
            this.Controls.Add(this.SongNamelbl);
            this.Controls.Add(this.Composertxt);
            this.Controls.Add(this.SongNametxt);
            this.Controls.Add(this.Composerlbl);
            this.Controls.Add(this.Authorlbl);
            this.Name = "AttributesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attributes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AttributesForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.NameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComposerError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Authorlbl;
        private System.Windows.Forms.Label Composerlbl;
        private System.Windows.Forms.TextBox SongNametxt;
        private System.Windows.Forms.TextBox Composertxt;
        private System.Windows.Forms.TextBox Authortxt;
        private System.Windows.Forms.Label SongNamelbl;
        private System.Windows.Forms.Button Nextbtn;
        private System.Windows.Forms.ErrorProvider NameError;
        private System.Windows.Forms.ErrorProvider ComposerError;
        private System.Windows.Forms.ErrorProvider AuthorError;
    }
}