namespace concordanceapConcordationDataSetTableAdaptersp
{
    partial class WordRelation
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
            this.AddTaglnk = new System.Windows.Forms.LinkLabel();
            this.AddTag = new System.Windows.Forms.Button();
            this.tagsList = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.concordationDataSet = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSet();
            this.wordRelationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wordRelationsTableAdapter = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSetTableAdapters.WordRelationsTableAdapter();
            this.WordRelationsGrid = new System.Windows.Forms.DataGridView();
            this.getRelationsOfWordResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.word1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordRelationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WordRelationsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRelationsOfWordResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTaglnk
            // 
            this.AddTaglnk.AutoSize = true;
            this.AddTaglnk.Location = new System.Drawing.Point(221, 218);
            this.AddTaglnk.MaximumSize = new System.Drawing.Size(398, 286);
            this.AddTaglnk.Name = "AddTaglnk";
            this.AddTaglnk.Size = new System.Drawing.Size(83, 13);
            this.AddTaglnk.TabIndex = 8;
            this.AddTaglnk.TabStop = true;
            this.AddTaglnk.Text = "Add A New Tag";
            // 
            // AddTag
            // 
            this.AddTag.Location = new System.Drawing.Point(310, 213);
            this.AddTag.MaximumSize = new System.Drawing.Size(398, 286);
            this.AddTag.Name = "AddTag";
            this.AddTag.Size = new System.Drawing.Size(60, 23);
            this.AddTag.TabIndex = 7;
            this.AddTag.Text = "Tag";
            this.AddTag.UseVisualStyleBackColor = true;
            // 
            // tagsList
            // 
            this.tagsList.AutoSize = true;
            this.tagsList.Location = new System.Drawing.Point(14, 218);
            this.tagsList.MaximumSize = new System.Drawing.Size(398, 286);
            this.tagsList.Name = "tagsList";
            this.tagsList.Size = new System.Drawing.Size(80, 13);
            this.tagsList.TabIndex = 6;
            this.tagsList.Text = "Available Tags:";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "TagName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 215);
            this.comboBox1.MaximumSize = new System.Drawing.Size(398, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "TagName";
            // 
            // concordationDataSet
            // 
            this.concordationDataSet.DataSetName = "ConcordationDataSet";
            this.concordationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wordRelationsBindingSource
            // 
            this.wordRelationsBindingSource.DataMember = "WordRelations";
            this.wordRelationsBindingSource.DataSource = this.concordationDataSet;
            // 
            // wordRelationsTableAdapter
            // 
            this.wordRelationsTableAdapter.ClearBeforeFill = true;
            // 
            // WordRelationsGrid
            // 
            this.WordRelationsGrid.AutoGenerateColumns = false;
            this.WordRelationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WordRelationsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordDataGridViewTextBoxColumn,
            this.relationNameDataGridViewTextBoxColumn,
            this.word1DataGridViewTextBoxColumn});
            this.WordRelationsGrid.DataSource = this.getRelationsOfWordResultBindingSource;
            this.WordRelationsGrid.Location = new System.Drawing.Point(13, 13);
            this.WordRelationsGrid.Name = "WordRelationsGrid";
            this.WordRelationsGrid.Size = new System.Drawing.Size(240, 150);
            this.WordRelationsGrid.TabIndex = 9;
            // 
            // getRelationsOfWordResultBindingSource
            // 
            this.getRelationsOfWordResultBindingSource.DataSource = typeof(concordanceapConcordationDataSetTableAdaptersp.getRelationsOfWordResult);
            // 
            // wordDataGridViewTextBoxColumn
            // 
            this.wordDataGridViewTextBoxColumn.DataPropertyName = "Word";
            this.wordDataGridViewTextBoxColumn.HeaderText = "Word";
            this.wordDataGridViewTextBoxColumn.Name = "wordDataGridViewTextBoxColumn";
            // 
            // relationNameDataGridViewTextBoxColumn
            // 
            this.relationNameDataGridViewTextBoxColumn.DataPropertyName = "RelationName";
            this.relationNameDataGridViewTextBoxColumn.HeaderText = "RelationName";
            this.relationNameDataGridViewTextBoxColumn.Name = "relationNameDataGridViewTextBoxColumn";
            // 
            // word1DataGridViewTextBoxColumn
            // 
            this.word1DataGridViewTextBoxColumn.DataPropertyName = "Word1";
            this.word1DataGridViewTextBoxColumn.HeaderText = "Word1";
            this.word1DataGridViewTextBoxColumn.Name = "word1DataGridViewTextBoxColumn";
            // 
            // WordRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 248);
            this.Controls.Add(this.WordRelationsGrid);
            this.Controls.Add(this.AddTaglnk);
            this.Controls.Add(this.AddTag);
            this.Controls.Add(this.tagsList);
            this.Controls.Add(this.comboBox1);
            this.MaximumSize = new System.Drawing.Size(398, 286);
            this.MinimumSize = new System.Drawing.Size(398, 286);
            this.Name = "WordRelation";
            this.Text = "WordRelation";
            this.Load += new System.EventHandler(this.WordRelation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordRelationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WordRelationsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRelationsOfWordResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel AddTaglnk;
        private System.Windows.Forms.Button AddTag;
        private System.Windows.Forms.Label tagsList;
        private System.Windows.Forms.ComboBox comboBox1;
        private ConcordationDataSet concordationDataSet;
        private System.Windows.Forms.BindingSource wordRelationsBindingSource;
        private ConcordationDataSetTableAdapters.WordRelationsTableAdapter wordRelationsTableAdapter;
        private System.Windows.Forms.DataGridView WordRelationsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn word1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getRelationsOfWordResultBindingSource;
    }
}