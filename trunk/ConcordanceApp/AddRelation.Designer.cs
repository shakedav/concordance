namespace concordanceapConcordationDataSetTableAdaptersp
{
    partial class AddRelation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.relationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concordationDataSet = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSet();
            this.relationsTableAdapter = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSetTableAdapters.RelationsTableAdapter();
            this.AddRelationlbl = new System.Windows.Forms.Label();
            this.AddRelationbtn = new System.Windows.Forms.Button();
            this.AddRelationTxtBox = new System.Windows.Forms.TextBox();
            this.Deletebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.relationNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.relationsBindingSource;
            this.dataGridView1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.Location = new System.Drawing.Point(15, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(476, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // relationNameDataGridViewTextBoxColumn
            // 
            this.relationNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.relationNameDataGridViewTextBoxColumn.DataPropertyName = "RelationName";
            this.relationNameDataGridViewTextBoxColumn.HeaderText = "Relation Name";
            this.relationNameDataGridViewTextBoxColumn.Name = "relationNameDataGridViewTextBoxColumn";
            this.relationNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // relationsBindingSource
            // 
            this.relationsBindingSource.DataMember = "Relations";
            this.relationsBindingSource.DataSource = this.concordationDataSet;
            // 
            // concordationDataSet
            // 
            this.concordationDataSet.DataSetName = "ConcordationDataSet";
            this.concordationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relationsTableAdapter
            // 
            this.relationsTableAdapter.ClearBeforeFill = true;
            // 
            // AddRelationlbl
            // 
            this.AddRelationlbl.AutoSize = true;
            this.AddRelationlbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRelationlbl.Location = new System.Drawing.Point(15, 289);
            this.AddRelationlbl.Name = "AddRelationlbl";
            this.AddRelationlbl.Size = new System.Drawing.Size(95, 13);
            this.AddRelationlbl.TabIndex = 1;
            this.AddRelationlbl.Text = "Relation Name:";
            // 
            // AddRelationbtn
            // 
            this.AddRelationbtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRelationbtn.Location = new System.Drawing.Point(257, 286);
            this.AddRelationbtn.Name = "AddRelationbtn";
            this.AddRelationbtn.Size = new System.Drawing.Size(101, 38);
            this.AddRelationbtn.TabIndex = 5;
            this.AddRelationbtn.Text = "Add Relation";
            this.AddRelationbtn.UseVisualStyleBackColor = true;
            this.AddRelationbtn.Click += new System.EventHandler(this.AddRelationbtn_Click);
            // 
            // AddRelationTxtBox
            // 
            this.AddRelationTxtBox.Location = new System.Drawing.Point(133, 286);
            this.AddRelationTxtBox.Name = "AddRelationTxtBox";
            this.AddRelationTxtBox.Size = new System.Drawing.Size(116, 21);
            this.AddRelationTxtBox.TabIndex = 4;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(365, 286);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(107, 38);
            this.Deletebtn.TabIndex = 6;
            this.Deletebtn.Text = "Delete Relation";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // AddRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 336);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.AddRelationbtn);
            this.Controls.Add(this.AddRelationTxtBox);
            this.Controls.Add(this.AddRelationlbl);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.MaximumSize = new System.Drawing.Size(521, 374);
            this.MinimumSize = new System.Drawing.Size(521, 374);
            this.Name = "AddRelation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Delete Word Relations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddRelation_FormClosed);
            this.Load += new System.EventHandler(this.AddRelation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ConcordationDataSet concordationDataSet;
        private System.Windows.Forms.BindingSource relationsBindingSource;
        private ConcordationDataSetTableAdapters.RelationsTableAdapter relationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label AddRelationlbl;
        private System.Windows.Forms.Button AddRelationbtn;
        private System.Windows.Forms.TextBox AddRelationTxtBox;
        private System.Windows.Forms.Button Deletebtn;
        
    }
}