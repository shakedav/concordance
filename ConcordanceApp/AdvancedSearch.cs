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
            label1.Text = _word;
            label1.Visible = true;
        }
    }
}
