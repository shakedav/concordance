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
            parent.TagSearchGrid.DataSource = DB.GetWordByTagName(Tagtxt.Text);
            parent.RegularSearchGrid.Visible = false;
            parent.AdvancedSearchGrid.Visible = false;
            parent.TagSearchGrid.Visible = true;
            parent.Wordtxt.Text = "You Searched for words with tag: " + Tagtxt.Text;
            parent.Wordtxt.Visible = true;
            this.Close();
        }
    }
}
