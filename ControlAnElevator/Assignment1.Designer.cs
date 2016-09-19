namespace ControlAnElevator
{
    partial class Assignment1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assignment1));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.firstFloor = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.secondFloor = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.updateButton = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.logID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.topPanel1Floor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topPanel2Floor = new System.Windows.Forms.Panel();
            this.secondFloorRB = new System.Windows.Forms.Button();
            this.firstFloorRB = new System.Windows.Forms.Button();
            this.elevator = new System.Windows.Forms.Panel();
            this.rightDoor = new System.Windows.Forms.Panel();
            this.leftDoor = new System.Windows.Forms.Panel();
            this.elevatorDisplay = new System.Windows.Forms.Panel();
            this.alarmButton = new System.Windows.Forms.Button();
            this.closeDoorsButton = new System.Windows.Forms.Button();
            this.openDoorsButton = new System.Windows.Forms.Button();
            this.firstFloorEB = new System.Windows.Forms.Button();
            this.elevatorArrow = new System.Windows.Forms.PictureBox();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.secondFloorEB = new System.Windows.Forms.Button();
            this.doorsBackground = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.logBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.elevator.SuspendLayout();
            this.elevatorDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.firstFloor,
            this.secondFloor});
            this.shapeContainer1.Size = new System.Drawing.Size(1060, 732);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // firstFloor
            // 
            this.firstFloor.BackColor = System.Drawing.Color.Black;
            this.firstFloor.BackgroundImage = global::ControlAnElevator.Properties.Resources.firstFloorLoft;
            this.firstFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.firstFloor.Location = new System.Drawing.Point(-36, 346);
            this.firstFloor.Name = "firstFloor";
            this.firstFloor.Size = new System.Drawing.Size(657, 416);
            // 
            // secondFloor
            // 
            this.secondFloor.BackColor = System.Drawing.Color.Black;
            this.secondFloor.BackgroundImage = global::ControlAnElevator.Properties.Resources.secondFloorLoft;
            this.secondFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.secondFloor.Location = new System.Drawing.Point(-36, -15);
            this.secondFloor.Name = "secondFloor";
            this.secondFloor.Size = new System.Drawing.Size(657, 416);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(23, 697);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(91, 23);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Show Database";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.White;
            this.logBox.Controls.Add(this.dataGridView1);
            this.logBox.Controls.Add(this.updateButton);
            this.logBox.Location = new System.Drawing.Point(580, 0);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(480, 732);
            this.logBox.TabIndex = 14;
            this.logBox.TabStop = false;
            this.logBox.Text = "Log Record";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logID,
            this.Time,
            this.Operation,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(6, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(468, 674);
            this.dataGridView1.TabIndex = 6;
            // 
            // logID
            // 
            this.logID.HeaderText = "ID";
            this.logID.Name = "logID";
            this.logID.ReadOnly = true;
            this.logID.Width = 50;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 80;
            // 
            // Operation
            // 
            this.Operation.HeaderText = "Operations";
            this.Operation.Name = "Operation";
            this.Operation.ReadOnly = true;
            this.Operation.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status of Elevator";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 150;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // topPanel1Floor
            // 
            this.topPanel1Floor.BackgroundImage = global::ControlAnElevator.Properties.Resources.numberOneTop;
            this.topPanel1Floor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.topPanel1Floor.Location = new System.Drawing.Point(290, 378);
            this.topPanel1Floor.Name = "topPanel1Floor";
            this.topPanel1Floor.Size = new System.Drawing.Size(24, 20);
            this.topPanel1Floor.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ControlAnElevator.Properties.Resources.between1and2Floor;
            this.pictureBox1.Location = new System.Drawing.Point(0, 333);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 78);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // topPanel2Floor
            // 
            this.topPanel2Floor.BackgroundImage = global::ControlAnElevator.Properties.Resources.numberOneTop;
            this.topPanel2Floor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.topPanel2Floor.Location = new System.Drawing.Point(290, 17);
            this.topPanel2Floor.Name = "topPanel2Floor";
            this.topPanel2Floor.Size = new System.Drawing.Size(24, 20);
            this.topPanel2Floor.TabIndex = 13;
            // 
            // secondFloorRB
            // 
            this.secondFloorRB.BackColor = System.Drawing.Color.Transparent;
            this.secondFloorRB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("secondFloorRB.BackgroundImage")));
            this.secondFloorRB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.secondFloorRB.FlatAppearance.BorderSize = 0;
            this.secondFloorRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondFloorRB.ForeColor = System.Drawing.Color.Transparent;
            this.secondFloorRB.Location = new System.Drawing.Point(449, 141);
            this.secondFloorRB.Name = "secondFloorRB";
            this.secondFloorRB.Size = new System.Drawing.Size(46, 44);
            this.secondFloorRB.TabIndex = 1;
            this.secondFloorRB.UseVisualStyleBackColor = false;
            this.secondFloorRB.Click += new System.EventHandler(this.secondFloorRB_Click);
            // 
            // firstFloorRB
            // 
            this.firstFloorRB.BackColor = System.Drawing.Color.Transparent;
            this.firstFloorRB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstFloorRB.BackgroundImage")));
            this.firstFloorRB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.firstFloorRB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.firstFloorRB.FlatAppearance.BorderSize = 0;
            this.firstFloorRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstFloorRB.ForeColor = System.Drawing.Color.Transparent;
            this.firstFloorRB.Location = new System.Drawing.Point(449, 504);
            this.firstFloorRB.Name = "firstFloorRB";
            this.firstFloorRB.Size = new System.Drawing.Size(46, 44);
            this.firstFloorRB.TabIndex = 0;
            this.firstFloorRB.UseVisualStyleBackColor = false;
            this.firstFloorRB.Click += new System.EventHandler(this.firstFloorRB_Click);
            // 
            // elevator
            // 
            this.elevator.BackColor = System.Drawing.Color.White;
            this.elevator.BackgroundImage = global::ControlAnElevator.Properties.Resources.elevator;
            this.elevator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.elevator.Controls.Add(this.rightDoor);
            this.elevator.Controls.Add(this.leftDoor);
            this.elevator.Controls.Add(this.elevatorDisplay);
            this.elevator.Location = new System.Drawing.Point(203, 412);
            this.elevator.Name = "elevator";
            this.elevator.Size = new System.Drawing.Size(200, 285);
            this.elevator.TabIndex = 0;
            // 
            // rightDoor
            // 
            this.rightDoor.BackColor = System.Drawing.Color.DimGray;
            this.rightDoor.BackgroundImage = global::ControlAnElevator.Properties.Resources.rightDoor;
            this.rightDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightDoor.Location = new System.Drawing.Point(103, 0);
            this.rightDoor.Name = "rightDoor";
            this.rightDoor.Size = new System.Drawing.Size(97, 285);
            this.rightDoor.TabIndex = 17;
            // 
            // leftDoor
            // 
            this.leftDoor.BackColor = System.Drawing.Color.DimGray;
            this.leftDoor.BackgroundImage = global::ControlAnElevator.Properties.Resources.leftDoor;
            this.leftDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftDoor.Location = new System.Drawing.Point(0, 0);
            this.leftDoor.Name = "leftDoor";
            this.leftDoor.Size = new System.Drawing.Size(98, 285);
            this.leftDoor.TabIndex = 16;
            // 
            // elevatorDisplay
            // 
            this.elevatorDisplay.BackColor = System.Drawing.Color.Transparent;
            this.elevatorDisplay.BackgroundImage = global::ControlAnElevator.Properties.Resources.panel;
            this.elevatorDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.elevatorDisplay.Controls.Add(this.alarmButton);
            this.elevatorDisplay.Controls.Add(this.closeDoorsButton);
            this.elevatorDisplay.Controls.Add(this.openDoorsButton);
            this.elevatorDisplay.Controls.Add(this.firstFloorEB);
            this.elevatorDisplay.Controls.Add(this.elevatorArrow);
            this.elevatorDisplay.Controls.Add(this.panelDisplay);
            this.elevatorDisplay.Controls.Add(this.secondFloorEB);
            this.elevatorDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.elevatorDisplay.ForeColor = System.Drawing.Color.Transparent;
            this.elevatorDisplay.Location = new System.Drawing.Point(52, 52);
            this.elevatorDisplay.Name = "elevatorDisplay";
            this.elevatorDisplay.Size = new System.Drawing.Size(95, 186);
            this.elevatorDisplay.TabIndex = 10;
            // 
            // alarmButton
            // 
            this.alarmButton.BackgroundImage = global::ControlAnElevator.Properties.Resources.alarmButton;
            this.alarmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.alarmButton.FlatAppearance.BorderSize = 0;
            this.alarmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alarmButton.Location = new System.Drawing.Point(33, 144);
            this.alarmButton.Name = "alarmButton";
            this.alarmButton.Size = new System.Drawing.Size(26, 26);
            this.alarmButton.TabIndex = 8;
            this.alarmButton.UseVisualStyleBackColor = true;
            this.alarmButton.Click += new System.EventHandler(this.alarmButton_Click);
            // 
            // closeDoorsButton
            // 
            this.closeDoorsButton.BackgroundImage = global::ControlAnElevator.Properties.Resources.closeButton;
            this.closeDoorsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeDoorsButton.FlatAppearance.BorderSize = 0;
            this.closeDoorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeDoorsButton.Location = new System.Drawing.Point(49, 112);
            this.closeDoorsButton.Name = "closeDoorsButton";
            this.closeDoorsButton.Size = new System.Drawing.Size(26, 26);
            this.closeDoorsButton.TabIndex = 7;
            this.closeDoorsButton.UseVisualStyleBackColor = true;
            this.closeDoorsButton.Click += new System.EventHandler(this.closeDoorsButton_Click);
            // 
            // openDoorsButton
            // 
            this.openDoorsButton.BackgroundImage = global::ControlAnElevator.Properties.Resources.openButton;
            this.openDoorsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openDoorsButton.FlatAppearance.BorderSize = 0;
            this.openDoorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openDoorsButton.Location = new System.Drawing.Point(17, 112);
            this.openDoorsButton.Name = "openDoorsButton";
            this.openDoorsButton.Size = new System.Drawing.Size(26, 26);
            this.openDoorsButton.TabIndex = 6;
            this.openDoorsButton.UseVisualStyleBackColor = true;
            this.openDoorsButton.Click += new System.EventHandler(this.openDoorsButton_Click);
            // 
            // firstFloorEB
            // 
            this.firstFloorEB.BackColor = System.Drawing.Color.Transparent;
            this.firstFloorEB.BackgroundImage = global::ControlAnElevator.Properties.Resources.buttonOne;
            this.firstFloorEB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.firstFloorEB.FlatAppearance.BorderSize = 0;
            this.firstFloorEB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstFloorEB.Font = new System.Drawing.Font("Maiandra GD", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstFloorEB.ForeColor = System.Drawing.Color.Transparent;
            this.firstFloorEB.Location = new System.Drawing.Point(17, 80);
            this.firstFloorEB.Name = "firstFloorEB";
            this.firstFloorEB.Size = new System.Drawing.Size(26, 26);
            this.firstFloorEB.TabIndex = 1;
            this.firstFloorEB.UseVisualStyleBackColor = false;
            this.firstFloorEB.Click += new System.EventHandler(this.firstFloorEB_Click);
            // 
            // elevatorArrow
            // 
            this.elevatorArrow.BackgroundImage = global::ControlAnElevator.Properties.Resources.upArrow;
            this.elevatorArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.elevatorArrow.Image = ((System.Drawing.Image)(resources.GetObject("elevatorArrow.Image")));
            this.elevatorArrow.Location = new System.Drawing.Point(25, 35);
            this.elevatorArrow.Name = "elevatorArrow";
            this.elevatorArrow.Size = new System.Drawing.Size(16, 25);
            this.elevatorArrow.TabIndex = 9;
            this.elevatorArrow.TabStop = false;
            this.elevatorArrow.Visible = false;
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackgroundImage = global::ControlAnElevator.Properties.Resources.numberOne;
            this.panelDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelDisplay.Location = new System.Drawing.Point(42, 28);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(30, 40);
            this.panelDisplay.TabIndex = 12;
            // 
            // secondFloorEB
            // 
            this.secondFloorEB.BackColor = System.Drawing.Color.Transparent;
            this.secondFloorEB.BackgroundImage = global::ControlAnElevator.Properties.Resources.buttonTwo;
            this.secondFloorEB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.secondFloorEB.FlatAppearance.BorderSize = 0;
            this.secondFloorEB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondFloorEB.Font = new System.Drawing.Font("Maiandra GD", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondFloorEB.ForeColor = System.Drawing.Color.Transparent;
            this.secondFloorEB.Location = new System.Drawing.Point(49, 80);
            this.secondFloorEB.Name = "secondFloorEB";
            this.secondFloorEB.Size = new System.Drawing.Size(26, 26);
            this.secondFloorEB.TabIndex = 0;
            this.secondFloorEB.UseVisualStyleBackColor = false;
            this.secondFloorEB.Click += new System.EventHandler(this.secondFloorEB_Click);
            // 
            // doorsBackground
            // 
            this.doorsBackground.BackColor = System.Drawing.Color.DimGray;
            this.doorsBackground.BackgroundImage = global::ControlAnElevator.Properties.Resources.doorBackground;
            this.doorsBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doorsBackground.Location = new System.Drawing.Point(201, 51);
            this.doorsBackground.Name = "doorsBackground";
            this.doorsBackground.Size = new System.Drawing.Size(204, 644);
            this.doorsBackground.TabIndex = 17;
            // 
            // Assignment1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1060, 732);
            this.Controls.Add(this.topPanel1Floor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.topPanel2Floor);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.secondFloorRB);
            this.Controls.Add(this.firstFloorRB);
            this.Controls.Add(this.elevator);
            this.Controls.Add(this.doorsBackground);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Assignment1";
            this.Text = "Control an Elevator";
            this.logBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.elevator.ResumeLayout(false);
            this.elevatorDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elevatorArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button firstFloorRB;
        private System.Windows.Forms.Button secondFloorRB;
        private System.Windows.Forms.Button firstFloorEB;
        private System.Windows.Forms.Button secondFloorEB;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button updateButton;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape secondFloor;
        private System.Windows.Forms.Button openDoorsButton;
        private System.Windows.Forms.Button closeDoorsButton;
        private System.Windows.Forms.Button alarmButton;
        private System.Windows.Forms.PictureBox elevatorArrow;
        private System.Windows.Forms.Panel elevatorDisplay;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape firstFloor;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Panel topPanel1Floor;
        private System.Windows.Forms.Panel topPanel2Floor;
        private System.Windows.Forms.Panel elevator;
        private System.Windows.Forms.GroupBox logBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn logID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel leftDoor;
        private System.Windows.Forms.Panel doorsBackground;
        private System.Windows.Forms.Panel rightDoor;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

