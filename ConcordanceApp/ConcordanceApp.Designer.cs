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
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.ArticlesCB = new System.Windows.Forms.CheckBox();
            this.SongsCB = new System.Windows.Forms.CheckBox();
            this.AuthorsCB = new System.Windows.Forms.CheckBox();
            this.MedicalRecordsCB = new System.Windows.Forms.CheckBox();
            this.ProgrammingCodeCB = new System.Windows.Forms.CheckBox();
            this.HLine = new System.Windows.Forms.GroupBox();
            this.VLine = new System.Windows.Forms.GroupBox();
            this.UpDocLbl = new System.Windows.Forms.LinkLabel();
            this.AddDocTypeLbl = new System.Windows.Forms.LinkLabel();
            this.AddTagLbl = new System.Windows.Forms.LinkLabel();
            this.DocumentsLbl = new System.Windows.Forms.Label();
            this.TagsLbl = new System.Windows.Forms.Label();
            this.GroupsLbl = new System.Windows.Forms.Label();
            this.AddGroupLbl = new System.Windows.Forms.LinkLabel();
            this.AddRelationsLbl = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TotAppearances = new System.Windows.Forms.Label();
            this.TotAppeartxt = new System.Windows.Forms.LinkLabel();
            this.SearchedWordlbl = new System.Windows.Forms.Label();
            this.Wordtxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ContainingDocsnum = new System.Windows.Forms.LinkLabel();
            this.TagsNum = new System.Windows.Forms.LinkLabel();
            this.Tags = new System.Windows.Forms.Label();
            this.RelationsNum = new System.Windows.Forms.LinkLabel();
            this.RelationsNumlbl = new System.Windows.Forms.Label();
            this.ExpressionsNum = new System.Windows.Forms.LinkLabel();
            this.Expressions = new System.Windows.Forms.Label();
            this.Relationslbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(62, 12);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(82, 20);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.Text = "Word / Term";
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(12, 15);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(44, 13);
            this.SearchLabel.TabIndex = 1;
            this.SearchLabel.Text = "Search:";
            // 
            // ArticlesCB
            // 
            this.ArticlesCB.AutoSize = true;
            this.ArticlesCB.Location = new System.Drawing.Point(15, 38);
            this.ArticlesCB.Name = "ArticlesCB";
            this.ArticlesCB.Size = new System.Drawing.Size(60, 17);
            this.ArticlesCB.TabIndex = 3;
            this.ArticlesCB.Text = "Articles";
            this.ArticlesCB.UseVisualStyleBackColor = true;
            // 
            // SongsCB
            // 
            this.SongsCB.AutoSize = true;
            this.SongsCB.Location = new System.Drawing.Point(15, 61);
            this.SongsCB.Name = "SongsCB";
            this.SongsCB.Size = new System.Drawing.Size(56, 17);
            this.SongsCB.TabIndex = 4;
            this.SongsCB.Text = "Songs";
            this.SongsCB.UseVisualStyleBackColor = true;
            // 
            // AuthorsCB
            // 
            this.AuthorsCB.AutoSize = true;
            this.AuthorsCB.Location = new System.Drawing.Point(15, 84);
            this.AuthorsCB.Name = "AuthorsCB";
            this.AuthorsCB.Size = new System.Drawing.Size(62, 17);
            this.AuthorsCB.TabIndex = 5;
            this.AuthorsCB.Text = "Authors";
            this.AuthorsCB.UseVisualStyleBackColor = true;
            // 
            // MedicalRecordsCB
            // 
            this.MedicalRecordsCB.AutoSize = true;
            this.MedicalRecordsCB.Location = new System.Drawing.Point(15, 107);
            this.MedicalRecordsCB.Name = "MedicalRecordsCB";
            this.MedicalRecordsCB.Size = new System.Drawing.Size(106, 17);
            this.MedicalRecordsCB.TabIndex = 6;
            this.MedicalRecordsCB.Text = "Medical Records";
            this.MedicalRecordsCB.UseVisualStyleBackColor = true;
            // 
            // ProgrammingCodeCB
            // 
            this.ProgrammingCodeCB.AutoSize = true;
            this.ProgrammingCodeCB.Location = new System.Drawing.Point(15, 130);
            this.ProgrammingCodeCB.Name = "ProgrammingCodeCB";
            this.ProgrammingCodeCB.Size = new System.Drawing.Size(115, 17);
            this.ProgrammingCodeCB.TabIndex = 7;
            this.ProgrammingCodeCB.Text = "Programming Code";
            this.ProgrammingCodeCB.UseVisualStyleBackColor = true;
            // 
            // HLine
            // 
            this.HLine.Location = new System.Drawing.Point(3, 153);
            this.HLine.Name = "HLine";
            this.HLine.Size = new System.Drawing.Size(211, 10);
            this.HLine.TabIndex = 8;
            this.HLine.TabStop = false;
            // 
            // VLine
            // 
            this.VLine.Location = new System.Drawing.Point(220, 12);
            this.VLine.Name = "VLine";
            this.VLine.Size = new System.Drawing.Size(10, 408);
            this.VLine.TabIndex = 9;
            this.VLine.TabStop = false;
            // 
            // UpDocLbl
            // 
            this.UpDocLbl.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.UpDocLbl.AutoSize = true;
            this.UpDocLbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDocLbl.LinkColor = System.Drawing.Color.DodgerBlue;
            this.UpDocLbl.Location = new System.Drawing.Point(12, 192);
            this.UpDocLbl.Name = "UpDocLbl";
            this.UpDocLbl.Size = new System.Drawing.Size(108, 13);
            this.UpDocLbl.TabIndex = 11;
            this.UpDocLbl.TabStop = true;
            this.UpDocLbl.Text = "Upload Document";
            this.UpDocLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UpDocLbl_LinkClicked);
            // 
            // AddDocTypeLbl
            // 
            this.AddDocTypeLbl.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.AddDocTypeLbl.AutoSize = true;
            this.AddDocTypeLbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDocTypeLbl.LinkColor = System.Drawing.Color.DodgerBlue;
            this.AddDocTypeLbl.Location = new System.Drawing.Point(12, 215);
            this.AddDocTypeLbl.Name = "AddDocTypeLbl";
            this.AddDocTypeLbl.Size = new System.Drawing.Size(123, 13);
            this.AddDocTypeLbl.TabIndex = 12;
            this.AddDocTypeLbl.TabStop = true;
            this.AddDocTypeLbl.Text = "Add Document Type";
            // 
            // AddTagLbl
            // 
            this.AddTagLbl.AutoSize = true;
            this.AddTagLbl.Location = new System.Drawing.Point(12, 276);
            this.AddTagLbl.Name = "AddTagLbl";
            this.AddTagLbl.Size = new System.Drawing.Size(48, 13);
            this.AddTagLbl.TabIndex = 13;
            this.AddTagLbl.TabStop = true;
            this.AddTagLbl.Text = "Add Tag";
            this.AddTagLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddTagLbl_LinkClicked);
            // 
            // DocumentsLbl
            // 
            this.DocumentsLbl.AutoSize = true;
            this.DocumentsLbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentsLbl.ForeColor = System.Drawing.Color.DimGray;
            this.DocumentsLbl.Location = new System.Drawing.Point(12, 169);
            this.DocumentsLbl.Name = "DocumentsLbl";
            this.DocumentsLbl.Size = new System.Drawing.Size(79, 13);
            this.DocumentsLbl.TabIndex = 14;
            this.DocumentsLbl.Text = "Documents";
            // 
            // TagsLbl
            // 
            this.TagsLbl.AutoSize = true;
            this.TagsLbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TagsLbl.Location = new System.Drawing.Point(12, 253);
            this.TagsLbl.Name = "TagsLbl";
            this.TagsLbl.Size = new System.Drawing.Size(30, 13);
            this.TagsLbl.TabIndex = 15;
            this.TagsLbl.Text = "Tags";
            // 
            // GroupsLbl
            // 
            this.GroupsLbl.AutoSize = true;
            this.GroupsLbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GroupsLbl.Location = new System.Drawing.Point(12, 316);
            this.GroupsLbl.Name = "GroupsLbl";
            this.GroupsLbl.Size = new System.Drawing.Size(41, 13);
            this.GroupsLbl.TabIndex = 17;
            this.GroupsLbl.Text = "Groups";
            // 
            // AddGroupLbl
            // 
            this.AddGroupLbl.AutoSize = true;
            this.AddGroupLbl.Location = new System.Drawing.Point(12, 339);
            this.AddGroupLbl.Name = "AddGroupLbl";
            this.AddGroupLbl.Size = new System.Drawing.Size(58, 13);
            this.AddGroupLbl.TabIndex = 16;
            this.AddGroupLbl.TabStop = true;
            this.AddGroupLbl.Text = "Add Group";
            // 
            // AddRelationsLbl
            // 
            this.AddRelationsLbl.AutoSize = true;
            this.AddRelationsLbl.Location = new System.Drawing.Point(12, 403);
            this.AddRelationsLbl.Name = "AddRelationsLbl";
            this.AddRelationsLbl.Size = new System.Drawing.Size(68, 13);
            this.AddRelationsLbl.TabIndex = 18;
            this.AddRelationsLbl.TabStop = true;
            this.AddRelationsLbl.Text = "Add Relation";
            this.AddRelationsLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddRelationsLbl_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(150, 10);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(64, 22);
            this.SearchBtn.TabIndex = 20;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(236, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(528, 382);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(784, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(10, 406);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // TotAppearances
            // 
            this.TotAppearances.AutoSize = true;
            this.TotAppearances.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotAppearances.Location = new System.Drawing.Point(800, 39);
            this.TotAppearances.Name = "TotAppearances";
            this.TotAppearances.Size = new System.Drawing.Size(124, 14);
            this.TotAppearances.TabIndex = 23;
            this.TotAppearances.Text = "Total Appearances";
            // 
            // TotAppeartxt
            // 
            this.TotAppeartxt.ActiveLinkColor = System.Drawing.Color.DarkOrange;
            this.TotAppeartxt.AutoSize = true;
            this.TotAppeartxt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotAppeartxt.ForeColor = System.Drawing.Color.Orange;
            this.TotAppeartxt.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.TotAppeartxt.LinkColor = System.Drawing.Color.Orange;
            this.TotAppeartxt.Location = new System.Drawing.Point(800, 16);
            this.TotAppeartxt.Name = "TotAppeartxt";
            this.TotAppeartxt.Size = new System.Drawing.Size(104, 16);
            this.TotAppeartxt.TabIndex = 24;
            this.TotAppeartxt.TabStop = true;
            this.TotAppeartxt.Text = "TotAppeartxt";
            this.TotAppeartxt.Visible = false;
            this.TotAppeartxt.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // SearchedWordlbl
            // 
            this.SearchedWordlbl.AutoSize = true;
            this.SearchedWordlbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SearchedWordlbl.Location = new System.Drawing.Point(237, 10);
            this.SearchedWordlbl.Name = "SearchedWordlbl";
            this.SearchedWordlbl.Size = new System.Drawing.Size(141, 16);
            this.SearchedWordlbl.TabIndex = 25;
            this.SearchedWordlbl.Text = "The Searched Word is:";
            this.SearchedWordlbl.Visible = false;
            // 
            // Wordtxt
            // 
            this.Wordtxt.AutoSize = true;
            this.Wordtxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Wordtxt.Location = new System.Drawing.Point(237, 9);
            this.Wordtxt.Name = "Wordtxt";
            this.Wordtxt.Size = new System.Drawing.Size(32, 16);
            this.Wordtxt.TabIndex = 26;
            this.Wordtxt.Text = "rrrr";
            this.Wordtxt.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.Location = new System.Drawing.Point(800, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Documents";
            // 
            // ContainingDocsnum
            // 
            this.ContainingDocsnum.AutoSize = true;
            this.ContainingDocsnum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ContainingDocsnum.LinkColor = System.Drawing.Color.Red;
            this.ContainingDocsnum.Location = new System.Drawing.Point(800, 83);
            this.ContainingDocsnum.Name = "ContainingDocsnum";
            this.ContainingDocsnum.Size = new System.Drawing.Size(95, 16);
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
            this.TagsNum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TagsNum.LinkColor = System.Drawing.Color.Red;
            this.TagsNum.Location = new System.Drawing.Point(800, 147);
            this.TagsNum.Name = "TagsNum";
            this.TagsNum.Size = new System.Drawing.Size(62, 16);
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
            this.Tags.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Tags.Location = new System.Drawing.Point(800, 170);
            this.Tags.Name = "Tags";
            this.Tags.Size = new System.Drawing.Size(36, 16);
            this.Tags.TabIndex = 29;
            this.Tags.Text = "Tags";
            // 
            // RelationsNum
            // 
            this.RelationsNum.AutoSize = true;
            this.RelationsNum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RelationsNum.LinkColor = System.Drawing.Color.Red;
            this.RelationsNum.Location = new System.Drawing.Point(800, 212);
            this.RelationsNum.Name = "RelationsNum";
            this.RelationsNum.Size = new System.Drawing.Size(86, 16);
            this.RelationsNum.TabIndex = 32;
            this.RelationsNum.TabStop = true;
            this.RelationsNum.Text = "RelationsNum";
            this.RelationsNum.Visible = false;
            this.RelationsNum.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // RelationsNumlbl
            // 
            this.RelationsNumlbl.AutoSize = true;
            this.RelationsNumlbl.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.RelationsNumlbl.Location = new System.Drawing.Point(800, 235);
            this.RelationsNumlbl.Name = "RelationsNumlbl";
            this.RelationsNumlbl.Size = new System.Drawing.Size(60, 16);
            this.RelationsNumlbl.TabIndex = 31;
            this.RelationsNumlbl.Text = "Relations";
            // 
            // ExpressionsNum
            // 
            this.ExpressionsNum.AutoSize = true;
            this.ExpressionsNum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExpressionsNum.LinkColor = System.Drawing.Color.Red;
            this.ExpressionsNum.Location = new System.Drawing.Point(800, 276);
            this.ExpressionsNum.Name = "ExpressionsNum";
            this.ExpressionsNum.Size = new System.Drawing.Size(101, 16);
            this.ExpressionsNum.TabIndex = 34;
            this.ExpressionsNum.TabStop = true;
            this.ExpressionsNum.Text = "ExpressionsNum";
            this.ExpressionsNum.Visible = false;
            this.ExpressionsNum.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // Expressions
            // 
            this.Expressions.AutoSize = true;
            this.Expressions.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Expressions.Location = new System.Drawing.Point(800, 299);
            this.Expressions.Name = "Expressions";
            this.Expressions.Size = new System.Drawing.Size(75, 16);
            this.Expressions.TabIndex = 33;
            this.Expressions.Text = "Expressions";
            // 
            // Relationslbl
            // 
            this.Relationslbl.AutoSize = true;
            this.Relationslbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Relationslbl.Location = new System.Drawing.Point(12, 380);
            this.Relationslbl.Name = "Relationslbl";
            this.Relationslbl.Size = new System.Drawing.Size(51, 13);
            this.Relationslbl.TabIndex = 35;
            this.Relationslbl.Text = "Relations";
            // 
            // ConcordanceApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 425);
            this.Controls.Add(this.Relationslbl);
            this.Controls.Add(this.ExpressionsNum);
            this.Controls.Add(this.Expressions);
            this.Controls.Add(this.RelationsNum);
            this.Controls.Add(this.RelationsNumlbl);
            this.Controls.Add(this.TagsNum);
            this.Controls.Add(this.Tags);
            this.Controls.Add(this.ContainingDocsnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Wordtxt);
            this.Controls.Add(this.SearchedWordlbl);
            this.Controls.Add(this.TotAppeartxt);
            this.Controls.Add(this.TotAppearances);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.AddRelationsLbl);
            this.Controls.Add(this.GroupsLbl);
            this.Controls.Add(this.AddGroupLbl);
            this.Controls.Add(this.TagsLbl);
            this.Controls.Add(this.DocumentsLbl);
            this.Controls.Add(this.AddTagLbl);
            this.Controls.Add(this.AddDocTypeLbl);
            this.Controls.Add(this.UpDocLbl);
            this.Controls.Add(this.VLine);
            this.Controls.Add(this.HLine);
            this.Controls.Add(this.ProgrammingCodeCB);
            this.Controls.Add(this.MedicalRecordsCB);
            this.Controls.Add(this.AuthorsCB);
            this.Controls.Add(this.SongsCB);
            this.Controls.Add(this.ArticlesCB);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchBox);
            this.Name = "ConcordanceApp";
            this.Text = "Concordance";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //public DBConDataContext DB = new DBConDataContext();
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.CheckBox ArticlesCB;
        private System.Windows.Forms.CheckBox SongsCB;
        private System.Windows.Forms.CheckBox AuthorsCB;
        private System.Windows.Forms.CheckBox MedicalRecordsCB;
        private System.Windows.Forms.CheckBox ProgrammingCodeCB;
        private GroupBox HLine;
        private GroupBox VLine;
        private LinkLabel UpDocLbl;
        private LinkLabel AddDocTypeLbl;
        private LinkLabel AddTagLbl;
        private Label DocumentsLbl;
        private Label TagsLbl;
        private Label GroupsLbl;
        private LinkLabel AddGroupLbl;
        private LinkLabel AddRelationsLbl;
        private OpenFileDialog openFileDialog1;
        private Button SearchBtn;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label TotAppearances;
        private LinkLabel TotAppeartxt;
        private Label SearchedWordlbl;
        private Label Wordtxt;
        private Label label1;
        private LinkLabel ContainingDocsnum;
        private LinkLabel TagsNum;
        private Label Tags;
        private LinkLabel RelationsNum;
        private Label RelationsNumlbl;
        private LinkLabel ExpressionsNum;
        private Label Expressions;
        private Label Relationslbl;
    }
}