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
        Form parent;

        public AddAttributes()
        {
            InitializeComponent();
        }

        public AddAttributes(AttributesForm myparent, int doctype)
        {
            // TODO: Complete member initialization
            parent = myparent;
            _doctype = doctype;
        }

        private void AddAttributes_Load(object sender, EventArgs e)
        {
            AttNames.DataSource = DB.GetDocAttrs(_doctype);
        }
    }
}
