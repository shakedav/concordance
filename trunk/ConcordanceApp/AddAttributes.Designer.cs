namespace concordanceapConcordationDataSetTableAdaptersp
{
    partial class AddAttributes
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
            this.AttNames = new System.Windows.Forms.ComboBox();
            this.getTypeAttsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getDocAttrsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AttName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NewAttrlnk = new System.Windows.Forms.LinkLabel();
            this.concordationDataSet = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSet();
            this.attributeTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attributeTypesTableAdapter = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSetTableAdapters.AttributeTypesTableAdapter();
            this.AttValtxt = new System.Windows.Forms.TextBox();
            this.SaveAtt = new System.Windows.Forms.Button();
            this.CurrentAttrs = new System.Windows.Forms.DataGridView();
            this.getExistingAttsfordocResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attributeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.getTypeAttsResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDocAttrsResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributeTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentAttrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExistingAttsfordocResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AttNames
            // 
            this.AttNames.DataSource = this.getTypeAttsResultBindingSource;
            this.AttNames.DisplayMember = "AttName";
            this.AttNames.FormattingEnabled = true;
            this.AttNames.Location = new System.Drawing.Point(98, 3);
            this.AttNames.Name = "AttNames";
            this.AttNames.Size = new System.Drawing.Size(121, 21);
            this.AttNames.TabIndex = 0;
            this.AttNames.ValueMember = "AttName";
            // 
            // getTypeAttsResultBindingSource
            // 
            this.getTypeAttsResultBindingSource.DataSource = typeof(concordanceapConcordationDataSetTableAdaptersp.GetTypeAttsResult);
            // 
            // getDocAttrsResultBindingSource
            // 
            this.getDocAttrsResultBindingSource.DataSource = typeof(concordanceapConcordationDataSetTableAdaptersp.GetDocAttrsResult);
            // 
            // AttName
            // 
            this.AttName.AutoSize = true;
            this.AttName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AttName.Location = new System.Drawing.Point(12, 9);
            this.AttName.Name = "AttName";
            this.AttName.Size = new System.Drawing.Size(80, 13);
            this.AttName.TabIndex = 1;
            this.AttName.Text = "Attribute Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Attribute Value";
            // 
            // NewAttrlnk
            // 
            this.NewAttrlnk.ActiveLinkColor = System.Drawing.Color.Blue;
            this.NewAttrlnk.AutoSize = true;
            this.NewAttrlnk.Location = new System.Drawing.Point(226, 9);
            this.NewAttrlnk.Name = "NewAttrlnk";
            this.NewAttrlnk.Size = new System.Drawing.Size(93, 13);
            this.NewAttrlnk.TabIndex = 3;
            this.NewAttrlnk.TabStop = true;
            this.NewAttrlnk.Text = "Add New Attribute";
            this.NewAttrlnk.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // concordationDataSet
            // 
            this.concordationDataSet.DataSetName = "ConcordationDataSet";
            this.concordationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attributeTypesBindingSource
            // 
            this.attributeTypesBindingSource.DataMember = "AttributeTypes";
            this.attributeTypesBindingSource.DataSource = this.concordationDataSet;
            // 
            // attributeTypesTableAdapter
            // 
            this.attributeTypesTableAdapter.ClearBeforeFill = true;
            // 
            // AttValtxt
            // 
            this.AttValtxt.Location = new System.Drawing.Point(97, 30);
            this.AttValtxt.Name = "AttValtxt";
            this.AttValtxt.Size = new System.Drawing.Size(121, 20);
            this.AttValtxt.TabIndex = 4;
            // 
            // SaveAtt
            // 
            this.SaveAtt.Location = new System.Drawing.Point(143, 56);
            this.SaveAtt.Name = "SaveAtt";
            this.SaveAtt.Size = new System.Drawing.Size(75, 23);
            this.SaveAtt.TabIndex = 5;
            this.SaveAtt.Text = "Save Attribute";
            this.SaveAtt.UseVisualStyleBackColor = true;
            this.SaveAtt.Click += new System.EventHandler(this.SaveAtt_Click);
            // 
            // CurrentAttrs
            // 
            this.CurrentAttrs.AllowUserToAddRows = false;
            this.CurrentAttrs.AllowUserToDeleteRows = false;
            this.CurrentAttrs.AutoGenerateColumns = false;
            this.CurrentAttrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentAttrs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attributeNameDataGridViewTextBoxColumn,
            this.attributeDataGridViewTextBoxColumn});
            this.CurrentAttrs.DataSource = this.getExistingAttsfordocResultBindingSource;
            this.CurrentAttrs.Location = new System.Drawing.Point(13, 90);
            this.CurrentAttrs.Name = "CurrentAttrs";
            this.CurrentAttrs.ReadOnly = true;
            this.CurrentAttrs.Size = new System.Drawing.Size(472, 150);
            this.CurrentAttrs.TabIndex = 6;
            // 
            // getExistingAttsfordocResultBindingSource
            // 
            this.getExistingAttsfordocResultBindingSource.DataSource = typeof(concordanceapConcordationDataSetTableAdaptersp.GetExistingAttsfordocResult);
            // 
            // attributeNameDataGridViewTextBoxColumn
            // 
            this.attributeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.attributeNameDataGridViewTextBoxColumn.DataPropertyName = "Attribute_Name";
            this.attributeNameDataGridViewTextBoxColumn.HeaderText = "Attribute Name";
            this.attributeNameDataGridViewTextBoxColumn.Name = "attributeNameDataGridViewTextBoxColumn";
            this.attributeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attributeDataGridViewTextBoxColumn
            // 
            this.attributeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.attributeDataGridViewTextBoxColumn.DataPropertyName = "Attribute";
            this.attributeDataGridViewTextBoxColumn.HeaderText = "Attribute Value";
            this.attributeDataGridViewTextBoxColumn.Name = "attributeDataGridViewTextBoxColumn";
            this.attributeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AddAttributes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 294);
            this.Controls.Add(this.CurrentAttrs);
            this.Controls.Add(this.SaveAtt);
            this.Controls.Add(this.AttValtxt);
            this.Controls.Add(this.NewAttrlnk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AttName);
            this.Controls.Add(this.AttNames);
            this.Name = "AddAttributes";
            this.Text = "Add Attributes";
            this.Load += new System.EventHandler(this.AddAttributes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getTypeAttsResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDocAttrsResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributeTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentAttrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExistingAttsfordocResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AttNames;
        private System.Windows.Forms.Label AttName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel NewAttrlnk;
        private ConcordationDataSet concordationDataSet;
        private System.Windows.Forms.BindingSource attributeTypesBindingSource;
        private ConcordationDataSetTableAdapters.AttributeTypesTableAdapter attributeTypesTableAdapter;
        private System.Windows.Forms.BindingSource getDocAttrsResultBindingSource;
        private System.Windows.Forms.TextBox AttValtxt;
        private System.Windows.Forms.Button SaveAtt;
        private System.Windows.Forms.DataGridView CurrentAttrs;
        private System.Windows.Forms.BindingSource getTypeAttsResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getExistingAttsfordocResultBindingSource;
    }
}