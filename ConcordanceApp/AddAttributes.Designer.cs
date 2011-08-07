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
            this.AttName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NewAttrlnk = new System.Windows.Forms.LinkLabel();
            this.concordationDataSet = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSet();
            this.attributeTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attributeTypesTableAdapter = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSetTableAdapters.AttributeTypesTableAdapter();
            this.getDocAttrsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributeTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDocAttrsResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AttNames
            // 
            this.AttNames.DataSource = this.getDocAttrsResultBindingSource;
            this.AttNames.DisplayMember = "AttName";
            this.AttNames.FormattingEnabled = true;
            this.AttNames.Location = new System.Drawing.Point(98, 3);
            this.AttNames.Name = "AttNames";
            this.AttNames.Size = new System.Drawing.Size(121, 21);
            this.AttNames.TabIndex = 0;
            this.AttNames.ValueMember = "AttName";
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
            // getDocAttrsResultBindingSource
            // 
            this.getDocAttrsResultBindingSource.DataSource = typeof(concordanceapConcordationDataSetTableAdaptersp.GetDocAttrsResult);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save Attribute";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // AddAttributes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 294);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NewAttrlnk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AttName);
            this.Controls.Add(this.AttNames);
            this.Name = "AddAttributes";
            this.Text = "AddAttributes";
            this.Load += new System.EventHandler(this.AddAttributes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributeTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDocAttrsResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}