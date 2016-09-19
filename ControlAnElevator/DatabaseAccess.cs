using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace ControlAnElevator
{
    public class DatabaseAccess
    {
        private string connectionString, queryString;
        private DataSet dataSet;
        private DataTable dataTable;
        private OleDbConnection database;
        private OleDbDataAdapter dataAdapter;
        private OleDbCommand commandInsert;
        System.Windows.Forms.DataGridView dataGridView;

        public DatabaseAccess(string connectionString, string queryString) 
        {
            this.connectionString = connectionString;
            this.queryString = queryString;
        }

        // Loads the content of the database in a datagrid
        public void loadDataGrid(System.Windows.Forms.DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;

            try
            {
                // Data Adapter is used to connect to the logReport.accdb
                database = new OleDbConnection(connectionString);
                dataAdapter = new OleDbDataAdapter(queryString, database);

                // Create Data Set and put the new table in it
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                // Create data Table to fill the data grid and put the columns in the requested order
                dataTable = dataSet.Tables[0];
                dataGridView.Columns.Clear();
                dataGridView.DataSource = dataTable;
            }
            catch (OleDbException dbException)
            {
                MessageBox.Show("Error in retrieving data: " + dbException.Message);
            }
        }

        // Inserts at the database an operation and status of the lift
        public void insertInDB(string operation, string status)
        {
            // Command to insert info in database
            commandInsert = new OleDbCommand("INSERT INTO LogReport (Date_and_Time, Operation, Status_of_Elevator)" +
                                              "VALUES (?, ?, ?)",
                                              database);

            commandInsert.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss"));
            commandInsert.Parameters.AddWithValue("?", operation);
            commandInsert.Parameters.AddWithValue("?", status);

            dataAdapter.InsertCommand = commandInsert;

            // Update the record
            try
            {
                database.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();
            }
            catch (OleDbException dbException)
            {
                MessageBox.Show("Error in retrieving data: " + dbException.Message);
            }
            finally
            {
                database.Close();
                loadDataGrid(dataGridView);
            }
        }
    }
}
