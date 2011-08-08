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
    public partial class AddAttributes : Form
    {
        DBConDataContext DB = new DBConDataContext();
        int _doctype;
        int docid;
        AttributesForm parent;

        public AddAttributes()
        {
            InitializeComponent();
        }

        public AddAttributes(AttributesForm myparent, int doctype)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            parent = myparent;
            _doctype = doctype;
            docid = DB.getDocID(parent.DocumentName);
        }

        private void AddAttributes_Load(object sender, EventArgs e)
        {
            AttNames.DataSource = DB.GetTypeAtts(_doctype);
            if (docid == -1)
                CurrentAttrs.Visible = false;
            else
            {
                CurrentAttrs.DataSource = DB.GetExistingAttsfordoc(docid);
                CurrentAttrs.Visible = true;
            }
        }

        private void SaveAtt_Click(object sender, EventArgs e)
        {
            int attid = DB.GetAttTypeID(AttNames.Text);
            DB.addAttributes(docid, AttValtxt.Text, attid);
            CurrentAttrs.DataSource = DB.GetExistingAttsfordoc(docid);
        }
    }
}
