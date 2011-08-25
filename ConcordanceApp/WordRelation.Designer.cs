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
            this.WordRelationsGrid = new System.Windows.Forms.DataGridView();
            this.word1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.word2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getRelationsOfWordResultBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.getRelationsOfWordResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concordationDataSet = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSet();
            this.relationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relationsTableAdapter = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSetTableAdapters.RelationsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.WordRelationsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRelationsOfWordResultBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRelationsOfWordResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTaglnk
            // 
            this.AddTaglnk.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.AddTaglnk.AutoSize = true;
            this.AddTaglnk.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTaglnk.LinkColor = System.Drawing.Color.DodgerBlue;
            this.AddTaglnk.Location = new System.Drawing.Point(14, 218);
            this.AddTaglnk.MaximumSize = new System.Drawing.Size(464, 286);
            this.AddTaglnk.Name = "AddTaglnk";
            this.AddTaglnk.Size = new System.Drawing.Size(119, 13);
            this.AddTaglnk.TabIndex = 8;
            this.AddTaglnk.TabStop = true;
            this.AddTaglnk.Text = "Add A New Relation";
            this.AddTaglnk.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.AddTaglnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddTaglnk_LinkClicked);
            // 
            // WordRelationsGrid
            // 
            this.WordRelationsGrid.AllowUserToAddRows = false;
            this.WordRelationsGrid.AllowUserToDeleteRows = false;
            this.WordRelationsGrid.AutoGenerateColumns = false;
            this.WordRelationsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.WordRelationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WordRelationsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.word1DataGridViewTextBoxColumn,
            this.RelationName,
            this.word2});
            this.WordRelationsGrid.DataSource = this.getRelationsOfWordResultBindingSource1;
            this.WordRelationsGrid.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordRelationsGrid.Location = new System.Drawing.Point(15, 13);
            this.WordRelationsGrid.Name = "WordRelationsGrid";
            this.WordRelationsGrid.ReadOnly = true;
            this.WordRelationsGrid.Size = new System.Drawing.Size(506, 194);
            this.WordRelationsGrid.TabIndex = 9;
            // 
            // word1DataGridViewTextBoxColumn
            // 
            this.word1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.word1DataGridViewTextBoxColumn.DataPropertyName = "word1";
            this.word1DataGridViewTextBoxColumn.HeaderText = "Word";
            this.word1DataGridViewTextBoxColumn.Name = "word1DataGridViewTextBoxColumn";
            this.word1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RelationName
            // 
            this.RelationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RelationName.DataPropertyName = "RelationName";
            this.RelationName.HeaderText = "Relation";
            this.RelationName.Name = "RelationName";
            this.RelationName.ReadOnly = true;
            // 
            // word2
            // 
            this.word2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.word2.DataPropertyName = "word2";
            this.word2.HeaderText = "Word";
            this.word2.Name = "word2";
            this.word2.ReadOnly = true;
            // 
            // getRelationsOfWordResultBindingSource1
            // 
            this.getRelationsOfWordResultBindingSource1.DataSource = typeof(concordanceapConcordationDataSetTableAdaptersp.getRelationsOfWordResult);
            // 
            // getRelationsOfWordResultBindingSource
            // 
            this.getRelationsOfWordResultBindingSource.DataSource = typeof(concordanceapConcordationDataSetTableAdaptersp.getRelationsOfWordResult);
            // 
            // concordationDataSet
            // 
            this.concordationDataSet.DataSetName = "ConcordationDataSet";
            this.concordationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relationsBindingSource
            // 
            this.relationsBindingSource.DataMember = "Relations";
            this.relationsBindingSource.DataSource = this.concordationDataSet;
            // 
            // relationsTableAdapter
            // 
            this.relationsTableAdapter.ClearBeforeFill = true;
            // 
            // WordRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 281);
            this.Controls.Add(this.WordRelationsGrid);
            this.Controls.Add(this.AddTaglnk);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.MinimumSize = new System.Drawing.Size(486, 319);
            this.Name = "WordRelation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Relations";
            this.Load += new System.EventHandler(this.WordRelation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WordRelationsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRelationsOfWordResultBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRelationsOfWordResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel AddTaglnk;
        private System.Windows.Forms.DataGridView WordRelationsGrid;
        private System.Windows.Forms.BindingSource getRelationsOfWordResultBindingSource;
        private ConcordationDataSet concordationDataSet;
        private System.Windows.Forms.BindingSource relationsBindingSource;
        private ConcordationDataSetTableAdapters.RelationsTableAdapter relationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn word1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RelationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn word2;
        private System.Windows.Forms.BindingSource getRelationsOfWordResultBindingSource1;
    }
}