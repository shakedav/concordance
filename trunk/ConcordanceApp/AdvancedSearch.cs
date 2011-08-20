using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace concordanceapConcordationDataSetTableAdaptersp
{
    public partial class AdvancedSearch : Form
    {
        DBConDataContext DB = new DBConDataContext();
        ConcordanceApp parent;
        string _word;
        public AdvancedSearch()
        {
            InitializeComponent();
        }

        public AdvancedSearch(ConcordanceApp myparent, string word)
        {
            InitializeComponent();
            parent = myparent;
            _word = word;
            TagsList.DataSource = DB.GetAllTags();
            Paths.DataSource = DB.GetAvailableAtts(1);
            FileName.DataSource = DB.GetAvailableAtts(2);
            Author.DataSource = DB.GetAvailableAtts(3);
            Composer.DataSource = DB.GetAvailableAtts(4);
            DocName.DataSource = DB.GetAvailableAtts(5);
            Pdate.DataSource = DB.GetAvailableAtts(6);
            Publisher.DataSource = DB.GetAvailableAtts(7);
            Performer.DataSource = DB.GetAvailableAtts(8);
        }


        private void SearchLinebtn_Click(object sender, EventArgs e)
        {
            parent.AdvancedSearchGrid.DataSource = DB.GetWordByLineAndNum(Convert.ToInt32(LineNumtxt.Text), Convert.ToInt32(WordNumtxt.Text));
            parent.RegularSearchGrid.Visible = false;
            parent.AdvancedSearchGrid.Visible = true;
            parent.Wordtxt.Text = "You Searched for words in Line " + LineNumtxt.Text + " Which their word number is:" + WordNumtxt.Text;
            parent.Wordtxt.Visible = true;
            this.Close();
        }

        private void TagSearchbtn_Click(object sender, EventArgs e)
        {
            parent.TagSearchGrid.DataSource = DB.GetWordByTagName(TagsList.Text);
            parent.RegularSearchGrid.Visible = false;
            parent.AdvancedSearchGrid.Visible = false;
            parent.TagSearchGrid.Visible = true;
            parent.Wordtxt.Text = "You Searched for words with tag: " + TagsList.Text;
            parent.Wordtxt.Visible = true;
            this.Close();
        }

        private void PathSearch(object sender, EventArgs e)
        {
            parent.DocumentsGrid.DataSource = DB.GetDocNameByAtt(Paths.Text);
            parent.RegularSearchGrid.Visible = false;
            parent.AdvancedSearchGrid.Visible = false;
            parent.DocumentsGrid.Visible = true;
            parent.Wordtxt.Visible = false;
            this.Close();
        }

        private void FNameSearch(object sender, EventArgs e)
        {
            parent.DocumentsGrid.DataSource = DB.GetDocNameByAtt(FileName.Text);
            parent.RegularSearchGrid.Visible = false;
            parent.AdvancedSearchGrid.Visible = false;
            parent.DocumentsGrid.Visible = true;
            parent.Wordtxt.Visible = false;
            this.Close();
        }

        private void AuthorSearch(object sender, EventArgs e)
        {
            parent.DocumentsGrid.DataSource = DB.GetDocNameByAtt(Author.Text);
            parent.RegularSearchGrid.Visible = false;
            parent.AdvancedSearchGrid.Visible = false;
            parent.DocumentsGrid.Visible = true;
            parent.Wordtxt.Visible = false;
            this.Close();
        }

        private void ComposerSearch(object sender, EventArgs e)
        {
            parent.DocumentsGrid.DataSource = DB.GetDocNameByAtt(Composer.Text);
            parent.RegularSearchGrid.Visible = false;
            parent.AdvancedSearchGrid.Visible = false;
            parent.DocumentsGrid.Visible = true;
            parent.Wordtxt.Visible = false;
            this.Close();
        }

        private void DNameSearch(object sender, EventArgs e)
        {
            parent.DocumentsGrid.DataSource = DB.GetDocNameByAtt(DocName.Text);
            parent.RegularSearchGrid.Visible = false;
            parent.AdvancedSearchGrid.Visible = false;
            parent.DocumentsGrid.Visible = true;
            parent.Wordtxt.Visible = false;
            this.Close();
        }

        private void PdateSearch(object sender, EventArgs e)
        {
            parent.DocumentsGrid.DataSource = DB.GetDocNameByAtt(Pdate.Text);
            parent.RegularSearchGrid.Visible = false;
            parent.AdvancedSearchGrid.Visible = false;
            parent.DocumentsGrid.Visible = true;
            parent.Wordtxt.Visible = false;
            this.Close();
        }

        private void PublisherSearch(object sender, EventArgs e)
        {
            parent.DocumentsGrid.DataSource = DB.GetDocNameByAtt(Publisher.Text);
            parent.RegularSearchGrid.Visible = false;
            parent.AdvancedSearchGrid.Visible = false;
            parent.DocumentsGrid.Visible = true;
            parent.Wordtxt.Visible = false;
            this.Close();
        }

        private void PerformerSearch(object sender, EventArgs e)
        {
            parent.DocumentsGrid.DataSource = DB.GetDocNameByAtt(Performer.Text);
            parent.RegularSearchGrid.Visible = false;
            parent.AdvancedSearchGrid.Visible = false;
            parent.DocumentsGrid.Visible = true;
            parent.Wordtxt.Visible = false;
            this.Close();
        }
    }
}
