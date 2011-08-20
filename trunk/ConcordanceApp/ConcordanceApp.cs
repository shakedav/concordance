using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace concordanceapConcordationDataSetTableAdaptersp
{
    public partial class ConcordanceApp : Form
    {
        public enum AttributeTypes { PATH = 1, FILENAME, AUTHOR, COMPOSER, NAME };
        DBConDataContext DB = new DBConDataContext();
        public ConcordanceApp()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        
        private void UpDocLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Get the Doc Type from the Form
            AttributesForm form = new AttributesForm(1, this);
            form.ShowDialog();
 
            /*DocAttributes.Show();*/
            string Author = form.Author;
            /*string Composer = form.Composer;*/
            string SongName = form.DocumentName;
            int DocID = form.DocType;

            if (string.IsNullOrEmpty(Author) || string.IsNullOrEmpty(SongName) )/*|| string.IsNullOrEmpty(Composer))*/
            {
                form.Close();
            }
        }

        public void LoadDocument(string author, string name, int DocID)
        {
            ArrayList words = new ArrayList();

            /* Select the file and load it */
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Select Document To Upload";
            fDialog.Filter = "TXT Files|*.txt";
            fDialog.InitialDirectory = @"C:\\temp";
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = fDialog.SafeFileNames.FirstOrDefault();
                string filePath = fDialog.FileNames.FirstOrDefault();
                filePath = filePath.Remove(filePath.IndexOf(fileName));
                DocID = DB.InsertDocument(DocID, fileName, filePath);
                /* insert the attributes to the DB */
                DB.addAttributes(DocID, author, (int)AttributeTypes.AUTHOR);
                DB.addAttributes(DocID, name, (int)AttributeTypes.NAME);
                ProgressBar pbar = new ProgressBar(fileName);
                pbar.Show();
                pbar.Medium();
                FileHandler.ParseFile(filePath + fileName, DocID);
                /*foreach (WordItem word in words)
                {
                    pbar.AdvancedStep();
                    DB.InsertWord2(word.word, word.lineNum, word.wordNum, DocID);
                }*/
                pbar.Fill();
                MessageBox.Show("Document Loading Finished");
                pbar.Close();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            //DB.CommandTimeout = 3600;
            DB.AddSearchNumber(SearchBox.Text);
            if ((!StoryCB.Checked) && (!SongsCB.Checked) || (StoryCB.Checked) && (SongsCB.Checked))
                RegularSearchGrid.DataSource = DB.ContextWords(SearchBox.Text, null).ToList<ContextWordsResult>();
            if ((StoryCB.Checked) && (!SongsCB.Checked))
                RegularSearchGrid.DataSource = DB.ContextWords(SearchBox.Text, 1).ToList<ContextWordsResult>();
            if ((!StoryCB.Checked) && (SongsCB.Checked))
                RegularSearchGrid.DataSource = DB.ContextWords(SearchBox.Text, 2).ToList<ContextWordsResult>();
            RegularSearchGrid.Visible = true;
            this.GetSearchNumbers();
        }

        private void GetSearchNumbers()
        {
            StatsGB.Visible = true;
            TotAppeartxt.Text = DB.GetTotalAppearances(SearchBox.Text).ToString();
            TotAppearances.Visible = true;
            TotAppeartxt.Visible = true;
            if (TotAppeartxt.Text.Equals("0"))
                TotAppeartxt.Enabled = false;
            else
                TotAppeartxt.Enabled = true;

            NumOfSearchestxt.Text = DB.GetWordSearches(SearchBox.Text).ToString();
            NumOfSearchlbl.Visible = true;
            NumOfSearchestxt.Visible = true;
            if (NumOfSearchestxt.Text.Equals("0"))
                NumOfSearchestxt.Enabled = false;
            else
                NumOfSearchestxt.Enabled = true;

            Wordtxt.Text = SearchBox.Text;
            Wordtxt.Visible = true;
            ContainingDocsnum.Text = DB.GetContainingDocs(SearchBox.Text).ToString();
            Documents.Visible = true;
            ContainingDocsnum.Visible = true;
            if (ContainingDocsnum.Text.Equals("0"))
                ContainingDocsnum.Enabled = false;
            else
                ContainingDocsnum.Enabled = true;
            TagsNum.Text = DB.GetContainingTags(SearchBox.Text).ToString();
            Tags.Visible = true;
            TagsNum.Visible = true;
            if (TagsNum.Text.Equals("0"))
            {
                TagsNum.Enabled = true;
                TagsNum.Text = "Add a tag to the word";
            }
            else
                TagsNum.Enabled = true;
            RelationsNum.Text = DB.GetContainingRelations(SearchBox.Text).ToString();
            RelationsNumlbl.Visible = true;
            RelationsNum.Visible = true;
            if (RelationsNum.Text.Equals("0"))
            {
                RelationsNum.Enabled = true;
                RelationsNum.Text = "Add a relation for the word";
            }
            else
                RelationsNum.Enabled = true;
            ExpressionsNum.Text = DB.GetContainingExpressions(SearchBox.Text).ToString();
            Expressions.Visible = true;
            ExpressionsNum.Visible = true;
            if (ExpressionsNum.Text.Equals("0"))
            {
                ExpressionsNum.Enabled = true;
                ExpressionsNum.Text = "Add an expression for the word";
            }
            else
                ExpressionsNum.Enabled = true;
        }
        
        private void ContainingDocsnum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DocNames form = new DocNames(SearchBox.Text, this);
            form.Show();
        }

        private void TagsNum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WordTags form = new WordTags(SearchBox.Text,this);
            form.Show();
        }

        private void AddTagLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddTag form = new AddTag(this);
            form.Show();
        }

        private void AddRelationsLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddRelation form = new AddRelation(this);
            form.Show();
        }

        private void RelationsNum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WordRelation form = new WordRelation(SearchBox.Text,this);
            form.Show();
        }

        private void ExpressionsNum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WordExpression form = new WordExpression(SearchBox.Text, this);
            form.Show();
        }

        private void AddExpression_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddExpression form = new AddExpression(this);
            form.Show();
        }

        private void AddDocTypeLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddDocType form = new AddDocType();
            form.Show();
        }

        private void ShowAllWords_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AllWords form = new AllWords();
            form.Show();
        }

        private void AdvancedSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdvancedSearch Form = new AdvancedSearch(this, SearchBox.Text);
            Form.ShowDialog();
        }
        
        private void BackupRestore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bacup_Restore form = new Bacup_Restore();
            form.ShowDialog();
        }
    }
}
