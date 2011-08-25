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
        DBConDataContext DB = new DBConDataContext();
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

        public string DocumentName
        {
            set { Nametxt.Text = value; }
            get
            {
                return Nametxt.Text;                 
            }
        }

        public int DocType
        {
            get
            {
                return DB.GetDocType(DocTypeBox.Text);
            }
        }

        private void Nametxt_Leave(object sender, EventArgs e)
        {
            if (Nametxt.Text == "")
                NameError.SetError(Nametxt, "Name is mandatory");
            else
                NameError.SetError(Nametxt, "");

        }

       /* private void Composertxt_Leave(object sender, EventArgs e)
        {
            if (Composertxt.Text == "")
                ComposerError.SetError(Composertxt, "Composer is mandatory");
            else
                ComposerError.SetError(Composertxt, "");
        }*/

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
            myParent.LoadDocument(this.Author, this.DocumentName, this.DocType);
            this.Close();
            if (this.DocType == 1)
            {
                // TODO: Add StoryAttrs Form
                StoryAttrs form = new StoryAttrs(this, this.DocType);
                form.ShowDialog();
            }
            if (this.DocType == 2)
            {
                // TODO: Add SongAttrs Form
                SongAttrs form = new SongAttrs(this, this.DocType);
                form.ShowDialog();
            }

            /*AddAttributes form = new AddAttributes(this,this.DocType);
            form.Show();*/
        }

        private void AttributesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'concordationDataSet.DocumentTypes' table. You can move, or remove it, as needed.
            this.documentTypesTableAdapter.Fill(this.concordationDataSet.DocumentTypes);

        }
    }
}
