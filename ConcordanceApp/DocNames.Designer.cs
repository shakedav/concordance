namespace concordanceapConcordationDataSetTableAdaptersp
{
    partial class DocNames
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
            this.DocNamesGrid = new System.Windows.Forms.DataGridView();
            this.docNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docPAthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getDocsOfWordResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DocNamesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDocsOfWordResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DocNamesGrid
            // 
            this.DocNamesGrid.AllowUserToAddRows = false;
            this.DocNamesGrid.AllowUserToDeleteRows = false;
            this.DocNamesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DocNamesGrid.AutoGenerateColumns = false;
            this.DocNamesGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DocNamesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DocNamesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.docNameDataGridViewTextBoxColumn,
            this.docPAthDataGridViewTextBoxColumn});
            this.DocNamesGrid.DataSource = this.getDocsOfWordResultBindingSource;
            this.DocNamesGrid.Location = new System.Drawing.Point(12, 12);
            this.DocNamesGrid.Name = "DocNamesGrid";
            this.DocNamesGrid.ReadOnly = true;
            this.DocNamesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DocNamesGrid.Size = new System.Drawing.Size(266, 180);
            this.DocNamesGrid.TabIndex = 1;
            // 
            // docNameDataGridViewTextBoxColumn
            // 
            this.docNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.docNameDataGridViewTextBoxColumn.DataPropertyName = "Doc_Name";
            this.docNameDataGridViewTextBoxColumn.HeaderText = "Document Name";
            this.docNameDataGridViewTextBoxColumn.Name = "docNameDataGridViewTextBoxColumn";
            this.docNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docPAthDataGridViewTextBoxColumn
            // 
            this.docPAthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.docPAthDataGridViewTextBoxColumn.DataPropertyName = "Doc_PAth";
            this.docPAthDataGridViewTextBoxColumn.HeaderText = "Document Path";
            this.docPAthDataGridViewTextBoxColumn.Name = "docPAthDataGridViewTextBoxColumn";
            this.docPAthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getDocsOfWordResultBindingSource
            // 
            this.getDocsOfWordResultBindingSource.DataSource = typeof(concordanceapConcordationDataSetTableAdaptersp.GetDocsOfWordResult);
            // 
            // DocNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 204);
            this.Controls.Add(this.DocNamesGrid);
            this.Name = "DocNames";
            this.Text = "Document Names";
            ((System.ComponentModel.ISupportInitialize)(this.DocNamesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDocsOfWordResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DocNamesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docPAthDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getDocsOfWordResultBindingSource;
    }
}