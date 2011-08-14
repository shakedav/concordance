using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Collections;

namespace concordanceapConcordationDataSetTableAdaptersp
{
    public partial class ImportForm : Form
    {
        string ImportPath = "C:\\Users\\shakedav\\Documents\\My Dropbox\\concordance\\ConcordanceApp\\Export_Import\\";
        DBConDataContext DB = new DBConDataContext();
        
        class AttributeType
        {
            public int AttID { get; set; }
            public string AttName { get; set; }
        }

        class AttributeValues
        {
            public int DocID { get; set; }
            public int AttID { get; set; }
            public string Value { get; set; }
        }

        class DocAttributes
        {
            public int AttID { get; set; }
            public int DocTypeID { get; set; }
        }

        class Documents
        {
            public int DocID { get; set; }
            public int DocType { get; set; }
        }

        class DocumentTypes
        {
            public int DocID { get; set; }
            public string Type { get; set; }
        }

        class Expressions
        {
            public int ExpID { get; set; }
            public string Expression { get; set; }
            public int WordID { get; set; }
            public int WordNum { get; set; }
        }

        class Relations
        {
            public int ID { get; set; }
            public string RelationName { get; set; }
        }

        class Tag
        {
            public int TagID { get; set; }
            public string TagName { get; set; }
        }

        class WordAppearances
        {
            public int WordID { get; set; }
            public int DocID { get; set; }
            public int LineNum { get; set; }
            public int WordNum { get; set; }
            public int Frequency { get; set; }
        }

        class WordRelations
        {
            public int Word1ID { get; set; }
            public int RelationID { get; set; }
            public int Word2ID { get; set; }
        }

        class Words
        {
            public int ID { get; set; }
            public string Word { get; set; }
            public int TotalCount { get; set; }
            public int SearchNums { get; set; }
        }

        class WordTags
        {
            public int WordID { get; set; }
            public int TagID { get; set; }
        }

        protected void ImportTags()
        {
            XDocument xdoc = XDocument.Load(ImportPath + "tags.xml");

            List<Tag> tags =
                (from tag in xdoc.Descendants("Tag")
                 select new Tag
                 {
                     TagID = Int32.Parse(tag.Element("ID").Value),
                     TagName = tag.Element("TagName").Value,
                 }).ToList<Tag>();

            foreach (Tag tag in tags)
                DB.Import_Tag(tag.TagName);
        }

        protected void ImportAttValues()
        {
            XDocument xdoc = XDocument.Load(ImportPath + "AttributeValues.xml");

            List<AttributeValues> AttVals =
                (from attval in xdoc.Descendants("AttributeValue")
                 select new AttributeValues
                 {
                     DocID = Int32.Parse(attval.Element("DocID").Value),
                     AttID = Int32.Parse(attval.Element("AttID").Value),
                     Value = attval.Element("Value").Value,
                 }).ToList<AttributeValues>();
            foreach (AttributeValues attval in AttVals)
                DB.Import_AttValue(attval.DocID, attval.AttID, attval.Value);
        }
       /* protected void ImportAttTypes()
        {
            XDocument xdoc = XDocument.Load(ImportPath + "AttributeTypes.xml");

            List<AttributeType> AttTypes =
                (from type in xdoc.Descendants("AttributeType")
                 select new AttributeType
                 {
                     AttID = Int32.Parse(type.Element("AttID").Value),
                     AttName = type.Element("AttName").Value,
                 }).ToList<AttributeType>();

            foreach (AttributeType type in AttTypes)
                DB.Import_AttType(type.AttName);
        }*/

        public ImportForm()
        {
            InitializeComponent();
        }

        private void Importbtn_Click(object sender, EventArgs e)
        {
             if (AttributeValuesCB.Checked)
                 ImportAttValues();/*
             if (DocAttributesCB.Checked)
                 tables.Add("DocAttributes");
             if (DocumentsCB.Checked)
                 tables.Add("Documents");
             if (DocumentTypesCB.Checked)
                 tables.Add("DocumentTypes");
             if (ExpressionsCB.Checked)
                 tables.Add("Expressions");
             if (RelationsCB.Checked)
                 tables.Add("Relations");*/
             if (TagsCB.Checked)
                    ImportTags();/*
             if (WordApperancesCB.Checked)
                 tables.Add("WordApperances");
             if (WordRelationsCB.Checked)
                 tables.Add("WordRelations");
             if (WordsCB.Checked)
                 tables.Add("Words");
             if (WordTagsCB.Checked)
                 tables.Add("WordTags");*/
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
