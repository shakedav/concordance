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
    public partial class WordTags : Form
    {
        DBConDataContext DB = new DBConDataContext();
        string _word;
        public WordTags(string word, Form myparent)
        {
            InitializeComponent();
            Tags.DataSource = DB.GetTagsofWord(word).ToList<GetTagsofWordResult>();
            _word = word;
        }

        private void WordTags_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'concordationDataSet.Tags' table. You can move, or remove it, as needed.
            this.tagsTableAdapter.Fill(this.concordationDataSet.Tags);
        }

        private void AddTaglnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddTag form = new AddTag();
            form.Show();
        }

        private void AddTag_Click(object sender, EventArgs e)
        {
            DB.TagWord(_word,comboBox1.Text);
            Tags.DataSource = DB.GetTagsofWord(_word).ToList<GetTagsofWordResult>();
        }
    }
}
