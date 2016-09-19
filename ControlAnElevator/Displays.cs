using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAnElevator
{
    public class Displays
    {
        private System.Windows.Forms.Panel panelDisplay, topPanel1Floor, topPanel2Floor;
        public System.Windows.Forms.PictureBox elevatorArrow;

        public Displays(System.Windows.Forms.Panel panelDisplay, System.Windows.Forms.Panel topPanel1Floor,
                        System.Windows.Forms.Panel topPanel2Floor, System.Windows.Forms.PictureBox elevatorArrow)
        {
            this.panelDisplay = panelDisplay;
            this.topPanel1Floor = topPanel1Floor;
            this.topPanel2Floor = topPanel2Floor;
            this.elevatorArrow = elevatorArrow;
        }

        // Change the floor on elevator display and top panels
        public void controlCurrentFloorDisplay(int desiredFloor)
        {
            // Put the current floor the lift is on the top panels
            if (desiredFloor == 1)
            {
                this.panelDisplay.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.numberOne));
                this.topPanel1Floor.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.numberOneTop));
                this.topPanel2Floor.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.numberOneTop));
            }
            else if (desiredFloor == 2)
            {
                this.panelDisplay.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.numberTwo));
                this.topPanel1Floor.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.numberTwoTop));
                this.topPanel2Floor.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.numberTwoTop));
            }
        }

        // Arrows that indicate if the elevator is going up or down
        public void startArrows(int desiredFloor)
        {
            if (desiredFloor == 1)
            {
                this.elevatorArrow.Image = ((System.Drawing.Image)(Properties.Resources.downArrow));
                this.elevatorArrow.Visible = true;
            }
            else if (desiredFloor == 2)
            {
                this.elevatorArrow.Image = ((System.Drawing.Image)(Properties.Resources.upArrow));
                this.elevatorArrow.Visible = true;
            }
        }
    }
}
