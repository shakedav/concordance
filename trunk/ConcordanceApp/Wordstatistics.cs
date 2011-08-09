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
    public partial class Wordstatistics : Form
    {
        DBConDataContext DB = new DBConDataContext();
        ConcordanceApp parent;
        string _word;

        public Wordstatistics()
        {
            InitializeComponent();
        }

        public Wordstatistics(ConcordanceApp myparent, string word)
        {
            InitializeComponent();
            if ((word != "Word / Term") && (word != ""))
            {
                Word.Text = word;
                StatsGrid.DataSource = DB.GetWordStats(word);
                parent = myparent;
                _word = word;
                this.ShowDialog();
            }
            else
            {
                MessageBox.Show("Search for a word first");
            }
            
        }
    }
}
