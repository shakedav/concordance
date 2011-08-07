using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            //ArrayList Attrib = new ArrayList();
            /* TODO: Write the SP and get the name in the other class */

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
                //DB.addAttributes(DocID, composer, (int)AttributeTypes.COMPOSER);
                DB.addAttributes(DocID, name, (int)AttributeTypes.NAME);
                words = FileHandler.ParseFile(filePath + fileName);
                foreach (WordItem word in words)
                    DB.InsertWord2(word.word, word.lineNum, word.wordNum, DocID);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

            //dataGridView1.DataSource = DB.GetSearchWord(SearchBox.Text);
            dataGridView1.DataSource = DB.ContextWords(SearchBox.Text).ToList<ContextWordsResult>();
            dataGridView1.Visible = true;
            this.GetSearchNumbers();
        }

        private void GetSearchNumbers()
        {
             TotAppeartxt.Text = DB.GetTotalAppearances(SearchBox.Text).ToString();
            TotAppeartxt.Visible = true;
            if (TotAppeartxt.Text.Equals("0"))
                TotAppeartxt.Enabled = false;
            else
                TotAppeartxt.Enabled = true;
            Wordtxt.Text = SearchBox.Text;
            Wordtxt.Visible = true;
            ContainingDocsnum.Text = DB.GetContainingDocs(SearchBox.Text).ToString();
            ContainingDocsnum.Visible = true;
            if (ContainingDocsnum.Text.Equals("0"))
                ContainingDocsnum.Enabled = false;
            else
                ContainingDocsnum.Enabled = true;
            TagsNum.Text = DB.GetContainingTags(SearchBox.Text).ToString();
            TagsNum.Visible = true;
            if (TagsNum.Text.Equals("0"))
            {
                TagsNum.Enabled = true;
                TagsNum.Text = "Add a tag to the word";
            }
            else
                TagsNum.Enabled = true;
            RelationsNum.Text = DB.GetContainingRelations(SearchBox.Text).ToString();
            RelationsNum.Visible = true;
            if (RelationsNum.Text.Equals("0"))
            {
                RelationsNum.Enabled = true;
                RelationsNum.Text = "Add a relation for the word";
            }
            else
                RelationsNum.Enabled = true;
            ExpressionsNum.Text = DB.GetContainingExpressions(SearchBox.Text).ToString();
            ExpressionsNum.Visible = true;
            if (ExpressionsNum.Text.Equals("0"))
            {
                ExpressionsNum.Enabled = true;
                ExpressionsNum.Text = "Add a relation for the word";
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
    }
}
