namespace concordanceapConcordationDataSetTableAdaptersp
{
    partial class AddTag
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
            this.AddTagDataGrid = new System.Windows.Forms.DataGridView();
            this.tagNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concordationDataSet = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSet();
            this.getTagsofWordResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagsTableAdapter = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSetTableAdapters.TagsTableAdapter();
            this.AddTagTagNamelbl = new System.Windows.Forms.Label();
            this.AddTagTxtBox = new System.Windows.Forms.TextBox();
            this.AddTagbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddTagDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTagsofWordResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTagDataGrid
            // 
            this.AddTagDataGrid.AllowUserToAddRows = false;
            this.AddTagDataGrid.AllowUserToDeleteRows = false;
            this.AddTagDataGrid.AutoGenerateColumns = false;
            this.AddTagDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AddTagDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddTagDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagNameDataGridViewTextBoxColumn});
            this.AddTagDataGrid.DataSource = this.tagsBindingSource;
            this.AddTagDataGrid.Location = new System.Drawing.Point(13, 13);
            this.AddTagDataGrid.Name = "AddTagDataGrid";
            this.AddTagDataGrid.ReadOnly = true;
            this.AddTagDataGrid.Size = new System.Drawing.Size(416, 271);
            this.AddTagDataGrid.TabIndex = 0;
            // 
            // tagNameDataGridViewTextBoxColumn
            // 
            this.tagNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tagNameDataGridViewTextBoxColumn.DataPropertyName = "TagName";
            this.tagNameDataGridViewTextBoxColumn.HeaderText = "Tag Name";
            this.tagNameDataGridViewTextBoxColumn.Name = "tagNameDataGridViewTextBoxColumn";
            this.tagNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tagsBindingSource
            // 
            this.tagsBindingSource.DataMember = "Tags";
            this.tagsBindingSource.DataSource = this.concordationDataSet;
            // 
            // concordationDataSet
            // 
            this.concordationDataSet.DataSetName = "ConcordationDataSet";
            this.concordationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getTagsofWordResultBindingSource
            // 
            this.getTagsofWordResultBindingSource.DataSource = typeof(concordanceapConcordationDataSetTableAdaptersp.GetTagsofWordResult);
            // 
            // tagsTableAdapter
            // 
            this.tagsTableAdapter.ClearBeforeFill = true;
            // 
            // AddTagTagNamelbl
            // 
            this.AddTagTagNamelbl.AutoSize = true;
            this.AddTagTagNamelbl.Location = new System.Drawing.Point(12, 301);
            this.AddTagTagNamelbl.Name = "AddTagTagNamelbl";
            this.AddTagTagNamelbl.Size = new System.Drawing.Size(60, 13);
            this.AddTagTagNamelbl.TabIndex = 1;
            this.AddTagTagNamelbl.Text = "Tag Name:";
            // 
            // AddTagTxtBox
            // 
            this.AddTagTxtBox.Location = new System.Drawing.Point(78, 298);
            this.AddTagTxtBox.Name = "AddTagTxtBox";
            this.AddTagTxtBox.Size = new System.Drawing.Size(100, 20);
            this.AddTagTxtBox.TabIndex = 2;
            // 
            // AddTagbtn
            // 
            this.AddTagbtn.Location = new System.Drawing.Point(354, 290);
            this.AddTagbtn.Name = "AddTagbtn";
            this.AddTagbtn.Size = new System.Drawing.Size(75, 34);
            this.AddTagbtn.TabIndex = 3;
            this.AddTagbtn.Text = "Tag Word";
            this.AddTagbtn.UseVisualStyleBackColor = true;
            this.AddTagbtn.Click += new System.EventHandler(this.AddTagbtn_Click);
            // 
            // AddTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 336);
            this.Controls.Add(this.AddTagbtn);
            this.Controls.Add(this.AddTagTxtBox);
            this.Controls.Add(this.AddTagTagNamelbl);
            this.Controls.Add(this.AddTagDataGrid);
            this.MaximumSize = new System.Drawing.Size(449, 374);
            this.MinimumSize = new System.Drawing.Size(449, 374);
            this.Name = "AddTag";
            this.Text = "Add Tag";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTag_FormClosed);
            this.Load += new System.EventHandler(this.AddTag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddTagDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTagsofWordResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AddTagDataGrid;
        private System.Windows.Forms.BindingSource getTagsofWordResultBindingSource;
        private ConcordationDataSet concordationDataSet;
        private System.Windows.Forms.BindingSource tagsBindingSource;
        private ConcordationDataSetTableAdapters.TagsTableAdapter tagsTableAdapter;
        private System.Windows.Forms.Label AddTagTagNamelbl;
        private System.Windows.Forms.TextBox AddTagTxtBox;
        private System.Windows.Forms.Button AddTagbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagNameDataGridViewTextBoxColumn;
    }
}