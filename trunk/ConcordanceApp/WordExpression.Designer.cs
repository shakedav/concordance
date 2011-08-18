﻿namespace concordanceapConcordationDataSetTableAdaptersp
{
    partial class WordExpression
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
            this.concordationDataSet = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSet();
            this.expressionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expressionsTableAdapter = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSetTableAdapters.ExpressionsTableAdapter();
            this.WordExpressionDG = new System.Windows.Forms.DataGridView();
            this.expressionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getExpressionsOfWordResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expressionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WordExpressionDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExpressionsOfWordResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // concordationDataSet
            // 
            this.concordationDataSet.DataSetName = "ConcordationDataSet";
            this.concordationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expressionsBindingSource
            // 
            this.expressionsBindingSource.DataMember = "Expressions";
            this.expressionsBindingSource.DataSource = this.concordationDataSet;
            // 
            // expressionsTableAdapter
            // 
            this.expressionsTableAdapter.ClearBeforeFill = true;
            // 
            // WordExpressionDG
            // 
            this.WordExpressionDG.AllowUserToAddRows = false;
            this.WordExpressionDG.AllowUserToDeleteRows = false;
            this.WordExpressionDG.AutoGenerateColumns = false;
            this.WordExpressionDG.BackgroundColor = System.Drawing.SystemColors.Control;
            this.WordExpressionDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WordExpressionDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expressionDataGridViewTextBoxColumn});
            this.WordExpressionDG.DataSource = this.getExpressionsOfWordResultBindingSource;
            this.WordExpressionDG.Location = new System.Drawing.Point(13, 13);
            this.WordExpressionDG.Name = "WordExpressionDG";
            this.WordExpressionDG.ReadOnly = true;
            this.WordExpressionDG.Size = new System.Drawing.Size(390, 204);
            this.WordExpressionDG.TabIndex = 0;
            // 
            // expressionDataGridViewTextBoxColumn
            // 
            this.expressionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.expressionDataGridViewTextBoxColumn.DataPropertyName = "Expression";
            this.expressionDataGridViewTextBoxColumn.HeaderText = "Expression";
            this.expressionDataGridViewTextBoxColumn.Name = "expressionDataGridViewTextBoxColumn";
            this.expressionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getExpressionsOfWordResultBindingSource
            // 
            this.getExpressionsOfWordResultBindingSource.DataSource = typeof(concordanceapConcordationDataSetTableAdaptersp.GetExpressionsOfWordResult);
            // 
            // WordExpression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 234);
            this.Controls.Add(this.WordExpressionDG);
            this.Name = "WordExpression";
            this.Text = "Word Expression";
            this.Load += new System.EventHandler(this.WordExpression_Load);
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expressionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WordExpressionDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getExpressionsOfWordResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ConcordationDataSet concordationDataSet;
        private System.Windows.Forms.BindingSource expressionsBindingSource;
        private ConcordationDataSetTableAdapters.ExpressionsTableAdapter expressionsTableAdapter;
        private System.Windows.Forms.DataGridView WordExpressionDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn expressionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getExpressionsOfWordResultBindingSource;
    }
}