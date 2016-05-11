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

        void selectQuery(string queryString, DataGridView dgv)
        {
            DataGridViewRowCollection resultGridRows = dgv.Rows;

            connect();
            SqlCommand query = new SqlCommand();
            query.Connection = bitdevConnection;
            query.CommandText = queryString;
            

            SqlDataReader reader;
            reader = query.ExecuteReader();
            reader.Read();          // Loads reader up with selected record

            int fieldCount = reader.FieldCount;

            var columns = Enumerable.Range(0, reader.FieldCount)        // Use some LINQ
                                    .Select(reader.GetName)
                                    .ToList();

            foreach (var col in columns)
            {
                dgv.Columns.Add(col, col);
            }

            while (reader.Read())
            {
                string[] newRow = new string[fieldCount];
                for (int i = 0; i < fieldCount; i++)
                {
                    string currField = reader.GetName(i);
                    string currValue = reader.GetValue(i).ToString();
                    newRow[i] = currValue;
                }
                resultGridRows.Add(newRow);

            }

            

            bitdevConnection.Close();   // Close connection after we're done with the query
        }

        public void ListAllPapers(DataGridView dgv)
        {
            string queryString = "SELECT dbo.tblPapers.Name, dbo.tblTutors.FirstName, dbo.tblTutors.LastName, dbo.tblTutors.Email " +
                "FROM dbo.tblPapers JOIN dbo.tblTutors ON dbo.tblPapers.TutorID=dbo.tblTutors.TutorID;";

            selectQuery(queryString, dgv);
        }
    }
}
