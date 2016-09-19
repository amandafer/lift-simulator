using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Drawing;

namespace ControlAnElevator
{
    public class Elevator
    {
        private int floor, desiredFloor;
        private bool isDoorOpen = false;
        private bool isRequestButton = false;
        private System.Windows.Forms.Panel objectLift, leftDoor, rightDoor;
        private System.Windows.Forms.Timer timer1, timer2, timer3;
        private System.Windows.Forms.Button requestButton;
        private DatabaseAccess database;
        private Displays liftDisplay;

        public Elevator(int floor, System.Windows.Forms.Panel objectLift, Displays liftDisplay, DatabaseAccess database, System.Windows.Forms.Timer timer1, 
                        System.Windows.Forms.Timer timer2, System.Windows.Forms.Timer timer3,
                        System.Windows.Forms.Panel leftDoor, System.Windows.Forms.Panel rightDoor)
        {
            this.floor = floor;
            this.objectLift = objectLift;
            this.liftDisplay = liftDisplay;
            this.database = database;
            this.timer1 = timer1;
            this.timer2 = timer2;
            this.timer3 = timer3;
            this.leftDoor = leftDoor;
            this.rightDoor = rightDoor;
        }

        // Starts the elevator when buttons from the elevator control are clicked
        public void startElevator(int desiredFloor)
        {
            this.isRequestButton = false;
            this.desiredFloor = desiredFloor;

            moveToFloor(desiredFloor);
            liftDisplay.startArrows(this.desiredFloor);
        }

        // Starts the elevator when requested buttons are clicked
        public void startElevator(int desiredFloor, System.Windows.Forms.Button requestButton)
        {
            this.requestButton = requestButton;
            this.isRequestButton = true;
            this.desiredFloor = desiredFloor;
            
            moveToFloor(desiredFloor);
            liftDisplay.startArrows(this.desiredFloor);
        }

        // Makes the elevator moves between the two floors by calling the event and defining the floor
        public void moveToFloor(int desiredFloor)
        {
            // If the lift is not on the floor where it was called, it goes to the pressed floor
            if (this.desiredFloor != this.floor) 
            {
                // When requests buttons are pressed, the light of it goes on
                if (this.desiredFloor == 1 && this.isRequestButton == true)
                {
                    this.requestButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.upButtonPressed));
                }
                else if (this.desiredFloor == 2 && this.isRequestButton == true)
                {
                    this.requestButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.downButtonPressed));
                }
                               
                if (this.isDoorOpen == true)
                {
                    this.closesDoor();
                }
                else
                {
                    //Animate de elevator                
                    this.timer1.Start();
                    this.timer1.Tick += new System.EventHandler(this.elevatorAnimation);
                }

                database.insertInDB("Elevator is going to " + this.floor + "º floor.", "Elevator is moving.");
            }
            else
            {
                this.opensDoor();
            }
        }

        public void opensDoor()
        {
            // animates door
            this.timer2.Start();
            this.timer2.Tick += new System.EventHandler(this.doorsOpeningAnimation);

            database.insertInDB("Doors Opening", "Elevator is at " + this.floor + "º floor.");
        }

        public void closesDoor()
        {
            // animates door
            this.timer3.Start();
            this.timer3.Tick += new System.EventHandler(this.doorsClosingAnimation);

            database.insertInDB("Doors Closing", "Elevator is at " + this.floor + "º floor.");
        }
        
        // Animate the lift, request buttons and displays
        private void elevatorAnimation(object sender, EventArgs e)
        {
            int newX, newY, minY, maxY;
            newX = objectLift.Location.X;
            newY = objectLift.Location.Y;
            minY = 51;
            maxY = 413;

            // Frames per second of the animation
            int ffs = 5;

            // Sets the new coordinates for the lift
            switch (this.desiredFloor)
            {
                case 1:
                    newX = objectLift.Location.X;
                    newY = objectLift.Location.Y + ffs;
                    break;
                case 2:
                    newX = objectLift.Location.X;
                    newY = objectLift.Location.Y - ffs;
                    break;
                default:
                    Console.WriteLine("The building doesn't have this floor.");
                    break;
            }

            // checks if the coordinates are between the bouderings or if the animation should stop
            if (newY > minY && newY < maxY)
            {
                objectLift.Location = new Point(newX, newY);
            }
            else
            {
                timer1.Stop();
                this.floor = this.desiredFloor;

                // Request buttons are turned off and controls the animations of displays
                switch (this.floor)
                {
                    case 1:
                        newY = maxY - 1;

                        if (this.isRequestButton)
                            this.requestButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.upButton));
                        break;
                    case 2:
                        newY = minY + 1;

                        if (this.isRequestButton)
                            this.requestButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.downButton));
                        break;
                    default:
                        Console.WriteLine("The building doesn't have this floor.");
                        break;
                }

                objectLift.Location = new Point(newX, newY);
                liftDisplay.controlCurrentFloorDisplay(this.floor);
                this.opensDoor();
            }
        }
        
        // Opens the door of the elevator
        private void doorsOpeningAnimation(object sender, EventArgs e)
        {
            int newLeftX, newRightX, newY, minLeftX, maxRightX;

            // Frames per second of the animation
            int ffs = 2;

            // The max and min x which both, left and right, doors are totally open
            minLeftX = -100;
            maxRightX = 200;

            // Sets the new coordinates for opening the doors
            newLeftX = leftDoor.Location.X - ffs;
            newRightX = rightDoor.Location.X + ffs;
            newY = leftDoor.Location.Y;
            
            // Checks if the coordinates are between the range or if the animation should stop
            if (newLeftX > minLeftX && newRightX < maxRightX)
            {
                leftDoor.Location = new Point(newLeftX, newY);
                rightDoor.Location = new Point(newRightX, newY);
            }
            else
            {
                timer2.Stop();

                // Control the new coordinates to be at its maximum or minimum 
                newLeftX = minLeftX + 1;
                newRightX = maxRightX - 1;
                this.isDoorOpen = true;
               
                leftDoor.Location = new Point(newLeftX, newY);
                rightDoor.Location = new Point(newRightX, newY);
                liftDisplay.elevatorArrow.Visible = false;
            }
        }

        // Closes the door of the elevator
        private void doorsClosingAnimation(object sender, EventArgs e)
        {
            int newLeftX, newRightX, newY, maxLeftX, minRightX;

            // Frames per second of the animation
            int ffs = 2;

            maxLeftX = 1;
            minRightX = 102;

            // Sets the new coordinates for closing the doors
            newLeftX = leftDoor.Location.X + ffs;
            newRightX = rightDoor.Location.X - ffs;
            newY = leftDoor.Location.Y;

            // Checks if the coordinates are between the range or if the animation should stop
            if (newLeftX < maxLeftX && newRightX > minRightX)
            {
                leftDoor.Location = new Point(newLeftX, newY);
                rightDoor.Location = new Point(newRightX, newY);
            }
            else
            {
                timer3.Stop();

                newLeftX = maxLeftX - 1;
                newRightX = minRightX + 1;
                this.isDoorOpen = false;

                //Animate de elevator               
                if (this.floor != this.desiredFloor)
                { 
                    this.timer1.Start();
                    this.timer1.Tick += new System.EventHandler(this.elevatorAnimation);
                }

                leftDoor.Location = new Point(newLeftX, newY);
                rightDoor.Location = new Point(newRightX, newY);
                liftDisplay.elevatorArrow.Visible = false;
            }
        }
    }
}
