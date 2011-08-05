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
            WordRelationsGrid.DataSource = DB.getRelationsOfWord(_word);
            InitializeComponent();
        }

        private void WordRelation_Load(object sender, EventArgs e)
        {
            WordRelationsGrid.DataSource = DB.getRelationsOfWord(_word);
        }
    }
}
