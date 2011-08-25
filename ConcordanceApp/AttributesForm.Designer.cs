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
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Authortxt = new System.Windows.Forms.TextBox();
            this.SongNamelbl = new System.Windows.Forms.Label();
            this.Nextbtn = new System.Windows.Forms.Button();
            this.NameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.AuthorError = new System.Windows.Forms.ErrorProvider(this.components);
            this.DocTypelbl = new System.Windows.Forms.Label();
            this.DocTypeBox = new System.Windows.Forms.ComboBox();
            this.documentTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concordationDataSet = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSet();
            this.documentTypesTableAdapter = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSetTableAdapters.DocumentTypesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Authorlbl
            // 
            this.Authorlbl.AutoSize = true;
            this.Authorlbl.Location = new System.Drawing.Point(14, 38);
            this.Authorlbl.Name = "Authorlbl";
            this.Authorlbl.Size = new System.Drawing.Size(50, 13);
            this.Authorlbl.TabIndex = 0;
            this.Authorlbl.Text = "Author:";
            // 
            // Nametxt
            // 
            this.NameError.SetError(this.Nametxt, "Document name is mandatory");
            this.Nametxt.Location = new System.Drawing.Point(123, 6);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(140, 21);
            this.Nametxt.TabIndex = 2;
            this.Nametxt.Leave += new System.EventHandler(this.Nametxt_Leave);
            // 
            // Authortxt
            // 
            this.AuthorError.SetError(this.Authortxt, "Author name is mandatory");
            this.Authortxt.Location = new System.Drawing.Point(123, 35);
            this.Authortxt.Name = "Authortxt";
            this.Authortxt.Size = new System.Drawing.Size(140, 21);
            this.Authortxt.TabIndex = 5;
            this.Authortxt.Leave += new System.EventHandler(this.Authortxt_Leave);
            // 
            // SongNamelbl
            // 
            this.SongNamelbl.AutoSize = true;
            this.SongNamelbl.Location = new System.Drawing.Point(14, 9);
            this.SongNamelbl.Name = "SongNamelbl";
            this.SongNamelbl.Size = new System.Drawing.Size(107, 13);
            this.SongNamelbl.TabIndex = 4;
            this.SongNamelbl.Text = "Document Name:";
            // 
            // Nextbtn
            // 
            this.Nextbtn.Location = new System.Drawing.Point(176, 88);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(87, 23);
            this.Nextbtn.TabIndex = 6;
            this.Nextbtn.Text = "Next";
            this.Nextbtn.UseVisualStyleBackColor = true;
            this.Nextbtn.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // NameError
            // 
            this.NameError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.NameError.ContainerControl = this;
            // 
            // AuthorError
            // 
            this.AuthorError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.AuthorError.ContainerControl = this;
            // 
            // DocTypelbl
            // 
            this.DocTypelbl.AutoSize = true;
            this.DocTypelbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocTypelbl.Location = new System.Drawing.Point(14, 69);
            this.DocTypelbl.Name = "DocTypelbl";
            this.DocTypelbl.Size = new System.Drawing.Size(102, 13);
            this.DocTypelbl.TabIndex = 7;
            this.DocTypelbl.Text = "Document Type:";
            // 
            // DocTypeBox
            // 
            this.DocTypeBox.DataSource = this.documentTypesBindingSource;
            this.DocTypeBox.DisplayMember = "Type";
            this.DocTypeBox.FormattingEnabled = true;
            this.DocTypeBox.Location = new System.Drawing.Point(123, 66);
            this.DocTypeBox.Name = "DocTypeBox";
            this.DocTypeBox.Size = new System.Drawing.Size(140, 21);
            this.DocTypeBox.TabIndex = 8;
            this.DocTypeBox.ValueMember = "Type";
            // 
            // documentTypesBindingSource
            // 
            this.documentTypesBindingSource.DataMember = "DocumentTypes";
            this.documentTypesBindingSource.DataSource = this.concordationDataSet;
            // 
            // concordationDataSet
            // 
            this.concordationDataSet.DataSetName = "ConcordationDataSet";
            this.concordationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentTypesTableAdapter
            // 
            this.documentTypesTableAdapter.ClearBeforeFill = true;
            // 
            // AttributesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 201);
            this.Controls.Add(this.DocTypeBox);
            this.Controls.Add(this.DocTypelbl);
            this.Controls.Add(this.Nextbtn);
            this.Controls.Add(this.Authortxt);
            this.Controls.Add(this.SongNamelbl);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.Authorlbl);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "AttributesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attributes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AttributesForm_FormClosed);
            this.Load += new System.EventHandler(this.AttributesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Authorlbl;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Authortxt;
        private System.Windows.Forms.Label SongNamelbl;
        private System.Windows.Forms.Button Nextbtn;
        private System.Windows.Forms.ErrorProvider NameError;
        private System.Windows.Forms.ErrorProvider AuthorError;
        private System.Windows.Forms.ComboBox DocTypeBox;
        private System.Windows.Forms.Label DocTypelbl;
        private ConcordationDataSet concordationDataSet;
        private System.Windows.Forms.BindingSource documentTypesBindingSource;
        private ConcordationDataSetTableAdapters.DocumentTypesTableAdapter documentTypesTableAdapter;
    }
}