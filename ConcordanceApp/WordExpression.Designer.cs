namespace concordanceapConcordationDataSetTableAdaptersp
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
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expressionsBindingSource)).BeginInit();
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
            // WordExpression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 286);
            this.Name = "WordExpression";
            this.Text = "Word Expression";
            this.Load += new System.EventHandler(this.WordExpression_Load);
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expressionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ConcordationDataSet concordationDataSet;
        private System.Windows.Forms.BindingSource expressionsBindingSource;
        private ConcordationDataSetTableAdapters.ExpressionsTableAdapter expressionsTableAdapter;
    }
}