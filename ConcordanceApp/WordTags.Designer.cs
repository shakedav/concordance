namespace concordanceapConcordationDataSetTableAdaptersp
{
    partial class WordTags
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
            this.Tags = new System.Windows.Forms.DataGridView();
            this.tagNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getTagsofWordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concordationDataSet = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSet();
            this.getTagsofWordTableAdapter = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSetTableAdapters.GetTagsofWordTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagsList = new System.Windows.Forms.Label();
            this.AddTag = new System.Windows.Forms.Button();
            this.AddTaglnk = new System.Windows.Forms.LinkLabel();
            this.tagsTableAdapter = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSetTableAdapters.TagsTableAdapter();
            this.Removebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTagsofWordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Tags
            // 
            this.Tags.AllowUserToAddRows = false;
            this.Tags.AllowUserToDeleteRows = false;
            this.Tags.AutoGenerateColumns = false;
            this.Tags.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Tags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagNameDataGridViewTextBoxColumn});
            this.Tags.DataSource = this.getTagsofWordBindingSource;
            this.Tags.Location = new System.Drawing.Point(12, 12);
            this.Tags.Name = "Tags";
            this.Tags.ReadOnly = true;
            this.Tags.Size = new System.Drawing.Size(475, 194);
            this.Tags.TabIndex = 0;
            // 
            // tagNameDataGridViewTextBoxColumn
            // 
            this.tagNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tagNameDataGridViewTextBoxColumn.DataPropertyName = "TagName";
            this.tagNameDataGridViewTextBoxColumn.HeaderText = "TagName";
            this.tagNameDataGridViewTextBoxColumn.Name = "tagNameDataGridViewTextBoxColumn";
            this.tagNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getTagsofWordBindingSource
            // 
            this.getTagsofWordBindingSource.DataMember = "GetTagsofWord";
            this.getTagsofWordBindingSource.DataSource = this.concordationDataSet;
            // 
            // concordationDataSet
            // 
            this.concordationDataSet.DataSetName = "ConcordationDataSet";
            this.concordationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getTagsofWordTableAdapter
            // 
            this.getTagsofWordTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tagsBindingSource;
            this.comboBox1.DisplayMember = "TagName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "TagName";
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            // 
            // tagsBindingSource
            // 
            this.tagsBindingSource.DataMember = "Tags";
            this.tagsBindingSource.DataSource = this.concordationDataSet;
            // 
            // tagsList
            // 
            this.tagsList.AutoSize = true;
            this.tagsList.Location = new System.Drawing.Point(13, 215);
            this.tagsList.Name = "tagsList";
            this.tagsList.Size = new System.Drawing.Size(80, 13);
            this.tagsList.TabIndex = 2;
            this.tagsList.Text = "Available Tags:";
            // 
            // AddTag
            // 
            this.AddTag.Location = new System.Drawing.Point(309, 210);
            this.AddTag.Name = "AddTag";
            this.AddTag.Size = new System.Drawing.Size(86, 23);
            this.AddTag.TabIndex = 3;
            this.AddTag.Text = "Tag Word";
            this.AddTag.UseVisualStyleBackColor = true;
            this.AddTag.Click += new System.EventHandler(this.AddTag_Click);
            // 
            // AddTaglnk
            // 
            this.AddTaglnk.AutoSize = true;
            this.AddTaglnk.Location = new System.Drawing.Point(220, 215);
            this.AddTaglnk.Name = "AddTaglnk";
            this.AddTaglnk.Size = new System.Drawing.Size(83, 13);
            this.AddTaglnk.TabIndex = 4;
            this.AddTaglnk.TabStop = true;
            this.AddTaglnk.Text = "Add A New Tag";
            this.AddTaglnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddTaglnk_LinkClicked);
            // 
            // tagsTableAdapter
            // 
            this.tagsTableAdapter.ClearBeforeFill = true;
            // 
            // Removebtn
            // 
            this.Removebtn.Location = new System.Drawing.Point(401, 210);
            this.Removebtn.Name = "Removebtn";
            this.Removebtn.Size = new System.Drawing.Size(86, 23);
            this.Removebtn.TabIndex = 5;
            this.Removebtn.Text = "Remove Tag";
            this.Removebtn.UseVisualStyleBackColor = true;
            this.Removebtn.Click += new System.EventHandler(this.Removebtn_Click);
            // 
            // WordTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 248);
            this.Controls.Add(this.Removebtn);
            this.Controls.Add(this.AddTaglnk);
            this.Controls.Add(this.AddTag);
            this.Controls.Add(this.tagsList);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Tags);
            this.Name = "WordTags";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Tags";
            this.Load += new System.EventHandler(this.WordTags_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTagsofWordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tags;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getTagsofWordBindingSource;
        private ConcordationDataSet concordationDataSet;
        private ConcordationDataSetTableAdapters.GetTagsofWordTableAdapter getTagsofWordTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label tagsList;
        private System.Windows.Forms.Button AddTag;
        private System.Windows.Forms.LinkLabel AddTaglnk;
        private System.Windows.Forms.BindingSource tagsBindingSource;
        private ConcordationDataSetTableAdapters.TagsTableAdapter tagsTableAdapter;
        private System.Windows.Forms.Button Removebtn;
    }
}