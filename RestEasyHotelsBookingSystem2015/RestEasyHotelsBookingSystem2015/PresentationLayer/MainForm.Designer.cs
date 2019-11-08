namespace RestEasyHotelsBookingSystem2015.PresentationLayer
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllGuestsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllRoomsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeABooking = new System.Windows.Forms.Button();
            this.changeABooking = new System.Windows.Forms.Button();
            this.cancelABooking = new System.Windows.Forms.Button();
            this.makeBookingEnquiry = new System.Windows.Forms.Button();
            this.generateOccupancyReport = new System.Windows.Forms.Button();
            this.generateBookingDatesReport = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.guestsToolStripMenuItem,
            this.roomsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutMenuItem,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOutMenuItem
            // 
            this.logOutMenuItem.Name = "logOutMenuItem";
            this.logOutMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logOutMenuItem.Text = "Log Out";
            this.logOutMenuItem.Click += new System.EventHandler(this.logOutMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // guestsToolStripMenuItem
            // 
            this.guestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem});
            this.guestsToolStripMenuItem.Name = "guestsToolStripMenuItem";
            this.guestsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.guestsToolStripMenuItem.Text = "Guests";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAllGuestsMenuItem});
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listToolStripMenuItem.Text = "List";
            // 
            // listAllGuestsMenuItem
            // 
            this.listAllGuestsMenuItem.Name = "listAllGuestsMenuItem";
            this.listAllGuestsMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listAllGuestsMenuItem.Text = "List All Guests";
            this.listAllGuestsMenuItem.Click += new System.EventHandler(this.listAllGuestsMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem1});
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.roomsToolStripMenuItem.Text = "Rooms";
            // 
            // listToolStripMenuItem1
            // 
            this.listToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAllRoomsMenuItem});
            this.listToolStripMenuItem1.Name = "listToolStripMenuItem1";
            this.listToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.listToolStripMenuItem1.Text = "List";
            // 
            // listAllRoomsMenuItem
            // 
            this.listAllRoomsMenuItem.Name = "listAllRoomsMenuItem";
            this.listAllRoomsMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listAllRoomsMenuItem.Text = "List All Rooms";
            this.listAllRoomsMenuItem.Click += new System.EventHandler(this.listAllRoomsMenuItem_Click);
            // 
            // makeABooking
            // 
            this.makeABooking.Location = new System.Drawing.Point(89, 42);
            this.makeABooking.Name = "makeABooking";
            this.makeABooking.Size = new System.Drawing.Size(95, 35);
            this.makeABooking.TabIndex = 1;
            this.makeABooking.Text = "Make a Booking";
            this.makeABooking.UseVisualStyleBackColor = true;
            this.makeABooking.Click += new System.EventHandler(this.makeABooking_Click);
            // 
            // changeABooking
            // 
            this.changeABooking.Location = new System.Drawing.Point(292, 42);
            this.changeABooking.Name = "changeABooking";
            this.changeABooking.Size = new System.Drawing.Size(93, 35);
            this.changeABooking.TabIndex = 2;
            this.changeABooking.Text = "Change a Booking";
            this.changeABooking.UseVisualStyleBackColor = true;
            this.changeABooking.Click += new System.EventHandler(this.changeABooking_Click);
            // 
            // cancelABooking
            // 
            this.cancelABooking.Location = new System.Drawing.Point(89, 136);
            this.cancelABooking.Name = "cancelABooking";
            this.cancelABooking.Size = new System.Drawing.Size(95, 45);
            this.cancelABooking.TabIndex = 3;
            this.cancelABooking.Text = "Cancel a Booking";
            this.cancelABooking.UseVisualStyleBackColor = true;
            this.cancelABooking.Click += new System.EventHandler(this.cancelABooking_Click);
            // 
            // makeBookingEnquiry
            // 
            this.makeBookingEnquiry.Location = new System.Drawing.Point(292, 136);
            this.makeBookingEnquiry.Name = "makeBookingEnquiry";
            this.makeBookingEnquiry.Size = new System.Drawing.Size(93, 45);
            this.makeBookingEnquiry.TabIndex = 4;
            this.makeBookingEnquiry.Text = "Make a Guest Booking Enquiry";
            this.makeBookingEnquiry.UseVisualStyleBackColor = true;
            this.makeBookingEnquiry.Click += new System.EventHandler(this.makeBookingEnquiry_Click);
            // 
            // generateOccupancyReport
            // 
            this.generateOccupancyReport.Location = new System.Drawing.Point(89, 245);
            this.generateOccupancyReport.Name = "generateOccupancyReport";
            this.generateOccupancyReport.Size = new System.Drawing.Size(95, 51);
            this.generateOccupancyReport.TabIndex = 5;
            this.generateOccupancyReport.Text = "Generate Occupancy Level Report";
            this.generateOccupancyReport.UseVisualStyleBackColor = true;
            this.generateOccupancyReport.Click += new System.EventHandler(this.generateOccupancyReport_Click);
            // 
            // generateBookingDatesReport
            // 
            this.generateBookingDatesReport.Location = new System.Drawing.Point(292, 245);
            this.generateBookingDatesReport.Name = "generateBookingDatesReport";
            this.generateBookingDatesReport.Size = new System.Drawing.Size(93, 51);
            this.generateBookingDatesReport.TabIndex = 6;
            this.generateBookingDatesReport.Text = "Generate Booking Date Report";
            this.generateBookingDatesReport.UseVisualStyleBackColor = true;
            this.generateBookingDatesReport.Click += new System.EventHandler(this.generateBookingDatesReport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 349);
            this.Controls.Add(this.generateBookingDatesReport);
            this.Controls.Add(this.generateOccupancyReport);
            this.Controls.Add(this.makeBookingEnquiry);
            this.Controls.Add(this.cancelABooking);
            this.Controls.Add(this.changeABooking);
            this.Controls.Add(this.makeABooking);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllGuestsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listAllRoomsMenuItem;
        private System.Windows.Forms.Button makeABooking;
        private System.Windows.Forms.Button changeABooking;
        private System.Windows.Forms.Button cancelABooking;
        private System.Windows.Forms.Button makeBookingEnquiry;
        private System.Windows.Forms.Button generateOccupancyReport;
        private System.Windows.Forms.Button generateBookingDatesReport;
    }
}