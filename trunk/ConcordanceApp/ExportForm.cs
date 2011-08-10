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

            // create the data adapter 
            SqlDataAdapter dataAdapter = new SqlDataAdapter ("SELECT userId,username FROM users ORDER BY username", sqlConn); 
            // create the DataSet 
            DataSet dataSet = new DataSet(); 
            // fill the DataSet using our DataAdapter 
            dataAdapter.Fill (dataSet);


            DataTable Word = new DataTable()

        }
    }
}
