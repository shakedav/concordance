using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.IO;

namespace concordanceapConcordationDataSetTableAdaptersp
{
    public partial class ExportForm : Form
    {
        DBConDataContext DB = new DBConDataContext();

        public ExportForm()
        {
            InitializeComponent();
        }

        private void Exportbtn_Click(object sender, EventArgs e)
        {
            ArrayList tables = new ArrayList();
            if (AttributeValuesCB.Checked)
                tables.Add("AttributeValues");
            if (DocAttributesCB.Checked)
                tables.Add("DocAttributes");
            if (DocumentsCB.Checked)
                tables.Add("Documents");
            if (DocumentTypesCB.Checked)
                tables.Add("DocumentTypes");
            if (ExpressionsCB.Checked)
                tables.Add("Expressions");
            if (RelationsCB.Checked)
                tables.Add("Relations");
            if (TagsCB.Checked)
                tables.Add("Tags");
            if (WordApperancesCB.Checked)
                tables.Add("WordApperances");
            if (WordRelationsCB.Checked)
                tables.Add("WordRelations");
            if (WordsCB.Checked)
                tables.Add("Words");
            if (WordTagsCB.Checked)
                tables.Add("WordTags");

            foreach (string table in tables)
            {
                string filename = table + ".xml"; 
                DB.ExportTable(table, filename);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AttributeValuesCB.Checked = true;
            DocAttributesCB.Checked = true;
            DocumentsCB.Checked = true;
            DocumentTypesCB.Checked = true;
            ExpressionsCB.Checked = true;
            RelationsCB.Checked = true;
            TagsCB.Checked = true;
            WordApperancesCB.Checked = true;
            WordRelationsCB.Checked = true;
            WordsCB.Checked = true;
            WordTagsCB.Checked = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AttributeValuesCB.Checked = false;
            DocAttributesCB.Checked = false;
            DocumentsCB.Checked = false;
            DocumentTypesCB.Checked = false;
            ExpressionsCB.Checked = false;
            RelationsCB.Checked = false;
            TagsCB.Checked = false;
            WordApperancesCB.Checked = false;
            WordRelationsCB.Checked = false;
            WordsCB.Checked = false;
            WordTagsCB.Checked = false;
        }
    }
}
