namespace concordanceapConcordationDataSetTableAdaptersp
{
    partial class Wordstatistics
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
            this.Wordlbl = new System.Windows.Forms.Label();
            this.Word = new System.Windows.Forms.Label();
            this.StatsGrid = new System.Windows.Forms.DataGridView();
            this.getWordStatsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchNumsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StatsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getWordStatsResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Wordlbl
            // 
            this.Wordlbl.AutoSize = true;
            this.Wordlbl.Location = new System.Drawing.Point(13, 13);
            this.Wordlbl.Name = "Wordlbl";
            this.Wordlbl.Size = new System.Drawing.Size(69, 13);
            this.Wordlbl.TabIndex = 0;
            this.Wordlbl.Text = "The Word Is:";
            // 
            // Word
            // 
            this.Word.AutoSize = true;
            this.Word.Location = new System.Drawing.Point(88, 13);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(33, 13);
            this.Word.TabIndex = 1;
            this.Word.Text = "Word";
            // 
            // StatsGrid
            // 
            this.StatsGrid.AllowUserToAddRows = false;
            this.StatsGrid.AllowUserToDeleteRows = false;
            this.StatsGrid.AutoGenerateColumns = false;
            this.StatsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.totalCountDataGridViewTextBoxColumn,
            this.searchNumsDataGridViewTextBoxColumn});
            this.StatsGrid.DataSource = this.getWordStatsResultBindingSource;
            this.StatsGrid.Location = new System.Drawing.Point(16, 42);
            this.StatsGrid.Name = "StatsGrid";
            this.StatsGrid.ReadOnly = true;
            this.StatsGrid.Size = new System.Drawing.Size(424, 57);
            this.StatsGrid.TabIndex = 2;
            // 
            // getWordStatsResultBindingSource
            // 
            this.getWordStatsResultBindingSource.DataSource = typeof(concordanceapConcordationDataSetTableAdaptersp.GetWordStatsResult);
            // 
            // totalCountDataGridViewTextBoxColumn
            // 
            this.totalCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalCountDataGridViewTextBoxColumn.DataPropertyName = "TotalCount";
            this.totalCountDataGridViewTextBoxColumn.HeaderText = "Total Appearances in the system";
            this.totalCountDataGridViewTextBoxColumn.Name = "totalCountDataGridViewTextBoxColumn";
            this.totalCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // searchNumsDataGridViewTextBoxColumn
            // 
            this.searchNumsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.searchNumsDataGridViewTextBoxColumn.DataPropertyName = "SearchNums";
            this.searchNumsDataGridViewTextBoxColumn.HeaderText = "Number of searches";
            this.searchNumsDataGridViewTextBoxColumn.Name = "searchNumsDataGridViewTextBoxColumn";
            this.searchNumsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Wordstatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 117);
            this.Controls.Add(this.StatsGrid);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.Wordlbl);
            this.Name = "Wordstatistics";
            this.Text = "Wordstatistics";
            ((System.ComponentModel.ISupportInitialize)(this.StatsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getWordStatsResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Wordlbl;
        private System.Windows.Forms.Label Word;
        private System.Windows.Forms.DataGridView StatsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchNumsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getWordStatsResultBindingSource;
    }
}