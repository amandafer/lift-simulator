using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ControlAnElevator
{
    public partial class Assignment1 : Form {
        private Elevator lift;
        private Displays liftDisplay;
        private DatabaseAccess database;
        private int desiredFloor;
        private string connectionString, queryString;

        public Assignment1() {
            InitializeComponent();

            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=logFile.accdb";
            queryString = "SELECT * FROM LogReport";
            database = new DatabaseAccess(connectionString, queryString);
            database.loadDataGrid(this.dataGridView1);

            liftDisplay = new Displays(this.panelDisplay, this.topPanel1Floor, this.topPanel2Floor, this.elevatorArrow);
            lift = new Elevator(1, this.elevator, this.liftDisplay, database, this.timer1, this.timer2, this.timer3, this.leftDoor, this.rightDoor);
        }

        /* START EVENT HANDLERS */
        // Event for the request button from the first floor
        private void firstFloorRB_Click(object sender, EventArgs e)
        {
            this.desiredFloor = 1;            
            lift.startElevator(this.desiredFloor, this.firstFloorRB);
        }

        // Event for the request button from the second floor
        private void secondFloorRB_Click(object sender, EventArgs e)
        {
            this.desiredFloor = 2;
            lift.startElevator(this.desiredFloor, this.secondFloorRB);
        }

        // Event for the elevator button that goes to first floor
        private void firstFloorEB_Click(object sender, EventArgs e)
        {
            this.desiredFloor = 1;
            lift.startElevator(this.desiredFloor);
        }

        // Event for the elevator button that goes to second floor
        private void secondFloorEB_Click(object sender, EventArgs e)
        {
            this.desiredFloor = 2;
            lift.startElevator(this.desiredFloor);
        }

        // Event for the elevator button to open the door
        private void openDoorsButton_Click(object sender, EventArgs e)
        {
            lift.opensDoor();
        }

        // Event for the elevator button to close the door
        private void closeDoorsButton_Click(object sender, EventArgs e)
        {
            lift.closesDoor();
        }

        // Event for the elevator button to alarm a problem with the lift
        private void alarmButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alarm button pressed. Elevator will be soon fixed!");
            MessageBox.Show("Elevator is now working!");
        }
        
        // Reloads the datagrid and fills it if any changes were made
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count != 0)
            {
                database.loadDataGrid(this.dataGridView1);
                MessageBox.Show("All changes were saved!");
            }
            else
            {
                MessageBox.Show("Your database is empty!");
            }
        }
        /* END EVENT HANDLERS */
    }
}
