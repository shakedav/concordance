namespace concordanceapConcordationDataSetTableAdaptersp
{
    partial class RelateWords
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
            this.Word1lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Word1Box = new System.Windows.Forms.ComboBox();
            this.wordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concordationDataSet = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSet();
            this.RelationBox = new System.Windows.Forms.ComboBox();
            this.relationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Word2Box = new System.Windows.Forms.ComboBox();
            this.wordsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wordsTableAdapter = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSetTableAdapters.WordsTableAdapter();
            this.relationsTableAdapter = new concordanceapConcordationDataSetTableAdaptersp.ConcordationDataSetTableAdapters.RelationsTableAdapter();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.Direction = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Word1lbl
            // 
            this.Word1lbl.AutoSize = true;
            this.Word1lbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Word1lbl.Location = new System.Drawing.Point(12, 9);
            this.Word1lbl.Name = "Word1lbl";
            this.Word1lbl.Size = new System.Drawing.Size(64, 16);
            this.Word1lbl.TabIndex = 0;
            this.Word1lbl.Text = "Word #1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relation Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Word #2:";
            // 
            // Word1Box
            // 
            this.Word1Box.DataSource = this.wordsBindingSource;
            this.Word1Box.DisplayMember = "Word";
            this.Word1Box.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Word1Box.FormattingEnabled = true;
            this.Word1Box.Location = new System.Drawing.Point(115, 9);
            this.Word1Box.Name = "Word1Box";
            this.Word1Box.Size = new System.Drawing.Size(121, 21);
            this.Word1Box.TabIndex = 3;
            this.Word1Box.ValueMember = "Word";
            // 
            // wordsBindingSource
            // 
            this.wordsBindingSource.DataMember = "Words";
            this.wordsBindingSource.DataSource = this.concordationDataSet;
            // 
            // concordationDataSet
            // 
            this.concordationDataSet.DataSetName = "ConcordationDataSet";
            this.concordationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RelationBox
            // 
            this.RelationBox.DataSource = this.relationsBindingSource;
            this.RelationBox.DisplayMember = "RelationName";
            this.RelationBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RelationBox.FormattingEnabled = true;
            this.RelationBox.Location = new System.Drawing.Point(115, 38);
            this.RelationBox.Name = "RelationBox";
            this.RelationBox.Size = new System.Drawing.Size(121, 21);
            this.RelationBox.TabIndex = 4;
            this.RelationBox.ValueMember = "RelationName";
            this.RelationBox.Enter += new System.EventHandler(this.RelationBox_Enter);
            // 
            // relationsBindingSource
            // 
            this.relationsBindingSource.DataMember = "Relations";
            this.relationsBindingSource.DataSource = this.concordationDataSet;
            // 
            // Word2Box
            // 
            this.Word2Box.DataSource = this.wordsBindingSource1;
            this.Word2Box.DisplayMember = "Word";
            this.Word2Box.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Word2Box.FormattingEnabled = true;
            this.Word2Box.Location = new System.Drawing.Point(115, 65);
            this.Word2Box.Name = "Word2Box";
            this.Word2Box.Size = new System.Drawing.Size(121, 21);
            this.Word2Box.TabIndex = 5;
            this.Word2Box.ValueMember = "Word";
            // 
            // wordsBindingSource1
            // 
            this.wordsBindingSource1.DataMember = "Words";
            this.wordsBindingSource1.DataSource = this.concordationDataSet;
            // 
            // wordsTableAdapter
            // 
            this.wordsTableAdapter.ClearBeforeFill = true;
            // 
            // relationsTableAdapter
            // 
            this.relationsTableAdapter.ClearBeforeFill = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(242, 41);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add New Relation";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save Relation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Direction
            // 
            this.Direction.AutoSize = true;
            this.Direction.Location = new System.Drawing.Point(115, 96);
            this.Direction.Name = "Direction";
            this.Direction.Size = new System.Drawing.Size(88, 17);
            this.Direction.TabIndex = 8;
            this.Direction.Text = "Bi-Directional";
            this.Direction.UseVisualStyleBackColor = true;
            // 
            // RelateWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 125);
            this.Controls.Add(this.Direction);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Word2Box);
            this.Controls.Add(this.RelationBox);
            this.Controls.Add(this.Word1Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Word1lbl);
            this.Name = "RelateWords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelateWords";
            this.Load += new System.EventHandler(this.RelateWords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concordationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Word1lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Word1Box;
        private System.Windows.Forms.ComboBox RelationBox;
        private System.Windows.Forms.ComboBox Word2Box;
        private ConcordationDataSet concordationDataSet;
        private System.Windows.Forms.BindingSource wordsBindingSource;
        private ConcordationDataSetTableAdapters.WordsTableAdapter wordsTableAdapter;
        private System.Windows.Forms.BindingSource relationsBindingSource;
        private ConcordationDataSetTableAdapters.RelationsTableAdapter relationsTableAdapter;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox Direction;
        private System.Windows.Forms.BindingSource wordsBindingSource1;
    }
}