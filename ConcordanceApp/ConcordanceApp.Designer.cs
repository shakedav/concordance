using System.Windows.Forms;
using System.Drawing;

namespace concordanceapConcordationDataSetTableAdaptersp 
{
    partial class ConcordanceApp
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
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.StoryCB = new System.Windows.Forms.CheckBox();
            this.SongsCB = new System.Windows.Forms.CheckBox();
            this.HLine = new System.Windows.Forms.GroupBox();
            this.VLine = new System.Windows.Forms.GroupBox();
            this.UpDocLbl = new System.Windows.Forms.LinkLabel();
            this.AddDocTypeLbl = new System.Windows.Forms.LinkLabel();
            this.AddTagLbl = new System.Windows.Forms.LinkLabel();
            this.DocumentsLbl = new System.Windows.Forms.Label();
            this.TagsLbl = new System.Windows.Forms.Label();
            this.AddRelationsLbl = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.RegularSearchGrid = new System.Windows.Forms.DataGridView();
            this.contextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextWordsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Wordtxt = new System.Windows.Forms.Label();
            this.Documents = new System.Windows.Forms.Label();
            this.ContainingDocsnum = new System.Windows.Forms.LinkLabel();
            this.TagsNum = new System.Windows.Forms.LinkLabel();
            this.Tags = new System.Windows.Forms.Label();
            this.RelationsNum = new System.Windows.Forms.LinkLabel();
            this.RelationsNumlbl = new System.Windows.Forms.Label();
            this.ExpressionsNum = new System.Windows.Forms.LinkLabel();
            this.Expressions = new System.Windows.Forms.Label();
            this.Relationslbl = new System.Windows.Forms.Label();
            this.Expressionslbl = new System.Windows.Forms.Label();
            this.AddExpression = new System.Windows.Forms.LinkLabel();
            this.ShowAllWords = new System.Windows.Forms.LinkLabel();
            this.AdvancedSearch = new System.Windows.Forms.LinkLabel();
            this.Statslbl = new System.Windows.Forms.Label();
            this.TotAppearances = new System.Windows.Forms.Label();
            this.NumOfSearchlbl = new System.Windows.Forms.Label();
            this.TotAppeartxt = new System.Windows.Forms.Label();
            this.NumOfSearchestxt = new System.Windows.Forms.Label();
            this.StatsGB = new System.Windows.Forms.GroupBox();
            this.AdvancedSearchGrid = new System.Windows.Forms.DataGridView();
            this.wordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getWordByLineAndNumResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TagSearchGrid = new System.Windows.Forms.DataGridView();
            this.wordDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getWordByTagNameResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BackupRestore = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RegularSearchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextWordsResultBindingSource)).BeginInit();
            this.StatsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdvancedSearchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getWordByLineAndNumResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TagSearchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getWordByTagNameResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(72, 12);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(95, 21);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.Text = "Word / Term";
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(14, 15);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(52, 13);
            this.SearchLabel.TabIndex = 1;
            this.SearchLabel.Text = "Search:";
            // 
            // StoryCB
            // 
            this.StoryCB.AutoSize = true;
            this.StoryCB.Location = new System.Drawing.Point(17, 38);
            this.StoryCB.Name = "StoryCB";
            this.StoryCB.Size = new System.Drawing.Size(66, 17);
            this.StoryCB.TabIndex = 3;
            this.StoryCB.Text = "Stories";
            this.StoryCB.UseVisualStyleBackColor = true;
            // 
            // SongsCB
            // 
            this.SongsCB.AutoSize = true;
            this.SongsCB.Location = new System.Drawing.Point(17, 61);
            this.SongsCB.Name = "SongsCB";
            this.SongsCB.Size = new System.Drawing.Size(61, 17);
            this.SongsCB.TabIndex = 4;
            this.SongsCB.Text = "Songs";
            this.SongsCB.UseVisualStyleBackColor = true;
            // 
            // HLine
            // 
            this.HLine.Location = new System.Drawing.Point(3, 84);
            this.HLine.Name = "HLine";
            this.HLine.Size = new System.Drawing.Size(246, 10);
            this.HLine.TabIndex = 8;
            this.HLine.TabStop = false;
            // 
            // VLine
            // 
            this.VLine.Location = new System.Drawing.Point(257, 12);
            this.VLine.Name = "VLine";
            this.VLine.Size = new System.Drawing.Size(10, 461);
            this.VLine.TabIndex = 9;
            this.VLine.TabStop = false;
            // 
            // UpDocLbl
            // 
            this.UpDocLbl.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.UpDocLbl.AutoSize = true;
            this.UpDocLbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDocLbl.LinkColor = System.Drawing.Color.DodgerBlue;
            this.UpDocLbl.Location = new System.Drawing.Point(14, 123);
            this.UpDocLbl.Name = "UpDocLbl";
            this.UpDocLbl.Size = new System.Drawing.Size(108, 13);
            this.UpDocLbl.TabIndex = 11;
            this.UpDocLbl.TabStop = true;
            this.UpDocLbl.Text = "Upload Document";
            this.UpDocLbl.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.UpDocLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UpDocLbl_LinkClicked);
            // 
            // AddDocTypeLbl
            // 
            this.AddDocTypeLbl.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.AddDocTypeLbl.AutoSize = true;
            this.AddDocTypeLbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDocTypeLbl.LinkColor = System.Drawing.Color.DodgerBlue;
            this.AddDocTypeLbl.Location = new System.Drawing.Point(14, 150);
            this.AddDocTypeLbl.Name = "AddDocTypeLbl";
            this.AddDocTypeLbl.Size = new System.Drawing.Size(123, 13);
            this.AddDocTypeLbl.TabIndex = 12;
            this.AddDocTypeLbl.TabStop = true;
            this.AddDocTypeLbl.Text = "Add Document Type";
            this.AddDocTypeLbl.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.AddDocTypeLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddDocTypeLbl_LinkClicked);
            // 
            // AddTagLbl
            // 
            this.AddTagLbl.AutoSize = true;
            this.AddTagLbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTagLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddTagLbl.LinkColor = System.Drawing.Color.DodgerBlue;
            this.AddTagLbl.Location = new System.Drawing.Point(14, 215);
            this.AddTagLbl.Name = "AddTagLbl";
            this.AddTagLbl.Size = new System.Drawing.Size(54, 13);
            this.AddTagLbl.TabIndex = 13;
            this.AddTagLbl.TabStop = true;
            this.AddTagLbl.Text = "Add Tag";
            this.AddTagLbl.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.AddTagLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddTagLbl_LinkClicked);
            // 
            // DocumentsLbl
            // 
            this.DocumentsLbl.AutoSize = true;
            this.DocumentsLbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentsLbl.ForeColor = System.Drawing.Color.DimGray;
            this.DocumentsLbl.Location = new System.Drawing.Point(14, 100);
            this.DocumentsLbl.Name = "DocumentsLbl";
            this.DocumentsLbl.Size = new System.Drawing.Size(79, 13);
            this.DocumentsLbl.TabIndex = 14;
            this.DocumentsLbl.Text = "Documents";
            // 
            // TagsLbl
            // 
            this.TagsLbl.AutoSize = true;
            this.TagsLbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagsLbl.ForeColor = System.Drawing.Color.DimGray;
            this.TagsLbl.Location = new System.Drawing.Point(14, 193);
            this.TagsLbl.Name = "TagsLbl";
            this.TagsLbl.Size = new System.Drawing.Size(38, 13);
            this.TagsLbl.TabIndex = 15;
            this.TagsLbl.Text = "Tags";
            // 
            // AddRelationsLbl
            // 
            this.AddRelationsLbl.AutoSize = true;
            this.AddRelationsLbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRelationsLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddRelationsLbl.LinkColor = System.Drawing.Color.DodgerBlue;
            this.AddRelationsLbl.Location = new System.Drawing.Point(14, 276);
            this.AddRelationsLbl.Name = "AddRelationsLbl";
            this.AddRelationsLbl.Size = new System.Drawing.Size(79, 13);
            this.AddRelationsLbl.TabIndex = 18;
            this.AddRelationsLbl.TabStop = true;
            this.AddRelationsLbl.Text = "Add Relation";
            this.AddRelationsLbl.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.AddRelationsLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddRelationsLbl_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(175, 10);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 22);
            this.SearchBtn.TabIndex = 20;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // RegularSearchGrid
            // 
            this.RegularSearchGrid.AllowUserToAddRows = false;
            this.RegularSearchGrid.AllowUserToDeleteRows = false;
            this.RegularSearchGrid.AllowUserToResizeColumns = false;
            this.RegularSearchGrid.AllowUserToResizeRows = false;
            this.RegularSearchGrid.AutoGenerateColumns = false;
            this.RegularSearchGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RegularSearchGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RegularSearchGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.RegularSearchGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegularSearchGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.RegularSearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegularSearchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contextDataGridViewTextBoxColumn,
            this.lineDataGridViewTextBoxColumn,
            this.wordNumberDataGridViewTextBoxColumn,
            this.documentDataGridViewTextBoxColumn});
            this.RegularSearchGrid.DataSource = this.contextWordsResultBindingSource;
            this.RegularSearchGrid.Location = new System.Drawing.Point(275, 38);
            this.RegularSearchGrid.Name = "RegularSearchGrid";
            this.RegularSearchGrid.ReadOnly = true;
            this.RegularSearchGrid.Size = new System.Drawing.Size(616, 419);
            this.RegularSearchGrid.TabIndex = 21;
            this.RegularSearchGrid.Visible = false;
            // 
            // contextDataGridViewTextBoxColumn
            // 
            this.contextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contextDataGridViewTextBoxColumn.DataPropertyName = "Context";
            this.contextDataGridViewTextBoxColumn.HeaderText = "Context";
            this.contextDataGridViewTextBoxColumn.Name = "contextDataGridViewTextBoxColumn";
            this.contextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineDataGridViewTextBoxColumn
            // 
            this.lineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lineDataGridViewTextBoxColumn.DataPropertyName = "Line";
            this.lineDataGridViewTextBoxColumn.HeaderText = "Line Number";
            this.lineDataGridViewTextBoxColumn.Name = "lineDataGridViewTextBoxColumn";
            this.lineDataGridViewTextBoxColumn.ReadOnly = true;
            this.lineDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // wordNumberDataGridViewTextBoxColumn
            // 
            this.wordNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wordNumberDataGridViewTextBoxColumn.DataPropertyName = "Word_Number";
            this.wordNumberDataGridViewTextBoxColumn.HeaderText = "Word Number";
            this.wordNumberDataGridViewTextBoxColumn.Name = "wordNumberDataGridViewTextBoxColumn";
            this.wordNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentDataGridViewTextBoxColumn
            // 
            this.documentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.documentDataGridViewTextBoxColumn.DataPropertyName = "Document";
            this.documentDataGridViewTextBoxColumn.HeaderText = "Document";
            this.documentDataGridViewTextBoxColumn.Name = "documentDataGridViewTextBoxColumn";
            this.documentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextWordsResultBindingSource
            // 
            this.contextWordsResultBindingSource.DataSource = typeof(concordanceapConcordationDataSetTableAdaptersp.ContextWordsResult);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(915, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(12, 459);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // Wordtxt
            // 
            this.Wordtxt.AutoSize = true;
            this.Wordtxt.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wordtxt.Location = new System.Drawing.Point(276, 10);
            this.Wordtxt.Name = "Wordtxt";
            this.Wordtxt.Size = new System.Drawing.Size(61, 29);
            this.Wordtxt.TabIndex = 26;
            this.Wordtxt.Text = "rrrr";
            this.Wordtxt.Visible = false;
            // 
            // Documents
            // 
            this.Documents.AutoSize = true;
            this.Documents.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Documents.Location = new System.Drawing.Point(930, 201);
            this.Documents.Name = "Documents";
            this.Documents.Size = new System.Drawing.Size(71, 13);
            this.Documents.TabIndex = 27;
            this.Documents.Text = "Documents";
            this.Documents.Visible = false;
            // 
            // ContainingDocsnum
            // 
            this.ContainingDocsnum.AutoSize = true;
            this.ContainingDocsnum.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainingDocsnum.LinkColor = System.Drawing.Color.Red;
            this.ContainingDocsnum.Location = new System.Drawing.Point(930, 178);
            this.ContainingDocsnum.Name = "ContainingDocsnum";
            this.ContainingDocsnum.Size = new System.Drawing.Size(96, 13);
            this.ContainingDocsnum.TabIndex = 28;
            this.ContainingDocsnum.TabStop = true;
            this.ContainingDocsnum.Text = "ContainingDocs";
            this.ContainingDocsnum.Visible = false;
            this.ContainingDocsnum.VisitedLinkColor = System.Drawing.Color.Red;
            this.ContainingDocsnum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ContainingDocsnum_LinkClicked);
            // 
            // TagsNum
            // 
            this.TagsNum.AutoSize = true;
            this.TagsNum.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagsNum.LinkColor = System.Drawing.Color.Red;
            this.TagsNum.Location = new System.Drawing.Point(930, 242);
            this.TagsNum.Name = "TagsNum";
            this.TagsNum.Size = new System.Drawing.Size(60, 13);
            this.TagsNum.TabIndex = 30;
            this.TagsNum.TabStop = true;
            this.TagsNum.Text = "TagsNum";
            this.TagsNum.Visible = false;
            this.TagsNum.VisitedLinkColor = System.Drawing.Color.Red;
            this.TagsNum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TagsNum_LinkClicked);
            // 
            // Tags
            // 
            this.Tags.AutoSize = true;
            this.Tags.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tags.Location = new System.Drawing.Point(930, 265);
            this.Tags.Name = "Tags";
            this.Tags.Size = new System.Drawing.Size(34, 13);
            this.Tags.TabIndex = 29;
            this.Tags.Text = "Tags";
            this.Tags.Visible = false;
            // 
            // RelationsNum
            // 
            this.RelationsNum.AutoSize = true;
            this.RelationsNum.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelationsNum.LinkColor = System.Drawing.Color.Red;
            this.RelationsNum.Location = new System.Drawing.Point(930, 307);
            this.RelationsNum.Name = "RelationsNum";
            this.RelationsNum.Size = new System.Drawing.Size(85, 13);
            this.RelationsNum.TabIndex = 32;
            this.RelationsNum.TabStop = true;
            this.RelationsNum.Text = "RelationsNum";
            this.RelationsNum.Visible = false;
            this.RelationsNum.VisitedLinkColor = System.Drawing.Color.Red;
            this.RelationsNum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RelationsNum_LinkClicked);
            // 
            // RelationsNumlbl
            // 
            this.RelationsNumlbl.AutoSize = true;
            this.RelationsNumlbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelationsNumlbl.Location = new System.Drawing.Point(930, 330);
            this.RelationsNumlbl.Name = "RelationsNumlbl";
            this.RelationsNumlbl.Size = new System.Drawing.Size(59, 13);
            this.RelationsNumlbl.TabIndex = 31;
            this.RelationsNumlbl.Text = "Relations";
            this.RelationsNumlbl.Visible = false;
            // 
            // ExpressionsNum
            // 
            this.ExpressionsNum.AutoSize = true;
            this.ExpressionsNum.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpressionsNum.LinkColor = System.Drawing.Color.Red;
            this.ExpressionsNum.Location = new System.Drawing.Point(930, 371);
            this.ExpressionsNum.Name = "ExpressionsNum";
            this.ExpressionsNum.Size = new System.Drawing.Size(101, 13);
            this.ExpressionsNum.TabIndex = 34;
            this.ExpressionsNum.TabStop = true;
            this.ExpressionsNum.Text = "ExpressionsNum";
            this.ExpressionsNum.Visible = false;
            this.ExpressionsNum.VisitedLinkColor = System.Drawing.Color.Red;
            this.ExpressionsNum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExpressionsNum_LinkClicked);
            // 
            // Expressions
            // 
            this.Expressions.AutoSize = true;
            this.Expressions.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expressions.Location = new System.Drawing.Point(930, 394);
            this.Expressions.Name = "Expressions";
            this.Expressions.Size = new System.Drawing.Size(75, 13);
            this.Expressions.TabIndex = 33;
            this.Expressions.Text = "Expressions";
            this.Expressions.Visible = false;
            // 
            // Relationslbl
            // 
            this.Relationslbl.AutoSize = true;
            this.Relationslbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Relationslbl.ForeColor = System.Drawing.Color.DimGray;
            this.Relationslbl.Location = new System.Drawing.Point(14, 254);
            this.Relationslbl.Name = "Relationslbl";
            this.Relationslbl.Size = new System.Drawing.Size(67, 13);
            this.Relationslbl.TabIndex = 35;
            this.Relationslbl.Text = "Relations";
            // 
            // Expressionslbl
            // 
            this.Expressionslbl.AutoSize = true;
            this.Expressionslbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expressionslbl.ForeColor = System.Drawing.Color.DimGray;
            this.Expressionslbl.Location = new System.Drawing.Point(14, 314);
            this.Expressionslbl.Name = "Expressionslbl";
            this.Expressionslbl.Size = new System.Drawing.Size(86, 13);
            this.Expressionslbl.TabIndex = 37;
            this.Expressionslbl.Text = "Expressions";
            // 
            // AddExpression
            // 
            this.AddExpression.AutoSize = true;
            this.AddExpression.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddExpression.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddExpression.LinkColor = System.Drawing.Color.DodgerBlue;
            this.AddExpression.Location = new System.Drawing.Point(12, 337);
            this.AddExpression.Name = "AddExpression";
            this.AddExpression.Size = new System.Drawing.Size(95, 13);
            this.AddExpression.TabIndex = 36;
            this.AddExpression.TabStop = true;
            this.AddExpression.Text = "Add Expression";
            this.AddExpression.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.AddExpression.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddExpression_LinkClicked);
            // 
            // ShowAllWords
            // 
            this.ShowAllWords.AutoSize = true;
            this.ShowAllWords.LinkColor = System.Drawing.Color.SlateGray;
            this.ShowAllWords.Location = new System.Drawing.Point(12, 394);
            this.ShowAllWords.Name = "ShowAllWords";
            this.ShowAllWords.Size = new System.Drawing.Size(96, 13);
            this.ShowAllWords.TabIndex = 38;
            this.ShowAllWords.TabStop = true;
            this.ShowAllWords.Text = "Show All Words";
            this.ShowAllWords.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.ShowAllWords.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowAllWords_LinkClicked);
            // 
            // AdvancedSearch
            // 
            this.AdvancedSearch.AutoSize = true;
            this.AdvancedSearch.Location = new System.Drawing.Point(141, 39);
            this.AdvancedSearch.Name = "AdvancedSearch";
            this.AdvancedSearch.Size = new System.Drawing.Size(107, 13);
            this.AdvancedSearch.TabIndex = 39;
            this.AdvancedSearch.TabStop = true;
            this.AdvancedSearch.Text = "Advanced Search";
            this.AdvancedSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AdvancedSearch_LinkClicked);
            // 
            // Statslbl
            // 
            this.Statslbl.AutoSize = true;
            this.Statslbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statslbl.ForeColor = System.Drawing.Color.Blue;
            this.Statslbl.Location = new System.Drawing.Point(7, 10);
            this.Statslbl.Name = "Statslbl";
            this.Statslbl.Size = new System.Drawing.Size(58, 13);
            this.Statslbl.TabIndex = 41;
            this.Statslbl.Text = "Statistics";
            // 
            // TotAppearances
            // 
            this.TotAppearances.AutoSize = true;
            this.TotAppearances.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotAppearances.Location = new System.Drawing.Point(7, 55);
            this.TotAppearances.Name = "TotAppearances";
            this.TotAppearances.Size = new System.Drawing.Size(113, 13);
            this.TotAppearances.TabIndex = 23;
            this.TotAppearances.Text = "Total Appearances";
            this.TotAppearances.Visible = false;
            // 
            // NumOfSearchlbl
            // 
            this.NumOfSearchlbl.AutoSize = true;
            this.NumOfSearchlbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfSearchlbl.Location = new System.Drawing.Point(8, 116);
            this.NumOfSearchlbl.Name = "NumOfSearchlbl";
            this.NumOfSearchlbl.Size = new System.Drawing.Size(126, 13);
            this.NumOfSearchlbl.TabIndex = 42;
            this.NumOfSearchlbl.Text = "Number Of Searches";
            this.NumOfSearchlbl.Visible = false;
            // 
            // TotAppeartxt
            // 
            this.TotAppeartxt.AutoSize = true;
            this.TotAppeartxt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotAppeartxt.ForeColor = System.Drawing.Color.Red;
            this.TotAppeartxt.Location = new System.Drawing.Point(7, 33);
            this.TotAppeartxt.Name = "TotAppeartxt";
            this.TotAppeartxt.Size = new System.Drawing.Size(113, 13);
            this.TotAppeartxt.TabIndex = 43;
            this.TotAppeartxt.Text = "Total Appearances";
            this.TotAppeartxt.Visible = false;
            // 
            // NumOfSearchestxt
            // 
            this.NumOfSearchestxt.AutoSize = true;
            this.NumOfSearchestxt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfSearchestxt.ForeColor = System.Drawing.Color.Red;
            this.NumOfSearchestxt.Location = new System.Drawing.Point(8, 91);
            this.NumOfSearchestxt.Name = "NumOfSearchestxt";
            this.NumOfSearchestxt.Size = new System.Drawing.Size(126, 13);
            this.NumOfSearchestxt.TabIndex = 44;
            this.NumOfSearchestxt.Text = "Number Of Searches";
            this.NumOfSearchestxt.Visible = false;
            // 
            // StatsGB
            // 
            this.StatsGB.Controls.Add(this.NumOfSearchestxt);
            this.StatsGB.Controls.Add(this.TotAppearances);
            this.StatsGB.Controls.Add(this.TotAppeartxt);
            this.StatsGB.Controls.Add(this.Statslbl);
            this.StatsGB.Controls.Add(this.NumOfSearchlbl);
            this.StatsGB.Location = new System.Drawing.Point(933, 9);
            this.StatsGB.Name = "StatsGB";
            this.StatsGB.Size = new System.Drawing.Size(233, 154);
            this.StatsGB.TabIndex = 45;
            this.StatsGB.TabStop = false;
            this.StatsGB.Visible = false;
            // 
            // AdvancedSearchGrid
            // 
            this.AdvancedSearchGrid.AllowUserToAddRows = false;
            this.AdvancedSearchGrid.AllowUserToDeleteRows = false;
            this.AdvancedSearchGrid.AutoGenerateColumns = false;
            this.AdvancedSearchGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AdvancedSearchGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AdvancedSearchGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AdvancedSearchGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdvancedSearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdvancedSearchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordDataGridViewTextBoxColumn,
            this.lineNumDataGridViewTextBoxColumn,
            this.wordNumDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.AdvancedSearchGrid.DataSource = this.getWordByLineAndNumResultBindingSource;
            this.AdvancedSearchGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AdvancedSearchGrid.Location = new System.Drawing.Point(275, 38);
            this.AdvancedSearchGrid.Name = "AdvancedSearchGrid";
            this.AdvancedSearchGrid.ReadOnly = true;
            this.AdvancedSearchGrid.Size = new System.Drawing.Size(616, 434);
            this.AdvancedSearchGrid.TabIndex = 46;
            this.AdvancedSearchGrid.Visible = false;
            // 
            // wordDataGridViewTextBoxColumn
            // 
            this.wordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wordDataGridViewTextBoxColumn.DataPropertyName = "word";
            this.wordDataGridViewTextBoxColumn.HeaderText = "Word";
            this.wordDataGridViewTextBoxColumn.Name = "wordDataGridViewTextBoxColumn";
            this.wordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineNumDataGridViewTextBoxColumn
            // 
            this.lineNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lineNumDataGridViewTextBoxColumn.DataPropertyName = "LineNum";
            this.lineNumDataGridViewTextBoxColumn.HeaderText = "Line Number";
            this.lineNumDataGridViewTextBoxColumn.Name = "lineNumDataGridViewTextBoxColumn";
            this.lineNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wordNumDataGridViewTextBoxColumn
            // 
            this.wordNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wordNumDataGridViewTextBoxColumn.DataPropertyName = "WordNum";
            this.wordNumDataGridViewTextBoxColumn.HeaderText = "Word Number";
            this.wordNumDataGridViewTextBoxColumn.Name = "wordNumDataGridViewTextBoxColumn";
            this.wordNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Document Name";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getWordByLineAndNumResultBindingSource
            // 
            this.getWordByLineAndNumResultBindingSource.DataSource = typeof(concordanceapConcordationDataSetTableAdaptersp.GetWordByLineAndNumResult);
            // 
            // TagSearchGrid
            // 
            this.TagSearchGrid.AllowUserToAddRows = false;
            this.TagSearchGrid.AllowUserToDeleteRows = false;
            this.TagSearchGrid.AutoGenerateColumns = false;
            this.TagSearchGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TagSearchGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TagSearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TagSearchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordDataGridViewTextBoxColumn1,
            this.tagNameDataGridViewTextBoxColumn});
            this.TagSearchGrid.DataSource = this.getWordByTagNameResultBindingSource;
            this.TagSearchGrid.Location = new System.Drawing.Point(275, 38);
            this.TagSearchGrid.Name = "TagSearchGrid";
            this.TagSearchGrid.ReadOnly = true;
            this.TagSearchGrid.Size = new System.Drawing.Size(616, 434);
            this.TagSearchGrid.TabIndex = 47;
            this.TagSearchGrid.Visible = false;
            // 
            // wordDataGridViewTextBoxColumn1
            // 
            this.wordDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wordDataGridViewTextBoxColumn1.DataPropertyName = "word";
            this.wordDataGridViewTextBoxColumn1.HeaderText = "Word";
            this.wordDataGridViewTextBoxColumn1.Name = "wordDataGridViewTextBoxColumn1";
            this.wordDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tagNameDataGridViewTextBoxColumn
            // 
            this.tagNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tagNameDataGridViewTextBoxColumn.DataPropertyName = "TagName";
            this.tagNameDataGridViewTextBoxColumn.HeaderText = "Tag Name";
            this.tagNameDataGridViewTextBoxColumn.Name = "tagNameDataGridViewTextBoxColumn";
            this.tagNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getWordByTagNameResultBindingSource
            // 
            this.getWordByTagNameResultBindingSource.DataSource = typeof(concordanceapConcordationDataSetTableAdaptersp.GetWordByTagNameResult);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(14, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Words";
            // 
            // BackupRestore
            // 
            this.BackupRestore.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.BackupRestore.AutoSize = true;
            this.BackupRestore.Location = new System.Drawing.Point(14, 444);
            this.BackupRestore.Name = "BackupRestore";
            this.BackupRestore.Size = new System.Drawing.Size(106, 13);
            this.BackupRestore.TabIndex = 50;
            this.BackupRestore.TabStop = true;
            this.BackupRestore.Text = "Backup / Restore";
            this.BackupRestore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackupRestore_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(14, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Maintenance";
            // 
            // ConcordanceApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackupRestore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TagSearchGrid);
            this.Controls.Add(this.AdvancedSearchGrid);
            this.Controls.Add(this.AdvancedSearch);
            this.Controls.Add(this.ShowAllWords);
            this.Controls.Add(this.Expressionslbl);
            this.Controls.Add(this.AddExpression);
            this.Controls.Add(this.Relationslbl);
            this.Controls.Add(this.ExpressionsNum);
            this.Controls.Add(this.Expressions);
            this.Controls.Add(this.RelationsNum);
            this.Controls.Add(this.RelationsNumlbl);
            this.Controls.Add(this.TagsNum);
            this.Controls.Add(this.Tags);
            this.Controls.Add(this.ContainingDocsnum);
            this.Controls.Add(this.Documents);
            this.Controls.Add(this.Wordtxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RegularSearchGrid);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.AddRelationsLbl);
            this.Controls.Add(this.TagsLbl);
            this.Controls.Add(this.DocumentsLbl);
            this.Controls.Add(this.AddTagLbl);
            this.Controls.Add(this.AddDocTypeLbl);
            this.Controls.Add(this.UpDocLbl);
            this.Controls.Add(this.VLine);
            this.Controls.Add(this.HLine);
            this.Controls.Add(this.SongsCB);
            this.Controls.Add(this.StoryCB);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.StatsGB);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1187, 463);
            this.Name = "ConcordanceApp";
            this.Text = "Concordance";
            ((System.ComponentModel.ISupportInitialize)(this.RegularSearchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextWordsResultBindingSource)).EndInit();
            this.StatsGB.ResumeLayout(false);
            this.StatsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdvancedSearchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getWordByLineAndNumResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TagSearchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getWordByTagNameResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //public DBConDataContext DB = new DBConDataContext();
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.CheckBox StoryCB;
        private System.Windows.Forms.CheckBox SongsCB;
        private GroupBox HLine;
        private GroupBox VLine;
        private LinkLabel UpDocLbl;
        private LinkLabel AddDocTypeLbl;
        private LinkLabel AddTagLbl;
        private Label DocumentsLbl;
        private Label TagsLbl;
        private LinkLabel AddRelationsLbl;
        private OpenFileDialog openFileDialog1;
        private Button SearchBtn;
        public DataGridView RegularSearchGrid;
        private GroupBox groupBox1;
        public Label Wordtxt;
        private Label Documents;
        private LinkLabel ContainingDocsnum;
        private LinkLabel TagsNum;
        private Label Tags;
        private LinkLabel RelationsNum;
        private Label RelationsNumlbl;
        private LinkLabel ExpressionsNum;
        private Label Expressions;
        private Label Relationslbl;
        private Label Expressionslbl;
        private LinkLabel AddExpression;
        private LinkLabel ShowAllWords;
        private DataGridViewTextBoxColumn contextDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lineDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wordNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn documentDataGridViewTextBoxColumn;
        private BindingSource contextWordsResultBindingSource;
        private LinkLabel AdvancedSearch;
        private Label Statslbl;
        private Label TotAppearances;
        private Label NumOfSearchlbl;
        private Label TotAppeartxt;
        private Label NumOfSearchestxt;
        private GroupBox StatsGB;
        public DataGridView AdvancedSearchGrid;
        private DataGridViewTextBoxColumn wordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lineNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wordNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private BindingSource getWordByLineAndNumResultBindingSource;
        public DataGridView TagSearchGrid;
        private DataGridViewTextBoxColumn wordDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn tagNameDataGridViewTextBoxColumn;
        private BindingSource getWordByTagNameResultBindingSource;
        private Label label1;
        private LinkLabel BackupRestore;
        private Label label2;
    }
}