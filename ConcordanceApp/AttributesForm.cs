using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using concordanceapConcordationDataSetTableAdaptersp;

namespace concordanceapConcordationDataSetTableAdaptersp
{
    public partial class AttributesForm : Form
    {
        ConcordanceApp myParent = null;
        public AttributesForm(int DocID, ConcordanceApp myParent)
        {
            InitializeComponent();
            this.myParent = myParent;
        }

        public string Author
        {
            set { Authortxt.Text = value; }

            get
            {
               return Authortxt.Text;
            }
        }

        public string Composer
        {
            set { Composertxt.Text = value; }
            get
            {
                return Composertxt.Text;
            }
        }

        public string SongName
        {
            set { SongNametxt.Text = value; }
            get
            {
                return SongNametxt.Text;                 
            }
        }

        private void SongNametxt_Leave(object sender, EventArgs e)
        {
            if (SongNametxt.Text == "")
                NameError.SetError(SongNametxt, "Name is mandatory");
            else
                NameError.SetError(SongNametxt, "");

        }

        private void Composertxt_Leave(object sender, EventArgs e)
        {
            if (Composertxt.Text == "")
                ComposerError.SetError(Composertxt, "Composer is mandatory");
            else
                ComposerError.SetError(Composertxt, "");
        }

        private void Authortxt_Leave(object sender, EventArgs e)
        {
            if (Authortxt.Text == "")
                AuthorError.SetError(Authortxt, "Author is mandatory");
            else
                AuthorError.SetError(Authortxt, "");
        }

        private void AttributesForm_FormClosed(object sender, FormClosedEventArgs e)
        { 

        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            myParent.LoadDocument(this.Author, this.Composer, this.SongName);
            this.Close();
        }
    }
}
