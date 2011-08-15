using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace concordanceapConcordationDataSetTableAdaptersp
{
    public partial class Bacup_Restore : Form
    {
        string ImportPath = "D:\\Concordance\\Export_Import\\";
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

        protected void ImportAttTypes()
        {
            if (File.Exists(ImportPath + "AttributeTypes.xml"))
            {
                try
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
                }
                catch (Exception )
                { }
            }
        }

        protected void ImportAttValues()
        {
            if (File.Exists(ImportPath + "AttributeValues.xml"))
            {
                try
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
                catch (Exception ) { }
            }
        }

        protected void ImportDocAttributes()
        {
            if (File.Exists(ImportPath + "DocAttributes.xml"))
            {
                try
                {

                    XDocument xdoc = XDocument.Load(ImportPath + "DocAttributes.xml");

                    List<DocAttributes> DocAtts =
                        (from docatt in xdoc.Descendants("DocAttribute")
                         select new DocAttributes
                         {
                             AttID = Int32.Parse(docatt.Element("AttID").Value),
                             DocTypeID = Int32.Parse(docatt.Element("DocTypeID").Value),
                         }).ToList<DocAttributes>();
                    foreach (DocAttributes docatt in DocAtts)
                        DB.Import_DocAtts(docatt.AttID, docatt.DocTypeID);
                }
                catch (Exception)
                {
                }
            }
        }

        protected void ImportDocuments()
        {
            if (File.Exists(ImportPath + "Documents.xml"))
            {
                try
                {
                    XDocument xdoc = XDocument.Load(ImportPath + "Documents.xml");

                    List<Documents> Docs =
                        (from doc in xdoc.Descendants("Document")
                         select new Documents
                         {
                             DocID = Int32.Parse(doc.Element("ID").Value),
                             DocType = Int32.Parse(doc.Element("TypeID").Value),
                         }).ToList<Documents>();

                    foreach (Documents doc in Docs)
                        DB.Import_Docs(doc.DocType);
                }
                catch (Exception ) { }
            }
        }

        protected void ImportDocumentTypes()
        {
            if (File.Exists(ImportPath + "DocumentTypes.xml"))
            {
                try
                {
                    XDocument xdoc = XDocument.Load(ImportPath + "DocumentTypes.xml");

                    List<DocumentTypes> DocTypes =
                        (from DocType in xdoc.Descendants("DocumentType")
                         select new DocumentTypes
                         {
                             Type = DocType.Element("Type").Value,
                         }).ToList<DocumentTypes>();

                    foreach (DocumentTypes DocType in DocTypes)
                        DB.Import_DocTypes(DocType.Type);
                }
                catch (Exception )
                { }
            }
        }

        protected void ImportExpressions()
        {
            if (File.Exists(ImportPath + "Expressions.xml"))
            {
                try
                {
                    XDocument xdoc = XDocument.Load(ImportPath + "Expressions.xml");

                    List<Expressions> expressions =
                        (from exp in xdoc.Descendants("MyExpression")
                         select new Expressions
                         {
                             ExpID = Int32.Parse(exp.Element("ExpID").Value),
                             Expression = exp.Element("Expression").Value,
                             WordID = Int32.Parse(exp.Element("WordID").Value),
                             WordNum = Int32.Parse(exp.Element("WordNum").Value),
                         }).ToList<Expressions>();

                    foreach (Expressions exp in expressions)
                        DB.Import_expressions(exp.Expression, exp.WordID, exp.WordNum);
                }
                catch (Exception )
                { }
            }
        }

        protected void ImportRelations()
        {
            if (File.Exists(ImportPath + "Relations.xml"))
            {
                try
                {
                    XDocument xdoc = XDocument.Load(ImportPath + "Relations.xml");

                    List<Relations> relations =
                        (from exp in xdoc.Descendants("Relation")
                         select new Relations
                         {
                             ID = Int32.Parse(exp.Element("ID").Value),
                             RelationName = exp.Element("RelationName").Value,
                         }).ToList<Relations>();

                    foreach (Relations rel in relations)
                        DB.Import_Relations(rel.RelationName);
                }
                catch (Exception) { }
            }
        }

        protected void ImportTags()
        {
            if (File.Exists(ImportPath + "tags.xml"))
            {
                try
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
                catch (Exception)
                { }
            }
        }

        protected void ImportWordAppearances()
        {
            if (File.Exists(ImportPath + "WordApperances.xml"))
            {
                try
                {
                    XDocument xdoc = XDocument.Load(ImportPath + "WordApperances.xml");

                    List<WordAppearances> WordAppearances =
                        (from wordAppearance in xdoc.Descendants("WordApperance")
                         select new WordAppearances
                         {
                             WordID = Int32.Parse(wordAppearance.Element("WordID").Value),
                             DocID = Int32.Parse(wordAppearance.Element("DocID").Value),
                             LineNum = Int32.Parse(wordAppearance.Element("LineNum").Value),
                             WordNum = Int32.Parse(wordAppearance.Element("WordNum").Value),
                             Frequency = Int32.Parse(wordAppearance.Element("Frequency").Value),
                         }).ToList<WordAppearances>();

                    foreach (WordAppearances wordAppearance in WordAppearances)
                        DB.Import_WordAppearances(wordAppearance.WordID, wordAppearance.DocID, wordAppearance.LineNum, wordAppearance.WordNum, wordAppearance.Frequency);
                }
                catch (Exception) { }
            }
        }

        protected void ImportWordRelations()
        {
            if (File.Exists(ImportPath + "WordRelations.xml"))
            {
                try
                {
                    XDocument xdoc = XDocument.Load(ImportPath + "WordRelations.xml");

                    List<WordRelations> WordRelations =
                        (from WordRelation in xdoc.Descendants("WordRelation")
                         select new WordRelations
                         {
                             Word1ID = Int32.Parse(WordRelation.Element("Word1ID").Value),
                             RelationID = Int32.Parse(WordRelation.Element("RelationID").Value),
                             Word2ID = Int32.Parse(WordRelation.Element("Word2ID").Value),
                         }).ToList<WordRelations>();

                    foreach (WordRelations WordRelation in WordRelations)
                        DB.Import_WordRelations(WordRelation.Word1ID, WordRelation.RelationID, WordRelation.Word2ID);
                }
                catch (Exception) { }
            }
        }

        protected void ImportWords()
        {
            if (File.Exists(ImportPath + "Words.xml"))
            {
                try
                {
                    XDocument xdoc = XDocument.Load(ImportPath + "Words.xml");

                    List<Words> words =
                        (from word in xdoc.Descendants("MyWord")
                         select new Words
                         {
                             ID = Int32.Parse(word.Element("ID").Value),
                             Word = word.Element("Word").Value,
                             TotalCount = Int32.Parse(word.Element("TotalCount").Value),
                             SearchNums = Int32.Parse(word.Element("SearchNums").Value),
                         }).ToList<Words>();

                    foreach (Words word in words)
                        DB.Import_Words(word.Word, word.TotalCount, word.SearchNums);
                }
                catch (Exception) { }
            }
        }

        protected void ImportWordTags()
        {
            if (File.Exists(ImportPath + "WordTags.xml"))
            {
                try
                {
                    XDocument xdoc = XDocument.Load(ImportPath + "WordTags.xml");

                    List<WordTags> wordtags =
                        (from Wordtag in xdoc.Descendants("WordTag")
                         select new WordTags
                         {
                             WordID = Int32.Parse(Wordtag.Element("WordID").Value),
                             TagID = Int32.Parse(Wordtag.Element("TagID").Value),
                         }).ToList<WordTags>();

                    foreach (WordTags WordTag in wordtags)
                        DB.Import_WordTags(WordTag.WordID, WordTag.TagID);
                }
                catch (Exception ) { }
            }
        }

        public Bacup_Restore()
        {
            InitializeComponent();
        }

        private void Backupbtn_Click(object sender, EventArgs e)
        {
            string[] tables = { "AttributeTypes", "AttributeValues", "DocumentTypes", "DocAttributes", "Documents", "Expressions", "Relations", "Tags", "WordApperances", "WordRelations", "Words", "WordTags" };

            foreach (string table in tables)
            {
                string filename = table + ".xml";
                DB.ExportTable(table, filename);
            }
            MessageBox.Show("Backup Completed, Files are at " + ImportPath);
            this.Close();
        }

        private void Restorebtn_Click(object sender, EventArgs e)
        {
            DB.Clean();
            ImportAttTypes();
            ImportAttValues();
            ImportDocAttributes();
            ImportDocuments();
            ImportDocumentTypes();
            ImportExpressions();
            ImportRelations();
            ImportTags();
            ImportWords();
            ImportWordAppearances();
            ImportWordRelations();
            ImportWordTags(); 
            MessageBox.Show("Restore Completed");
            this.Close();
        }
    }
}
