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
            // TODO: This line of code loads data into the 'concordationDataSet.Expressions' table. You can move, or remove it, as needed.
            this.expressionsTableAdapter.Fill(this.concordationDataSet.Expressions);

        }
    }
}
