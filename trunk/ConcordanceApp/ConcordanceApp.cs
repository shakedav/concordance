﻿using System;
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
        public enum AttributeTypes { PATH = 1, FILENAME, AUTHOR, COMPOSER, SONGNAME };
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
            /*int DocID = DocAttributes.getTypeID();*/
            AttributesForm form = new AttributesForm(1, this);
            form.ShowDialog();
 
            /*DocAttributes.Show();*/
            string Author = form.Author;
            string Composer = form.Composer;
            string SongName = form.SongName;

            if (string.IsNullOrEmpty(Author) || string.IsNullOrEmpty(SongName) || string.IsNullOrEmpty(Composer))
            {
                form.Close();
            }
        }

        public void LoadDocument(string author, string composer, string name)
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
                int DocID = DB.InsertDocument("Song", fileName, filePath);
                /* insert the attributes to the DB */
                DB.addAttributes(DocID, author, (int)AttributeTypes.AUTHOR);
                DB.addAttributes(DocID, composer, (int)AttributeTypes.COMPOSER);
                DB.addAttributes(DocID, name, (int)AttributeTypes.SONGNAME);
                words = FileHandler.ParseFile(filePath + fileName);
                foreach (WordItem word in words)
                    DB.InsertWord(word.word, word.lineNum, word.wordNum, DocID);
            }
        }
       
        private void SearchBtn_Click(object sender, EventArgs e)
        {               

            //dataGridView1.DataSource = DB.GetSearchWord(SearchBox.Text);
            dataGridView1.DataSource = DB.ContextWords(SearchBox.Text).ToList<ContextWordsResult>();
            dataGridView1.Visible = true;
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
                TagsNum.Enabled = false;
            else
                TagsNum.Enabled = true;
            
        }

        private void ContainingDocsnum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DocNames form = new DocNames(SearchBox.Text, this);
            form.Show();
        }

        private void TagsNum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //WordTags form = new WordTags(SearchBox.Text,this);
            //form.Show();
        }

        private void AddTagLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddTag form = new AddTag();
            form.Show();
        }
    }
}
