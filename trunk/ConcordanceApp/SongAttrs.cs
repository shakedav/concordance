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
    public partial class SongAttrs : Form
    {

        DBConDataContext DB = new DBConDataContext();
        int _doctype;
        int docid;
        AttributesForm parent;

        public SongAttrs()
        {
            InitializeComponent();
        }

        public SongAttrs(AttributesForm myparent, int doctype)
        {
            InitializeComponent();
            parent = myparent;
            _doctype = doctype;
            docid = DB.getDocID(parent.DocumentName);
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (Composertxt.Text != "")
                DB.addAttributes(docid, Composertxt.Text, 4);
            if (PublishDatetxt.Text != "")
                DB.addAttributes(docid, PublishDatetxt.Text, 6);
            if (Publishertxt.Text != "")
                DB.addAttributes(docid, Publishertxt.Text, 7);
            if (Performertxt.Text != "")
                DB.addAttributes(docid, Performertxt.Text, 8);
            this.Close();
        }

    }
}
