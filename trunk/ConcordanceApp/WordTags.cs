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
            AddTag form = new AddTag(this);
            form.Show();
        }

        private void AddTag_Click(object sender, EventArgs e)
        {
            int result = DB.TagWord(_word,comboBox1.Text);
            if (result == -1)
                MessageBox.Show("Tag Already Exists for this word");
            Tags.DataSource = DB.GetTagsofWord(_word).ToList<GetTagsofWordResult>();
            this.tagsTableAdapter.Fill(this.concordationDataSet.Tags);
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            this.tagsTableAdapter.Fill(this.concordationDataSet.Tags);
        }
    }
}
