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
    public partial class RelateWords : Form
    {
        DBConDataContext DB = new DBConDataContext();
        Form parent;
        int isDual;
        public RelateWords()
        {
            InitializeComponent();
            this.relationsTableAdapter.Fill(this.concordationDataSet._Relations);
        }

        public RelateWords(Form myparent)
        {
            InitializeComponent();
            parent = myparent;
        }

        private void RelateWords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'concordationDataSet._Relations' table. You can move, or remove it, as needed.
            this.relationsTableAdapter.Fill(this.concordationDataSet._Relations);
            // TODO: This line of code loads data into the 'concordationDataSet.Words' table. You can move, or remove it, as needed.
            this.wordsTableAdapter.Fill(this.concordationDataSet.Words);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddRelation form = new AddRelation(this);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Direction.Checked)
                isDual = 1;
            else
                isDual = 0;
            if (RelationBox.Text != "")
            {
                int result = DB.RelateWords(Word1Box.Text, RelationBox.Text, Word2Box.Text, isDual);
                if (result == -1)
                    MessageBox.Show("Relation Already Exists");
                this.Close();
                
            }
            else
                MessageBox.Show("Relation Name is mandatory, Click the \"add Relation\" Link");
            
        }

        private void RelationBox_Enter(object sender, EventArgs e)
        {
            this.relationsTableAdapter.Fill(this.concordationDataSet._Relations);
        }
    }
}
