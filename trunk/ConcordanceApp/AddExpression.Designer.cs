namespace concordanceapConcordationDataSetTableAdaptersp
{
    partial class AddExpression
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
            this.expressionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concordationDataSet = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSet();
            this.expressionsTableAdapter = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSetTableAdapters.ExpressionsTableAdapter();
            this.AddExpressionlbl = new System.Windows.Forms.Label();
            this.Expressiontxt = new System.Windows.Forms.TextBox();
            this.Expressionbtn = new System.Windows.Forms.Button();
            this.ExpressionsGrid = new System.Windows.Forms.DataGridView();
            this.expressionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getExpressionsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Deletebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.expressionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpressionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExpressionsResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // expressionsBindingSource
            // 
            this.expressionsBindingSource.DataMember = "Expressions";
            this.expressionsBindingSource.DataSource = this.concordationDataSet;
            // 
            // concordationDataSet
            // 
            this.concordationDataSet.DataSetName = "ConcordationDataSet";
            this.concordationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expressionsTableAdapter
            // 
            this.expressionsTableAdapter.ClearBeforeFill = true;
            // 
            // AddExpressionlbl
            // 
            this.AddExpressionlbl.AutoSize = true;
            this.AddExpressionlbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddExpressionlbl.Location = new System.Drawing.Point(10, 205);
            this.AddExpressionlbl.Name = "AddExpressionlbl";
            this.AddExpressionlbl.Size = new System.Drawing.Size(63, 13);
            this.AddExpressionlbl.TabIndex = 1;
            this.AddExpressionlbl.Text = "Expression:";
            // 
            // Expressiontxt
            // 
            this.Expressiontxt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Expressiontxt.Location = new System.Drawing.Point(79, 202);
            this.Expressiontxt.Name = "Expressiontxt";
            this.Expressiontxt.Size = new System.Drawing.Size(100, 21);
            this.Expressiontxt.TabIndex = 2;
            // 
            // Expressionbtn
            // 
            this.Expressionbtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Expressionbtn.Location = new System.Drawing.Point(185, 200);
            this.Expressionbtn.Name = "Expressionbtn";
            this.Expressionbtn.Size = new System.Drawing.Size(100, 23);
            this.Expressionbtn.TabIndex = 3;
            this.Expressionbtn.Text = "Save Expression";
            this.Expressionbtn.UseVisualStyleBackColor = true;
            this.Expressionbtn.Click += new System.EventHandler(this.Expressionbtn_Click);
            // 
            // ExpressionsGrid
            // 
            this.ExpressionsGrid.AllowUserToAddRows = false;
            this.ExpressionsGrid.AllowUserToDeleteRows = false;
            this.ExpressionsGrid.AutoGenerateColumns = false;
            this.ExpressionsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ExpressionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpressionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expressionDataGridViewTextBoxColumn});
            this.ExpressionsGrid.DataSource = this.getExpressionsResultBindingSource;
            this.ExpressionsGrid.Location = new System.Drawing.Point(13, 13);
            this.ExpressionsGrid.Name = "ExpressionsGrid";
            this.ExpressionsGrid.ReadOnly = true;
            this.ExpressionsGrid.Size = new System.Drawing.Size(479, 173);
            this.ExpressionsGrid.TabIndex = 0;
            this.ExpressionsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpressionsGrid_CellDoubleClick);
            // 
            // expressionDataGridViewTextBoxColumn
            // 
            this.expressionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.expressionDataGridViewTextBoxColumn.DataPropertyName = "expression";
            this.expressionDataGridViewTextBoxColumn.HeaderText = "Expression";
            this.expressionDataGridViewTextBoxColumn.Name = "expressionDataGridViewTextBoxColumn";
            this.expressionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getExpressionsResultBindingSource
            // 
            this.getExpressionsResultBindingSource.DataSource = typeof(concordanceapConcordationDataSetTableAdaptersp.GetExpressionsResult);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Deletebtn.Location = new System.Drawing.Point(291, 200);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(112, 23);
            this.Deletebtn.TabIndex = 4;
            this.Deletebtn.Text = "Delete Expression";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // AddExpression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 262);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Expressionbtn);
            this.Controls.Add(this.Expressiontxt);
            this.Controls.Add(this.AddExpressionlbl);
            this.Controls.Add(this.ExpressionsGrid);
            this.Name = "AddExpression";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Delete Expression";
            this.Load += new System.EventHandler(this.AddExpression_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expressionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpressionsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExpressionsResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConcordationDataSet concordationDataSet;
        private System.Windows.Forms.BindingSource expressionsBindingSource;
        private ConcordationDataSetTableAdapters.ExpressionsTableAdapter expressionsTableAdapter;
        private System.Windows.Forms.Label AddExpressionlbl;
        private System.Windows.Forms.TextBox Expressiontxt;
        private System.Windows.Forms.Button Expressionbtn;
        private System.Windows.Forms.DataGridView ExpressionsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn expressionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getExpressionsResultBindingSource;
        private System.Windows.Forms.Button Deletebtn;
    }
}