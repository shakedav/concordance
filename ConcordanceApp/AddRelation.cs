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
    public partial class AddRelation : Form
    {
        DBConDataContext DB = new DBConDataContext();
        Form parent;
        public AddRelation()
        {
            InitializeComponent();
        }

        public AddRelation(Form myparent)
        {
            InitializeComponent();
            parent = myparent;
        }

        private void AddRelation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'concordationDataSet._Relations' table. You can move, or remove it, as needed.
            this.relationsTableAdapter.Fill(this.concordationDataSet._Relations);

        }

        private void AddRelationbtn_Click(object sender, EventArgs e)
        {
            int result = DB.AddRelation(AddRelationTxtBox.Text);
            if (result == 0)
                this.relationsTableAdapter.Fill(this.concordationDataSet._Relations);
            else
                MessageBox.Show("Relation Already Exists");
        }     

        private void AddRelation_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Invalidate();
        }
    }
}
