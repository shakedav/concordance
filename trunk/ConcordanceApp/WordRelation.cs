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
    public partial class WordRelation : Form
    {
        DBConDataContext DB = new DBConDataContext();
        Form parent;
        string _word;

        public WordRelation()
        {
            InitializeComponent();
        }

        public WordRelation(string word, Form myparent)
        {
            parent = myparent;
            _word = word;
            InitializeComponent();
        }

        private void WordRelation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'concordationDataSet._Relations' table. You can move, or remove it, as needed.
            this.relationsTableAdapter.Fill(this.concordationDataSet._Relations);
            WordRelationsGrid.DataSource = DB.getRelationsOfWord(_word);
        }

        private void AddTaglnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RelateWords form = new RelateWords(this);
            form.ShowDialog();
        }
    }
}
