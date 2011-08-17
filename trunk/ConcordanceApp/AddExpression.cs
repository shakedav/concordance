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
    public partial class AddExpression : Form
    {
        DBConDataContext DB = new DBConDataContext();
        Form parent;

        public AddExpression()
        {
            InitializeComponent();
        }

        public AddExpression(Form myparent)
        {
            InitializeComponent();
            parent = myparent;
        }

        private void AddExpression_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'concordationDataSet.Expressions' table. You can move, or remove it, as needed.
            //this.expressionsTableAdapter.Fill(this.concordationDataSet.Expressions);
            ExpressionsGrid.DataSource = DB.GetExpressions();
            
        }

        private void Expressionbtn_Click(object sender, EventArgs e)
        {
            string Expression = Expressiontxt.Text.Trim();
            string[] words = Expression.Split(' ');
            int wordid;
            int wordnum = 0;
            foreach( string word in words)
            {
                wordnum++;
                wordid = DB.GetWordID(word);
                if (wordid == -1)
                {
                    DB.InsertWord2(word, -1, -1, -1);
                    wordid = DB.GetWordID(word);
                }
                DB.AddExpression(wordid, Expressiontxt.Text, wordnum);
            }
            ExpressionsGrid.DataSource = DB.GetExpressions();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(Expressiontxt.Text)))
            {
                DB.DeleteExpression(Expressiontxt.Text);
                ExpressionsGrid.DataSource = DB.GetExpressions();
                Expressiontxt.Clear();
            }
        }

        private void ExpressionsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Expressiontxt.Text = ExpressionsGrid[ExpressionsGrid.CurrentCellAddress.X, ExpressionsGrid.CurrentCellAddress.Y].Value.ToString();
        }

    }
}
