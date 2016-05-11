using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentTrackingADO
{
    public class DBManager
    {
        SqlConnection bitdevConnection;
        public DBManager()
        {
            populateDatabase();            
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

        // We will use this whever we need to execute a non-query
        private void executeNonQuery(string queryToExecute)
        {
            SqlCommand nonQuery = new SqlCommand(queryToExecute, bitdevConnection);
            nonQuery.ExecuteNonQuery();
        }

        // Method used to drop a table if it exists
        private void dropTable(string tableToDrop)
        {
            String dropTable = "IF OBJECT_ID('dbo." + tableToDrop + "', 'U') IS NOT NULL DROP TABLE dbo." + tableToDrop + ";";
            executeNonQuery(dropTable);
        }

        //=========================================================================================================================================
        //
        //                                                          Table Creation
        //
        //=========================================================================================================================================

        void createTutorsTable()
        {
            string createTableQuery = "CREATE TABLE dbo.tblTutors (" +
                                        "TutorID INT IDENTITY, " +
                                        "FirstName VARCHAR(50), " +
                                        "LastName VARCHAR(50), " +
                                        "Email VARCHAR(50), " +
                                        "PhoneNumber VARCHAR(20), " +       // Leave as string for now because leading zeros maybe problematic
                                        "PRIMARY KEY (TutorID))";

            executeNonQuery(createTableQuery);
        }

        void createPapersTable()
        {
            string createTableQuery = "CREATE TABLE dbo.tblPapers (" +
                                        "PaperID INT IDENTITY, " +
                                        "TutorID INT, " +
                                        "Name VARCHAR(50), " +
                                        "Description VARCHAR(100), " +
                                        "PRIMARY KEY (PaperID))";

            executeNonQuery(createTableQuery);
        }

        void createAssignmentsTable()
        {
            string createTableQuery = "CREATE TABLE dbo.tblAssignments (" +
                                        "AssignmentID INT IDENTITY, " +
                                        "PaperID INT, " +
                                        "Name VARCHAR(50)," +
                                        "Description VARCHAR(100), " +
                                        "DueDate DATE, " +              // DATE - format YY-MM-DD
                                        "Grade INT, " +
                                        "Submitted BIT, " +             // Bit is a 1 or 0, 0 = false, 1 = true -- SQL Booleans don't exist?
                                        "PRIMARY KEY (AssignmentID))";

            executeNonQuery(createTableQuery);
        }

        //=========================================================================================================================================
        //
        //                                                          Insert Records
        //
        //=========================================================================================================================================

        // Tutors
        
        // insertTutor - Used when we want to insert a tutor in to our database
        void insertTutor(string firstName, string lastName, string email, string phone)
        {
            string insertTutor = "INSERT INTO dbo.tblTutors VALUES ('" + firstName + "', '" + lastName + "', '" + email + "', '" + phone + "');";
            executeNonQuery(insertTutor);
        }

        // insertAllTutors - Insert a batch of tutors
        void insertAllTutors()
        {
            insertTutor("Patricia", "Haden", "phaden@op.ac.nz", "0212835521");
            insertTutor("Christopher", "Frantz", "cfrantz@op.ac.nz", "022193212");
            insertTutor("Tom", "Clark", "tclark@op.ac.nz", "0279293422");
        }

        // Papers

        void insertPaper(int tutorID, string name, string description)
        {
            string insertPaper = "INSERT INTO dbo.tblPapers VALUES ('" + tutorID + "', '" + name + "', '" + description + "');";
            executeNonQuery(insertPaper);
        }

        void insertAllPapers()
        {
            insertPaper(1, "OOSD", "Object Oriented System Design - Learn design patterns and some advanced programming techniques.");
            insertPaper(2, "Systems Administration", "Learn Systems Administration tools and techniques used when administering small systems.");
            insertPaper(3, "Project", "Third Year Project - Work for a client to develop a software solution to their problem.");
        }

        // Assignments

        void insertAssignment(int paperID, string name, string description, int year, int month, int day, int grade, bool bit)
        {
            int submitted = 0;      // start as false (0)
            if (bit)
                submitted = 1;      // change to true (1) if true
            string date = year + "-" + month + "-" + day;

            string insertAssignment = "INSERT INTO dbo.tblAssignments VALUES ('" + paperID + "', '" + name + "', '" + description + "', '" +
                                                                                date + "', '" + grade + "', '" + submitted + "');";
            executeNonQuery(insertAssignment);
        }

        void insertAllAssignments()
        {
            insertAssignment(1, "Assignment One - Grey Scott", "Create a grey-scott simulation and produce some nice images.",
                2016, 05, 02, 83, true);
            insertAssignment(1, "Assignment Two - MVC", "Create some sort of website using MVC architecture.",
                2016, 06, 05, 0, false);
            insertAssignment(2, "Assignment One - Administer a cloud-based system", "Use a variety of tools to set-up and admin a small system",
                2016, 07, 01, 0, false);
            insertAssignment(3, "Third Year Project - EMF", "Produce an asset management system based around Experience Management Framework",
                2016, 06, 20, 0, false);
            insertAssignment(1, "Week 11 OOSD Lab", "Produce a Windows Forms application to track your assignments for the BIT",
                2016, 05, 13, 0, false);
        }


        //=========================================================================================================================================
        //
        //                                                          Populate Database
        //
        //=========================================================================================================================================


        // We will first drop tables and then repopulate them with seed data created above
        void populateDatabase()
        {
            connect();
            
            // Drop tables
            dropTable("tblTutors");
            dropTable("tblPapers");
            dropTable("tblAssignments");

            createTutorsTable();
            insertAllTutors();

            createPapersTable();
            insertAllPapers();

            createAssignmentsTable();
            insertAllAssignments();

            bitdevConnection.Close();   
        }
    }
}
