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
            if (AttributeTypesCB.Checked)
                tables.Add("AttributeTypes");
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

            /*
            ConcordationDataSet DS = new ConcordationDataSet();
            DS.WriteXml("C:\\tmp\\ds.xml");*/
            /*
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\tmp\Export.xml",true);
            string result = "";
            foreach (string table in tables)
            {
                result = DB.ExportTable(table).ToString();
                file.WriteLine(result);
            }*/
        }
    }
}
