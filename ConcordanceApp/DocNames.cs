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
    public partial class DocNames : Form
    {
        DBConDataContext DB = new DBConDataContext();
        public DocNames(string word, ConcordanceApp myParent)
        {
            InitializeComponent();
            DocNamesGrid.DataSource = DB.GetDocsOfWord(word);
        }
    }
}
