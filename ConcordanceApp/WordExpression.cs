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
    public partial class WordExpression : Form
    {
        DBConDataContext DB = new DBConDataContext();
        Form parent;
        string _word;
        public WordExpression()
        {
            InitializeComponent();
        }

        public WordExpression(string word, Form myparent)
        {
            InitializeComponent();
            _word = word;
            parent = myparent;
        }

        private void WordExpression_Load(object sender, EventArgs e)
        {
            WordExpressionDG.DataSource = DB.GetExpressionsOfWord(_word);

        }

        private void AddExpression_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddExpression form = new AddExpression(this);
            form.Show();
        }
    }
}
