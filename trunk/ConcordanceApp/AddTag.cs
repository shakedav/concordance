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
    public partial class AddTag : Form
    {
        DBConDataContext DB = new DBConDataContext();
        public AddTag()
        {
            InitializeComponent();
        }

        private void AddTag_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'concordationDataSet.Tags' table. You can move, or remove it, as needed.
            this.tagsTableAdapter.Fill(this.concordationDataSet.Tags);
        }

        private void AddTagbtn_Click(object sender, EventArgs e)
        {
            int result = DB.AddTag(AddTagTxtBox.Text);
            if (result == 0)
                this.tagsTableAdapter.Fill(this.concordationDataSet.Tags);
            else
                MessageBox.Show("Tag Already Exists");
        }
    }
}
