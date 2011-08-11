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

namespace concordanceapConcordationDataSetTableAdaptersp
{
    public partial class ExportForm : Form
    {
        DBConDataContext DB = new DBConDataContext();

        public ExportForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ContactDataContext db = new ContactDataContext();
            ConcordationDataSet DB = new ConcordationDataSet();

            XElement xmlDoc = new XElement("Words", 
                                from w in DB.Words 
                                orderby w.ID 
                                select new XElement("word",
                                        new XElement( "Word", w.Word), 
                                        new XElement( "ID", w.ID),
                                        new XElement("TotalAppearances",w.TotalCount),
                                        new XElement("SearchNums",w.SearchNums)));
            xmlDoc.Save("c:\\tmp\\wordsExport");

            /*XElement xmlDoc = new XElement("Contacts", 
                              from c in db.Contacts
                              orderby c.ContactID
                              select new XElement("Contact",
                                     new XElement("ContactID", c.ContactID),
                                     new XElement("FirstName", c.FirstName),
                                     new XElement("LastName", c.LastName)));
            xmlDoc.Save(Server.MapPath(@"~/export.xml"));*/

        }
    }
}
