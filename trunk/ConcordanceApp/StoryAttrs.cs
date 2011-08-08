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
    public partial class StoryAttrs : Form
    {
        DBConDataContext DB = new DBConDataContext();
        int _doctype;
        int docid;
        AttributesForm parent;

        public StoryAttrs()
        {
            InitializeComponent();
        }

        public StoryAttrs(AttributesForm myparent, int doctype)
        {
            InitializeComponent();
            parent = myparent;
            _doctype = doctype;
            docid = DB.getDocID(parent.DocumentName);
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (PublishDatetxt.Text != "")  
                DB.addAttributes(docid, PublishDatetxt.Text, 6);
            if (Publishertxt.Text != "")
                DB.addAttributes(docid, Publishertxt.Text, 7);
            this.Close();
        }
    }
}
