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
    public partial class AllWords : Form
    {
        DBConDataContext DB = new DBConDataContext();
        public AllWords()
        {
            InitializeComponent();
            PleaseWait form = new PleaseWait();
            form.Show();
            Application.DoEvents();
            WordsGrid.DataSource = DB.GetAllWords().ToList<GetAllWordsResult>();
            form.Close();
            WordsGrid.Visible = true;
        }
    }
}
