using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentDatabaseADO
{
    public class DBManager
    {
        SqlConnection bitdevConnection;

        public DBManager()
        {
            // dunno yet
        }

        //=========================================================================================================================================
        //
        //                                                          Utility Methods
        //
        //=========================================================================================================================================

        // Use when we need to connect to the database
        void connect()
        {
            bitdevConnection = new SqlConnection();

            bitdevConnection.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;" +
                                                "Initial Catalog = IN712_201501_sleemjm1;" +
                                                "User ID = sleemjm1;" +
                                                "Password = " + Info.password + ";";

            bitdevConnection.Open();
        }

        void selectQuery(string queryString, DataGridView dgv, BindingSource bs)
        {
            connect();
            SqlCommand query = new SqlCommand();
            query.Connection = bitdevConnection;
            query.CommandText = queryString;
            
            SqlDataReader reader;
            reader = query.ExecuteReader();
            //reader.Read();

            // Set up data grid view
            dgv.Dock = DockStyle.Fill;

            // Automatically generate the DataGridView columns
            dgv.AutoGenerateColumns = true;

            // Set up data source
            bs.DataSource = reader.Read();
            dgv.DataSource = bs;

            // Automatically resize the visable rows
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            //int fieldCount = reader.FieldCount;
            //for (int i = 0; i < fieldCount; i++)
            //{
            //    string currentField = reader.GetName(i);
            //    string currentValue = reader.GetValue(i).ToString();

            //    // Code here to add to dataGridView
            //}

            bitdevConnection.Close();   // Close connection after we're done with the query
        }

        public void ListAllPapers(DataGridView dgv, BindingSource bs)
        {
            string queryString = "SELECT dbo.tblPapers.Name, dbo.tblTutors.FirstName, dbo.tblTutors.LastName, dbo.tblTutors.Email " +
                "FROM dbo.tblPapers JOIN dbo.tblTutors ON dbo.Papers.TutorID=dbo.tblTutors.TutorID;";

            selectQuery(queryString, dgv, bs);
        }
    }
}
