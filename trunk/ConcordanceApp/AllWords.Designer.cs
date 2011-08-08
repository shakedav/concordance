namespace concordanceapConcordationDataSetTableAdaptersp
{
	partial class AllWords
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
            this.WordsGrid = new System.Windows.Forms.DataGridView();
            this.getAllWordsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.WordsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllWordsResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // WordsGrid
            // 
            this.WordsGrid.AllowUserToAddRows = false;
            this.WordsGrid.AllowUserToDeleteRows = false;
            this.WordsGrid.AutoGenerateColumns = false;
            this.WordsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.WordsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WordsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordDataGridViewTextBoxColumn,
            this.lineNumDataGridViewTextBoxColumn,
            this.wordNumDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.WordsGrid.DataSource = this.getAllWordsResultBindingSource;
            this.WordsGrid.Location = new System.Drawing.Point(13, 13);
            this.WordsGrid.Name = "WordsGrid";
            this.WordsGrid.ReadOnly = true;
            this.WordsGrid.Size = new System.Drawing.Size(645, 470);
            this.WordsGrid.TabIndex = 0;
            // 
            // getAllWordsResultBindingSource
            // 
            this.getAllWordsResultBindingSource.DataSource = typeof(concordanceapConcordationDataSetTableAdaptersp.GetAllWordsResult);
            // 
            // wordDataGridViewTextBoxColumn
            // 
            this.wordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wordDataGridViewTextBoxColumn.DataPropertyName = "Word";
            this.wordDataGridViewTextBoxColumn.HeaderText = "Word";
            this.wordDataGridViewTextBoxColumn.Name = "wordDataGridViewTextBoxColumn";
            this.wordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineNumDataGridViewTextBoxColumn
            // 
            this.lineNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lineNumDataGridViewTextBoxColumn.DataPropertyName = "LineNum";
            this.lineNumDataGridViewTextBoxColumn.HeaderText = "Line Number";
            this.lineNumDataGridViewTextBoxColumn.Name = "lineNumDataGridViewTextBoxColumn";
            this.lineNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wordNumDataGridViewTextBoxColumn
            // 
            this.wordNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wordNumDataGridViewTextBoxColumn.DataPropertyName = "WordNum";
            this.wordNumDataGridViewTextBoxColumn.HeaderText = "Word Number";
            this.wordNumDataGridViewTextBoxColumn.Name = "wordNumDataGridViewTextBoxColumn";
            this.wordNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Document Name";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AllWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 495);
            this.Controls.Add(this.WordsGrid);
            this.Name = "AllWords";
            this.Text = "AllWords";
            ((System.ComponentModel.ISupportInitialize)(this.WordsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllWordsResultBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.DataGridView WordsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getAllWordsResultBindingSource;
	}
}